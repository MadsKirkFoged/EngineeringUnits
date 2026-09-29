using System;
using System.ComponentModel;
using System.Globalization;

namespace EngineeringUnits.Fast;

/// <summary>
/// Converts a quantity to and from "value SI-symbol" text, e.g. "298.15 K".<br></br>
/// <br></br>
/// Why it exists: Newtonsoft.Json uses a type's TypeConverter automatically. Without one it writes every getter of the struct
/// and, because a Fast quantity has no setter, reads it back as ZERO without any error (25 °C came back as -273.15 °C).
/// With this converter Newtonsoft writes "298.15 K" and reads it back exactly - no extra package, no registration.
/// It also serves Microsoft.Extensions.Configuration, WPF/WinForms binding and anything else that uses TypeConverters.
/// <br></br>
/// This is not a unit parser: it only reads the SI symbol of this quantity (or a bare number, taken as SI). Anything else -
/// another unit, another quantity - throws, so bad data fails loudly.
/// </summary>
public sealed class QuantityTypeConverter<T> : TypeConverter where T : struct, IQuantity<T>
{
    private static readonly string Symbol = default(T).SIUnit.Symbol;

    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        => sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
        => destinationType == typeof(string) || base.CanConvertTo(context, destinationType);

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is T q)
            return Format(q.SI);

        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        if (value is string text)
            return T.FromSI(Read(text));

        return base.ConvertFrom(context, culture, value);
    }

    internal static string Format(double si)
    {
        var number = si.ToString("R", CultureInfo.InvariantCulture);
        return Symbol.Length == 0 ? number : number + " " + Symbol;
    }

    internal static double Read(string text)
    {
        var t = text.Trim();

        if (Symbol.Length > 0 && t.EndsWith(Symbol, StringComparison.Ordinal))
            t = t.Substring(0, t.Length - Symbol.Length).TrimEnd();

        if (double.TryParse(t, NumberStyles.Float, CultureInfo.InvariantCulture, out var si))
            return si;

        throw new FormatException($"'{text}' is not a {typeof(T).Name}. Expected a number in SI, optionally followed by [{Symbol}], e.g. \"{Format(1.5)}\".");
    }
}
