using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AreaDensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaDensity FromSI(double si)
        {
            double value = (double)si;
            return new AreaDensity(value, AreaDensityUnit.SI);
        }

        /// <summary>
        ///     Get AreaDensity from KilogramsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaDensity FromKilogramsPerSquareMeter(double kilogramspersquaremeter)
        {
            double value = (double)kilogramspersquaremeter;
            return new AreaDensity(value, AreaDensityUnit.KilogramPerSquareMeter);
        }

    }
}
