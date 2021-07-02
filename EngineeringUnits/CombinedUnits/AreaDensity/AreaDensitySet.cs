using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AreaDensity
    {
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
