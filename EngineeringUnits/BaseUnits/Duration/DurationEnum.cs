using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class DurationUnit : Enumeration
    {


        public static readonly DurationUnit Nanosecond =     new DurationUnit(PreFix.nano, BaseUnits.time);
        public static readonly DurationUnit Millisecond =    new DurationUnit(PreFix.milli, BaseUnits.time);
        public static readonly DurationUnit Microsecond =    new DurationUnit(PreFix.micro, BaseUnits.time);
        public static readonly DurationUnit Second =         new DurationUnit(PreFix.SI, BaseUnits.time);
        public static readonly DurationUnit SI =             new DurationUnit(PreFix.SI, BaseUnits.time);

        public static readonly DurationUnit Minute =         new DurationUnit("m", 1, 60m);
        public static readonly DurationUnit Hour =           new DurationUnit("h", 1, 3600m);
        public static readonly DurationUnit Day =            new DurationUnit("d", 1, (24*3600m));
        public static readonly DurationUnit Week =           new DurationUnit("wk", 1, (7*24*3600m));
        public static readonly DurationUnit Month30 =        new DurationUnit("mo", 1, (30 * 24 * 3600m));
        public static readonly DurationUnit Year365 =        new DurationUnit("yr", 1, (365*24*3600m));



        public DurationUnit() { }


        public DurationUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Duration = (DurationUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public DurationUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Duration = (DurationUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }      

    }



}