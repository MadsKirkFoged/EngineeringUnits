using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace EngineeringUnits.Fast;

/// <summary>Implemented by every quantity struct.</summary>
public interface IQuantity
{
    /// <summary>The value in SI units.</summary>
    double SI { get; }

    /// <summary>The SI unit of this quantity, e.g. W for Power.</summary>
    UnitTypebase SIUnit { get; }
}

/// <summary>Lets generic code create quantities, e.g. <c>T.FromSI(1)</c>.</summary>
public interface IQuantity<TSelf> : IQuantity where TSelf : struct, IQuantity<TSelf>
{
    static abstract TSelf FromSI(double si);
}

/// <summary>
/// One unit of measure: SI = value * <see cref="Factor"/> + <see cref="Offset"/>.<br></br>
/// Factors and offsets are generated from the exact fractions in EngineeringUnits. A currency unit (€, kr/kWh, ...) also
/// multiplies by its exchange rate, which it reads at every conversion (<see cref="ExchangeRates"/>).
/// </summary>
public abstract class UnitTypebase
{
    // SI = value * _multiplier / _divisor + Offset. One of the two is always 1, so a factor of n or 1/n is one exact
    // operation (e.g. J/h -> W is value / 3600, not value * 0.000277...)
    private readonly double _multiplier;
    private readonly double _divisor;

    // Set for a currency unit: its multiplier is the exchange rate times _multiplier
    private readonly ExchangeRates.Currency? _currency;

    private protected UnitTypebase(string name, string symbol, double multiplier, double divisor, double offset)
    {
        Name = name;
        Symbol = symbol;
        _multiplier = multiplier;
        _divisor = divisor;
        Offset = offset;
    }

    /// <summary>A currency unit: SI ($) = value * the exchange rate of <paramref name="currency"/> * multiplier / divisor.</summary>
    private protected UnitTypebase(string name, string symbol, ExchangeRates.Currency currency, double multiplier, double divisor)
        : this(name, symbol, multiplier, divisor, 0d)
    {
        _currency = currency;
    }

    /// <summary>Name of the unit, e.g. Kilowatt.</summary>
    public string Name { get; }

    /// <summary>Display symbol, e.g. kW.</summary>
    public string Symbol { get; }

    /// <summary>SI per unit, e.g. 1000 for kW. For a currency unit it holds the current exchange rate.</summary>
    public double Factor => Multiplier / _divisor;

    /// <summary>Non-zero for units like °C and °F.</summary>
    public double Offset { get; }

    public bool IsSI => _currency is null && _multiplier == 1d && _divisor == 1d && Offset == 0d;

    private double Multiplier => _currency is { } currency ? ExchangeRates.UsdPerUnit(currency) * _multiplier : _multiplier;

    // Same operation order as the generated FromXxx/Xxx members, so both give bit-identical results
    public double ToSI(double value)
    {
        var v = value * Multiplier / _divisor;
        return Offset == 0d ? v : v + Offset;
    }

    public double FromSI(double si)
    {
        var v = Offset == 0d ? si : si - Offset;
        return v / Multiplier * _divisor;
    }

    public override string ToString() => Symbol;

    /// <summary>
    /// The unit of <typeparamref name="T"/> with this name, e.g. GetUnitByString&lt;PowerUnit&gt;("Kilowatt"). Case-insensitive,
    /// like EngineeringUnits. This is a lookup of a unit NAME (as stored in a database "_uom" column), not a text parser.
    /// A currency also goes by its currency code: "EUR" is <c>CostUnit.Euro</c> (<see cref="CurrencyCodeAttribute"/>).
    /// </summary>
    /// <exception cref="ArgumentException">No unit with that name - the message lists the options.</exception>
    public static T GetUnitByString<T>(string name) where T : UnitTypebase
    {
        if (name is not null && UnitsOf<T>.ByName.TryGetValue(name, out var unit))
            return unit;

        throw new ArgumentException($"Could not find a unit with a name of '{name}'\n The available options are: {string.Join(", ", UnitsOf<T>.Names)}");
    }

    /// <summary>All units of <typeparamref name="T"/>, in declaration order (SI first), like EngineeringUnits.</summary>
    public static List<T> ListOf<T>() where T : UnitTypebase => [.. UnitsOf<T>.All];

    // Built once per unit type: GetUnitByString is called for every database value
    private static class UnitsOf<T> where T : UnitTypebase
    {
        private static readonly FieldInfo[] UnitFields = typeof(T)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(T))
            .ToArray();

