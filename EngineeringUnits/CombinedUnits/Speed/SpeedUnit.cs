using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class SpeedUnit : Enumeration
    {



        public static SpeedUnit MeterPerSecond = new SpeedUnit(LengthUnit.Meter, DurationUnit.Second);
        public static SpeedUnit MeterPerMinute = new SpeedUnit(LengthUnit.Meter, DurationUnit.Minute);
        public static SpeedUnit KilometerPerhour = new SpeedUnit(LengthUnit.Kilometer, DurationUnit.Hour);
        public static SpeedUnit SI = new SpeedUnit(LengthUnit.SI, DurationUnit.SI);


        public static SpeedUnit InchPerSecond = new SpeedUnit(LengthUnit.Inch, DurationUnit.Second);
        public static SpeedUnit YardPerSecond = new SpeedUnit(LengthUnit.Yard, DurationUnit.Second);
        public static SpeedUnit MilePerSecond = new SpeedUnit(LengthUnit.Mile, DurationUnit.Second);




        public SpeedUnit(LengthUnit length, DurationUnit time)
        {
            Name = "Speed";
            Unit = length.Unit / time.Unit;
        }



        protected SpeedUnit() { }




        //public static IEnumerable<LengthUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        //}
        // Other util methods




    }




}