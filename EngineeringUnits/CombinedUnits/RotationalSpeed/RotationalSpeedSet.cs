
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class RotationalSpeed
    {

 

            /// <summary>
            ///     Get RotationalSpeed from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromSI(double SI)
            {
                double value= (double)SI;
                return new RotationalSpeed(value, RotationalSpeedUnit.SI);
            }
            /// <summary>
            ///     Get RotationalSpeed from RadianPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromRadianPerSecond(double RadianPerSecond)
            {
                double value= (double)RadianPerSecond;
                return new RotationalSpeed(value, RotationalSpeedUnit.RadianPerSecond);
            }
            /// <summary>
            ///     Get RotationalSpeed from Hertz.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromHertz(double Hertz)
            {
                double value= (double)Hertz;
                return new RotationalSpeed(value, RotationalSpeedUnit.Hertz);
            }
            /// <summary>
            ///     Get RotationalSpeed from Kilohertz.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromKilohertz(double Kilohertz)
            {
                double value= (double)Kilohertz;
                return new RotationalSpeed(value, RotationalSpeedUnit.Kilohertz);
            }
            /// <summary>
            ///     Get RotationalSpeed from Megahertz.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromMegahertz(double Megahertz)
            {
                double value= (double)Megahertz;
                return new RotationalSpeed(value, RotationalSpeedUnit.Megahertz);
            }
            /// <summary>
            ///     Get RotationalSpeed from Gigahertz.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromGigahertz(double Gigahertz)
            {
                double value= (double)Gigahertz;
                return new RotationalSpeed(value, RotationalSpeedUnit.Gigahertz);
            }
            /// <summary>
            ///     Get RotationalSpeed from Terahertz.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromTerahertz(double Terahertz)
            {
                double value= (double)Terahertz;
                return new RotationalSpeed(value, RotationalSpeedUnit.Terahertz);
            }
            /// <summary>
            ///     Get RotationalSpeed from PerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromPerSecond(double PerSecond)
            {
                double value= (double)PerSecond;
                return new RotationalSpeed(value, RotationalSpeedUnit.PerSecond);
            }
            /// <summary>
            ///     Get RotationalSpeed from BeatPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromBeatPerMinute(double BeatPerMinute)
            {
                double value= (double)BeatPerMinute;
                return new RotationalSpeed(value, RotationalSpeedUnit.BeatPerMinute);
            }
            /// <summary>
            ///     Get RotationalSpeed from CyclePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromCyclePerHour(double CyclePerHour)
            {
                double value= (double)CyclePerHour;
                return new RotationalSpeed(value, RotationalSpeedUnit.CyclePerHour);
            }
            /// <summary>
            ///     Get RotationalSpeed from CyclePerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static RotationalSpeed FromCyclePerMinute(double CyclePerMinute)
            {
                double value= (double)CyclePerMinute;
                return new RotationalSpeed(value, RotationalSpeedUnit.CyclePerMinute);
            }
    }
}


