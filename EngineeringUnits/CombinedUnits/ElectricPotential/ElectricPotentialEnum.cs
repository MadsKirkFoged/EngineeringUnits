using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricPotentialUnit : Enumeration
    {

        public static readonly ElectricPotentialUnit SI = new ElectricPotentialUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "V");
        public static readonly ElectricPotentialUnit Volt = new ElectricPotentialUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere , "V");
        public static readonly ElectricPotentialUnit Kilovolt = new ElectricPotentialUnit(PreFix.kilo, Volt);
        public static readonly ElectricPotentialUnit Megavolt = new ElectricPotentialUnit(PreFix.mega, Volt);
        public static readonly ElectricPotentialUnit Gigavolt = new ElectricPotentialUnit(PreFix.giga, Volt);
        public static readonly ElectricPotentialUnit Microvolt = new ElectricPotentialUnit(PreFix.micro, Volt);
        public static readonly ElectricPotentialUnit Millivolt = new ElectricPotentialUnit(PreFix.milli, Volt);




        public ElectricPotentialUnit(MassUnit mass, LengthUnit Length,DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (mass * Length.Pow(2)) / (duration.Pow(3) * electricCurrent);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }


        public ElectricPotentialUnit(PreFix SI, ElectricPotentialUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }



    }




}