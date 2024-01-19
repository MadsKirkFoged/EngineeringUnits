using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ThermalResistanceUnit : UnitTypebase
    {

        public static readonly ThermalResistanceUnit SI = new(AreaUnit.SI, TemperatureUnit.SI, PowerUnit.SI);
        public static readonly ThermalResistanceUnit SquareMeterDegreeCelsiusPerWatt = new(AreaUnit.SquareMeter, TemperatureUnit.Kelvin, PowerUnit.Watt, "m²°C/W");
        public static readonly ThermalResistanceUnit SquareMeterKelvinPerKilowatt = new(AreaUnit.SquareMeter, TemperatureUnit.Kelvin, PowerUnit.Kilowatt);
        public static readonly ThermalResistanceUnit SquareCentimeterKelvinPerWatt = new(AreaUnit.SquareCentimeter, TemperatureUnit.Kelvin, PowerUnit.Watt);
        public static readonly ThermalResistanceUnit SquareCentimeterHourDegreeCelsiusPerKilocalorie = new(AreaUnit.SquareCentimeter, DurationUnit.Hour, TemperatureUnit.Kelvin, EnergyUnit.Kilocalorie, "cm²Hr°C/kcal");
        public static readonly ThermalResistanceUnit HourSquareFeetDegreeFahrenheitPerBtu = new(AreaUnit.SquareFoot, DurationUnit.Hour, TemperatureUnit.DegreeRankine, EnergyUnit.BritishThermalUnit, "Hrft²°F/Btu");




        public ThermalResistanceUnit(AreaUnit area, TemperatureUnit temperature, PowerUnit power)
        {
            Unit = new UnitSystem((area* temperature)/ power, 
                                $"{area}{temperature}/{power}");
        }

        public ThermalResistanceUnit(AreaUnit area, TemperatureUnit temperature, PowerUnit power, string NewSymbol)
        {
            Unit = new UnitSystem((area * temperature) / power,
                                    NewSymbol);
        }

        public ThermalResistanceUnit(AreaUnit area, DurationUnit duration, TemperatureUnit temperature, EnergyUnit energy, string NewSymbol)
        {
            Unit = new UnitSystem((area * duration * temperature) / energy , NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }

}