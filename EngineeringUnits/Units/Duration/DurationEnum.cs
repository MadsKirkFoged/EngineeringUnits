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


        public static DurationUnit Nanosecond = new DurationUnit("ns",1, 1e+9m);
        public static DurationUnit Microsecond = new DurationUnit("ns",1, 1e+6m);
        public static DurationUnit Millisecond = new DurationUnit("ns", 1, 1e+3m);
        public static DurationUnit Second = new DurationUnit("ns", 1, 1m);
        public static DurationUnit Minute = new DurationUnit("ns", 1, 1 /60m);
        public static DurationUnit Hour = new DurationUnit("ns", 1, 1 /3600m);
        public static DurationUnit Day = new DurationUnit("ns", 1, 1 /(24*3600m));
        public static DurationUnit Week = new DurationUnit("ns", 1, 1 /(7*24*3600m));




        protected DurationUnit() { }


        public DurationUnit(string symbol, decimal a1, decimal a2)
    : base(symbol, a1, a2)
        {
        }

        public DurationUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<DurationUnit> List()
        {
            return new[] { Nanosecond , Microsecond , Millisecond , Second , Minute , Hour , Day , Week };
        }
        // Other util methods
    }



}