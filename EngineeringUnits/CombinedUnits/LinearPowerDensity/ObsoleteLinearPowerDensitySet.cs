using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class LinearPowerDensity
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static LinearPowerDensity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new LinearPowerDensity(value, LinearPowerDensityUnit.SI);
    //}

    /// <summary>
    ///     Get LinearPowerDensity from GigawattsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerCentimeter->FromGigawattPerCentimeter")]
    public static LinearPowerDensity FromGigawattsPerCentimeter(double gigawattspercentimeter)
    {
        var value = (double)gigawattspercentimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerCentimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from GigawattsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerFoot->FromGigawattPerFoot")]
    public static LinearPowerDensity FromGigawattsPerFoot(double gigawattsperfoot)
    {
        var value = (double)gigawattsperfoot;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerFoot);
    }
    /// <summary>
    ///     Get LinearPowerDensity from GigawattsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerInch->FromGigawattPerInch")]
    public static LinearPowerDensity FromGigawattsPerInch(double gigawattsperinch)
    {
        var value = (double)gigawattsperinch;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerInch);
    }
    /// <summary>
    ///     Get LinearPowerDensity from GigawattsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerMeter->FromGigawattPerMeter")]
    public static LinearPowerDensity FromGigawattsPerMeter(double gigawattspermeter)
    {
        var value = (double)gigawattspermeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerMeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from GigawattsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerMillimeter->FromGigawattPerMillimeter")]
    public static LinearPowerDensity FromGigawattsPerMillimeter(double gigawattspermillimeter)
    {
        var value = (double)gigawattspermillimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerMillimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from KilowattsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerCentimeter->FromKilowattPerCentimeter")]
    public static LinearPowerDensity FromKilowattsPerCentimeter(double kilowattspercentimeter)
    {
        var value = (double)kilowattspercentimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerCentimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from KilowattsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerFoot->FromKilowattPerFoot")]
    public static LinearPowerDensity FromKilowattsPerFoot(double kilowattsperfoot)
    {
        var value = (double)kilowattsperfoot;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerFoot);
    }
    /// <summary>
    ///     Get LinearPowerDensity from KilowattsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerInch->FromKilowattPerInch")]
    public static LinearPowerDensity FromKilowattsPerInch(double kilowattsperinch)
    {
        var value = (double)kilowattsperinch;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerInch);
    }
    /// <summary>
    ///     Get LinearPowerDensity from KilowattsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerMeter->FromKilowattPerMeter")]
    public static LinearPowerDensity FromKilowattsPerMeter(double kilowattspermeter)
    {
        var value = (double)kilowattspermeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerMeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from KilowattsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerMillimeter->FromKilowattPerMillimeter")]
    public static LinearPowerDensity FromKilowattsPerMillimeter(double kilowattspermillimeter)
    {
        var value = (double)kilowattspermillimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerMillimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MegawattsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerCentimeter->FromMegawattPerCentimeter")]
    public static LinearPowerDensity FromMegawattsPerCentimeter(double megawattspercentimeter)
    {
        var value = (double)megawattspercentimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerCentimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MegawattsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerFoot->FromMegawattPerFoot")]
    public static LinearPowerDensity FromMegawattsPerFoot(double megawattsperfoot)
    {
        var value = (double)megawattsperfoot;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerFoot);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MegawattsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerInch->FromMegawattPerInch")]
    public static LinearPowerDensity FromMegawattsPerInch(double megawattsperinch)
    {
        var value = (double)megawattsperinch;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerInch);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MegawattsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerMeter->FromMegawattPerMeter")]
    public static LinearPowerDensity FromMegawattsPerMeter(double megawattspermeter)
    {
        var value = (double)megawattspermeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerMeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MegawattsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerMillimeter->FromMegawattPerMillimeter")]
    public static LinearPowerDensity FromMegawattsPerMillimeter(double megawattspermillimeter)
    {
        var value = (double)megawattspermillimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerMillimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MilliwattsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerCentimeter->FromMilliwattPerCentimeter")]
    public static LinearPowerDensity FromMilliwattsPerCentimeter(double milliwattspercentimeter)
    {
        var value = (double)milliwattspercentimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerCentimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MilliwattsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerFoot->FromMilliwattPerFoot")]
    public static LinearPowerDensity FromMilliwattsPerFoot(double milliwattsperfoot)
    {
        var value = (double)milliwattsperfoot;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerFoot);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MilliwattsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerInch->FromMilliwattPerInch")]
    public static LinearPowerDensity FromMilliwattsPerInch(double milliwattsperinch)
    {
        var value = (double)milliwattsperinch;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerInch);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MilliwattsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerMeter->FromMilliwattPerMeter")]
    public static LinearPowerDensity FromMilliwattsPerMeter(double milliwattspermeter)
    {
        var value = (double)milliwattspermeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerMeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from MilliwattsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerMillimeter->FromMilliwattPerMillimeter")]
    public static LinearPowerDensity FromMilliwattsPerMillimeter(double milliwattspermillimeter)
    {
        var value = (double)milliwattspermillimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerMillimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from WattsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerCentimeter->FromWattPerCentimeter")]
    public static LinearPowerDensity FromWattsPerCentimeter(double wattspercentimeter)
    {
        var value = (double)wattspercentimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerCentimeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from WattsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerFoot->FromWattPerFoot")]
    public static LinearPowerDensity FromWattsPerFoot(double wattsperfoot)
    {
        var value = (double)wattsperfoot;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerFoot);
    }
    /// <summary>
    ///     Get LinearPowerDensity from WattsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerInch->FromWattPerInch")]
    public static LinearPowerDensity FromWattsPerInch(double wattsperinch)
    {
        var value = (double)wattsperinch;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerInch);
    }
    /// <summary>
    ///     Get LinearPowerDensity from WattsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerMeter->FromWattPerMeter")]
    public static LinearPowerDensity FromWattsPerMeter(double wattspermeter)
    {
        var value = (double)wattspermeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerMeter);
    }
    /// <summary>
    ///     Get LinearPowerDensity from WattsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerMillimeter->FromWattPerMillimeter")]
    public static LinearPowerDensity FromWattsPerMillimeter(double wattspermillimeter)
    {
        var value = (double)wattspermillimeter;
        return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerMillimeter);
    }
}
