using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AccelerationUnit : Enumeration
    {

        public static readonly AccelerationUnit SI =                         new AccelerationUnit(LengthUnit.SI, DurationUnit.SI);
        public static readonly AccelerationUnit KilometerPerSecondSquared =  new AccelerationUnit(LengthUnit.Kilometer, DurationUnit.Second);
        public static readonly AccelerationUnit MeterPerSecondSquared =      new AccelerationUnit(LengthUnit.SI, DurationUnit.SI);
        public static readonly AccelerationUnit DecimeterPerSecondSquared =  new AccelerationUnit(LengthUnit.Decimeter, DurationUnit.Second);
        public static readonly AccelerationUnit CentimeterPerSecondSquared = new AccelerationUnit(LengthUnit.Centimeter, DurationUnit.Second);
        public static readonly AccelerationUnit MicrometerPerSecondSquared = new AccelerationUnit(LengthUnit.Micrometer, DurationUnit.Second);
        public static readonly AccelerationUnit MillimeterPerSecondSquared = new AccelerationUnit(LengthUnit.Millimeter, DurationUnit.Second);
        public static readonly AccelerationUnit NanometerPerSecondSquared =  new AccelerationUnit(LengthUnit.Nanometer, DurationUnit.Second);
        public static readonly AccelerationUnit InchPerSecondSquared = new AccelerationUnit(LengthUnit.Inch, DurationUnit.Second);
        public static readonly AccelerationUnit FootPerSecondSquared = new AccelerationUnit(LengthUnit.Foot, DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerSecond =  new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerMinute =  new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Minute);
        public static readonly AccelerationUnit KnotPerHour =    new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Hour);
        public static readonly AccelerationUnit StandardGravity = new AccelerationUnit(LengthUnit.SI, DurationUnit.SI, "g", 9.80665m);
        public static readonly AccelerationUnit MillistandardGravity = new AccelerationUnit(PreFix.milli, StandardGravity);






        private AccelerationUnit(LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            //Unit = length.Unit / (duration.Unit * duration.Unit);
            Unit = length / (duration.Pow(2));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        private AccelerationUnit(SpeedUnit speed, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = speed.Unit / (duration.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{speed}/{duration}");         
        }

        private AccelerationUnit(PreFix SI, AccelerationUnit energyunit)
        {
            Unit = energyunit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);

        }







    }




}