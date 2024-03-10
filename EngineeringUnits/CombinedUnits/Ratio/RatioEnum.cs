namespace EngineeringUnits.Units;

public partial record RatioUnit : UnitTypebase
{

    public static readonly RatioUnit SI = new("");
    public static readonly RatioUnit DecimalFraction = new("-");
    public static readonly RatioUnit PartPerBillion = new("ppb", 1/1e9m);
    public static readonly RatioUnit PartPerMillion = new("ppm", 1 / 1e6m);
    public static readonly RatioUnit PartPerThousand = new("‰", 1 / 1e3m);
    public static readonly RatioUnit PartPerTrillion = new("ppt", 1 / 1e12m);
    public static readonly RatioUnit Percent = new("%", 1 / 1e2m);

    public static readonly RatioUnit CentigramPerGram = new(MassUnit.Centigram, MassUnit.Gram);
    public static readonly RatioUnit CentigramPerKilogram = new(MassUnit.Centigram, MassUnit.Kilogram);
    public static readonly RatioUnit DecagramPerGram = new(MassUnit.Decagram, MassUnit.Gram);
    public static readonly RatioUnit DecagramPerKilogram = new(MassUnit.Decagram, MassUnit.Kilogram);
    public static readonly RatioUnit DecigramPerGram = new(MassUnit.Decigram, MassUnit.Gram);
    public static readonly RatioUnit DecigramPerKilogram = new(MassUnit.Decigram, MassUnit.Kilogram);

    public static readonly RatioUnit GramPerGram = new(MassUnit.Gram, MassUnit.Gram);
    public static readonly RatioUnit GramPerKilogram = new(MassUnit.Gram, MassUnit.Kilogram);
    public static readonly RatioUnit HectogramPerGram = new(MassUnit.Hectogram, MassUnit.Gram);
    public static readonly RatioUnit HectogramPerKilogram = new(MassUnit.Hectogram, MassUnit.Kilogram);
    public static readonly RatioUnit KilogramPerGram = new(MassUnit.Kilogram, MassUnit.Gram);
    public static readonly RatioUnit KilogramPerKilogram = new(MassUnit.Kilogram, MassUnit.Kilogram);
    public static readonly RatioUnit MicrogramPerGram = new(MassUnit.Microgram, MassUnit.Gram);
    public static readonly RatioUnit MicrogramPerKilogram = new(MassUnit.Microgram, MassUnit.Kilogram);
    public static readonly RatioUnit MilligramPerGram = new(MassUnit.Milligram, MassUnit.Gram);
    public static readonly RatioUnit MilligramPerKilogram = new(MassUnit.Milligram, MassUnit.Kilogram);
    public static readonly RatioUnit NanogramPerGram = new(MassUnit.Nanogram, MassUnit.Gram);
    public static readonly RatioUnit NanogramPerKilogram = new(MassUnit.Nanogram, MassUnit.Kilogram);

    public static readonly RatioUnit CentilitersPerLiter = new(VolumeUnit.Centiliter, VolumeUnit.Liter);
    public static readonly RatioUnit CentilitersPerMililiter = new(VolumeUnit.Centiliter, VolumeUnit.Milliliter);
    public static readonly RatioUnit DecilitersPerLiter = new(VolumeUnit.Deciliter, VolumeUnit.Liter);
    public static readonly RatioUnit DecilitersPerMililiter = new(VolumeUnit.Deciliter, VolumeUnit.Milliliter);
    public static readonly RatioUnit LitersPerLiter = new(VolumeUnit.Liter, VolumeUnit.Liter);
    public static readonly RatioUnit LitersPerMililiter = new(VolumeUnit.Liter, VolumeUnit.Milliliter);
    public static readonly RatioUnit MicrolitersPerLiter = new(VolumeUnit.Microliter, VolumeUnit.Liter);
    public static readonly RatioUnit MicrolitersPerMililiter = new(VolumeUnit.Microliter, VolumeUnit.Milliliter);
    public static readonly RatioUnit MillilitersPerLiter = new(VolumeUnit.Milliliter, VolumeUnit.Liter);
    public static readonly RatioUnit MillilitersPerMililiter = new(VolumeUnit.Milliliter, VolumeUnit.Milliliter);
    public static readonly RatioUnit NanolitersPerLiter = new(VolumeUnit.Nanoliter, VolumeUnit.Liter);
    public static readonly RatioUnit NanolitersPerMililiter = new(VolumeUnit.Nanoliter, VolumeUnit.Milliliter);
    public static readonly RatioUnit PicolitersPerLiter = new(VolumeUnit.Picoliter, VolumeUnit.Liter);
    public static readonly RatioUnit PicolitersPerMililiter = new(VolumeUnit.Picoliter, VolumeUnit.Milliliter);

    public RatioUnit(string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(correction, NewSymbol);
    }

    public RatioUnit(MassUnit mass1, MassUnit mass2)
    {
        Unit = new UnitSystem(mass1 / mass2,
                            $"{mass1}/{mass2}");
    }

    public RatioUnit(VolumeUnit vol1, VolumeUnit vol2)
    {
        Unit = new UnitSystem(vol1 / vol2,
                            $"{vol1}/{vol2}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}