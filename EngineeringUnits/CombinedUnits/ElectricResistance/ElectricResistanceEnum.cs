using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
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
            Unit = (mass * Length.Pow(2)) / (duration.Pow(3) * electricCurrent.Pow(2));
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