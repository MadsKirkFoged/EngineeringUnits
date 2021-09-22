using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class RotationalSpeed
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromSI(double si)
        {
            double value = (double)si;
            return new RotationalSpeed(value, RotationalSpeedUnit.SI);
        }

        /// <summary>
        ///     Get Frequency from BeatsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromBeatsPerMinute(double beatsperminute)
        {
            double value = (double)beatsperminute;
            return new RotationalSpeed(value, RotationalSpeedUnit.BeatPerMinute);
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
        public static RotationalSpeed FromCyclesPerHour(double cyclesperhour)
        {
            double value = (double)cyclesperhour;
            return new RotationalSpeed(value, RotationalSpeedUnit.CyclePerHour);
        }
        /// <summary>
        ///     Get Frequency from CyclesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromCyclesPerMinute(double cyclesperminute)
        {
            double value = (double)cyclesperminute;
            return new RotationalSpeed(value, RotationalSpeedUnit.CyclePerMinute);
        }
        /// <summary>
        ///     Get Frequency from Gigahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromGigahertz(double gigahertz)
        {
            double value = (double)gigahertz;
            return new RotationalSpeed(value, RotationalSpeedUnit.Gigahertz);
        }
        /// <summary>
        ///     Get Frequency from Hertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromHertz(double hertz)
        {
            double value = (double)hertz;
            return new RotationalSpeed(value, RotationalSpeedUnit.Hertz);
        }
        /// <summary>
        ///     Get Frequency from Kilohertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromKilohertz(double kilohertz)
        {
            double value = (double)kilohertz;
            return new RotationalSpeed(value, RotationalSpeedUnit.Kilohertz);
        }
        /// <summary>
        ///     Get Frequency from Megahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMegahertz(double megahertz)
        {
            double value = (double)megahertz;
            return new RotationalSpeed(value, RotationalSpeedUnit.Megahertz);
        }
        /// <summary>
        ///     Get Frequency from PerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromPerSecond(double persecond)
        {
            double value = (double)persecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.PerSecond);
        }
        /// <summary>
        ///     Get Frequency from RadiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRadiansPerSecond(double radianspersecond)
        {
            double value = (double)radianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.RadianPerSecond);
        }
        /// <summary>
        ///     Get Frequency from Terahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromTerahertz(double terahertz)
        {
            double value = (double)terahertz;
            return new RotationalSpeed(value, RotationalSpeedUnit.Terahertz);
        }


    }
}
