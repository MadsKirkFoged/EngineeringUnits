﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Frequency
{
    /// <summary>
    ///     Get Frequency in BeatsPerMinute.
    /// </summary>
    [Obsolete("Use without the 's' - BeatsPerMinute->BeatPerMinute")]
    public double BeatsPerMinute => As(FrequencyUnit.BeatPerMinute);

    /// <summary>
    ///     Get Frequency in BUnits.
    /// </summary>
    //public double BUnits => As(FrequencyUnit.BUnit);

    /// <summary>
    ///     Get Frequency in CyclesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - CyclesPerHour->CyclePerHour")]
    public double CyclesPerHour => As(FrequencyUnit.CyclePerHour);

    /// <summary>
    ///     Get Frequency in CyclesPerMinute.
    /// </summary>
    [Obsolete("Use without the 's' - CyclesPerMinute->CyclePerMinute")]
    public double CyclesPerMinute => As(FrequencyUnit.CyclePerMinute);

    /// <summary>
    ///     Get Frequency in Gigahertz.
    /// </summary>
   // public double Gigahertz => As(FrequencyUnit.Gigahertz);

    /// <summary>
    ///     Get Frequency in Hertz.
    /// </summary>
   // public double Hertz => As(FrequencyUnit.Hertz);

    /// <summary>
    ///     Get Frequency in SI Unit (Hertz).
    /// </summary>
   // public double SI => As(FrequencyUnit.SI);

    /// <summary>
    ///     Get Frequency in Kilohertz.
    /// </summary>
    //public double Kilohertz => As(FrequencyUnit.Kilohertz);

    /// <summary>
    ///     Get Frequency in Megahertz.
    /// </summary>
    //public double Megahertz => As(FrequencyUnit.Megahertz);

    /// <summary>
    ///     Get Frequency in PerSecond.
    /// </summary>
    //public double PerSecond => As(FrequencyUnit.PerSecond);

    /// <summary>
    ///     Get Frequency in RadiansPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - RadiansPerSecond->RadianPerSecond")]
    public double RadiansPerSecond => As(FrequencyUnit.RadianPerSecond);

    /// <summary>
    ///     Get Frequency in Terahertz.
    /// </summary>
    //public double Terahertz => As(FrequencyUnit.Terahertz);

}
