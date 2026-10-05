using Fractions;
using Newtonsoft.Json;
using System;

namespace EngineeringUnits;

// BaseUnit.testValue is a boxed Fraction (object?). Without this, Newtonsoft would read it back as a string,
// and the next conversion would fail on (Fraction)testValue. The JSON is the same as a Fraction? field gives ("381/1250").
internal sealed class BoxedFractionJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) => objectType == typeof(object);

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        if (value is Fraction fraction)
            serializer.Serialize(writer, fraction);
        else
            writer.WriteNull();
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) =>
        reader.TokenType == JsonToken.Null ? null : serializer.Deserialize<Fraction>(reader);
}
