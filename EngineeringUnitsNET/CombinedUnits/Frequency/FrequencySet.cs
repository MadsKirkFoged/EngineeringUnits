using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Frequency
    {
        /// <summary>
        ///     Get Frequency from BeatsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromBeatsPerMinute(double beatsperminute)
        {
            double value = (double)beatsperminute;
            return new Frequency(value, FrequencyUnit.BeatPerMinute);
        }
        /// <summary>
        ///     Get Frequency from BUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Frequency FromBUnits(double bunits)
        //{
        //    double value = (double)bunits;
        //    return new Frequency(value, FrequencyUnit.BUnit);
        //}
        /// <summary>
        ///     Get Frequency from CyclesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerHour(double cyclesperhour)
        {
            double value = (double)cyclesperhour;
            return new Frequency(value, FrequencyUnit.CyclePerHour);
        }
        /// <summary>
        ///     Get Frequency from CyclesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerMinute(double cyclesperminute)
        {
            double value = (double)cyclesperminute;
            return new Frequency(value, FrequencyUnit.CyclePerMinute);
        }
        /// <summary>
        ///     Get Frequency from Gigahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromGigahertz(double gigahertz)
        {
            double value = (double)gigahertz;
            return new Frequency(value, FrequencyUnit.Gigahertz);
        }
        /// <summary>
        ///     Get Frequency from Hertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromHertz(double hertz)
        {
            double value = (double)hertz;
            return new Frequency(value, FrequencyUnit.Hertz);
        }
        /// <summary>
        ///     Get Frequency from Kilohertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromKilohertz(double kilohertz)
        {
            double value = (double)kilohertz;
            return new Frequency(value, FrequencyUnit.Kilohertz);
        }
        /// <summary>
        ///     Get Frequency from Megahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromMegahertz(double megahertz)
        {
            double value = (double)megahertz;
            return new Frequency(value, FrequencyUnit.Megahertz);
        }
        /// <summary>
        ///     Get Frequency from PerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromPerSecond(double persecond)
        {
            double value = (double)persecond;
            return new Frequency(value, FrequencyUnit.PerSecond);
        }
        /// <summary>
        ///     Get Frequency from RadiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromRadiansPerSecond(double radianspersecond)
        {
            double value = (double)radianspersecond;
            return new Frequency(value, FrequencyUnit.RadianPerSecond);
        }
        /// <summary>
        ///     Get Frequency from Terahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromTerahertz(double terahertz)
        {
            double value = (double)terahertz;
            return new Frequency(value, FrequencyUnit.Terahertz);
        }

    }
}
