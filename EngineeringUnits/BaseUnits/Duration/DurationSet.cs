using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Duration
    {
        /// <summary>
        ///     Get Duration from Days.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromDays(double days)
        {
            double value = (double)days;
            return new Duration(value, DurationUnit.Day);
        }
        /// <summary>
        ///     Get Duration from Hours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromHours(double hours)
        {
            double value = (double)hours;
            return new Duration(value, DurationUnit.Hour);
        }
        /// <summary>
        ///     Get Duration from Microseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMicroseconds(double microseconds)
        {
            double value = (double)microseconds;
            return new Duration(value, DurationUnit.Microsecond);
        }
        /// <summary>
        ///     Get Duration from Milliseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMilliseconds(double milliseconds)
        {
            double value = (double)milliseconds;
            return new Duration(value, DurationUnit.Millisecond);
        }
        /// <summary>
        ///     Get Duration from Minutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMinutes(double minutes)
        {
            double value = (double)minutes;
            return new Duration(value, DurationUnit.Minute);
        }
        /// <summary>
        ///     Get Duration from Months30.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMonths30(double months30)
        {
            double value = (double)months30;
            return new Duration(value, DurationUnit.Month30);
        }
        /// <summary>
        ///     Get Duration from Nanoseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromNanoseconds(double nanoseconds)
        {
            double value = (double)nanoseconds;
            return new Duration(value, DurationUnit.Nanosecond);
        }
        /// <summary>
        ///     Get Duration from Seconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromSeconds(double seconds)
        {
            double value = (double)seconds;
            return new Duration(value, DurationUnit.Second);
        }
        /// <summary>
        ///     Get Duration from Weeks.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromWeeks(double weeks)
        {
            double value = (double)weeks;
            return new Duration(value, DurationUnit.Week);
        }
        /// <summary>
        ///     Get Duration from Years365.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromYears365(double years365)
        {
            double value = (double)years365;
            return new Duration(value, DurationUnit.Year365);
        }



    }
}
