
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class HeatTransferCoefficient
    {

 

            /// <summary>
            ///     Get HeatTransferCoefficient from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatTransferCoefficient FromSI(double SI)
            {
                double value= (double)SI;
                return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.SI);
            }
            /// <summary>
            ///     Get HeatTransferCoefficient from WattPerSquareMeterKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatTransferCoefficient FromWattPerSquareMeterKelvin(double WattPerSquareMeterKelvin)
            {
                double value= (double)WattPerSquareMeterKelvin;
                return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
            }
            /// <summary>
            ///     Get HeatTransferCoefficient from WattPerSquareMeterCelsius.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatTransferCoefficient FromWattPerSquareMeterCelsius(double WattPerSquareMeterCelsius)
            {
                double value= (double)WattPerSquareMeterCelsius;
                return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);
            }
            /// <summary>
            ///     Get HeatTransferCoefficient from BtuPerSquareFootDegreeFahrenheit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatTransferCoefficient FromBtuPerSquareFootDegreeFahrenheit(double BtuPerSquareFootDegreeFahrenheit)
            {
                double value= (double)BtuPerSquareFootDegreeFahrenheit;
                return new HeatTransferCoefficient(value, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
            }
    }
}


