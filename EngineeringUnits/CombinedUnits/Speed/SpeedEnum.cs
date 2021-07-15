using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class SpeedUnit : Enumeration
    {

       public static readonly SpeedUnit CentimeterPerHour =     new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Hour);
       public static readonly SpeedUnit CentimeterPerMinute =   new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Minute);
       public static readonly SpeedUnit CentimeterPerSecond =   new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Second);
       public static readonly SpeedUnit DecimeterPerMinute =    new SpeedUnit(LengthUnit.Decimeter,     DurationUnit.Minute);
       public static readonly SpeedUnit DecimeterPerSecond =    new SpeedUnit(LengthUnit.Decimeter,     DurationUnit.Second);
       public static readonly SpeedUnit FootPerHour =           new SpeedUnit(LengthUnit.Foot,          DurationUnit.Hour);
       public static readonly SpeedUnit FootPerMinute =         new SpeedUnit(LengthUnit.Foot,          DurationUnit.Minute);
       public static readonly SpeedUnit FootPerSecond =         new SpeedUnit(LengthUnit.Foot,          DurationUnit.Second);
       public static readonly SpeedUnit InchPerHour =           new SpeedUnit(LengthUnit.Inch,          DurationUnit.Hour);
       public static readonly SpeedUnit InchPerMinute =         new SpeedUnit(LengthUnit.Inch,          DurationUnit.Minute);
       public static readonly SpeedUnit InchPerSecond =         new SpeedUnit(LengthUnit.Inch,          DurationUnit.Second);
       public static readonly SpeedUnit KilometerPerHour =      new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Hour);
       public static readonly SpeedUnit KilometerPerMinute =    new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Minute);
       public static readonly SpeedUnit KilometerPerSecond =    new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Second);
       public static readonly SpeedUnit Knot =                  new SpeedUnit(LengthUnit.NauticalMile,  DurationUnit.Hour, "kn");
       public static readonly SpeedUnit MeterPerHour =          new SpeedUnit(LengthUnit.Meter,         DurationUnit.Hour);
       public static readonly SpeedUnit MeterPerMinute =        new SpeedUnit(LengthUnit.Meter,         DurationUnit.Minute);
       public static readonly SpeedUnit MeterPerSecond =        new SpeedUnit(LengthUnit.Meter,         DurationUnit.Second);
       public static readonly SpeedUnit MicrometerPerMinute =   new SpeedUnit(LengthUnit.Micrometer,    DurationUnit.Minute);
       public static readonly SpeedUnit MicrometerPerSecond =   new SpeedUnit(LengthUnit.Micrometer,    DurationUnit.Second);
       public static readonly SpeedUnit MilePerHour =           new SpeedUnit(LengthUnit.Mile,          DurationUnit.Hour, "mph");
       public static readonly SpeedUnit MillimeterPerHour =     new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Hour);
       public static readonly SpeedUnit MillimeterPerMinute =   new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Minute);
       public static readonly SpeedUnit MillimeterPerSecond =   new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Second);
       public static readonly SpeedUnit NanometerPerMinute =    new SpeedUnit(LengthUnit.Nanometer,     DurationUnit.Minute);
       public static readonly SpeedUnit NanometerPerSecond =    new SpeedUnit(LengthUnit.Nanometer,     DurationUnit.Second);
       public static readonly SpeedUnit UsSurveyFootPerHour =   new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Hour);
       public static readonly SpeedUnit UsSurveyFootPerMinute = new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Minute);
       public static readonly SpeedUnit UsSurveyFootPerSecond = new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Second);
       public static readonly SpeedUnit YardPerHour =           new SpeedUnit(LengthUnit.Yard,          DurationUnit.Hour);
       public static readonly SpeedUnit YardPerMinute =         new SpeedUnit(LengthUnit.Yard,          DurationUnit.Minute);
       public static readonly SpeedUnit YardPerSecond =         new SpeedUnit(LengthUnit.Yard,          DurationUnit.Second);
       public static readonly SpeedUnit KilometerPerhour =      new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Hour);
       public static readonly SpeedUnit SI =                    new SpeedUnit(LengthUnit.SI,            DurationUnit.SI);
        public static readonly SpeedUnit MilePerSecond =         new SpeedUnit(LengthUnit.Mile,          DurationUnit.Second);



        public SpeedUnit(LengthUnit length, DurationUnit time, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = length / time;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{length}/{time}");
        }

    }
}