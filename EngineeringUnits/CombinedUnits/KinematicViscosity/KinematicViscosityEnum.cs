namespace EngineeringUnits.Units;

public partial record KinematicViscosityUnit : UnitTypebase
{

    public static readonly KinematicViscosityUnit SI = new(AreaUnit.SI, DurationUnit.SI);
    public static readonly KinematicViscosityUnit SquareMeterPerSecond = new(AreaUnit.SquareMeter, DurationUnit.Second);
    public static readonly KinematicViscosityUnit Stokes = new(AreaUnit.SquareCentimeter, DurationUnit.Second, "St");
    public static readonly KinematicViscosityUnit Centistokes = new(PreFix.centi, Stokes);
    public static readonly KinematicViscosityUnit Decistokes = new(PreFix.deci, Stokes);
    public static readonly KinematicViscosityUnit Kilostokes = new(PreFix.kilo, Stokes);
    public static readonly KinematicViscosityUnit Microstokes = new(PreFix.micro, Stokes);
    public static readonly KinematicViscosityUnit Millistokes = new(PreFix.milli, Stokes);
    public static readonly KinematicViscosityUnit Nanostokes = new(PreFix.nano, Stokes);

    public KinematicViscosityUnit(AreaUnit Length, DurationUnit duration, string NewSymbol = null)
    {
        Unit = new UnitSystem(Length / duration, NewSymbol);
    }
    public KinematicViscosityUnit(PreFix SI, KinematicViscosityUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}