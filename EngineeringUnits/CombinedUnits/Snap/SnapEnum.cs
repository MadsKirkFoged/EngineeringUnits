namespace EngineeringUnits.Units;

public partial record SnapUnit : UnitTypebase
{
    public static readonly SnapUnit SI = new(LengthUnit.SI, DurationUnit.SI);
    public static readonly SnapUnit KilometerPerSecond4 = new(LengthUnit.Kilometer, DurationUnit.Second);
    public static readonly SnapUnit MeterPerSecond4 = new(LengthUnit.SI, DurationUnit.SI);
    public static readonly SnapUnit DecimeterPerSecond4 = new(LengthUnit.Decimeter, DurationUnit.Second);
    public static readonly SnapUnit CentimeterPerSecond4 = new(LengthUnit.Centimeter, DurationUnit.Second);
    public static readonly SnapUnit MicrometerPerSecond4 = new(LengthUnit.Micrometer, DurationUnit.Second);
    public static readonly SnapUnit MillimeterPerSecond4 = new(LengthUnit.Millimeter, DurationUnit.Second);
    public static readonly SnapUnit NanometerPerSecond4 = new(LengthUnit.Nanometer, DurationUnit.Second);

    public SnapUnit(LengthUnit length, DurationUnit duration)
    {
        Unit = length / duration.Pow(4);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
