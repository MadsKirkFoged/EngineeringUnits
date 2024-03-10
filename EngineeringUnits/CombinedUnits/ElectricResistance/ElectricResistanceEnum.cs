﻿namespace EngineeringUnits.Units;

public partial record ElectricResistanceUnit : UnitTypebase
{

    public static readonly ElectricResistanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "Ω");
    public static readonly ElectricResistanceUnit Ohm = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "Ω");
    public static readonly ElectricResistanceUnit Gigaohm = new(PreFix.giga, Ohm);
    public static readonly ElectricResistanceUnit Kiloohm = new(PreFix.kilo, Ohm);
    public static readonly ElectricResistanceUnit Megaohm = new(PreFix.mega, Ohm);
    public static readonly ElectricResistanceUnit Microohm = new(PreFix.micro, Ohm);
    public static readonly ElectricResistanceUnit Milliohm = new(PreFix.milli, Ohm);

    public ElectricResistanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
    {
        Unit = new UnitSystem(mass * Length.Pow(2) / (duration.Pow(3) * electricCurrent.Pow(2)), NewSymbol);
    }

    public ElectricResistanceUnit(PreFix SI, ElectricResistanceUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}