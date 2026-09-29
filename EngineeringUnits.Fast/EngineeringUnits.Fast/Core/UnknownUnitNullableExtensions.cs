using System;
using EngineeringUnits.Fast;

// Global namespace on purpose, like the generated {T}NullableExtensions: in EngineeringUnits UnknownUnit is a class and these are
// instance members, usable without "using EngineeringUnits;". Extension members in the global namespace are in scope everywhere.

/// <summary>The members of <see cref="UnknownUnit"/> on an <see cref="UnknownUnit"/>?.</summary>
public static class UnknownUnitNullableExtensions
{
    /// <summary>"" for null, like Nullable&lt;T&gt;.ToString().</summary>
    public static string ToString(this UnknownUnit? value, string? format) => value is { } v ? v.ToString(format) : "";
    public static string ToString(this UnknownUnit? value, IFormatProvider formatProvider) => value is { } v ? v.ToString(formatProvider) : "";
    public static string ToString(this UnknownUnit? value, string? format, IFormatProvider? formatProvider) => value is { } v ? v.ToString(format, formatProvider) : "";
}
