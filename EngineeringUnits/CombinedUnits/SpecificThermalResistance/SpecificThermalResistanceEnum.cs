using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record SpecificThermalResistanceUnit : UnitTypebase
    {

        public static readonly SpecificThermalResistanceUnit SI = new(LengthUnit.SI, TemperatureUnit.SI, PowerUnit.SI);
        public static readonly SpecificThermalResistanceUnit MeterDegreeCelsiusPerWatt = new(LengthUnit.Meter, TemperatureUnit.Kelvin, PowerUnit.Watt);
        public static readonly SpecificThermalResistanceUnit MeterKelvinPerKilowatt = new(LengthUnit.Meter, TemperatureUnit.Kelvin, PowerUnit.Kilowatt);
        public static readonly SpecificThermalResistanceUnit CentimeterKelvinPerWatt = new(LengthUnit.Centimeter, TemperatureUnit.Kelvin, PowerUnit.Watt);
       


        public SpecificThermalResistanceUnit(LengthUnit length, TemperatureUnit temperature, PowerUnit power)
        {
            Unit = new UnitSystem((length* temperature)/ power,
                                $"{length}{temperature}/{power}");
        }

        public SpecificThermalResistanceUnit(LengthUnit length, TemperatureUnit temperature, PowerUnit power, string NewSymbol)
        {
            Unit = new UnitSystem((length * temperature) / power,
                                    NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}