using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Magnetization
    {
        /// <summary>
        ///     Get Magnetization from AmperesPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Magnetization FromAmperesPerMeter(double amperespermeter)
        {
            double value = (double)amperespermeter;
            return new Magnetization(value, MagnetizationUnit.AmperePerMeter);
        }

    }
}
