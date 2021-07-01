using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class HeatTransferCoefficientUnit : Enumeration
    {

        public static readonly HeatTransferCoefficientUnit SI = new HeatTransferCoefficientUnit(PowerUnit.Watt, AreaUnit.SquareMeter, TemperatureUnit.Kelvin);
        public static readonly HeatTransferCoefficientUnit WattPerSquareMeterKelvin = new HeatTransferCoefficientUnit(PowerUnit.Watt, AreaUnit.SquareMeter, TemperatureUnit.Kelvin, "W/m²·K");
        public static readonly HeatTransferCoefficientUnit WattPerSquareMeterCelsius = new HeatTransferCoefficientUnit(PowerUnit.Watt, AreaUnit.SquareMeter, TemperatureUnit.Kelvin, "W/m²·°C");
        public static readonly HeatTransferCoefficientUnit BtuPerSquareFootDegreeFahrenheit = new HeatTransferCoefficientUnit(PowerUnit.BritishThermalUnitPerHour, AreaUnit.SquareFoot, TemperatureUnit.DegreeRankine, "Btu/ft²·hr·°F");


        public HeatTransferCoefficientUnit(PowerUnit power, AreaUnit area, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power.Unit / (area.Unit * temperature.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{area}{temperature}");
        }

       

    }




}