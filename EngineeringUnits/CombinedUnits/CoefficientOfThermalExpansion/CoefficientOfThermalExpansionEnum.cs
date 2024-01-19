using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record CoefficientOfThermalExpansionUnit : UnitTypebase
    {

        public static readonly CoefficientOfThermalExpansionUnit SI = new(TemperatureUnit.SI);
        public static readonly CoefficientOfThermalExpansionUnit InverseKelvin = new(TemperatureUnit.Kelvin, "K⁻¹");
        public static readonly CoefficientOfThermalExpansionUnit InverseDegreeFahrenheit = new(TemperatureUnit.DegreeFahrenheit);
        public static readonly CoefficientOfThermalExpansionUnit InverseDegreeCelsius = new(TemperatureUnit.DegreeCelsius);



        public CoefficientOfThermalExpansionUnit(TemperatureUnit temperature, string NewSymbol = null)
        {
            Unit = new UnitSystem(temperature.Pow(-1), NewSymbol);
        }
        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }




}