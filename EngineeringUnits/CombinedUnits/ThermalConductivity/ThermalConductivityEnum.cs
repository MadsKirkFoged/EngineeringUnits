using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ThermalConductivityUnit : Enumeration
    {
        public static readonly ThermalConductivityUnit SI = new ThermalConductivityUnit(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static readonly ThermalConductivityUnit WattPerMeterKelvin = new ThermalConductivityUnit(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static readonly ThermalConductivityUnit BtuPerHourFootFahrenheit = new ThermalConductivityUnit(PowerUnit.BritishThermalUnitPerHour, LengthUnit.Foot, TemperatureUnit.DegreeRankine, "BTU/h·ft·°F"); //Not sure this is correct in UnitNets





        public ThermalConductivityUnit(PowerUnit power, LengthUnit length, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power / (length * temperature);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{length}·{temperature}");
        }


    }




}