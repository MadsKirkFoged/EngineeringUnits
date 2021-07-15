using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class TemperatureChangeRate
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromSI(double si)
        {
            double value = (double)si;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.SI);
        }

        /// <summary>
        ///     Get TemperatureChangeRate from CentidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(double centidegreescelsiuspersecond)
        {
            double value = (double)centidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from DecadegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(double decadegreescelsiuspersecond)
        {
            double value = (double)decadegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from DecidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(double decidegreescelsiuspersecond)
        {
            double value = (double)decidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(double degreescelsiusperminute)
        {
            double value = (double)degreescelsiusperminute;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(double degreescelsiuspersecond)
        {
            double value = (double)degreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from HectodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(double hectodegreescelsiuspersecond)
        {
            double value = (double)hectodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from KilodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(double kilodegreescelsiuspersecond)
        {
            double value = (double)kilodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from MicrodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(double microdegreescelsiuspersecond)
        {
            double value = (double)microdegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from MillidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(double millidegreescelsiuspersecond)
        {
            double value = (double)millidegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
        }
        /// <summary>
        ///     Get TemperatureChangeRate from NanodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(double nanodegreescelsiuspersecond)
        {
            double value = (double)nanodegreescelsiuspersecond;
            return new TemperatureChangeRate(value, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
        }

    }
}
