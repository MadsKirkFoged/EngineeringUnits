using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricResistanceUnit : Enumeration
    {

        public static readonly ElectricResistanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ElectricResistanceUnit Ohm = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "Ω");
        public static readonly ElectricResistanceUnit Gigaohm = new(PreFix.giga, Ohm);
        public static readonly ElectricResistanceUnit Kiloohm = new(PreFix.kilo, Ohm);
        public static readonly ElectricResistanceUnit Megaohm = new(PreFix.mega, Ohm);
        public static readonly ElectricResistanceUnit Microohm = new(PreFix.micro, Ohm);
        public static readonly ElectricResistanceUnit Milliohm = new(PreFix.milli, Ohm);




        public ElectricResistanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty")
        {
            //kg⋅m2⋅s−3⋅A−2
            Unit = (mass * Length.Pow(2)) / (duration.Pow(3) * electricCurrent.Pow(2));
            SetNewSymbol(NewSymbol);
        }

       

        public ElectricResistanceUnit(PreFix SI, ElectricResistanceUnit unit) : base(SI, unit)
        {
        }



    }




}