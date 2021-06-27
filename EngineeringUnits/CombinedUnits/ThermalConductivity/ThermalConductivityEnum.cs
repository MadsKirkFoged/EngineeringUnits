using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ThermalConductivityUnit : Enumeration
    {
        public static ThermalConductivityUnit SI = new ThermalConductivityUnit(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static ThermalConductivityUnit WattPerMeterKelvin = new ThermalConductivityUnit(PowerUnit.Watt, LengthUnit.Meter, TemperatureUnit.Kelvin);
        public static ThermalConductivityUnit BtuPerHourFootFahrenheit = new ThermalConductivityUnit(PowerUnit.BritishThermalUnitPerHour, LengthUnit.Foot, TemperatureUnit.DegreeRankine, "BTU/h·ft·°F"); //Not sure this is correct in UnitNets





        public ThermalConductivityUnit(PowerUnit power, LengthUnit length, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ThermalConductivity";
            Unit = power.Unit / (length.Unit * temperature.Unit);

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{length}·{temperature}");

        }

        public ThermalConductivityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ThermalConductivity";
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ThermalConductivityUnit(PreFix SI, ThermalConductivityUnit unit)
        {
            //Name = "ThermalConductivity";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ThermalConductivityUnit(ThermalConductivityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ThermalConductivity";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public static IEnumerable<ThermalConductivityUnit> List()
        {
            return new[] { BtuPerHourFootFahrenheit, WattPerMeterKelvin,  };
        }





    }




}