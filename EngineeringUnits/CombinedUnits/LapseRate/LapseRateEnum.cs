using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LapseRateUnit : Enumeration
    {

        public static readonly LapseRateUnit SI = new(TemperatureUnit.SI, LengthUnit.SI);
        public static readonly LapseRateUnit DegreeCelsiusPerKilometer = new(TemperatureUnit.Kelvin, LengthUnit.Meter, "∆°C/km");




        public LapseRateUnit(TemperatureUnit temperature, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = temperature / length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

      

    }




}