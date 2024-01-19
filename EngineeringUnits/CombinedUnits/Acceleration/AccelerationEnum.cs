using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record AccelerationUnit : UnitTypebase
    {

        public static readonly AccelerationUnit SI =                            new(LengthUnit.SI,          DurationUnit.SI);
        public static readonly AccelerationUnit KilometerPerSecondSquared =     new(LengthUnit.Kilometer,   DurationUnit.Second);
        public static readonly AccelerationUnit MeterPerSecondSquared =         new(LengthUnit.SI,          DurationUnit.SI);
        public static readonly AccelerationUnit DecimeterPerSecondSquared =     new(LengthUnit.Decimeter,   DurationUnit.Second);
        public static readonly AccelerationUnit CentimeterPerSecondSquared =    new(LengthUnit.Centimeter,  DurationUnit.Second);
        public static readonly AccelerationUnit MicrometerPerSecondSquared =    new(LengthUnit.Micrometer,  DurationUnit.Second);
        public static readonly AccelerationUnit MillimeterPerSecondSquared =    new(LengthUnit.Millimeter,  DurationUnit.Second);
        public static readonly AccelerationUnit NanometerPerSecondSquared =     new(LengthUnit.Nanometer,   DurationUnit.Second);
        public static readonly AccelerationUnit InchPerSecondSquared =          new(LengthUnit.Inch,        DurationUnit.Second);
        public static readonly AccelerationUnit FootPerSecondSquared =          new(LengthUnit.Foot,        DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerSecond =                 new(SpeedUnit.Knot,         DurationUnit.Second);
        public static readonly AccelerationUnit KnotPerMinute =                 new(SpeedUnit.Knot,         DurationUnit.Minute);
        public static readonly AccelerationUnit KnotPerHour =                   new(SpeedUnit.Knot,         DurationUnit.Hour);
        public static readonly AccelerationUnit StandardGravity =               new(AccelerationUnit.SI, "g", 9.80665m);
        public static readonly AccelerationUnit MillistandardGravity =          new(PreFix.milli, StandardGravity);


        public AccelerationUnit(LengthUnit length, DurationUnit duration)
        {
            Unit = length/duration.Pow(2);
        }


        public AccelerationUnit(SpeedUnit speed, DurationUnit duration)
        {
            Unit = new UnitSystem(speed/duration,
                                $"{speed}/{duration}");         
        }

        public AccelerationUnit(PreFix SI, AccelerationUnit unit) :base(SI, unit) {}
        public AccelerationUnit(AccelerationUnit unit, string NewSymbol, decimal correction) :base(unit, NewSymbol, correction) {}



        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }



    }




}