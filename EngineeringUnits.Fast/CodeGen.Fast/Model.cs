using System.Globalization;
using System.Numerics;
using System.Reflection;
using EngineeringUnits;
using Fractions;

namespace CodeGen.Fast;

/// <summary>A dimension as sorted, non-zero (base unit name, exponent) terms.</summary>
internal sealed record Dim(IReadOnlyList<(string Base, int Exp)> Terms)
{
    public string Key => string.Join(",", Terms.Select(t => $"{t.Base}{t.Exp}"));

    public string AttributeArgs => string.Join(", ", Terms.Select(t => $"BaseunitType.{t.Base}, {t.Exp}"));

    public static Dim From(IEnumerable<(string Base, int Exp)> terms) => new(terms
        .GroupBy(t => t.Base)
        .Select(g => (g.Key, g.Sum(x => x.Exp)))
        .Where(t => t.Item2 != 0)
        .OrderBy(t => (int)Enum.Parse<BaseunitType>(t.Key))
        .ToList());
}

/// <summary>
/// SI = value * Multiplier / Divisor + Offset. One of Multiplier/Divisor is 1 when the factor is n or 1/n,
/// so conversions like J/h -> W are a single rounding (value / 3600) instead of value * 0.000277...
/// </summary>
internal sealed record UnitDef(string Name, string Symbol, double Multiplier, double Divisor, double Offset, Fraction ExactFactor, Fraction ExactOffset)
{
    public bool IsSI => Multiplier == 1 && Divisor == 1 && Offset == 0;
}

internal sealed record QuantityDef(string Name, Dim Dim, List<UnitDef> Units, Type OriginalType, Type OriginalUnitType)
{
    /// <summary>Extra original members (UnitsNet-style names like FromDegreesCelsius) that map onto one of our units.</summary>
    public List<(string Member, UnitDef Unit, bool IsFactory)> Forwarders { get; } = [];
}

internal sealed record ConstantDef(string Name, string? QuantityName, Dim Dim, double SI, string? Summary);

internal static class Model
{
    public static readonly List<string> Log = [];

    /// <summary>EngineeringUnits member names left out because they are [Obsolete] there (Quantity.Member).</summary>
    public static readonly List<string> ObsoleteSkipped = [];

    // Members every generated struct has - a unit with one of these names would not compile
    private static readonly HashSet<string> ReservedNames =
    [
        "SI", "SIUnit", "From", "FromSI", "As", "Zero", "NaN", "PositiveInfinity", "NegativeInfinity", "MaxValue", "MinValue",
        "AdditiveIdentity", "Abs", "Clamp", "Min", "Max", "Equals", "GetHashCode", "ToString", "CompareTo",
        "Units", "GetType", "IsNaN", "IsInfinity", "IsCloseTo", "IsZero", "IsNotZero", "IsAboveZero", "IsBelowZero", "HasValue", "HasNoValue",
        "IfNullSetToZero", "LowerLimitAt", "UpperLimitAt", "RoundTo", "CeilingTo", "FloorTo", "ToUnit", "Parse", "TryParse", "AsSI", "Value", "GetValueOrDefault", "ConvertToSI",
    ];

    /// <summary>Quantities that are wrong in EngineeringUnits. Transferring them would teach the analyzer a wrong dimension.</summary>
    public static readonly Dictionary<string, string> NotTransferred = new()
    {
        ["ElectricConductance"] = "its units in EngineeringUnits are a copy of Volume (SI = m³, CubicMeter, HectocubicMeter, ...) instead of siemens - " +
                                  "a wrong dimension would make the analyzer accept wrong code.",
        ["ElectricAdmittance"] = "a stub in EngineeringUnits (all its constructors are commented out), so nothing can be checked against it.",
    };

    /// <summary>True when EngineeringUnits has an implicit conversion from <paramref name="from"/> to <paramref name="to"/>.</summary>
    public static bool HasImplicitConversion(QuantityDef to, QuantityDef from) =>
        new[] { to.OriginalType, from.OriginalType }
            .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            .Any(m => m.Name == "op_Implicit"
                      && m.ReturnType == to.OriginalType
                      && m.GetParameters() is [{ } p] && p.ParameterType == from.OriginalType);

