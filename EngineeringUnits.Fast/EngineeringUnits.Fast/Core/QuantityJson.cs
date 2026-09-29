using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;

namespace EngineeringUnits.Fast;

/// <summary>
/// Shared JSON logic for the generated converters.<br></br>
/// The unit is written next to the value, so reading a Length into a Power fails instead of silently giving wrong numbers.<br></br>
/// Reads {"Value": 10, "Unit": "kW"} or a bare number in SI. Text like "10 kW" is not accepted - Fast has no parser.
/// </summary>
public static class QuantityJson
{
    public static double Read<TUnit>(ref Utf8JsonReader reader, string quantityName, IReadOnlyDictionary<string, TUnit?> bySymbol)
        where TUnit : UnitTypebase
    {
        switch (reader.TokenType)
        {
            // Bare number: SI
            case JsonTokenType.Number:
                return reader.GetDouble();

            // {"Value": 10, "Unit": "kW"} - the unit must be the exact symbol of a unit of this quantity
            case JsonTokenType.StartObject:
            {
                double? value = null;
                string? unit = null;

                while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
                {
                    if (reader.TokenType != JsonTokenType.PropertyName)
                        throw new JsonException($"Unexpected {reader.TokenType} in a {quantityName}");

                    var name = reader.GetString();
                    reader.Read();

                    if (string.Equals(name, "Value", StringComparison.OrdinalIgnoreCase))
                        value = reader.TokenType == JsonTokenType.String
                            ? double.Parse(reader.GetString()!, NumberStyles.Float, CultureInfo.InvariantCulture)
                            : reader.GetDouble();
                    else if (string.Equals(name, "Unit", StringComparison.OrdinalIgnoreCase))
                        unit = reader.GetString();
                    else
                        reader.Skip();
                }

                if (value is null)
                    throw new JsonException($"A {quantityName} needs a \"Value\"");

                if (unit is null)
                    return value.Value;

                if (!bySymbol.TryGetValue(unit, out var u))
                    throw new JsonException($"[{unit}] is not a unit of {quantityName}");

                if (u is null)
                    throw new JsonException($"[{unit}] is ambiguous for {quantityName}: several units with different sizes use this symbol");

                return u.ToSI(value.Value);
            }

            default:
                throw new JsonException($"Can't read a {quantityName} from {reader.TokenType}");
        }
    }

    public static void Write(Utf8JsonWriter writer, double si, string siSymbol)
    {
        writer.WriteStartObject();

        if (double.IsNaN(si) || double.IsInfinity(si))
            writer.WriteString("Value", si.ToString(CultureInfo.InvariantCulture));
        else
            writer.WriteNumber("Value", si);

        writer.WriteString("Unit", siSymbol);
        writer.WriteEndObject();
    }
}
