using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Duration
{  

/// <summary>
/// Get Duration from Nanosecond.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Nanosecond))]
public static Duration? FromNanosecond(double? Nanosecond)
{
    if (Nanosecond is null)
        return null;

    return new Duration((double)Nanosecond, DurationUnit.Nanosecond);
}                     
/// <summary>
/// Get Duration from Millisecond.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Millisecond))]
public static Duration? FromMillisecond(double? Millisecond)
{
    if (Millisecond is null)
        return null;

    return new Duration((double)Millisecond, DurationUnit.Millisecond);
}                     
/// <summary>
/// Get Duration from Microsecond.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Microsecond))]
public static Duration? FromMicrosecond(double? Microsecond)
{
    if (Microsecond is null)
        return null;

    return new Duration((double)Microsecond, DurationUnit.Microsecond);
}                     
/// <summary>
/// Get Duration from Second.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Second))]
public static Duration? FromSecond(double? Second)
{
    if (Second is null)
        return null;

    return new Duration((double)Second, DurationUnit.Second);
}                     
/// <summary>
/// Get Duration from Minute.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Minute))]
public static Duration? FromMinute(double? Minute)
{
    if (Minute is null)
        return null;

    return new Duration((double)Minute, DurationUnit.Minute);
}                     
/// <summary>
/// Get Duration from Hour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Hour))]
public static Duration? FromHour(double? Hour)
{
    if (Hour is null)
        return null;

    return new Duration((double)Hour, DurationUnit.Hour);
}                     
/// <summary>
/// Get Duration from Day.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Day))]
public static Duration? FromDay(double? Day)
{
    if (Day is null)
        return null;

    return new Duration((double)Day, DurationUnit.Day);
}                     
/// <summary>
/// Get Duration from Week.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Week))]
public static Duration? FromWeek(double? Week)
{
    if (Week is null)
        return null;

    return new Duration((double)Week, DurationUnit.Week);
}                     
/// <summary>
/// Get Duration from Month30.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Month30))]
public static Duration? FromMonth30(double? Month30)
{
    if (Month30 is null)
        return null;

    return new Duration((double)Month30, DurationUnit.Month30);
}                     
/// <summary>
/// Get Duration from Year365.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Year365))]
public static Duration? FromYear365(double? Year365)
{
    if (Year365 is null)
        return null;

    return new Duration((double)Year365, DurationUnit.Year365);
}                     
/// <summary>
/// Get Duration from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static Duration? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Duration((double)SI, DurationUnit.SI);
}                     

}                     