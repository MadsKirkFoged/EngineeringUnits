using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LuminousIntensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LuminousIntensity FromSI(double si)
        {
            double value = (double)si;
            return new LuminousIntensity(value, LuminousIntensityUnit.SI);
        }

        /// <summary>
        ///     Get LuminousIntensity from Candela.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LuminousIntensity FromCandela(double candela)
        {
            double value = (double)candela;
            return new LuminousIntensity(value, LuminousIntensityUnit.Candela);
        }

    }
}
