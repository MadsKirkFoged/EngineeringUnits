namespace EngineeringUnits.Units;

public partial record MassFluxUnit : UnitTypebase
{

    public static readonly MassFluxUnit SI = new(MassUnit.SI, DurationUnit.SI, AreaUnit.SI);
    public static readonly MassFluxUnit KilogramPerSecondPerSquareMeter = new(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareMeter);

    public static readonly MassFluxUnit GramPerHourPerSquareCentimeter = new(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareCentimeter);
    public static readonly MassFluxUnit GramPerHourPerSquareMeter = new(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareMeter);
    public static readonly MassFluxUnit GramPerHourPerSquareMillimeter = new(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareMillimeter);
    public static readonly MassFluxUnit GramPerSecondPerSquareCentimeter = new(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareCentimeter);
    public static readonly MassFluxUnit GramPerSecondPerSquareMeter = new(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareMeter);
    public static readonly MassFluxUnit GramPerSecondPerSquareMillimeter = new(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareMillimeter);

    public static readonly MassFluxUnit KilogramPerHourPerSquareCentimeter = new(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareCentimeter);
    public static readonly MassFluxUnit KilogramPerHourPerSquareMeter = new(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareMeter);
    public static readonly MassFluxUnit KilogramPerHourPerSquareMillimeter = new(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareMillimeter);
    public static readonly MassFluxUnit KilogramPerSecondPerSquareCentimeter = new(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareCentimeter);
    public static readonly MassFluxUnit KilogramPerSecondPerSquareMillimeter = new(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareMillimeter);

    public MassFluxUnit(MassUnit mass, DurationUnit duration, AreaUnit area)
    {
        Unit = mass / (duration * area);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}