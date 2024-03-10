﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricResistivity
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricResistivity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricResistivity(value, ElectricResistivityUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricResistivity from KiloohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloohmsCentimeter->FromKiloohmCentimeter")]
    public static ElectricResistivity FromKiloohmsCentimeter(double kiloohmscentimeter)
    {
        var value = (double)kiloohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from KiloohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloohmMeters->FromKiloohmMeter")]
    public static ElectricResistivity FromKiloohmMeters(double kiloohmmeters)
    {
        var value = (double)kiloohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MegaohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaohmsCentimeter->FromMegaohmCentimeter")]
    public static ElectricResistivity FromMegaohmsCentimeter(double megaohmscentimeter)
    {
        var value = (double)megaohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MegaohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaohmMeters->FromMegaohmMeter")]
    public static ElectricResistivity FromMegaohmMeters(double megaohmmeters)
    {
        var value = (double)megaohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MicroohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroohmsCentimeter->FromMicroohmCentimeter")]
    public static ElectricResistivity FromMicroohmsCentimeter(double microohmscentimeter)
    {
        var value = (double)microohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MicroohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroohmMeters->FromMicroohmMeter")]
    public static ElectricResistivity FromMicroohmMeters(double microohmmeters)
    {
        var value = (double)microohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MilliohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliohmsCentimeter->FromMilliohmCentimeter")]
    public static ElectricResistivity FromMilliohmsCentimeter(double milliohmscentimeter)
    {
        var value = (double)milliohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from MilliohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliohmMeters->FromMilliohmMeter")]
    public static ElectricResistivity FromMilliohmMeters(double milliohmmeters)
    {
        var value = (double)milliohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from NanoohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanoohmsCentimeter->FromNanoohmsCentimeter")]
    public static ElectricResistivity FromNanoohmsCentimeter(double nanoohmscentimeter)
    {
        var value = (double)nanoohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from NanoohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanoohmMeters->FromNanoohmMeter")]
    public static ElectricResistivity FromNanoohmMeters(double nanoohmmeters)
    {
        var value = (double)nanoohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from OhmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOhmsCentimeter->FromOhmCentimeter")]
    public static ElectricResistivity FromOhmsCentimeter(double ohmscentimeter)
    {
        var value = (double)ohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.OhmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from OhmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOhmMeters->FromOhmMeter")]
    public static ElectricResistivity FromOhmMeters(double ohmmeters)
    {
        var value = (double)ohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.OhmMeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from PicoohmsCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicoohmsCentimeter->FromPicoohmCentimeter")]
    public static ElectricResistivity FromPicoohmsCentimeter(double picoohmscentimeter)
    {
        var value = (double)picoohmscentimeter;
        return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmCentimeter);
    }
    /// <summary>
    ///     Get ElectricResistivity from PicoohmMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicoohmMeters->FromPicoohmMetes")]
    public static ElectricResistivity FromPicoohmMeters(double picoohmmeters)
    {
        var value = (double)picoohmmeters;
        return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmMeter);
    }
}
