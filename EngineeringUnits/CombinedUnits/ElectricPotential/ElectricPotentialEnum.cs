using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record ElectricPotentialUnit : UnitTypebase
{

    public static readonly ElectricPotentialUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "V");

    [Synonyms("volt", "volts", "V")]
    public static readonly ElectricPotentialUnit Volt = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "V");

    [Synonyms("kilovolt", "kilovolts", "kV")]
    public static readonly ElectricPotentialUnit Kilovolt = new(PreFix.kilo, Volt);

    [Synonyms("megavolt", "megavolts", "MV")]
    public static readonly ElectricPotentialUnit Megavolt = new(PreFix.mega, Volt);

    [Synonyms("gigavolt", "gigavolts", "GV")]
    public static readonly ElectricPotentialUnit Gigavolt = new(PreFix.giga, Volt);

    [Synonyms("microvolt", "microvolts", "µV", "uV")]
    public static readonly ElectricPotentialUnit Microvolt = new(PreFix.micro, Volt);

    [Synonyms("millivolt", "millivolts", "mV")]
    public static readonly ElectricPotentialUnit Millivolt = new(PreFix.milli, Volt);

    public ElectricPotentialUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
    {
        Unit = new UnitSystem(mass * Length.Pow(2) / (duration.Pow(3) * electricCurrent), NewSymbol);
    }

    public ElectricPotentialUnit(PreFix SI, ElectricPotentialUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}