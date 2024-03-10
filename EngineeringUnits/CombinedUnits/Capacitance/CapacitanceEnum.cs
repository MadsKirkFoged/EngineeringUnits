namespace EngineeringUnits.Units;

public partial record CapacitanceUnit : UnitTypebase
{

    public static readonly CapacitanceUnit SI = new(DurationUnit.SI, ElectricCurrentUnit.SI, LengthUnit.SI, MassUnit.SI, "F");
    public static readonly CapacitanceUnit Farad = new(DurationUnit.Second, ElectricCurrentUnit.Ampere, LengthUnit.Meter, MassUnit.Kilogram, "F");
    public static readonly CapacitanceUnit Kilofarad = new(PreFix.kilo, Farad);
    public static readonly CapacitanceUnit Megafarad = new(PreFix.mega, Farad);
    public static readonly CapacitanceUnit Microfarad = new(PreFix.micro, Farad);
    public static readonly CapacitanceUnit Millifarad = new(PreFix.milli, Farad);
    public static readonly CapacitanceUnit Nanofarad = new(PreFix.nano, Farad);
    public static readonly CapacitanceUnit Picofarad = new(PreFix.pico, Farad);

    public CapacitanceUnit(DurationUnit duration, ElectricCurrentUnit electricCurrent, LengthUnit Length, MassUnit Mass, string NewSymbol)
    {
        Unit = new UnitSystem(duration.Pow(4) * electricCurrent.Pow(2) / (Length.Pow(2) * Mass.Unit), NewSymbol);
    }

    public CapacitanceUnit(PreFix SI, CapacitanceUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}