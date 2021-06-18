using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ThermalResistance
    {
        /// <summary>
        ///     Get ThermalResistance from HourSquareFeetDegreesFahrenheitPerBtu.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalResistance FromHourSquareFeetDegreesFahrenheitPerBtu(double hoursquarefeetdegreesfahrenheitperbtu)
        {
            double value = (double)hoursquarefeetdegreesfahrenheitperbtu;
            return new ThermalResistance(value, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
        }
        /// <summary>
        ///     Get ThermalResistance from SquareCentimeterHourDegreesCelsiusPerKilocalorie.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalResistance FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(double squarecentimeterhourdegreescelsiusperkilocalorie)
        {
            double value = (double)squarecentimeterhourdegreescelsiusperkilocalorie;
            return new ThermalResistance(value, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
        }
        /// <summary>
        ///     Get ThermalResistance from SquareCentimeterKelvinsPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalResistance FromSquareCentimeterKelvinsPerWatt(double squarecentimeterkelvinsperwatt)
        {
            double value = (double)squarecentimeterkelvinsperwatt;
            return new ThermalResistance(value, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
        }
        /// <summary>
        ///     Get ThermalResistance from SquareMeterDegreesCelsiusPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalResistance FromSquareMeterDegreesCelsiusPerWatt(double squaremeterdegreescelsiusperwatt)
        {
            double value = (double)squaremeterdegreescelsiusperwatt;
            return new ThermalResistance(value, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
        }
        /// <summary>
        ///     Get ThermalResistance from SquareMeterKelvinsPerKilowatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalResistance FromSquareMeterKelvinsPerKilowatt(double squaremeterkelvinsperkilowatt)
        {
            double value = (double)squaremeterkelvinsperkilowatt;
            return new ThermalResistance(value, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
        }

    }
}
