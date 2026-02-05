using Fractions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EngineeringUnits;

// A unitsystem is list of RawUnits
// It represent how a unit of measure is defined
// --> It does not know the value of the unit!
// --> Combined with a value you get the BaseUnit class..
// ex if you have a list of {length+1, duration-1} that could represent a speed [m/s] 

public class UnitSystem
{
    public string? Symbol { get; init; }

    //[JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
    public IEnumerable<RawUnit> ListOfUnits { get; init; }

    public UnitSystem()
    {
        ListOfUnits = [];
    }

    public UnitSystem(List<RawUnit> LocalUnitList, string? symbol = null)
    {
        ListOfUnits = LocalUnitList.ReduceUnits();
        Symbol = symbol;
    }

    public UnitSystem(RawUnit unit) : this([unit]) { }
    public UnitSystem(decimal unit, string? symbol)
    {
        //Adding just a dimensionless unit
        var dimensionless = new RawUnit()
        {
            Symbol=symbol,
            A = new(unit),
            UnitType = BaseunitType.CombinedUnit,
            B = 0,
            Count = 1,
        };

        ListOfUnits = [dimensionless];
    }

    public UnitSystem(UnitSystem unit, string? symbol)
    {
        ListOfUnits = new List<RawUnit>(unit.ListOfUnits);
        Symbol = symbol;
    }

    public static bool operator ==(UnitSystem a, UnitSystem b)
    {
        return a.GetHashCodeForUnitTypeCompare() == b.GetHashCodeForUnitTypeCompare();
    }
    public static bool operator !=(UnitSystem a, UnitSystem b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        //Check for null and compare run-time types.
        if ((obj is null) || !GetType().Equals(obj.GetType()))
            return false;
        else
            return this == (UnitSystem)obj;
    }

    public bool Equals(UnitSystem other) => this == other;

    public static UnitSystem operator +(UnitSystem left, UnitSystem right)
    {
        if (left != right)
            throw new WrongUnitException($"Failed to do: {left} + {right}. Expected both units to be the same!");

        //Using left unitsystem as the final system
        return left;
    }
    public static UnitSystem operator -(UnitSystem left, UnitSystem right)
    {
        if (left != right)
            throw new WrongUnitException($"Failed to do: {left} - {right}. Expected both units to be the same!");

        //Using left unitsystem as the final system
        return left;

    }


#if DEBUG
    public static int MultiplyCacheCount => CacheMultiply.Count;
    public static int DivideCacheCount => CacheDivide.Count;
#endif


    private static readonly ConcurrentDictionary<(int,int), UnitSystem> CacheMultiply = new();
    public static UnitSystem operator *(UnitSystem left, UnitSystem right)
    {
        var key = (Left: left.GetHashCode(), Right: right.GetHashCode());

        if (CacheMultiply.TryGetValue(key, out UnitSystem? local))
            return local;

        var test2 = new UnitSystem(new List<RawUnit>(left.ListOfUnits.Concat(right.ListOfUnits)));


        _ = CacheMultiply.TryAdd(key, test2);

        return test2;
    }

    public static UnitSystem operator *(decimal left, UnitSystem right)
    {
        return right * left;
    }
    public static UnitSystem operator *(UnitSystem left, decimal right)
    {
        if (right == 1)
            return left;

        List<RawUnit> LocalUnitList = [.. left.ListOfUnits];
        //LocalUnitList.Add(new CombinedUnit(constant));

        var dimensionless = new RawUnit()
        {
            Symbol=null,
            A = new(right),
            UnitType = BaseunitType.CombinedUnit,
            B = 0,
            Count = 1,

        };
        LocalUnitList.Add(dimensionless);

        return new UnitSystem(LocalUnitList, left.Symbol);

    }

    private static readonly ConcurrentDictionary<(int,int), UnitSystem> CacheDivide = new();
    public static UnitSystem operator /(UnitSystem left, UnitSystem right)
    {
        //var Hashes = (left.GetHashCode() * 512265997) ^ right.GetHashCode();
        var key = (Left: left.GetHashCode(), Right: right.GetHashCode());

        if (CacheDivide.TryGetValue(key, out UnitSystem? local))
            return local;

        List<RawUnit> LocalUnitList = new(left.ListOfUnits);

        foreach (RawUnit item in right.ListOfUnits)
            LocalUnitList.Add(item.CloneAndReverseCount());

        var DividedUnit = new UnitSystem(LocalUnitList);       

        _ = CacheDivide.TryAdd(key, DividedUnit);

        return DividedUnit;

    }

    public string ToStringOld()
    {

        if (Symbol is not null)
            return Symbol;

        //Creates all positive symbols
        var local = ListOfUnits
            .Where(x => x.Count > 0)
            .Aggregate("", (x, y) => x += $"{y.Symbol}{y.Count.ToSuperScript()}");

        //If any negative values are present create a '/'
        if (ListOfUnits.Any(x => x.Count < 0))
            local += "/";

        //Creates all negative symbols
        local += ListOfUnits
            .Where(x => x.Count < 0)
            .Aggregate("", (x, y) => x += $"{y.Symbol}{(y.Count * -1).ToSuperScript()}");

        return local;
    }

