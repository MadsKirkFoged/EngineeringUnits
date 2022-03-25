using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class DurationUnit : UnitEnumbase
    {


        public static readonly DurationUnit Nanosecond =    new(PreFix.nano);
        public static readonly DurationUnit Millisecond =   new(PreFix.milli);
        public static readonly DurationUnit Microsecond =   new(PreFix.micro);
        public static readonly DurationUnit Second =        new(PreFix.SI);

        public static readonly DurationUnit Minute =        new("min", 60m);
        public static readonly DurationUnit Hour =          new("h", 3600m);
        public static readonly DurationUnit Day =           new("day", 24*3600m);
        public static readonly DurationUnit Week =          new("wk", 7*24*3600m);
        public static readonly DurationUnit Month30 =       new("mo", 30 * 24 * 3600m);
        public static readonly DurationUnit Year365 =       new("yr", 365*24*3600m);
        public static readonly DurationUnit SI =            new(PreFix.SI);

        public DurationUnit() { }


        public DurationUnit(string symbol, decimal Constant) : base(symbol, new Fraction(Constant), BaseunitType.time)
        {
            Unit = new UnitSystem(this);
        }


        public DurationUnit(PreFix SI) : base(SI, BaseunitType.time)
        {
            Unit = new UnitSystem(this);
        }      

    }



}