        private static readonly (string Name, T Unit)[] Fields = UnitFields
            .Select(f => (f.Name, (T)f.GetValue(null)!))
            .ToArray();

        // The currency codes come after the names, as in EngineeringUnits: a name always wins
        private static readonly (string Name, T Unit)[] CurrencyCodes = UnitFields
            .Where(f => f.IsDefined(typeof(CurrencyCodeAttribute), false))
            .Select(f => (f.GetCustomAttribute<CurrencyCodeAttribute>(false)!.Code, (T)f.GetValue(null)!))
            .ToArray();

        public static readonly T[] All = Fields.Select(f => f.Unit).ToArray();
        public static readonly string[] Names = Fields.Concat(CurrencyCodes).Select(f => f.Name).ToArray();
        public static readonly Dictionary<string, T> ByName = Fields.Concat(CurrencyCodes)
            .GroupBy(f => f.Name, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.First().Unit, StringComparer.OrdinalIgnoreCase);
    }
}

/// <summary>Number formatting shared by all quantities. Same format strings as EngineeringUnits: S4 (default), V4, A, or any .NET numeric format.</summary>
public static class QuantityFormatter
{
    public static string Format(double value, string symbol, string? format, IFormatProvider? provider)
    {
        format ??= "S4";
        provider ??= CultureInfo.InvariantCulture;

        if (format.Length == 0)
            format = "G";

        return format[0] switch
        {
            'A' or 'a' or 'U' or 'u' or 'Q' or 'q' => symbol,
            'V' or 'v' => FormatNumber(value, "S" + format.Substring(1), provider),
            _ => $"{FormatNumber(value, format, provider)} {symbol}".Trim(),
        };
    }

    public static string FormatNumber(double value, string? format, IFormatProvider? provider)
    {
        format ??= "S4";
        provider ??= CultureInfo.InvariantCulture;

        if (format.Length > 1 && format[0] is 'S' or 's' && int.TryParse(format.Substring(1), out var digits))
            return SignificantDigits(value, digits);

        return value.ToString(format, provider);
    }

    private const double DecimalMax = 7.9e28;

    // Port of EngineeringUnits' DisplaySignificantDigits so both libraries print the same text
    private static string SignificantDigits(double value, int count)
    {
        if (double.IsNaN(value))
            return double.NaN.ToString(CultureInfo.InvariantCulture);
        if (double.IsInfinity(value))
            return value > 0 ? "Infinity" : "-Infinity";

        if (Math.Abs(value) >= DecimalMax || (value != 0 && Math.Abs(value) < 1e-28))
            return value.ToString("G" + count, CultureInfo.InvariantCulture);

        return SignificantDigits((decimal)value, count);
    }

    private static string SignificantDigits(decimal local, int count)
    {
        var text = local.ToString(CultureInfo.InvariantCulture);

        if (!text.Contains('.'))
            return text;

        text = text.TrimEnd('0').TrimEnd('.');

        if (!text.Contains('.'))
            return text;

        var currentCount = text.Count(x => x is not '.' and not '-');
        if (currentCount <= count)
            return text;

        var dotIndex = text.IndexOf('.');
        if (text.Contains('-'))
            dotIndex--;

        var precisionAfterDot = Math.Max(0, count - dotIndex);
        var rounded = decimal.Round(local, precisionAfterDot, MidpointRounding.AwayFromZero);

        return SignificantDigits(rounded, count);
    }
}

/// <summary>Finds a unit by its exact symbol - used when reading JSON.</summary>
public static class UnitLookup
{
    /// <summary>
    /// Symbol -> unit. A symbol that EngineeringUnits gives to two units with different factors (HectocubicMeter 100 m³ and
    /// CubicHectometer 10⁶ m³ are both "hm³") maps to null: it is ambiguous and must not be guessed.
    /// </summary>
    public static Dictionary<string, TUnit?> BySymbol<TUnit>(IEnumerable<TUnit> units) where TUnit : UnitTypebase
    {
        var result = new Dictionary<string, TUnit?>(StringComparer.Ordinal);

        foreach (var u in units)
        {
            if (string.IsNullOrWhiteSpace(u.Symbol))
                continue;

            if (!result.TryGetValue(u.Symbol, out var existing))
                result[u.Symbol] = u;
            else if (existing is not null && (existing.Factor != u.Factor || existing.Offset != u.Offset))
                result[u.Symbol] = null;
        }

        return result;
    }
}
