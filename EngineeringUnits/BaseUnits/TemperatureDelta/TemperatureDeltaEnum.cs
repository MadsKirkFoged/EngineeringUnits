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
    public class TemperatureDeltaUnit : Enumeration
    {


        public static readonly TemperatureUnit SI = new TemperatureUnit("K", 1, 1, 0);

        public TemperatureDeltaUnit() { }


    
     

    }


}