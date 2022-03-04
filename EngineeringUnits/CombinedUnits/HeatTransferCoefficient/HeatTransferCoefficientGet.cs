
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class HeatTransferCoefficient
    {

 

            /// <summary>
            ///     Get HeatTransferCoefficient in SI.
            /// </summary>
            public double SI => As(HeatTransferCoefficientUnit.SI);
            /// <summary>
            ///     Get HeatTransferCoefficient in WattPerSquareMeterKelvin.
            /// </summary>
            public double WattPerSquareMeterKelvin => As(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
            /// <summary>
            ///     Get HeatTransferCoefficient in WattPerSquareMeterCelsius.
            /// </summary>
            public double WattPerSquareMeterCelsius => As(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);
            /// <summary>
            ///     Get HeatTransferCoefficient in BtuPerSquareFootDegreeFahrenheit.
            /// </summary>
            public double BtuPerSquareFootDegreeFahrenheit => As(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
    }
}


