using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Frequency
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Frequency(value, FrequencyUnit.SI);
    //}

    /// <summary>
    ///     Get Frequency from BeatsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBeatsPerMinute->FromBeatPerMinute")]
    public static Frequency FromBeatsPerMinute(double beatsperminute)
    {
        var value = (double)beatsperminute;
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
    [Obsolete("Use without the 's' - FromCyclesPerHour->FromCyclePerHour")]
    public static Frequency FromCyclesPerHour(double cyclesperhour)
    {
        var value = (double)cyclesperhour;
        return new Frequency(value, FrequencyUnit.CyclePerHour);
    }
    /// <summary>
    ///     Get Frequency from CyclesPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCyclesPerMinute->FromCyclePerMinute")]
    public static Frequency FromCyclesPerMinute(double cyclesperminute)
    {
        var value = (double)cyclesperminute;
        return new Frequency(value, FrequencyUnit.CyclePerMinute);
    }
    /// <summary>
    ///     Get Frequency from Gigahertz.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromGigahertz(double gigahertz)
    //{
    //    double value = (double)gigahertz;
    //    return new Frequency(value, FrequencyUnit.Gigahertz);
    //}
    /// <summary>
    ///     Get Frequency from Hertz.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromHertz(double hertz)
    //{
    //    double value = (double)hertz;
    //    return new Frequency(value, FrequencyUnit.Hertz);
    //}
    /// <summary>
    ///     Get Frequency from Kilohertz.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromKilohertz(double kilohertz)
    //{
    //    double value = (double)kilohertz;
    //    return new Frequency(value, FrequencyUnit.Kilohertz);
    //}
    /// <summary>
    ///     Get Frequency from Megahertz.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromMegahertz(double megahertz)
    //{
    //    double value = (double)megahertz;
    //    return new Frequency(value, FrequencyUnit.Megahertz);
    //}
    /// <summary>
    ///     Get Frequency from PerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromPerSecond(double persecond)
    //{
    //    double value = (double)persecond;
    //    return new Frequency(value, FrequencyUnit.PerSecond);
    //}
    /// <summary>
    ///     Get Frequency from RadiansPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromRadiansPerSecond->FromRadianPerSecond")]
    public static Frequency FromRadiansPerSecond(double radianspersecond)
    {
        var value = (double)radianspersecond;
        return new Frequency(value, FrequencyUnit.RadianPerSecond);
    }
    /// <summary>
    ///     Get Frequency from Terahertz.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Frequency FromTerahertz(double terahertz)
    //{
    //    double value = (double)terahertz;
    //    return new Frequency(value, FrequencyUnit.Terahertz);
    //}

}
