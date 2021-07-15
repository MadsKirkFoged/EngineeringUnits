using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class HeatTransferCoefficient
    {
        /// <summary>
        ///     Get HeatTransferCoefficient in BtusPerSquareFootDegreeFahrenheit.
        /// </summary>
        public double BtusPerSquareFootDegreeFahrenheit => As(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

        /// <summary>
        ///     Get HeatTransferCoefficient in WattsPerSquareMeterCelsius.
        /// </summary>
        public double WattsPerSquareMeterCelsius => As(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);

        /// <summary>
        ///     Get HeatTransferCoefficient in WattsPerSquareMeterKelvin.
        /// </summary>
        public double WattsPerSquareMeterKelvin => As(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

        /// <summary>
        ///     Get HeatTransferCoefficient in SI Unit (WattsPerSquareMeterKelvin).
        /// </summary>
        public double SI => As(HeatTransferCoefficientUnit.SI);
    }
}
