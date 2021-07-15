using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ThermalResistanceUnit : Enumeration
    {

        public static readonly ThermalResistanceUnit SI = new ThermalResistanceUnit(AreaUnit.SquareMeter, TemperatureUnit.Kelvin, PowerUnit.Watt);
        public static readonly ThermalResistanceUnit SquareMeterDegreeCelsiusPerWatt = new ThermalResistanceUnit(AreaUnit.SquareMeter, TemperatureUnit.Kelvin, PowerUnit.Watt, "m²°C/W");
        public static readonly ThermalResistanceUnit SquareMeterKelvinPerKilowatt = new ThermalResistanceUnit(AreaUnit.SquareMeter, TemperatureUnit.Kelvin, PowerUnit.Kilowatt);
        public static readonly ThermalResistanceUnit SquareCentimeterKelvinPerWatt = new ThermalResistanceUnit(AreaUnit.SquareCentimeter, TemperatureUnit.Kelvin, PowerUnit.Watt);
        public static readonly ThermalResistanceUnit SquareCentimeterHourDegreeCelsiusPerKilocalorie = new ThermalResistanceUnit(AreaUnit.SquareCentimeter, DurationUnit.Hour, TemperatureUnit.Kelvin, EnergyUnit.Kilocalorie, "cm²Hr°C/kcal");
        public static readonly ThermalResistanceUnit HourSquareFeetDegreeFahrenheitPerBtu = new ThermalResistanceUnit(AreaUnit.SquareFoot, DurationUnit.Hour, TemperatureUnit.DegreeRankine, EnergyUnit.BritishThermalUnit, "Hrft²°F/Btu");




        public ThermalResistanceUnit(AreaUnit area, TemperatureUnit temperature, PowerUnit power, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (area * temperature) / power;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{area}{temperature}/{power}");
        }

        public ThermalResistanceUnit(AreaUnit area, DurationUnit duration, TemperatureUnit temperature, EnergyUnit energy, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (area * duration * temperature) / energy;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{area}{duration}{temperature}/{energy}");
        }

    }

}