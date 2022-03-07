using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricPotentialChangeRate
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ElectricPotentialChangeRate FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.SI);
        //}

        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltsPerHours->FromKilovoltsPerHour")]
        public static ElectricPotentialChangeRate FromKilovoltsPerHours(double kilovoltsperhours)
        {
            double value = (double)kilovoltsperhours;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.KilovoltPerHour);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltsPerMicroseconds->FromKilovoltsPerMicrosecond")]
        public static ElectricPotentialChangeRate FromKilovoltsPerMicroseconds(double kilovoltspermicroseconds)
        {
            double value = (double)kilovoltspermicroseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltsPerMinutes->FromKilovoltsPerMinute")]
        public static ElectricPotentialChangeRate FromKilovoltsPerMinutes(double kilovoltsperminutes)
        {
            double value = (double)kilovoltsperminutes;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.KilovoltPerMinute);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltsPerSeconds->FromKilovoltsPerSecond")]
        public static ElectricPotentialChangeRate FromKilovoltsPerSeconds(double kilovoltsperseconds)
        {
            double value = (double)kilovoltsperseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.KilovoltPerSecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltsPerHours->FromMegavoltsPerHour")]
        public static ElectricPotentialChangeRate FromMegavoltsPerHours(double megavoltsperhours)
        {
            double value = (double)megavoltsperhours;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MegavoltPerHour);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltsPerMicroseconds->FromMegavoltsPerMicrosecond")]
        public static ElectricPotentialChangeRate FromMegavoltsPerMicroseconds(double megavoltspermicroseconds)
        {
            double value = (double)megavoltspermicroseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltsPerMinutes->FromMegavoltsPerMinute")]
        public static ElectricPotentialChangeRate FromMegavoltsPerMinutes(double megavoltsperminutes)
        {
            double value = (double)megavoltsperminutes;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MegavoltPerMinute);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltsPerSeconds->FromMegavoltsPerSecond")]
        public static ElectricPotentialChangeRate FromMegavoltsPerSeconds(double megavoltsperseconds)
        {
            double value = (double)megavoltsperseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MegavoltPerSecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrovoltsPerHours->FromMicrovoltsPerHour")]
        public static ElectricPotentialChangeRate FromMicrovoltsPerHours(double microvoltsperhours)
        {
            double value = (double)microvoltsperhours;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MicrovoltPerHour);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrovoltsPerMicroseconds->FromMicrovoltsPerMicrosecond")]
        public static ElectricPotentialChangeRate FromMicrovoltsPerMicroseconds(double microvoltspermicroseconds)
        {
            double value = (double)microvoltspermicroseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrovoltsPerMinutes->FromMicrovoltsPerMinute")]
        public static ElectricPotentialChangeRate FromMicrovoltsPerMinutes(double microvoltsperminutes)
        {
            double value = (double)microvoltsperminutes;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MicrovoltPerMinute);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrovoltsPerSeconds->FromMicrovoltsPerSecond")]
        public static ElectricPotentialChangeRate FromMicrovoltsPerSeconds(double microvoltsperseconds)
        {
            double value = (double)microvoltsperseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MicrovoltPerSecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillivoltsPerHours->FromMillivoltsPerHour")]
        public static ElectricPotentialChangeRate FromMillivoltsPerHours(double millivoltsperhours)
        {
            double value = (double)millivoltsperhours;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MillivoltPerHour);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillivoltsPerMicroseconds->FromMillivoltsPerMicrosecond")]
        public static ElectricPotentialChangeRate FromMillivoltsPerMicroseconds(double millivoltspermicroseconds)
        {
            double value = (double)millivoltspermicroseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillivoltsPerMinutes->FromMillivoltsPerMinute")]
        public static ElectricPotentialChangeRate FromMillivoltsPerMinutes(double millivoltsperminutes)
        {
            double value = (double)millivoltsperminutes;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MillivoltPerMinute);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillivoltsPerSeconds->FromMillivoltsPerSecond")]
        public static ElectricPotentialChangeRate FromMillivoltsPerSeconds(double millivoltsperseconds)
        {
            double value = (double)millivoltsperseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.MillivoltPerSecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltsPerHours->FromVoltsPerHour")]
        public static ElectricPotentialChangeRate FromVoltsPerHours(double voltsperhours)
        {
            double value = (double)voltsperhours;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.VoltPerHour);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltsPerMicroseconds->FromVoltsPerMicrosecond")]
        public static ElectricPotentialChangeRate FromVoltsPerMicroseconds(double voltspermicroseconds)
        {
            double value = (double)voltspermicroseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.VoltPerMicrosecond);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltsPerMinutes->FromVoltsPerMinute")]
        public static ElectricPotentialChangeRate FromVoltsPerMinutes(double voltsperminutes)
        {
            double value = (double)voltsperminutes;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.VoltPerMinute);
        }
        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltsPerSeconds->FromVoltsPerSecond")]
        public static ElectricPotentialChangeRate FromVoltsPerSeconds(double voltsperseconds)
        {
            double value = (double)voltsperseconds;
            return new ElectricPotentialChangeRate(value, ElectricPotentialChangeRateUnit.VoltPerSecond);
        }

    }
}
