using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion
    {
        /// <summary>
        ///     Get CoefficientOfThermalExpansion in InverseDegreeCelsius.
        /// </summary>
        public double InverseDegreeCelsius => As(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);

        /// <summary>
        ///     Get CoefficientOfThermalExpansion in InverseDegreeFahrenheit.
        /// </summary>
        public double InverseDegreeFahrenheit => As(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);

        /// <summary>
        ///     Get CoefficientOfThermalExpansion in InverseKelvin.
        /// </summary>
        public double InverseKelvin => As(CoefficientOfThermalExpansionUnit.InverseKelvin);

        /// <summary>
        ///     Get CoefficientOfThermalExpansion in SI Unit (InverseKelvin).
        /// </summary>
        public double SI => As(CoefficientOfThermalExpansionUnit.SI);

    }
}
