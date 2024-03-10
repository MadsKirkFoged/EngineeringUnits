﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Irradiance
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Irradiance FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Irradiance(value, IrradianceUnit.SI);
    //}

    /// <summary>
    ///     Get Irradiance from KilowattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerSquareCentimeter->FromKilowattPerSquareCentimeter")]
    public static Irradiance FromKilowattsPerSquareCentimeter(double kilowattspersquarecentimeter)
    {
        var value = (double)kilowattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.KilowattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from KilowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerSquareMeter->FromKilowattPerSquareMeter")]
    public static Irradiance FromKilowattsPerSquareMeter(double kilowattspersquaremeter)
    {
        var value = (double)kilowattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.KilowattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from MegawattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerSquareCentimeter->FromMegawattPerSquareCentimeter")]
    public static Irradiance FromMegawattsPerSquareCentimeter(double megawattspersquarecentimeter)
    {
        var value = (double)megawattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.MegawattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from MegawattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerSquareMeter->FromMegawattPerSquareMeter")]
    public static Irradiance FromMegawattsPerSquareMeter(double megawattspersquaremeter)
    {
        var value = (double)megawattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.MegawattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from MicrowattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerSquareCentimeter->FromMicrowattPerSquareCentimeter")]
    public static Irradiance FromMicrowattsPerSquareCentimeter(double microwattspersquarecentimeter)
    {
        var value = (double)microwattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.MicrowattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from MicrowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerSquareMeter->FromMicrowattPerSquareMeter")]
    public static Irradiance FromMicrowattsPerSquareMeter(double microwattspersquaremeter)
    {
        var value = (double)microwattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.MicrowattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from MilliwattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerSquareCentimeter->FromMilliwattPerSquareCentimeter")]
    public static Irradiance FromMilliwattsPerSquareCentimeter(double milliwattspersquarecentimeter)
    {
        var value = (double)milliwattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.MilliwattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from MilliwattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerSquareMeter->FromMilliwattPerSquareMeter")]
    public static Irradiance FromMilliwattsPerSquareMeter(double milliwattspersquaremeter)
    {
        var value = (double)milliwattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.MilliwattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from NanowattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerSquareCentimeter->FromNanowattPerSquareCentimeter")]
    public static Irradiance FromNanowattsPerSquareCentimeter(double nanowattspersquarecentimeter)
    {
        var value = (double)nanowattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.NanowattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from NanowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerSquareMeter->FromNanowattPerSquareMeter")]
    public static Irradiance FromNanowattsPerSquareMeter(double nanowattspersquaremeter)
    {
        var value = (double)nanowattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.NanowattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from PicowattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerSquareCentimeter->FromPicowattPerSquareCentimeter")]
    public static Irradiance FromPicowattsPerSquareCentimeter(double picowattspersquarecentimeter)
    {
        var value = (double)picowattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.PicowattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from PicowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerSquareMeter->FromPicowattPerSquareMeter")]
    public static Irradiance FromPicowattsPerSquareMeter(double picowattspersquaremeter)
    {
        var value = (double)picowattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.PicowattPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiance from WattsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerSquareCentimeter->FromWattPerSquareCentimeter")]
    public static Irradiance FromWattsPerSquareCentimeter(double wattspersquarecentimeter)
    {
        var value = (double)wattspersquarecentimeter;
        return new Irradiance(value, IrradianceUnit.WattPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiance from WattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerSquareMeter->FromWattPerSquareMeter")]
    public static Irradiance FromWattsPerSquareMeter(double wattspersquaremeter)
    {
        var value = (double)wattspersquaremeter;
        return new Irradiance(value, IrradianceUnit.WattPerSquareMeter);
    }
}
