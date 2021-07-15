using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class CapacitanceUnit : Enumeration
    {

        public static readonly CapacitanceUnit SI = new CapacitanceUnit(DurationUnit.Second, ElectricCurrentUnit.Ampere, LengthUnit.Meter, MassUnit.Kilogram, "F");
        public static readonly CapacitanceUnit Farad = new CapacitanceUnit(DurationUnit.Second, ElectricCurrentUnit.Ampere, LengthUnit.Meter, MassUnit.Kilogram, "F");
        public static readonly CapacitanceUnit Kilofarad = new CapacitanceUnit(PreFix.kilo, Farad);
        public static readonly CapacitanceUnit Megafarad = new CapacitanceUnit(PreFix.mega, Farad);
        public static readonly CapacitanceUnit Microfarad = new CapacitanceUnit(PreFix.micro, Farad);
        public static readonly CapacitanceUnit Millifarad = new CapacitanceUnit(PreFix.milli, Farad);
        public static readonly CapacitanceUnit Nanofarad = new CapacitanceUnit(PreFix.nano, Farad);
        public static readonly CapacitanceUnit Picofarad = new CapacitanceUnit(PreFix.pico, Farad);




        public CapacitanceUnit(DurationUnit duration, ElectricCurrentUnit electricCurrent, LengthUnit Length, MassUnit Mass, string NewSymbol = "Empty", decimal correction = 1)
        {

            //s4⋅A2⋅m−2⋅kg−1

            Unit = (duration.Pow(4) * electricCurrent.Pow(2)) / (Length.Pow(2) * Mass.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

      

        public CapacitanceUnit(PreFix SI, CapacitanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

       

    }




}