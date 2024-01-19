using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record SpeedUnit : UnitTypebase
    {

       public static readonly SpeedUnit CentimeterPerHour =     new(LengthUnit.Centimeter,    DurationUnit.Hour);
       public static readonly SpeedUnit CentimeterPerMinute =   new(LengthUnit.Centimeter,    DurationUnit.Minute);
       public static readonly SpeedUnit CentimeterPerSecond =   new(LengthUnit.Centimeter,    DurationUnit.Second);
       public static readonly SpeedUnit DecimeterPerMinute =    new(LengthUnit.Decimeter,     DurationUnit.Minute);
       public static readonly SpeedUnit DecimeterPerSecond =    new(LengthUnit.Decimeter,     DurationUnit.Second);
       public static readonly SpeedUnit FootPerHour =           new(LengthUnit.Foot,          DurationUnit.Hour);
       public static readonly SpeedUnit FootPerMinute =         new(LengthUnit.Foot,          DurationUnit.Minute);
       public static readonly SpeedUnit FootPerSecond =         new(LengthUnit.Foot,          DurationUnit.Second);
       public static readonly SpeedUnit InchPerHour =           new(LengthUnit.Inch,          DurationUnit.Hour);
       public static readonly SpeedUnit InchPerMinute =         new(LengthUnit.Inch,          DurationUnit.Minute);
       public static readonly SpeedUnit InchPerSecond =         new(LengthUnit.Inch,          DurationUnit.Second);
       public static readonly SpeedUnit KilometerPerHour =      new(LengthUnit.Kilometer,     DurationUnit.Hour);
       public static readonly SpeedUnit KilometerPerMinute =    new(LengthUnit.Kilometer,     DurationUnit.Minute);
       public static readonly SpeedUnit KilometerPerSecond =    new(LengthUnit.Kilometer,     DurationUnit.Second);
       public static readonly SpeedUnit Knot =                  new(LengthUnit.NauticalMile,  DurationUnit.Hour, "kn");
       public static readonly SpeedUnit MeterPerHour =          new(LengthUnit.Meter,         DurationUnit.Hour);
       public static readonly SpeedUnit MeterPerMinute =        new(LengthUnit.Meter,         DurationUnit.Minute);
       public static readonly SpeedUnit MeterPerSecond =        new(LengthUnit.Meter,         DurationUnit.Second);
       public static readonly SpeedUnit MicrometerPerMinute =   new(LengthUnit.Micrometer,    DurationUnit.Minute);
       public static readonly SpeedUnit MicrometerPerSecond =   new(LengthUnit.Micrometer,    DurationUnit.Second);
       public static readonly SpeedUnit MilePerHour =           new(LengthUnit.Mile,          DurationUnit.Hour, "mph");
       public static readonly SpeedUnit MillimeterPerHour =     new(LengthUnit.Millimeter,    DurationUnit.Hour);
       public static readonly SpeedUnit MillimeterPerMinute =   new(LengthUnit.Millimeter,    DurationUnit.Minute);
       public static readonly SpeedUnit MillimeterPerSecond =   new(LengthUnit.Millimeter,    DurationUnit.Second);
       public static readonly SpeedUnit NanometerPerMinute =    new(LengthUnit.Nanometer,     DurationUnit.Minute);
       public static readonly SpeedUnit NanometerPerSecond =    new(LengthUnit.Nanometer,     DurationUnit.Second);
       public static readonly SpeedUnit UsSurveyFootPerHour =   new(LengthUnit.UsSurveyFoot,  DurationUnit.Hour);
       public static readonly SpeedUnit UsSurveyFootPerMinute = new(LengthUnit.UsSurveyFoot,  DurationUnit.Minute);
       public static readonly SpeedUnit UsSurveyFootPerSecond = new(LengthUnit.UsSurveyFoot,  DurationUnit.Second);
       public static readonly SpeedUnit YardPerHour =           new(LengthUnit.Yard,          DurationUnit.Hour);
       public static readonly SpeedUnit YardPerMinute =         new(LengthUnit.Yard,          DurationUnit.Minute);
       public static readonly SpeedUnit YardPerSecond =         new(LengthUnit.Yard,          DurationUnit.Second);
       public static readonly SpeedUnit KilometerPerhour =      new(LengthUnit.Kilometer,     DurationUnit.Hour);
       public static readonly SpeedUnit SI =                    new(LengthUnit.SI,            DurationUnit.SI);
       public static readonly SpeedUnit MilePerSecond =         new(LengthUnit.Mile,          DurationUnit.Second);



        public SpeedUnit(LengthUnit length, DurationUnit time)
        {
            Unit = length / time;
        }

        public SpeedUnit(LengthUnit length, DurationUnit time, string NewSymbol)
        {
            Unit = new UnitSystem(length / time, NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }
}