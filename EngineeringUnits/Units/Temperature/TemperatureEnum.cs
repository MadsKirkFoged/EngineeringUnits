using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum TemperatureUnit
    {



        [Vector(1, "k", 1, 0)] Kelvin,
        [Vector(1, "°C", 1, 273.15)] DegreeCelsius,
        [Vector(1, "°F", 5/9d, 273.15, -32)] DegreeFahrenheit,

    }



    

}