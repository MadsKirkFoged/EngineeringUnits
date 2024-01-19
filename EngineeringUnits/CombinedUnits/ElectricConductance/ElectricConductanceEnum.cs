using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ElectricConductanceUnit : UnitTypebase
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

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}