    private int HashCodeCached;
    //public override int GetHashCode()
    //{
    //    if (HashCodeCached is not 0)
    //        return HashCodeCached;

    //    int TempHashCode;
    //    unchecked // Overflow is fine, just wrap
    //    {
    //        TempHashCode = 795945743;

    //        var deleteme = ListOfUnits.OrderBy(x => x.UnitType).ToList();

    //        foreach (RawUnit item in ListOfUnits.OrderBy(x => x.UnitType))
    //        {
    //            TempHashCode = (TempHashCode * 512265997) ^ item.GetHashCode();
    //        }
    //    }

    //    HashCodeCached = TempHashCode;

    //    return TempHashCode;
    //}

    public override int GetHashCode()
    {
        if (HashCodeCached is not 0)
            return HashCodeCached;

        int TempHashCode;
        var hc = new HashCode();

        foreach (RawUnit item in ListOfUnits.OrderBy(x => x.UnitType))
        {
            hc.Add(item);
        }

        HashCodeCached = hc.ToHashCode();

        return HashCodeCached;
    }

    internal int HashCodeForUnitCompare;
    public int GetHashCodeForUnitTypeCompare()
    {
        //This can tell if two units is of the same type
        //ex meter and feet is both length and would return the same hashcode

        if (HashCodeForUnitCompare is 0)
        {

            //Exemple of output:
            //Mass - 2
            //Length - 1
            //Duration - 3

            IOrderedEnumerable<(BaseunitType Key, int)> _UnitsCount = ListOfUnits
                              .Where(x => x.UnitType is not BaseunitType.CombinedUnit)
                              .GroupBy(x => x.UnitType)
                              .Select(x => (x.Key, x.Sum(x => x.Count)))
                              .Where(x => x.Item2 != 0)
                              .OrderBy(x => x.Key)
                              .ThenBy(x => x.Item2);

            HashCode hashCode = new();

            foreach ((BaseunitType Key, var Value) in _UnitsCount)
            {
                hashCode.Add(Key);
                hashCode.Add(Value);
            }

            HashCodeForUnitCompare = hashCode.ToHashCode();
        }

        return HashCodeForUnitCompare;
    }

    private bool? isSIUnit = null;
    public bool IsSIUnit()
    {
        if (isSIUnit is null)
            isSIUnit = ListOfUnits.All(x => x.IsSI);

        return (bool)isSIUnit;
    }


    // Canonical, parse-friendly form by default
    //public override string ToString() => ToString("C", null);

    // Formats:
    // "C" = Canonical parse-friendly: kg·m^2·s^-3·A^-1
    // "P" = Pretty: kg·m²·s⁻³·A⁻¹
    // "S" = Symbol if present, otherwise canonical
    //public string ToString(string? format, IFormatProvider? formatProvider)
    //{
    //    format ??= "C";
    //    format = format.Trim().ToUpperInvariant();

    //    return format switch
    //    {
    //        "P" => Symbol ?? ToPrettyNoDivision(),
    //        "S" => Symbol ?? ToCanonicalNoDivision(),
    //        _ => ToCanonicalNoDivision(),
    //    };
    //}

    //public string ToCanonicalNoDivision()
    //{
    //    if (Symbol is not null)
    //        return Symbol; // optional: consider not short-circuiting for canonical

    //    var units = ListOfUnits
    //        .Where(u => !IsUselessDimensionlessCombined(u))
    //        .Where(u => !string.IsNullOrWhiteSpace(u.Symbol))
    //        .Where(u => u.Count != 0)
    //        .ToList();

    //    if (units.Count == 0)
    //        return "";

    //    // For determinism: order by base unit type, then symbol
    //    // (prevents random ordering in output)
    //    var ordered = units
    //        .OrderBy(u => u.UnitType)
    //        .ThenBy(u => u.Symbol, StringComparer.Ordinal)
    //        .ToList();

    //    string Format(RawUnit u)
    //    {
    //        if (u.Count == 1)
    //            return u.Symbol!;
    //        return $"{u.Symbol}^{u.Count}";
    //    }

    //    return string.Join("·", ordered.Select(Format));
    //}

    //public string ToPrettyNoDivision()
    //{
    //    if (Symbol is not null)
    //        return Symbol;

    //    var units = ListOfUnits
    //        .Where(u => !IsUselessDimensionlessCombined(u))
    //        .Where(u => !string.IsNullOrWhiteSpace(u.Symbol))
    //        .Where(u => u.Count != 0)
    //        .ToList();

    //    if (units.Count == 0)
    //        return "";

    //    var ordered = units
    //        .OrderBy(u => u.UnitType)
    //        .ThenBy(u => u.Symbol, StringComparer.Ordinal)
    //        .ToList();

    //    string Format(RawUnit u)
    //    {
    //        // Uses your existing ToSuperScript helper on int
    //        // exponent 1 => omit
    //        if (u.Count == 1)
    //            return u.Symbol!;
    //        return $"{u.Symbol}{u.Count.ToSuperScript()}";
    //    }

    //    return string.Join("·", ordered.Select(Format));
    //}

