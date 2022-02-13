using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricConductanceUnit : Enumeration
    {

        public static readonly ElectricConductanceUnit SI = new(LengthUnit.SI);
        public static readonly ElectricConductanceUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly ElectricConductanceUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly ElectricConductanceUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public ElectricConductanceUnit(LengthUnit Length)
        {
            Unit = Length.Pow(3);
        }


        public ElectricConductanceUnit(PreFix SI, ElectricConductanceUnit unit) : base(SI, unit) {}


    }




}