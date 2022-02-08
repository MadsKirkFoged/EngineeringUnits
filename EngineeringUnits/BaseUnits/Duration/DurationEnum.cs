using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class DurationUnit : Enumeration
    {


        public static readonly DurationUnit Nanosecond =    new(PreFix.nano, BaseUnits.time);
        public static readonly DurationUnit Millisecond =   new(PreFix.milli, BaseUnits.time);
        public static readonly DurationUnit Microsecond =   new(PreFix.micro, BaseUnits.time);
        public static readonly DurationUnit Second =        new(PreFix.SI, BaseUnits.time);

        public static readonly DurationUnit Minute =        new("m", 60m);
        public static readonly DurationUnit Hour =          new("h", 3600m);
        public static readonly DurationUnit Day =           new("d", 24*3600m);
        public static readonly DurationUnit Week =          new("wk", 7*24*3600m);
        public static readonly DurationUnit Month30 =       new("mo", 30 * 24 * 3600m);
        public static readonly DurationUnit Year365 =       new("yr", 365*24*3600m);
        public static readonly DurationUnit SI =            new(PreFix.SI, BaseUnits.time);

        public DurationUnit() { }


        public DurationUnit(string symbol, decimal Constant) : base(symbol, Constant)
        {
            Unit = new UnitSystem();
            //Unit.Duration = (DurationUnit)Clone();

            Unit.ListOfUnits.Add(this);
        }


        public DurationUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            //Unit.Duration = (DurationUnit)Clone();

            Unit.ListOfUnits.Add(this);
        }      

    }



}