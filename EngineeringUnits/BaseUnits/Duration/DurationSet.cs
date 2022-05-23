
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Duration
    {

 

            /// <summary>
            ///     Get Duration from Nanosecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromNanosecond(double Nanosecond)
            {
                double value= (double)Nanosecond;
                return new Duration(value, DurationUnit.Nanosecond);
            }
            /// <summary>
            ///     Get Duration from Millisecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromMillisecond(double Millisecond)
            {
                double value= (double)Millisecond;
                return new Duration(value, DurationUnit.Millisecond);
            }
            /// <summary>
            ///     Get Duration from Microsecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromMicrosecond(double Microsecond)
            {
                double value= (double)Microsecond;
                return new Duration(value, DurationUnit.Microsecond);
            }
            /// <summary>
            ///     Get Duration from Second.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromSecond(double Second)
            {
                double value= (double)Second;
                return new Duration(value, DurationUnit.Second);
            }
            /// <summary>
            ///     Get Duration from Minute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromMinute(double Minute)
            {
                double value= (double)Minute;
                return new Duration(value, DurationUnit.Minute);
            }
            /// <summary>
            ///     Get Duration from Hour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromHour(double Hour)
            {
                double value= (double)Hour;
                return new Duration(value, DurationUnit.Hour);
            }
            /// <summary>
            ///     Get Duration from Day.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromDay(double Day)
            {
                double value= (double)Day;
                return new Duration(value, DurationUnit.Day);
            }
            /// <summary>
            ///     Get Duration from Week.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromWeek(double Week)
            {
                double value= (double)Week;
                return new Duration(value, DurationUnit.Week);
            }
            /// <summary>
            ///     Get Duration from Month30.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromMonth30(double Month30)
            {
                double value= (double)Month30;
                return new Duration(value, DurationUnit.Month30);
            }
            /// <summary>
            ///     Get Duration from Year365.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromYear365(double Year365)
            {
                double value= (double)Year365;
                return new Duration(value, DurationUnit.Year365);
            }
            /// <summary>
            ///     Get Duration from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Duration FromSI(double SI)
            {
                double value= (double)SI;
                return new Duration(value, DurationUnit.SI);
            }
    }
}


