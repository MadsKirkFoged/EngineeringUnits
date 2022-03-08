using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class HeatTransferCoefficient
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static HeatTransferCoefficient FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.SI);
        //}

        /// <summary>
        ///     Get HeatTransferCoefficient from BtusPerSquareFootDegreeFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromBtusPerSquareFootDegreeFahrenheit->FromBtuPerSquareFootDegreeFahrenheit")]
        public static HeatTransferCoefficient FromBtusPerSquareFootDegreeFahrenheit(double btuspersquarefootdegreefahrenheit)
        {
            double value = (double)btuspersquarefootdegreefahrenheit;
            return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
        }
        /// <summary>
        ///     Get HeatTransferCoefficient from WattsPerSquareMeterCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattsPerSquareMeterCelsius->FromWattPerSquareMeterCelsius")]
        public static HeatTransferCoefficient FromWattsPerSquareMeterCelsius(double wattspersquaremetercelsius)
        {
            double value = (double)wattspersquaremetercelsius;
            return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);
        }
        /// <summary>
        ///     Get HeatTransferCoefficient from WattsPerSquareMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattsPerSquareMeterKelvin->FromWattPerSquareMeterKelvin")]
        public static HeatTransferCoefficient FromWattsPerSquareMeterKelvin(double wattspersquaremeterkelvin)
        {
            double value = (double)wattspersquaremeterkelvin;
            return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
        }

    }
}
