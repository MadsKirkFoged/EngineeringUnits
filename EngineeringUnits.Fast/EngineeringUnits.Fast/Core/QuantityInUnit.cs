using System;

namespace EngineeringUnits.Fast;

/// <summary>
/// What <c>x.ToUnit(PressureUnit.Bar)</c> gives: the same value, shown in the chosen unit.<br></br>
/// In EngineeringUnits a value remembers its unit. Fast always stores SI, so ToUnit returns this small display wrapper instead:
/// <c>$"{p.ToUnit(PressureUnit.Bar)}"</c> prints "2 bar" as before, and it converts back to the quantity, so
/// <c>Pressure q = p.ToUnit(PressureUnit.Bar);</c> still compiles. Math on it does not: convert first.<br></br>
/// It compares by value, like the quantity, so <c>list.Max(x => x.ToUnit(PressureUnit.Bar))</c> and <c>OrderBy</c> work as in
/// EngineeringUnits: 2 bar and 200 kPa compare as equal, whatever unit each is shown in.
/// </summary>
public readonly struct QuantityInUnit<T> : IFormattable, IComparable<QuantityInUnit<T>>, IComparable where T : struct, IQuantity<T>
{
    public QuantityInUnit(T quantity, UnitTypebase unit)
    {
        Quantity = quantity;
        Unit = unit;
    }

    /// <summary>The value, as a quantity (stored in SI).</summary>
    public T Quantity { get; }

    /// <summary>The unit it is shown in.</summary>
    public UnitTypebase Unit { get; }

    /// <summary>The number in <see cref="Unit"/>, e.g. 2 for 2 bar.</summary>
    public double ValueInUnit => Unit.FromSI(Quantity.SI);

    public static implicit operator T(QuantityInUnit<T> value) => value.Quantity;
    public static implicit operator UnknownUnit(QuantityInUnit<T> value) => new(value.Quantity.SI);

    /// <summary>Compares the values (in SI), not the display units - the same order as the quantities themselves.</summary>
    public int CompareTo(QuantityInUnit<T> other) => Quantity.SI.CompareTo(other.Quantity.SI);

    /// <summary>
    /// For <c>Comparer&lt;T&gt;.Default</c>, which LINQ's Min/Max/OrderBy use. Also takes the quantity itself; anything else
    /// (another quantity, null) throws, like the quantities do.
    /// </summary>
    public int CompareTo(object? obj) => obj switch
    {
        QuantityInUnit<T> other => CompareTo(other),
        T quantity => Quantity.SI.CompareTo(quantity.SI),
        _ => throw new ArgumentException($"Can't compare {typeof(T).Name} with {obj?.GetType().Name ?? "null"}"),
    };

    public override string ToString() => ToString(null, null);
    public string ToString(string? format) => ToString(format, null);
    public string ToString(IFormatProvider formatProvider) => ToString(null, formatProvider);
    public string ToString(string? format, IFormatProvider? formatProvider) => QuantityFormatter.Format(ValueInUnit, Unit.Symbol, format, formatProvider);
}

/// <summary>
/// What <c>unknown.ToUnit(displayUnit)</c> gives: an <see cref="UnknownUnit"/> shown in a unit chosen at runtime.<br></br>
/// The analyzer checks that the value and the unit have the same dimension ([SameDimension], EUF0005). Where it can't see
/// the dimension - an UnknownUnit read from a field, a unit typed as UnitTypebase - it reports EUF0007: that is the one place
/// a runtime-chosen unit needs a conscious decision.
/// </summary>
public readonly struct UnknownUnitInUnit : IFormattable
{
    private readonly double _si;

    internal UnknownUnitInUnit(double si, UnitTypebase unit)
    {
        _si = si;
        Unit = unit;
    }

    public UnitTypebase Unit { get; }
    public double ValueInUnit => Unit.FromSI(_si);

    public override string ToString() => ToString(null, null);
    public string ToString(string? format) => ToString(format, null);
    public string ToString(IFormatProvider formatProvider) => ToString(null, formatProvider);
    public string ToString(string? format, IFormatProvider? formatProvider) => QuantityFormatter.Format(ValueInUnit, Unit.Symbol, format, formatProvider);
}

public static class UnknownUnitDisplay
{
    /// <summary>Shows the value in <paramref name="unit"/>. Value and unit must have the same dimension (checked by the analyzer).</summary>
    public static UnknownUnitInUnit ToUnit([SameDimension] this UnknownUnit value, [SameDimension] UnitTypebase unit) => new(value.SI, unit);

    public static UnknownUnitInUnit? ToUnit([SameDimension] this UnknownUnit? value, [SameDimension] UnitTypebase unit)
        => value is { } v ? new UnknownUnitInUnit(v.SI, unit) : null;

    /// <summary>Returns the same value: it is always stored in SI. (EngineeringUnits converts the unit here.)</summary>
    [return: DimensionOf(nameof(value))]
    public static UnknownUnit ConvertToSI(this UnknownUnit value) => value;
    [return: DimensionOf(nameof(value))]
    public static UnknownUnit? ConvertToSI(this UnknownUnit? value) => value;
}
