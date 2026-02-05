using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace EngineeringUnits;

//This is the object that is used in the list of the unitsystem

//When converting between units we use y=ax+b
//The a and the b are found below
//The count tell how many of the same type we have: 
//ex. 1meter has a count of 1 lenght
//ex. 1meter^2 (area) has a count of 2 lenght

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
public record RawUnit
{

    [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    [DefaultValue("")]
    [System.Text.Json.Serialization.JsonPropertyName("S")]
    public string? Symbol { get; init; }


    public Fraction A { get; init; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    [DefaultValue(0d)]
    [System.Text.Json.Serialization.JsonPropertyName("B")]
    public Fraction B { get; init; }

    [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    [DefaultValue(1)]
    [System.Text.Json.Serialization.JsonPropertyName("C")]
    public int Count { get; init; }
    public BaseunitType UnitType { get; init; }

    [JsonIgnore]
    public Fraction TotalConstant => Fraction.Pow(A, Count);

    [JsonIgnore]
    public bool IsSI => A == Fraction.One && B == Fraction.Zero;

    public RawUnit() { }

    public RawUnit CloneAndReverseCount()
    {
        return this with
        {
            Count = Count * -1,
        };

    }
    public RawUnit CloneWithNewCount(int newCount)
    {
        if (Count == newCount)
            return this;

        return this with
        {
            Count = newCount,
        };

    }

    public RawUnit CloneAsSI()
    {

        return UnitType switch
        {
            BaseunitType.length => this with { A = Fraction.One, B = 0, Symbol = LengthUnit.SI.ToString() },
            BaseunitType.mass => this with { A = Fraction.One, B = 0, Symbol = MassUnit.SI.ToString() },
            BaseunitType.time => this with { A = Fraction.One, B = 0, Symbol = DurationUnit.SI.ToString() },
            BaseunitType.electricCurrent => this with { A = Fraction.One, B = 0, Symbol = ElectricCurrentUnit.SI.ToString() },
            BaseunitType.temperature => this with { A = Fraction.One, B = 0, Symbol = TemperatureUnit.SI.ToString() },
            BaseunitType.amountOfSubstance => this with { A = Fraction.One, B = 0, Symbol = AmountOfSubstanceUnit.SI.ToString() },
            BaseunitType.luminousIntensity => this with { A = Fraction.One, B = 0, Symbol = LuminousIntensityUnit.SI.ToString() },
            BaseunitType.Cost => this with { A = Fraction.One, B = 0, Symbol = CostUnit.SI.ToString() },
            BaseunitType.CombinedUnit => this with { A = Fraction.One, B = 0, Symbol = null },
            _ => throw new InvalidOperationException("Invalid UnitType")
        };

    }

    public RawUnit CloneWithOutOffset() => this with { B = 0, Symbol = null };

    //public override int GetHashCode()
    //{
    //    int TempHashCode;
    //    unchecked // Overflow is fine, just wrap
    //    {
    //        TempHashCode = (int)2166136261;
    //        TempHashCode = (TempHashCode * 16777619) ^ A.GetHashCode();
    //        TempHashCode = (TempHashCode * 45476689) ^ B.GetHashCode();
    //        TempHashCode = (TempHashCode * 16777619) ^ Count.GetHashCode();
    //        TempHashCode = (TempHashCode * 16777619) ^ UnitType.GetHashCode();
    //    }

    //    return TempHashCode;
    //}

    public override int GetHashCode()
    {
        var hc = new HashCode();

        
        //hc.Add(Symbol, StringComparer.Ordinal);

        hc.Add(A);
        hc.Add(B);
        hc.Add(Count);
        hc.Add(UnitType);

        return hc.ToHashCode();
    }
}
