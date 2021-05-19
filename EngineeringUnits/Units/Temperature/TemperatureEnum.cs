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



        [Vector("k" , 1         , 0)]                       Kelvin,
        [Vector("°C", 1         , -273.15)]                 DegreeCelsius,
        [Vector("°F", (9/5d)    ,  (-273.15*(9/5d))+32)]    DegreeFahrenheit,

    }



    

}