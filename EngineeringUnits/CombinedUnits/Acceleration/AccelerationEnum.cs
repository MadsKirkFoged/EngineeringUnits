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


        public AccelerationUnit(LengthUnit length, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Acceleration";


            Unit = length.Unit / (duration.Unit * duration.Unit);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }

        public AccelerationUnit(SpeedUnit speed, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Acceleration";


            Unit = speed.Unit / (duration.Unit);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }
            else
            {
                Unit.Symbol = $"{speed}/{duration}";
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }

        public AccelerationUnit(PreFix SI, AccelerationUnit energyunit)
        {
            Unit = energyunit.Unit.Copy();


            if (Unit.Combined is null)
                Unit.Combined = new CombinedUnit("", 1, PrefixSISize(SI));
            else
                Unit.Combined.GlobalC *= PrefixSISize(SI);




            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
        }



        public static IEnumerable<AccelerationUnit> List()
        {
            return new[] { CentimeterPerSecondSquared, DecimeterPerSecondSquared, FootPerSecondSquared, InchPerSecondSquared, KilometerPerSecondSquared, KnotPerHour, KnotPerMinute, KnotPerSecond, MeterPerSecondSquared, MicrometerPerSecondSquared, MillimeterPerSecondSquared, MillistandardGravity, NanometerPerSecondSquared, StandardGravity, };
        }





    }




}