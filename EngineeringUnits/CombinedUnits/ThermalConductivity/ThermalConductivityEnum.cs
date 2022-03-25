using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ThermalConductivityUnit : UnitEnumbase
    {
        public static readonly ThermalConductivityUnit SI = new(PowerUnit.SI, LengthUnit.SI, TemperatureUnit.SI);
        public static readonly ThermalConductivityUnit WattPerMeterKelvin = new(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static readonly ThermalConductivityUnit BtuPerHourFootFahrenheit = new(PowerUnit.BritishThermalUnitPerHour, LengthUnit.Foot, TemperatureUnit.DegreeRankine, "BTU/h·ft·°F"); //Not sure this is correct in UnitNets


        public ThermalConductivityUnit(PowerUnit power, LengthUnit length, TemperatureUnit temperature)
        {
            Unit = new UnitSystem(power / (length* temperature), 
                               $"{power}/{length}·{temperature}");
        }

        public ThermalConductivityUnit(PowerUnit power, LengthUnit length, TemperatureUnit temperature, string NewSymbol)
        {
            Unit = new UnitSystem(power / (length * temperature), NewSymbol);
        }


    }




}