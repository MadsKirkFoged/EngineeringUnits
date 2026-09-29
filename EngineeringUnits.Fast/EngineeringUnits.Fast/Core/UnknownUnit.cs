using System;
using System.Globalization;

namespace EngineeringUnits.Fast;

/// <summary>
/// The result of arithmetic between quantities, e.g. <c>massFlow * enthalpy</c>.<br></br>
/// At runtime it is only a double in SI units - it does NOT know its dimension. The analyzer knows it at compile time
/// and checks it when the value is turned into a named quantity (<c>Power q = massFlow * enthalpy;</c>).
/// </summary>
/// <remarks>
/// Keep <see cref="UnknownUnit"/> inside expressions or in locals. Stored anywhere else (fields, parameters, return values,
/// collections) the analyzer can't follow it and reports EUF0007, unless it is marked with <see cref="UnitDimensionAttribute"/>.
/// </remarks>
public readonly struct UnknownUnit : IEquatable<UnknownUnit>, IFormattable
{
    private readonly double _si;

    internal UnknownUnit(double si) => _si = si;

    /// <summary>
    /// The value in SI units. Internal on purpose: a public raw value would let <c>Power.FromSI(x.SI)</c> strip the unit
    /// without any check. Use <c>(double)(x / Power.FromWatt(1))</c> - the analyzer checks that cast (EUF0004).
    /// </summary>
    internal double SI => _si;

    public static UnknownUnit operator +(UnknownUnit a, UnknownUnit b) => new(a._si + b._si);
    public static UnknownUnit operator -(UnknownUnit a, UnknownUnit b) => new(a._si - b._si);
    public static UnknownUnit operator *(UnknownUnit a, UnknownUnit b) => new(a._si * b._si);
    public static UnknownUnit operator /(UnknownUnit a, UnknownUnit b) => new(a._si / b._si);
    public static UnknownUnit operator *(UnknownUnit a, double b) => new(a._si * b);
    public static UnknownUnit operator *(double a, UnknownUnit b) => new(a * b._si);
    public static UnknownUnit operator /(UnknownUnit a, double b) => new(a._si / b);
    public static UnknownUnit operator /(double a, UnknownUnit b) => new(a / b._si);
    // 1 - massRatio: only valid when the UnknownUnit is dimensionless - checked by the analyzer (EUF0002)
    public static UnknownUnit operator +(UnknownUnit a, double b) => new(a._si + b);
    public static UnknownUnit operator +(double a, UnknownUnit b) => new(a + b._si);
    public static UnknownUnit operator -(UnknownUnit a, double b) => new(a._si - b);
    public static UnknownUnit operator -(double a, UnknownUnit b) => new(a - b._si);

    public static UnknownUnit operator -(UnknownUnit a) => new(-a._si);
    public static UnknownUnit operator +(UnknownUnit a) => a;

    public static bool operator ==(UnknownUnit a, UnknownUnit b) => a._si == b._si;
    public static bool operator !=(UnknownUnit a, UnknownUnit b) => a._si != b._si;
    public static bool operator <(UnknownUnit a, UnknownUnit b) => a._si < b._si;
    public static bool operator >(UnknownUnit a, UnknownUnit b) => a._si > b._si;
    public static bool operator <=(UnknownUnit a, UnknownUnit b) => a._si <= b._si;
    public static bool operator >=(UnknownUnit a, UnknownUnit b) => a._si >= b._si;

    /// <summary>Only allowed when the value is dimensionless - checked by the analyzer (EUF0004).</summary>
    public static explicit operator double(UnknownUnit a) => a._si;

    public bool Equals(UnknownUnit other) => _si.Equals(other._si);
    public override bool Equals(object? obj) => obj is UnknownUnit other && Equals(other);
    public override int GetHashCode() => _si.GetHashCode();

    /// <summary>Prints the SI value followed by [?]: the unit is not known at runtime.</summary>
    public override string ToString() => ToString(null, null);
    public string ToString(string? format) => ToString(format, null);
    public string ToString(IFormatProvider formatProvider) => ToString(null, formatProvider);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => QuantityFormatter.Format(_si, "[?]", format, formatProvider);   // same formats as a quantity: S4, V4 (number only), U (unit only)
}
