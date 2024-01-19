using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits.Units
{
    public partial record JerkUnit : UnitTypebase
    {
        public static readonly JerkUnit SI = new(LengthUnit.SI, DurationUnit.SI);
        public static readonly JerkUnit KilometerPerSecondCubed = new(LengthUnit.Kilometer, DurationUnit.Second);
        public static readonly JerkUnit MeterPerSecondCubed = new(LengthUnit.SI, DurationUnit.SI);
        public static readonly JerkUnit DecimeterPerSecondCubed = new(LengthUnit.Decimeter, DurationUnit.Second);
        public static readonly JerkUnit CentimeterPerSecondCubed = new(LengthUnit.Centimeter, DurationUnit.Second);
        public static readonly JerkUnit MicrometerPerSecondCubed = new(LengthUnit.Micrometer, DurationUnit.Second);
        public static readonly JerkUnit MillimeterPerSecondCubed = new(LengthUnit.Millimeter, DurationUnit.Second);
        public static readonly JerkUnit NanometerPerSecondCubed = new(LengthUnit.Nanometer, DurationUnit.Second);


        private JerkUnit(LengthUnit length, DurationUnit duration)
        {
            Unit = length/duration.Pow(3);
        }


        //private JerkUnit(SpeedUnit speed, DurationUnit duration)
        //{
        //    Unit = new UnitSystem(speed/duration,
        //                        $"{speed}/{duration}");
        //}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }



    }
}
