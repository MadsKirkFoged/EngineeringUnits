using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class CapacitanceUnit : Enumeration
    {

        public static readonly CapacitanceUnit SI = new(DurationUnit.SI, ElectricCurrentUnit.SI, LengthUnit.SI, MassUnit.SI, "F");
        public static readonly CapacitanceUnit Farad = new(DurationUnit.Second, ElectricCurrentUnit.Ampere, LengthUnit.Meter, MassUnit.Kilogram, "F");
        public static readonly CapacitanceUnit Kilofarad = new(PreFix.kilo, Farad);
        public static readonly CapacitanceUnit Megafarad = new(PreFix.mega, Farad);
        public static readonly CapacitanceUnit Microfarad = new(PreFix.micro, Farad);
        public static readonly CapacitanceUnit Millifarad = new(PreFix.milli, Farad);
        public static readonly CapacitanceUnit Nanofarad = new(PreFix.nano, Farad);
        public static readonly CapacitanceUnit Picofarad = new(PreFix.pico, Farad);




        public CapacitanceUnit(DurationUnit duration, ElectricCurrentUnit electricCurrent, LengthUnit Length, MassUnit Mass, string NewSymbol = "Empty")
        {

            //s4⋅A2⋅m−2⋅kg−1

            Unit = (duration.Pow(4) * electricCurrent.Pow(2)) / (Length.Pow(2) * Mass.Unit);
            SetNewSymbol(NewSymbol);
        }

      

        public CapacitanceUnit(PreFix SI, CapacitanceUnit unit) : base(SI, unit)
        {
        }

       

    }




}