using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{


    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public record TemperatureDeltaUnit : UnitTypebase
    {


        public static readonly TemperatureUnit SI = new("K", 1m, 1m, 0m);

        public TemperatureDeltaUnit() { }


    
     

    }


}