using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LapseRateUnit : Enumeration
    {

        public static readonly LapseRateUnit SI = new LapseRateUnit(TemperatureUnit.Kelvin, LengthUnit.Meter);
        public static readonly LapseRateUnit DegreeCelsiusPerKilometer = new LapseRateUnit(TemperatureUnit.Kelvin, LengthUnit.Meter, "∆°C/km");




        public LapseRateUnit(TemperatureUnit temperature, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = temperature / length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

      

    }




}