using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record DimensionlessUnit : UnitTypebase
{
    public static readonly DimensionlessUnit SI = new("-");

    public static readonly DimensionlessUnit DecimalFraction = new("-");

    [Synonyms("partperbillion", "partsperbillion", "ppb")]
    public static readonly DimensionlessUnit PartPerBillion = new("ppb", 1 / 1e9m);

    [Synonyms("partpermillion", "partspermillion", "ppm")]
    public static readonly DimensionlessUnit PartPerMillion = new("ppm", 1 / 1e6m);

    [Synonyms("permille", "per mille", "perthousand", "per thousand")]
    public static readonly DimensionlessUnit PartPerThousand = new("‰", 1 / 1e3m);

    [Synonyms("partpertrillion", "partspertrillion", "ppt")]
    public static readonly DimensionlessUnit PartPerTrillion = new("ppt", 1 / 1e12m);

    [Synonyms("percent", "percentage", "%")]
    public static readonly DimensionlessUnit Percent = new("%", 1 / 1e2m);

    public DimensionlessUnit(string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(correction, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}