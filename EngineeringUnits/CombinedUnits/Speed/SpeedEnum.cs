using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class SpeedUnit : Enumeration
    {

        public static SpeedUnit CentimeterPerHour =     new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Hour);
        public static SpeedUnit CentimeterPerMinute =   new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Minute);
        public static SpeedUnit CentimeterPerSecond =   new SpeedUnit(LengthUnit.Centimeter,    DurationUnit.Second);
        public static SpeedUnit DecimeterPerMinute =    new SpeedUnit(LengthUnit.Decimeter,     DurationUnit.Minute);
        public static SpeedUnit DecimeterPerSecond =    new SpeedUnit(LengthUnit.Decimeter,     DurationUnit.Second);
        public static SpeedUnit FootPerHour =           new SpeedUnit(LengthUnit.Foot,          DurationUnit.Hour);
        public static SpeedUnit FootPerMinute =         new SpeedUnit(LengthUnit.Foot,          DurationUnit.Minute);
        public static SpeedUnit FootPerSecond =         new SpeedUnit(LengthUnit.Foot,          DurationUnit.Second);
        public static SpeedUnit InchPerHour =           new SpeedUnit(LengthUnit.Inch,          DurationUnit.Hour);
        public static SpeedUnit InchPerMinute =         new SpeedUnit(LengthUnit.Inch,          DurationUnit.Minute);
        public static SpeedUnit InchPerSecond =         new SpeedUnit(LengthUnit.Inch,          DurationUnit.Second);
        public static SpeedUnit KilometerPerHour =      new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Hour);
        public static SpeedUnit KilometerPerMinute =    new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Minute);
        public static SpeedUnit KilometerPerSecond =    new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Second);
        public static SpeedUnit Knot =                  new SpeedUnit(LengthUnit.NauticalMile,  DurationUnit.Hour, "kn");
        public static SpeedUnit MeterPerHour =          new SpeedUnit(LengthUnit.Meter,         DurationUnit.Hour);
        public static SpeedUnit MeterPerMinute =        new SpeedUnit(LengthUnit.Meter,         DurationUnit.Minute);
        public static SpeedUnit MeterPerSecond =        new SpeedUnit(LengthUnit.Meter,         DurationUnit.Second);
        public static SpeedUnit MicrometerPerMinute =   new SpeedUnit(LengthUnit.Micrometer,    DurationUnit.Minute);
        public static SpeedUnit MicrometerPerSecond =   new SpeedUnit(LengthUnit.Micrometer,    DurationUnit.Second);
        public static SpeedUnit MilePerHour =           new SpeedUnit(LengthUnit.Mile,          DurationUnit.Hour, "mph");
        public static SpeedUnit MillimeterPerHour =     new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Hour);
        public static SpeedUnit MillimeterPerMinute =   new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Minute);
        public static SpeedUnit MillimeterPerSecond =   new SpeedUnit(LengthUnit.Millimeter,    DurationUnit.Second);
        public static SpeedUnit NanometerPerMinute =    new SpeedUnit(LengthUnit.Nanometer,     DurationUnit.Minute);
        public static SpeedUnit NanometerPerSecond =    new SpeedUnit(LengthUnit.Nanometer,     DurationUnit.Second);

        public static SpeedUnit UsSurveyFootPerHour =   new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Hour);
        public static SpeedUnit UsSurveyFootPerMinute = new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Minute);
        public static SpeedUnit UsSurveyFootPerSecond = new SpeedUnit(LengthUnit.UsSurveyFoot,  DurationUnit.Second);

        public static SpeedUnit YardPerHour =           new SpeedUnit(LengthUnit.Yard,          DurationUnit.Hour);
        public static SpeedUnit YardPerMinute =         new SpeedUnit(LengthUnit.Yard,          DurationUnit.Minute);
        public static SpeedUnit YardPerSecond =         new SpeedUnit(LengthUnit.Yard,          DurationUnit.Second);

        public static SpeedUnit KilometerPerhour =      new SpeedUnit(LengthUnit.Kilometer,     DurationUnit.Hour);
        public static SpeedUnit SI =                    new SpeedUnit(LengthUnit.SI,            DurationUnit.SI);

        public static SpeedUnit MilePerSecond =         new SpeedUnit(LengthUnit.Mile,          DurationUnit.Second);



        public SpeedUnit(LengthUnit length, DurationUnit time, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = length.Unit / time.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{length}/{time}");
        }

    }
}