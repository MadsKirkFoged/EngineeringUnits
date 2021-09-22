using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class RotationalSpeed
    {
        /// <summary>
        ///     Get Frequency in BeatsPerMinute.
        /// </summary>
        public double BeatsPerMinute => As(RotationalSpeedUnit.BeatPerMinute);

        /// <summary>
        ///     Get Frequency in BUnits.
        /// </summary>
        //public double BUnits => As(FrequencyUnit.BUnit);

        /// <summary>
        ///     Get Frequency in CyclesPerHour.
        /// </summary>
        public double CyclesPerHour => As(RotationalSpeedUnit.CyclePerHour);

        /// <summary>
        ///     Get Frequency in CyclesPerMinute.
        /// </summary>
        public double CyclesPerMinute => As(RotationalSpeedUnit.CyclePerMinute);

        /// <summary>
        ///     Get Frequency in Gigahertz.
        /// </summary>
        public double Gigahertz => As(RotationalSpeedUnit.Gigahertz);

        /// <summary>
        ///     Get Frequency in Hertz.
        /// </summary>
        public double Hertz => As(RotationalSpeedUnit.Hertz);

        /// <summary>
        ///     Get Frequency in SI Unit (Hertz).
        /// </summary>
        public double SI => As(RotationalSpeedUnit.SI);

        /// <summary>
        ///     Get Frequency in Kilohertz.
        /// </summary>
        public double Kilohertz => As(RotationalSpeedUnit.Kilohertz);

        /// <summary>
        ///     Get Frequency in Megahertz.
        /// </summary>
        public double Megahertz => As(RotationalSpeedUnit.Megahertz);

        /// <summary>
        ///     Get Frequency in PerSecond.
        /// </summary>
        public double PerSecond => As(RotationalSpeedUnit.PerSecond);

        /// <summary>
        ///     Get Frequency in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond => As(RotationalSpeedUnit.RadianPerSecond);

        /// <summary>
        ///     Get Frequency in Terahertz.
        /// </summary>
        public double Terahertz => As(RotationalSpeedUnit.Terahertz);

    }
}
