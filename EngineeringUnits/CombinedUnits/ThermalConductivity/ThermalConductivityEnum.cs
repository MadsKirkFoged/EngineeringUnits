using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ThermalConductivityUnit : Enumeration
    {
        public static readonly ThermalConductivityUnit SI = new(PowerUnit.SI, LengthUnit.SI, TemperatureUnit.SI);
        public static readonly ThermalConductivityUnit WattPerMeterKelvin = new(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static readonly ThermalConductivityUnit BtuPerHourFootFahrenheit = new(PowerUnit.BritishThermalUnitPerHour, LengthUnit.Foot, TemperatureUnit.DegreeRankine, "BTU/h·ft·°F"); //Not sure this is correct in UnitNets





        public ThermalConductivityUnit(PowerUnit power, LengthUnit length, TemperatureUnit temperature, string NewSymbol = "Empty")
        {
            Unit = power / (length * temperature);
            SetNewSymbol(NewSymbol, $"{power}/{length}·{temperature}");
        }


    }




}