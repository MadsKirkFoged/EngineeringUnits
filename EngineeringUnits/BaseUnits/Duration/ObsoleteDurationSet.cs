using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Duration
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Duration FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Duration(value, DurationUnit.SI);
    //}

    /// <summary>
    ///     Get Duration from Days.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDays->FromDay")]
    public static Duration FromDays(double days)
    {
        var value = (double)days;
        return new Duration(value, DurationUnit.Day);
    }
    /// <summary>
    ///     Get Duration from Hours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHours->FromHour")]
    public static Duration FromHours(double hours)
    {
        var value = (double)hours;
        return new Duration(value, DurationUnit.Hour);
    }
    /// <summary>
    ///     Get Duration from Microseconds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroseconds->FromMicrosecond")]
    public static Duration FromMicroseconds(double microseconds)
    {
        var value = (double)microseconds;
        return new Duration(value, DurationUnit.Microsecond);
    }
    /// <summary>
    ///     Get Duration from Milliseconds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliseconds->FromMillisecond")]
    public static Duration FromMilliseconds(double milliseconds)
    {
        var value = (double)milliseconds;
        return new Duration(value, DurationUnit.Millisecond);
    }
    /// <summary>
    ///     Get Duration from Minutes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMinutes->FromMinute")]
    public static Duration FromMinutes(double minutes)
    {
        var value = (double)minutes;
        return new Duration(value, DurationUnit.Minute);
    }
    /// <summary>
    ///     Get Duration from Months30.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMonths30->FromMonth30")]
    public static Duration FromMonths30(double months30)
    {
        var value = (double)months30;
        return new Duration(value, DurationUnit.Month30);
    }
    /// <summary>
    ///     Get Duration from Nanoseconds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanoseconds->FromNanosecond")]
    public static Duration FromNanoseconds(double nanoseconds)
    {
        var value = (double)nanoseconds;
        return new Duration(value, DurationUnit.Nanosecond);
    }
    /// <summary>
    ///     Get Duration from Seconds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromSeconds->FromSecond")]
    public static Duration FromSeconds(double seconds)
    {
        var value = (double)seconds;
        return new Duration(value, DurationUnit.Second);
    }
    /// <summary>
    ///     Get Duration from Weeks.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWeeks->FromWeek")]
    public static Duration FromWeeks(double weeks)
    {
        var value = (double)weeks;
        return new Duration(value, DurationUnit.Week);
    }
    /// <summary>
    ///     Get Duration from Years365.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromYears365->FromYear365")]
    public static Duration FromYears365(double years365)
    {
        var value = (double)years365;
        return new Duration(value, DurationUnit.Year365);
    }
}
