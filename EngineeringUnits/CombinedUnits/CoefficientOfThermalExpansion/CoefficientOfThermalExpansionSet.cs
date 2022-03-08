
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion
    {

 

            /// <summary>
            ///     Get CoefficientOfThermalExpansion from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static CoefficientOfThermalExpansion FromSI(double SI)
            {
                double value= (double)SI;
                return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.SI);
            }
            /// <summary>
            ///     Get CoefficientOfThermalExpansion from InverseKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static CoefficientOfThermalExpansion FromInverseKelvin(double InverseKelvin)
            {
                double value= (double)InverseKelvin;
                return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseKelvin);
            }
            /// <summary>
            ///     Get CoefficientOfThermalExpansion from InverseDegreeFahrenheit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static CoefficientOfThermalExpansion FromInverseDegreeFahrenheit(double InverseDegreeFahrenheit)
            {
                double value= (double)InverseDegreeFahrenheit;
                return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
            }
            /// <summary>
            ///     Get CoefficientOfThermalExpansion from InverseDegreeCelsius.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static CoefficientOfThermalExpansion FromInverseDegreeCelsius(double InverseDegreeCelsius)
            {
                double value= (double)InverseDegreeCelsius;
                return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);
            }
    }
}


