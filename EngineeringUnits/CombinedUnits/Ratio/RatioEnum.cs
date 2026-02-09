using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record RatioUnit : UnitTypebase
{

    
    public static readonly RatioUnit SI = new("");

    // RatioUnit synonyms (case-insensitive-safe; no case-dependent disambiguation)

    [Synonyms("[-]", "[ - ]", "dimensionless", "ratio", "fraction", "decimal fraction", "unitless")]
    public static readonly RatioUnit DecimalFraction = new("-");

    [Synonyms("ppb", "part per billion", "parts per billion", "partsperbillion", "partperbillion")]
    public static readonly RatioUnit PartPerBillion = new("ppb", 1 / 1e9m);

    [Synonyms("ppm", "part per million", "parts per million", "partspermillion", "partpermillion")]
    public static readonly RatioUnit PartPerMillion = new("ppm", 1 / 1e6m);

    [Synonyms("‰", "permille", "per mille", "per-mille", "per thousand", "parts per thousand", "partsperthousand", "partperthousand", "ppth")]
    public static readonly RatioUnit PartPerThousand = new("‰", 1 / 1e3m);

    [Synonyms("ppt", "part per trillion", "parts per trillion", "partspertrillion", "partpertrillion", "pptr")]
    public static readonly RatioUnit PartPerTrillion = new("ppt", 1 / 1e12m);

    [Synonyms("%", "percent", "per cent", "per-cent", "percentage", "pct")]
    public static readonly RatioUnit Percent = new("%", 1 / 1e2m);

    // --- Mass ratios (mass/mass) ---

    [Synonyms("cg/g", "cg per g", "centigram per gram", "centigrams per gram", "centigrampergram", "centigramspergram")]
    public static readonly RatioUnit CentigramPerGram = new(MassUnit.Centigram, MassUnit.Gram);

    [Synonyms("cg/kg", "cg per kg", "centigram per kilogram", "centigrams per kilogram", "centigramperkilogram", "centigramsperkilogram")]
    public static readonly RatioUnit CentigramPerKilogram = new(MassUnit.Centigram, MassUnit.Kilogram);

    [Synonyms("dag/g", "dag per g", "decagram per gram", "decagrams per gram", "decagrampergram", "decagramspergram", "dkg/g", "dkg per g")]
    public static readonly RatioUnit DecagramPerGram = new(MassUnit.Decagram, MassUnit.Gram);

    [Synonyms("dag/kg", "dag per kg", "decagram per kilogram", "decagrams per kilogram", "decagramperkilogram", "decagramsperkilogram", "dkg/kg", "dkg per kg")]
    public static readonly RatioUnit DecagramPerKilogram = new(MassUnit.Decagram, MassUnit.Kilogram);

    [Synonyms("dg/g", "dg per g", "decigram per gram", "decigrams per gram", "decigrampergram", "decigramspergram")]
    public static readonly RatioUnit DecigramPerGram = new(MassUnit.Decigram, MassUnit.Gram);

    [Synonyms("dg/kg", "dg per kg", "decigram per kilogram", "decigrams per kilogram", "decigramperkilogram", "decigramsperkilogram")]
    public static readonly RatioUnit DecigramPerKilogram = new(MassUnit.Decigram, MassUnit.Kilogram);

    [Synonyms("g/g", "g per g", "gram per gram", "grams per gram", "grampergram", "gramspergram")]
    public static readonly RatioUnit GramPerGram = new(MassUnit.Gram, MassUnit.Gram);

    [Synonyms("g/kg", "g per kg", "gram per kilogram", "grams per kilogram", "gramperkilogram", "gramsperkilogram")]
    public static readonly RatioUnit GramPerKilogram = new(MassUnit.Gram, MassUnit.Kilogram);

    [Synonyms("hg/g", "hg per g", "hectogram per gram", "hectograms per gram", "hectogrampergram", "hectogramspergram")]
    public static readonly RatioUnit HectogramPerGram = new(MassUnit.Hectogram, MassUnit.Gram);

    [Synonyms("hg/kg", "hg per kg", "hectogram per kilogram", "hectograms per kilogram", "hectogramperkilogram", "hectogramsperkilogram")]
    public static readonly RatioUnit HectogramPerKilogram = new(MassUnit.Hectogram, MassUnit.Kilogram);

    [Synonyms("kg/g", "kg per g", "kilogram per gram", "kilograms per gram", "kilogrampergram", "kilogramspergram")]
    public static readonly RatioUnit KilogramPerGram = new(MassUnit.Kilogram, MassUnit.Gram);

    [Synonyms("kg/kg", "kg per kg", "kilogram per kilogram", "kilograms per kilogram", "kilogramperkilogram", "kilogramsperkilogram")]
    public static readonly RatioUnit KilogramPerKilogram = new(MassUnit.Kilogram, MassUnit.Kilogram);

    [Synonyms("ug/g", "µg/g", "mcg/g", "ug per g", "microgram per gram", "micrograms per gram", "microgrampergram", "microgramspergram")]
    public static readonly RatioUnit MicrogramPerGram = new(MassUnit.Microgram, MassUnit.Gram);

    [Synonyms("ug/kg", "µg/kg", "mcg/kg", "ug per kg", "microgram per kilogram", "micrograms per kilogram", "microgramperkilogram", "microgramsperkilogram")]
    public static readonly RatioUnit MicrogramPerKilogram = new(MassUnit.Microgram, MassUnit.Kilogram);

    [Synonyms("mg/g", "mg per g", "milligram per gram", "milligrams per gram", "milligrampergram", "milligramspergram")]
    public static readonly RatioUnit MilligramPerGram = new(MassUnit.Milligram, MassUnit.Gram);

    [Synonyms("mg/kg", "mg per kg", "milligram per kilogram", "milligrams per kilogram", "milligramperkilogram", "milligramsperkilogram")]
    public static readonly RatioUnit MilligramPerKilogram = new(MassUnit.Milligram, MassUnit.Kilogram);

    [Synonyms("ng/g", "ng per g", "nanogram per gram", "nanograms per gram", "nanogrampergram", "nanogramspergram")]
    public static readonly RatioUnit NanogramPerGram = new(MassUnit.Nanogram, MassUnit.Gram);

    [Synonyms("ng/kg", "ng per kg", "nanogram per kilogram", "nanograms per kilogram", "nanogramperkilogram", "nanogramsperkilogram")]
    public static readonly RatioUnit NanogramPerKilogram = new(MassUnit.Nanogram, MassUnit.Kilogram);

    // --- Volume ratios (volume/volume) ---

    [Synonyms("cl/l", "cL/L", "cl per l", "centiliter per liter", "centiliters per liter", "centiliterperliter", "centilitersperliter")]
    public static readonly RatioUnit CentilitersPerLiter = new(VolumeUnit.Centiliter, VolumeUnit.Liter);

    [Synonyms("cl/ml", "cL/mL", "cl per ml", "centiliter per milliliter", "centiliters per milliliter", "centiliterpermilliliter", "centiliterspermilliliter")]
    public static readonly RatioUnit CentilitersPerMililiter = new(VolumeUnit.Centiliter, VolumeUnit.Milliliter);

    [Synonyms("dl/l", "dL/L", "dl per l", "deciliter per liter", "deciliters per liter", "deciliterperliter", "decilitersperliter")]
    public static readonly RatioUnit DecilitersPerLiter = new(VolumeUnit.Deciliter, VolumeUnit.Liter);

    [Synonyms("dl/ml", "dL/mL", "dl per ml", "deciliter per milliliter", "deciliters per milliliter", "deciliterpermilliliter", "deciliterspermilliliter")]
    public static readonly RatioUnit DecilitersPerMililiter = new(VolumeUnit.Deciliter, VolumeUnit.Milliliter);

    [Synonyms("l/l", "L/L", "l per l", "liter per liter", "liters per liter", "literperliter", "litersperliter")]
    public static readonly RatioUnit LitersPerLiter = new(VolumeUnit.Liter, VolumeUnit.Liter);

    [Synonyms("l/ml", "L/mL", "l per ml", "liter per milliliter", "liters per milliliter", "literpermilliliter", "literspermilliliter")]
    public static readonly RatioUnit LitersPerMililiter = new(VolumeUnit.Liter, VolumeUnit.Milliliter);

    [Synonyms("ul/l", "µl/l", "uL/L", "ul per l", "microliter per liter", "microliters per liter", "microliterperliter", "microlitersperliter")]
    public static readonly RatioUnit MicrolitersPerLiter = new(VolumeUnit.Microliter, VolumeUnit.Liter);

    [Synonyms("ul/ml", "µl/ml", "uL/mL", "ul per ml", "microliter per milliliter", "microliters per milliliter", "microliterpermilliliter", "microliterspermilliliter")]
    public static readonly RatioUnit MicrolitersPerMililiter = new(VolumeUnit.Microliter, VolumeUnit.Milliliter);

    [Synonyms("ml/l", "mL/L", "ml per l", "milliliter per liter", "milliliters per liter", "milliliterperliter", "millilitersperliter")]
    public static readonly RatioUnit MillilitersPerLiter = new(VolumeUnit.Milliliter, VolumeUnit.Liter);

    [Synonyms("ml/ml", "mL/mL", "ml per ml", "milliliter per milliliter", "milliliters per milliliter", "milliliterpermilliliter", "milliliterspermilliliter")]
    public static readonly RatioUnit MillilitersPerMililiter = new(VolumeUnit.Milliliter, VolumeUnit.Milliliter);

    [Synonyms("nl/l", "nL/L", "nl per l", "nanoliter per liter", "nanoliters per liter", "nanoliterperliter", "nanolitersperliter")]
    public static readonly RatioUnit NanolitersPerLiter = new(VolumeUnit.Nanoliter, VolumeUnit.Liter);

    [Synonyms("nl/ml", "nL/mL", "nl per ml", "nanoliter per milliliter", "nanoliters per milliliter", "nanoliterpermilliliter", "nanoliterspermilliliter")]
    public static readonly RatioUnit NanolitersPerMililiter = new(VolumeUnit.Nanoliter, VolumeUnit.Milliliter);

    [Synonyms("pl/l", "pL/L", "pl per l", "picoliter per liter", "picoliters per liter", "picoliterperliter", "picolitersperliter")]
    public static readonly RatioUnit PicolitersPerLiter = new(VolumeUnit.Picoliter, VolumeUnit.Liter);

    [Synonyms("pl/ml", "pL/mL", "pl per ml", "picoliter per milliliter", "picoliters per milliliter", "picoliterpermilliliter", "picoliterspermilliliter")]
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