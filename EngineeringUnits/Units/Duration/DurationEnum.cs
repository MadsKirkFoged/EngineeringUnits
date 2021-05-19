using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum DurationUnit
    {
        [Vector( "ns", 1e-9d)] Nanosecond,
        [Vector("μs", 1e-6d)] Microsecond,
        [Vector("ms", 1e-3d)] Millisecond,
        [Vector("s", 1)] Second,
        [Vector("min", 60)] Minute,
        [Vector("h", 3600)] Hour,
        [Vector("d", 24 * 3600)] Day,
        [Vector("w", 7 * 24 * 3600)] Week,

    }



    

}