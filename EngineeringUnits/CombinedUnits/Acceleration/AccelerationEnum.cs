using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AccelerationUnit : Enumeration
    {

        public static readonly AccelerationUnit SI =                         new(LengthUnit.SI, DurationUnit.SI);
        public static readonly AccelerationUnit KilometerPerSecondSquared =  new(LengthUnit.Kilometer, DurationUnit.Second);
        public static readonly AccelerationUnit MeterPerSecondSquared =      new(LengthUnit.SI, DurationUnit.SI);
        public static readonly AccelerationUnit DecimeterPerSecondSquared =  new(LengthUnit.Decimeter, DurationUnit.Second);
        public static readonly AccelerationUnit CentimeterPerSecondSquared = new(LengthUnit.Centimeter, DurationUnit.Second);
        public static readonly AccelerationUnit MicrometerPerSecondSquared = new(LengthUnit.Micrometer, DurationUnit.Second);
        public static readonly AccelerationUnit MillimeterPerSecondSquared = new(LengthUnit.Millimeter, DurationUnit.Second);
        public static readonly AccelerationUnit NanometerPerSecondSquared =  new(LengthUnit.Nanometer, DurationUnit.Second);
        public static readonly AccelerationUnit InchPerSecondSquared = new(LengthUnit.Inch, DurationUnit.Second);
        public static readonly AccelerationUnit FootPerSecondSquared = new(LengthUnit.Foot, DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerSecond =  new(SpeedUnit.Knot, DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerMinute =  new(SpeedUnit.Knot, DurationUnit.Minute);
        public static readonly AccelerationUnit KnotPerHour =    new(SpeedUnit.Knot, DurationUnit.Hour);
        public static readonly AccelerationUnit StandardGravity = new(LengthUnit.SI, DurationUnit.SI, "g", 9.80665m);
        public static readonly AccelerationUnit MillistandardGravity = new(PreFix.milli, StandardGravity);






        private AccelerationUnit(LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = length / duration.Pow(2) * correction;
            SetNewSymbol(NewSymbol);
        }

        private AccelerationUnit(SpeedUnit speed, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = speed / duration;
            SetNewSymbol(NewSymbol, $"{speed}/{duration}");         
        }

        private AccelerationUnit(PreFix SI, AccelerationUnit energyunit) :base(SI, energyunit)
        {
        }







    }




}