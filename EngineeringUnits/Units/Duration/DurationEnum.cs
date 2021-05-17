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
        [Vector(1e-9d, "ns", 1)] Nanosecond,
        [Vector(1e-6d, "μs", 1)] Microsecond,
        [Vector(1e-3d, "ms",  1)] Millisecond,
        [Vector(1, "s", 1)] Second,
        [Vector(60, "min",  1)] Minute,
        [Vector(3600, "h", 1)] Hour,
        [Vector(24*3600, "d",  1)] Day,
        [Vector(7*24*3600, "w", 1)] Week,

    }



    

}