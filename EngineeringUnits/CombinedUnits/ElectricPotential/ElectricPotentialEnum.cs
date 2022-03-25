using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricPotentialUnit : UnitEnumbase
    {

        public static readonly ElectricPotentialUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "V");
        public static readonly ElectricPotentialUnit Volt = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere , "V");
        public static readonly ElectricPotentialUnit Kilovolt = new(PreFix.kilo, Volt);
        public static readonly ElectricPotentialUnit Megavolt = new(PreFix.mega, Volt);
        public static readonly ElectricPotentialUnit Gigavolt = new(PreFix.giga, Volt);
        public static readonly ElectricPotentialUnit Microvolt = new(PreFix.micro, Volt);
        public static readonly ElectricPotentialUnit Millivolt = new(PreFix.milli, Volt);

        public ElectricPotentialUnit(MassUnit mass, LengthUnit Length,DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
        {
            Unit = new UnitSystem((mass * Length.Pow(2)) / (duration.Pow(3) * electricCurrent), NewSymbol);
        }

        public ElectricPotentialUnit(PreFix SI, ElectricPotentialUnit unit) : base(SI, unit) {}



    }




}