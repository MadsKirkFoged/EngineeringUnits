using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AccelerationUnit : Enumeration
    {

        public static AccelerationUnit SI = new AccelerationUnit(LengthUnit.SI, DurationUnit.SI);
        public static AccelerationUnit KilometerPerSecondSquared = new AccelerationUnit(LengthUnit.Kilometer, DurationUnit.Second);
        public static AccelerationUnit MeterPerSecondSquared = new AccelerationUnit(LengthUnit.SI, DurationUnit.SI);
        public static AccelerationUnit DecimeterPerSecondSquared = new AccelerationUnit(LengthUnit.Decimeter, DurationUnit.Second);
        public static AccelerationUnit CentimeterPerSecondSquared = new AccelerationUnit(LengthUnit.Centimeter, DurationUnit.Second);
        public static AccelerationUnit MicrometerPerSecondSquared = new AccelerationUnit(LengthUnit.Micrometer, DurationUnit.Second);
        public static AccelerationUnit MillimeterPerSecondSquared = new AccelerationUnit(LengthUnit.Millimeter, DurationUnit.Second);
        public static AccelerationUnit NanometerPerSecondSquared = new AccelerationUnit(LengthUnit.Nanometer, DurationUnit.Second);

        public static AccelerationUnit InchPerSecondSquared = new AccelerationUnit(LengthUnit.Inch, DurationUnit.Second);
        public static AccelerationUnit FootPerSecondSquared = new AccelerationUnit(LengthUnit.Foot, DurationUnit.Second);

        public static AccelerationUnit KnotPerSecond = new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Second);
        public static AccelerationUnit KnotPerMinute = new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Minute);
        public static AccelerationUnit KnotPerHour = new AccelerationUnit(SpeedUnit.Knot, DurationUnit.Hour);

        public static AccelerationUnit StandardGravity = new AccelerationUnit(LengthUnit.SI, DurationUnit.SI, "g", 9.80665m);
        public static AccelerationUnit MillistandardGravity = new AccelerationUnit(PreFix.milli, StandardGravity);






        private AccelerationUnit(LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "Acceleration";


            Unit = length.Unit / (duration.Unit * duration.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        private AccelerationUnit(SpeedUnit speed, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            //Name = "Acceleration";
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



        public static IEnumerable<AccelerationUnit> List()
        {
            return new[] { CentimeterPerSecondSquared, DecimeterPerSecondSquared, FootPerSecondSquared, InchPerSecondSquared, KilometerPerSecondSquared, KnotPerHour, KnotPerMinute, KnotPerSecond, MeterPerSecondSquared, MicrometerPerSecondSquared, MillimeterPerSecondSquared, MillistandardGravity, NanometerPerSecondSquared, StandardGravity, };
        }





    }




}