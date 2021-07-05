using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient
    {
        /// <summary>
        ///     Get ElectricCurrentGradient from AmperesPerMicrosecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerMicrosecond(double amperespermicrosecond)
        {
            double value = (double)amperespermicrosecond;
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricCurrentGradient from AmperesPerMillisecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerMillisecond(double amperespermillisecond)
        {
            double value = (double)amperespermillisecond;
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMillisecond);
        }
        /// <summary>
        ///     Get ElectricCurrentGradient from AmperesPerNanosecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerNanosecond(double amperespernanosecond)
        {
            double value = (double)amperespernanosecond;
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerNanosecond);
        }
        /// <summary>
        ///     Get ElectricCurrentGradient from AmperesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentGradient FromAmperesPerSecond(double amperespersecond)
        {
            double value = (double)amperespersecond;
            return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerSecond);
        }

    }
}