    //private static bool IsUselessDimensionlessCombined(RawUnit u)
    //{
    //    // filters out the internal "dimensionless" CombinedUnit noise
    //    if (u.UnitType != BaseunitType.CombinedUnit)
    //        return false;

    //    bool noSymbol = string.IsNullOrWhiteSpace(u.Symbol);
    //    bool isOne = u.A == Fraction.One;
    //    bool noOffset = u.B == Fraction.Zero;
    //    bool countOne = u.Count == 1;

    //    return noSymbol && isOne && noOffset && countOne;
    //}


    // Default = PrettyFraction (simple fraction else product)
    public override string ToString() => ToString("PF", CultureInfo.InvariantCulture);

    // PF = PrettyFraction (default)
    // PP = PrettyProduct (always signed superscripts, no '/')
    // C  = Canonical (parse-friendly, uses ^ with signed ints, no '/')
    // S  = Symbol if present, else PF
    public string ToString(string? format, IFormatProvider? provider)
    {
        format ??= "Unit:PF";
        format = format.Trim().ToUpperInvariant();

        return format switch
        {
            "Unit:PP" => ToPrettyProduct(),
            "Unit:C" => ToCanonicalProduct(),
            "Unit:S" => Symbol ?? ToPrettyFraction(),
            _ => ToPrettyFraction(),
        };
    }

    private string ToPrettyFraction()
    {
        if (Symbol is not null)
            return Symbol;

        var units = ListOfUnits.Where(u => !IsUselessDimensionlessCombined(u))
                               .Where(u => !string.IsNullOrWhiteSpace(u.Symbol))
                               .Where(u => u.Count != 0)
                               .ToList();

        if (units.Count == 0)
            return "";//"[-]"; // pretty dimensionless

        // Deterministic ordering prevents flaky tests and "random" output
        var ordered = units.OrderBy(u => u.UnitType).ThenBy(u => u.Symbol, StringComparer.Ordinal).ToList();

        var pos = ordered.Where(u => u.Count > 0).ToList();
        var neg = ordered.Where(u => u.Count < 0).ToList();

        // If no numerator -> do NOT show 1/(...) in pretty mode
        if (pos.Count == 0 || neg.Count == 0)
            return ToPrettyProductFromOrdered(ordered);

        bool simple = (pos.Count <= 2) && (neg.Count <= 2);
        if (!simple)
            return ToPrettyProductFromOrdered(ordered);

        string Num() => string.Join("·", pos.Select(u => $"{u.Symbol}{u.Count.ToSuperScript()}"));
        string Den() => string.Join("·", neg.Select(u => $"{u.Symbol}{(-u.Count).ToSuperScript()}"));

        var num = Num();
        var den = Den();

        if (pos.Count == 2)
            num = "(" + num + ")";
        if (neg.Count == 2)
            den = "(" + den + ")";

        return $"{num}/{den}";
    }

    private string ToPrettyProduct()
    {
        if (Symbol is not null)
            return Symbol;

        var units = ListOfUnits.Where(u => !IsUselessDimensionlessCombined(u))
                               .Where(u => !string.IsNullOrWhiteSpace(u.Symbol))
                               .Where(u => u.Count != 0)
                               .OrderBy(u => u.UnitType).ThenBy(u => u.Symbol, StringComparer.Ordinal)
                               .ToList();

        if (units.Count == 0)
            return "[-]";

        return ToPrettyProductFromOrdered(units);
    }

    private static string ToPrettyProductFromOrdered(System.Collections.Generic.IEnumerable<RawUnit> ordered)
    {
        return string.Join("·", ordered.Select(u =>
            u.Count == 1 ? u.Symbol! : $"{u.Symbol}{u.Count.ToSuperScript()}"));
    }

    private string ToCanonicalProduct()
    {
        // Canonical should not depend on Symbol; it should be round-trip safe.
        // If you want Symbol-shortcut, use format "S".
        var units = ListOfUnits.Where(u => !IsUselessDimensionlessCombined(u))
                               .Where(u => !string.IsNullOrWhiteSpace(u.Symbol))
                               .Where(u => u.Count != 0)
                               .OrderBy(u => u.UnitType).ThenBy(u => u.Symbol, StringComparer.Ordinal)
                               .ToList();

        if (units.Count == 0)
            return "1";

        return string.Join("·", units.Select(u =>
            u.Count == 1 ? u.Symbol! : $"{u.Symbol}^{u.Count}"));
    }

    private static bool IsUselessDimensionlessCombined(RawUnit u)
    {
        // internal dimensionless CombinedUnit noise: A=1, B=0, Count=1, no symbol
        // RawUnit stores A/B/Count/UnitType. [2](https://www.freecodecamp.org/news/how-to-write-a-good-readme-file/)
        if (u.UnitType != BaseunitType.CombinedUnit)
            return false;

        bool noSymbol = string.IsNullOrWhiteSpace(u.Symbol);
        bool isOne = u.A == Fraction.One;
        bool noOffset = u.B == Fraction.Zero;
        bool countOne = u.Count == 1;

        return noSymbol && isOne && noOffset && countOne;
    }



}
