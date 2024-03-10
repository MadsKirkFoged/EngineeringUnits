using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Duration
{

    /// <summary>
    ///     Get Duration in Days.
    /// </summary>
    [Obsolete("Use without the 's' - Days->Day")]

    public double Days => As(DurationUnit.Day);

    /// <summary>
    ///     Get Duration in Hours.
    /// </summary>
    [Obsolete("Use without the 's' - Hours->Hour")]

    public double Hours => As(DurationUnit.Hour);

    /// <summary>
    ///     Get Duration in Microseconds.
    /// </summary>
    [Obsolete("Use without the 's' - Microseconds->Microsecond")]

    public double Microseconds => As(DurationUnit.Microsecond);

    /// <summary>
    ///     Get Duration in Milliseconds.
    /// </summary>
    [Obsolete("Use without the 's' - Milliseconds->Millisecond")]

    public double Milliseconds => As(DurationUnit.Millisecond);

    /// <summary>
    ///     Get Duration in Minutes.
    /// </summary>
    [Obsolete("Use without the 's' - Minutes->Minute")]

    public double Minutes => As(DurationUnit.Minute);

    /// <summary>
    ///     Get Duration in Months30.
    /// </summary>
    [Obsolete("Use without the 's' - Months30->Month30")]

    public double Months30 => As(DurationUnit.Month30);

    /// <summary>
    ///     Get Duration in Nanoseconds.
    /// </summary>
    [Obsolete("Use without the 's' - Nanoseconds->Nanosecond")]

    public double Nanoseconds => As(DurationUnit.Nanosecond);

    /// <summary>
    ///     Get Duration in Seconds.
    /// </summary>
    [Obsolete("Use without the 's' - Seconds->Second")]

    public double Seconds => As(DurationUnit.Second);

    /// <summary>
    ///     Get Duration in SI Unit (Seconds).
    /// </summary>

    //public double SI => As(DurationUnit.SI);

    /// <summary>
    ///     Get Duration in Weeks.
    /// </summary>
    [Obsolete("Use without the 's' - Weeks->Week")]

    public double Weeks => As(DurationUnit.Week);

    /// <summary>
    ///     Get Duration in Years365.
    /// </summary>
    [Obsolete("Use without the 's' - Years365->Year365")]

    public double Years365 => As(DurationUnit.Year365);

}
