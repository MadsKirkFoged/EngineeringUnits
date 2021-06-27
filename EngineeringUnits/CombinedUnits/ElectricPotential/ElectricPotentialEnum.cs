using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricPotentialUnit : Enumeration
    {

        public static ElectricPotentialUnit SI = new ElectricPotentialUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "V");
        public static ElectricPotentialUnit Volt = new ElectricPotentialUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere , "V");

        public static ElectricPotentialUnit Kilovolt = new ElectricPotentialUnit(PreFix.kilo, Volt);
        public static ElectricPotentialUnit Megavolt = new ElectricPotentialUnit(PreFix.mega, Volt);
        public static ElectricPotentialUnit Microvolt = new ElectricPotentialUnit(PreFix.micro, Volt);
        public static ElectricPotentialUnit Millivolt = new ElectricPotentialUnit(PreFix.milli, Volt);




        public ElectricPotentialUnit(MassUnit mass, LengthUnit Length,DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ElectricPotential";

            //kg·m2·s−3·A−1
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit * duration.Unit * electricCurrent.Unit);

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }


        public ElectricPotentialUnit(PreFix SI, ElectricPotentialUnit unit)
        {
            //Name = "ElectricPotentialh";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }




        public static IEnumerable<ElectricPotentialUnit> List()
        {
            return new[] { Kilovolt, Megavolt, Microvolt, Millivolt, Volt, };
        }





    }




}