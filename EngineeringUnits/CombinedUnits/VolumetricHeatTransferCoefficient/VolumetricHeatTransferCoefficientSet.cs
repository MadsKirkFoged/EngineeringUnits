
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class VolumetricHeatTransferCoefficient
    {

 

            /// <summary>
            ///     Get VolumetricHeatTransferCoefficient from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumetricHeatTransferCoefficient FromSI(double SI)
            {
                double value= (double)SI;
                return new VolumetricHeatTransferCoefficient(value, VolumetricHeatTransferCoefficientUnit.SI);
            }
            /// <summary>
            ///     Get VolumetricHeatTransferCoefficient from WattPerCubicMeterKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumetricHeatTransferCoefficient FromWattPerCubicMeterKelvin(double WattPerCubicMeterKelvin)
            {
                double value= (double)WattPerCubicMeterKelvin;
                return new VolumetricHeatTransferCoefficient(value, VolumetricHeatTransferCoefficientUnit.WattPerCubicMeterKelvin);
            }
    }
}