    public static List<QuantityDef> ReadQuantities()
    {
        var asm = typeof(BaseUnit).Assembly;
        var result = new List<QuantityDef>();

        // Every exported quantity class - also the few without [UnitDimension] (Level, Dimensionless, ...): their dimension
        // is read from their SI unit below instead of skipping them
        var candidates = asm.GetExportedTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseUnit)))
            .Where(t => t != typeof(UnknownUnit) && t != typeof(Constants))
            .OrderBy(t => t.Name, StringComparer.Ordinal);

        foreach (var type in candidates)
        {
            if (type.GetCustomAttribute<ObsoleteAttribute>() is not null)
            {
                Log.Add($"Skipped quantity {type.Name}: marked [Obsolete]");
                continue;
            }

            if (NotTransferred.TryGetValue(type.Name, out var reason))
            {
                Log.Add($"Not transferred {type.Name}: {reason}");
                continue;
            }

            var unitType = asm.GetType($"EngineeringUnits.Units.{type.Name}Unit");
            if (unitType is null)
            {
                Log.Add($"Skipped quantity {type.Name}: no {type.Name}Unit type");
                continue;
            }

            Dim dim;
            var attr = type.GetCustomAttribute<UnitDimensionAttribute>();
            if (attr is not null)
            {
                dim = Dim.From(attr.Types.Zip(attr.Exponents, (t, e) => (t.ToString(), e)));
            }
            else if (unitType.GetField("SI", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) is UnitTypebase si)
            {
                dim = Dim.From(si.Unit.ListOfUnits
                    .Where(r => r.UnitType != BaseunitType.CombinedUnit)
                    .Select(r => (r.UnitType.ToString(), r.Count)));
                Log.Add($"Note {type.Name} has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [{(dim.Terms.Count == 0 ? "dimensionless" : dim.Key)}]");
            }
            else
            {
                Log.Add($"Skipped quantity {type.Name}: no [UnitDimension] and no {type.Name}Unit.SI");
                continue;
            }

            var units = ReadUnits(type, unitType, dim);
            if (units.Count == 0)
            {
                Log.Add($"Skipped quantity {type.Name}: no units left");
                continue;
            }

            result.Add(new QuantityDef(type.Name, dim, units, type, unitType));
        }

        return result;
    }

    private static List<UnitDef> ReadUnits(Type quantity, Type unitType, Dim dim)
    {
        var members = unitType.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == unitType)
            .Select(f => (Member: (MemberInfo)f, Value: f.GetValue(null)))
            .Concat(unitType.GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.PropertyType == unitType && p.GetIndexParameters().Length == 0)
                .Select(p => (Member: (MemberInfo)p, Value: p.GetValue(null))))
            .ToList();

        var units = new List<UnitDef>();
        var names = new HashSet<string>(StringComparer.Ordinal);

        // SI first so it wins symbol ties when parsing
        foreach (var (member, value) in members.OrderBy(m => m.Member.Name == "SI" ? 0 : 1))
        {
            if (value is not UnitTypebase unit)
                continue;

            if (member.GetCustomAttribute<ObsoleteAttribute>() is not null)
            {
                Log.Add($"Skipped unit {quantity.Name}.{member.Name}: marked [Obsolete]");
                continue;
            }

            if (member.Name != "SI" && (ReservedNames.Contains(member.Name) || member.Name == quantity.Name))
            {
                Log.Add($"Skipped unit {quantity.Name}.{member.Name}: name clashes with a generated member");
                continue;
            }

            if (!names.Add(member.Name))
                continue;

            if (IsExchangeRateUnit(unit.Unit))
            {
                Log.Add($"Not transferred {quantity.Name}.{member.Name} [{unit}]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale");
                continue;
            }

            // Coherent SI: SI = a * value + b, straight from the exact fractions (RawUnit.A, RawUnit.B)
            Fraction a = unit.Unit.SumConstant();
            Fraction b = unit.Unit.SumOfBConstants();

            var (mul, div) = SplitFactor(a);
            var def = new UnitDef(member.Name, unit.ToString(), mul, div, b.ToDouble(), a, b);

            if (member.Name == "SI" && !def.IsSI)
                Log.Add($"WARNING {quantity.Name}.SI is not coherent SI (factor {a}, offset {b}) - Fast stores coherent SI regardless");

            units.Add(def);
        }

        return units;
    }

    // The value is either n (multiply) or 1/n (divide) when that is exact in a double, otherwise the rounded factor
    private static (double Mul, double Div) SplitFactor(Fraction a)
    {
        var num = a.Numerator;
        var den = a.Denominator;
        var limit = BigInteger.Pow(2, 53);

        if (den.IsOne && BigInteger.Abs(num) <= limit)
            return ((double)num, 1);
        if (num.IsOne && den <= limit)
            return (1, (double)den);

        return (a.ToDouble(), 1);
    }

    private static bool IsExchangeRateUnit(UnitSystem unit)
    {
        foreach (var raw in unit.ListOfUnits)
        {
            if (raw.UnitType != BaseunitType.Cost)
                continue;

            // USD based units are exact powers of ten (1 $, 1e6 M$); every other currency is a rate
            var a = raw.A;
            while (a.Numerator % 10 == 0 && a.Numerator != 0)
                a = new Fraction(a.Numerator / 10, a.Denominator);
            while (a.Denominator % 10 == 0)
                a = new Fraction(a.Numerator, a.Denominator / 10);
            if (!(a.Numerator.IsOne && a.Denominator.IsOne))
                return true;
        }

        return false;
    }

    /// <summary>
    /// Finds the original's other public factories (static From*(double)) and getters (double properties), works out by
    /// VALUE which unit each one is, and records a forwarder. Members that don't match exactly one unit are logged.
    /// </summary>
    public static void ReadForwarders(List<QuantityDef> quantities)
    {
        double[] probes = [1, 7.25, -3.5];

        foreach (var q in quantities)
        {
            var generated = new HashSet<string>(q.Units.SelectMany(u => new[] { u.Name, "From" + u.Name }), StringComparer.Ordinal);
            var siUnit = ((UnitTypebase)q.OriginalUnitType.GetField("SI")!.GetValue(null)!).Unit;

            double OriginalSI(BaseUnit value) => value.GetValueAs(siUnit).ToDouble();

            // Factories: static From*(double) or From*(double?) returning the quantity
            var factories = q.OriginalType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name.StartsWith("From", StringComparison.Ordinal) && m.Name != "From" && m.Name != "FromSI")
                .Where(m => m.GetParameters() is [{ } p] && (p.ParameterType == typeof(double) || p.ParameterType == typeof(double?)))
                .Where(m => m.ReturnType == q.OriginalType)
                .GroupBy(m => m.Name).Select(g => g.First());

            foreach (var m in factories)
            {
                if (generated.Contains(m.Name) || ReservedNames.Contains(m.Name))
                    continue;

                var match = Match(u => probes.Max(x => RelativeError(OriginalSI((BaseUnit)m.Invoke(null, [x])!), u.ToSIExact(x))), 1e-12);
                Record(m.Name, m, match, isFactory: true);
            }

            // Getters: public double instance properties
            var getters = q.OriginalType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.PropertyType == typeof(double) && p.GetIndexParameters().Length == 0 && p.DeclaringType == q.OriginalType);

            foreach (var p in getters)
            {
                if (generated.Contains(p.Name) || ReservedNames.Contains(p.Name) || p.Name == "Value")
                    continue;

                // Probe with values that are moderate in the candidate unit: the original's getters go through decimal
                // and lose digits on tiny results (1 m in parsec is 3e-17)
                var match = Match(u => probes.Max(x =>
                {
                    var value = (BaseUnit)Activator.CreateInstance(q.OriginalType, [u.ToSIExact(x), q.OriginalUnitType.GetField("SI")!.GetValue(null)])!;
                    return RelativeError((double)p.GetValue(value)!, x);
                }), 1e-9);
                Record(p.Name, p, match, isFactory: false);
            }

            // The closest unit wins. Units can be very close (decatherm E.C. vs imperial differ by 4e-11), so "within
            // tolerance" alone is not enough; a tie between units that really differ is ambiguous and not forwarded.
            UnitDef? Match(Func<UnitDef, double> error, double tolerance)
            {
                var scored = q.Units
                    .Select(u => (Unit: u, Error: Try(() => error(u))))
                    .Where(s => s.Error <= tolerance)
                    .OrderBy(s => s.Error)
                    .ToList();

                if (scored.Count == 0)
                    return null;

                var best = scored[0];
                var tie = scored.Any(s => s.Error == best.Error && (s.Unit.ExactFactor != best.Unit.ExactFactor || s.Unit.ExactOffset != best.Unit.ExactOffset));
                return tie ? null : best.Unit;
            }

            static double Try(Func<double> f) { try { return f(); } catch { return double.PositiveInfinity; } }

            void Record(string name, MemberInfo member, UnitDef? unit, bool isFactory)
            {
                if (member.GetCustomAttribute<ObsoleteAttribute>() is not null)
                {
                    ObsoleteSkipped.Add($"{q.Name}.{name}");
                    return;
                }
                if (unit is null)
                {
                    Log.Add($"Not transferred {q.Name}.{name}: doesn't match a unit by value");
                    return;
                }
                q.Forwarders.Add((name, unit, isFactory));
            }
        }
    }

    private static double RelativeError(double a, double b) => a == b ? 0 : Math.Abs(a - b) / Math.Max(Math.Abs(a), Math.Abs(b));

    private static double ToSIExact(this UnitDef u, double x) => (u.ExactFactor * new Fraction((decimal)x) + u.ExactOffset).ToDouble();
    private static double FromSIExact(this UnitDef u, double si) => ((new Fraction((decimal)si) - u.ExactOffset) / u.ExactFactor).ToDouble();

    public static List<ConstantDef> ReadConstants(List<QuantityDef> quantities)
    {
        var byType = quantities.ToDictionary(q => q.OriginalType);
        var result = new List<ConstantDef>();

        foreach (var prop in typeof(Constants).GetProperties(BindingFlags.Public | BindingFlags.Static).OrderBy(p => p.MetadataToken))
        {
            if (prop.GetValue(null) is not BaseUnit value)
                continue;

            // Exact path (Fraction) - AsSI is a decimal and would turn e.g. the Planck constant into 0
            var si = value.GetValueAs(value.Unit.GetSIUnitsystem()).ToDouble();

            if (byType.TryGetValue(prop.PropertyType, out var q))
            {
                result.Add(new ConstantDef(prop.Name, q.Name, q.Dim, si, null));
                continue;
            }

            // BaseUnit-typed constant: the dimension only exists at runtime - read it from its unit system
            var dim = Dim.From(value.Unit.ListOfUnits
                .Where(r => r.UnitType != BaseunitType.CombinedUnit)
                .Select(r => (r.UnitType.ToString(), r.Count)));

            // Use a named quantity when one has the same dimension
            var match = quantities.FirstOrDefault(x => x.Dim.Key == dim.Key);
            result.Add(new ConstantDef(prop.Name, match?.Name, dim, si, null));
        }

        return result;
    }

    public static string Num(double d)
    {
        if (double.IsNaN(d)) return "double.NaN";
        if (double.IsPositiveInfinity(d)) return "double.PositiveInfinity";
        if (double.IsNegativeInfinity(d)) return "double.NegativeInfinity";
        return d.ToString("R", CultureInfo.InvariantCulture) + "d";
    }

    public static string Str(string s) => "\"" + s.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
}
