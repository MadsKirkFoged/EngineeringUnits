using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion
    {
        /// <summary>
        ///     Get CoefficientOfThermalExpansion from InverseDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseDegreeCelsius(double inversedegreecelsius)
        {
            double value = (double)inversedegreecelsius;
            return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);
        }
        /// <summary>
        ///     Get CoefficientOfThermalExpansion from InverseDegreeFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseDegreeFahrenheit(double inversedegreefahrenheit)
        {
            double value = (double)inversedegreefahrenheit;
            return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
        }
        /// <summary>
        ///     Get CoefficientOfThermalExpansion from InverseKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseKelvin(double inversekelvin)
        {
            double value = (double)inversekelvin;
            return new CoefficientOfThermalExpansion(value, CoefficientOfThermalExpansionUnit.InverseKelvin);
        }

    }
}
