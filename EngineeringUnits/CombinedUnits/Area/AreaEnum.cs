using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record AreaUnit : UnitTypebase
{

    [Synonyms("acre", "acres", "ac")]
    public static readonly AreaUnit Acre = new(LengthUnit.Chain, "ac", 10);

    [Synonyms("hectare", "hectares", "ha")]
    public static readonly AreaUnit Hectare = new(LengthUnit.Hectometer, "ha");

    [Synonyms("square centimeter", "square centimeters", "square centimetre", "square centimetres", "sq cm", "sq centimeter", "sq centimetre")]
    public static readonly AreaUnit SquareCentimeter = new(LengthUnit.Centimeter);

    [Synonyms("square decimeter", "square decimeters", "square decimetre", "square decimetres", "sq dm", "sq decimeter", "sq decimetre")]
    public static readonly AreaUnit SquareDecimeter = new(LengthUnit.Decimeter);

    [Synonyms("square kilometer", "square kilometers", "square kilometre", "square kilometres", "sq km", "sq kilometer", "sq kilometre")]
    public static readonly AreaUnit SquareKilometer = new(LengthUnit.Kilometer);

    [Synonyms("square meter", "square meters", "square metre", "square metres", "sq m", "sq meter", "sq metre")]
    public static readonly AreaUnit SquareMeter = new(LengthUnit.Meter);

    [Synonyms("square micrometer", "square micrometers", "square micrometre", "square micrometres", "sq um", "sq micrometer", "sq micrometre")]
    public static readonly AreaUnit SquareMicrometer = new(LengthUnit.Micrometer);

    public static readonly AreaUnit SI = new(LengthUnit.SI);

    [Synonyms("square millimeter", "square millimeters", "square millimetre", "square millimetres", "sq mm", "sq millimeter", "sq millimetre")]
    public static readonly AreaUnit SquareMillimeter = new(LengthUnit.Millimeter);

    [Synonyms("square nanometer", "square nanometers", "square nanometre", "square nanometres", "sq nm", "sq nanometer", "sq nanometre")]
    public static readonly AreaUnit SquareNanometer = new(LengthUnit.Nanometer);

    [Synonyms("square inch", "square inches", "sq in", "sq inch")]
    public static readonly AreaUnit SquareInch = new(LengthUnit.Inch);

    [Synonyms("square foot", "square feet", "sq ft", "sq foot")]
    public static readonly AreaUnit SquareFoot = new(LengthUnit.Foot);

    [Synonyms("square yard", "square yards", "sq yd", "sq yard")]
    public static readonly AreaUnit SquareYard = new(LengthUnit.Yard);

    [Synonyms("square mile", "square miles", "sq mi", "sq mile")]
    public static readonly AreaUnit SquareMile = new(LengthUnit.Mile);

    [Synonyms("square nautical mile", "square nautical miles")]
    public static readonly AreaUnit SquareNauticalMile = new(LengthUnit.NauticalMile, "nmi²"); //TODO Length and Area have diff naming

    [Synonyms("square chain", "square chains")]
    public static readonly AreaUnit SquareChain = new(LengthUnit.Chain);

    public AreaUnit(LengthUnit Length, string? NewSymbol = null, decimal correction = 1)
    {
        Unit = new UnitSystem(Length.Pow(2) * correction, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}