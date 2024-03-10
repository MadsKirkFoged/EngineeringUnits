namespace EngineeringUnits.Units;

public partial record ElectricInductanceUnit : UnitTypebase
{

    public static readonly ElectricInductanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "H");
    public static readonly ElectricInductanceUnit Henry = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "H");
    public static readonly ElectricInductanceUnit Microhenry = new(PreFix.micro, Henry);
    public static readonly ElectricInductanceUnit Millihenry = new(PreFix.milli, Henry);
    public static readonly ElectricInductanceUnit Nanohenry = new(PreFix.nano, Henry);

    public ElectricInductanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
    {
        Unit = new UnitSystem(mass * Length.Pow(2)/(duration.Pow(2)  * electricCurrent.Pow(2)), NewSymbol);
    }

    public ElectricInductanceUnit(PreFix SI, ElectricInductanceUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}