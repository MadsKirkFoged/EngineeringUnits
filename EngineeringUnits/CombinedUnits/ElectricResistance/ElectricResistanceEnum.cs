using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricResistanceUnit : Enumeration
    {

        public static readonly ElectricResistanceUnit SI = new ElectricResistanceUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere);
        public static readonly ElectricResistanceUnit Ohm = new ElectricResistanceUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "Ω");
        public static readonly ElectricResistanceUnit Gigaohm = new ElectricResistanceUnit(PreFix.giga, Ohm);
        public static readonly ElectricResistanceUnit Kiloohm = new ElectricResistanceUnit(PreFix.kilo, Ohm);
        public static readonly ElectricResistanceUnit Megaohm = new ElectricResistanceUnit(PreFix.mega, Ohm);
        public static readonly ElectricResistanceUnit Microohm = new ElectricResistanceUnit(PreFix.micro, Ohm);
        public static readonly ElectricResistanceUnit Milliohm = new ElectricResistanceUnit(PreFix.milli, Ohm);




        public ElectricResistanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            //kg⋅m2⋅s−3⋅A−2
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit * duration.Unit * electricCurrent.Unit * electricCurrent.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

       

        public ElectricResistanceUnit(PreFix SI, ElectricResistanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }



    }




}