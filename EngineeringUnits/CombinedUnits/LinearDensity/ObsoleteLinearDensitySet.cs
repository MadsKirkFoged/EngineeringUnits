﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class LinearDensity
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static LinearDensity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new LinearDensity(value, LinearDensityUnit.SI);
    //}

    /// <summary>
    ///     Get LinearDensity from GramsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerCentimeter->FromGramPerCentimeter")]
    public static LinearDensity FromGramsPerCentimeter(double gramspercentimeter)
    {
        var value = (double)gramspercentimeter;
        return new LinearDensity(value, LinearDensityUnit.GramPerCentimeter);
    }
    /// <summary>
    ///     Get LinearDensity from GramsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerMeter->FromGramPerMeter")]
    public static LinearDensity FromGramsPerMeter(double gramspermeter)
    {
        var value = (double)gramspermeter;
        return new LinearDensity(value, LinearDensityUnit.GramPerMeter);
    }
    /// <summary>
    ///     Get LinearDensity from GramsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerMillimeter->FromGramPerMillimeter")]
    public static LinearDensity FromGramsPerMillimeter(double gramspermillimeter)
    {
        var value = (double)gramspermillimeter;
        return new LinearDensity(value, LinearDensityUnit.GramPerMillimeter);
    }
    /// <summary>
    ///     Get LinearDensity from KilogramsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerCentimeter->FromKilogramPerCentimeter")]
    public static LinearDensity FromKilogramsPerCentimeter(double kilogramspercentimeter)
    {
        var value = (double)kilogramspercentimeter;
        return new LinearDensity(value, LinearDensityUnit.KilogramPerCentimeter);
    }
    /// <summary>
    ///     Get LinearDensity from KilogramsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerMeter->FromKilogramPerMeter")]
    public static LinearDensity FromKilogramsPerMeter(double kilogramspermeter)
    {
        var value = (double)kilogramspermeter;
        return new LinearDensity(value, LinearDensityUnit.KilogramPerMeter);
    }
    /// <summary>
    ///     Get LinearDensity from KilogramsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerMillimeter->FromKilogramPerMillimeter")]
    public static LinearDensity FromKilogramsPerMillimeter(double kilogramspermillimeter)
    {
        var value = (double)kilogramspermillimeter;
        return new LinearDensity(value, LinearDensityUnit.KilogramPerMillimeter);
    }
    /// <summary>
    ///     Get LinearDensity from MicrogramsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerCentimeter->FromMicrogramPerCentimeter")]
    public static LinearDensity FromMicrogramsPerCentimeter(double microgramspercentimeter)
    {
        var value = (double)microgramspercentimeter;
        return new LinearDensity(value, LinearDensityUnit.MicrogramPerCentimeter);
    }
    /// <summary>
    ///     Get LinearDensity from MicrogramsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerMeter->FromMicrogramPerMeter")]
    public static LinearDensity FromMicrogramsPerMeter(double microgramspermeter)
    {
        var value = (double)microgramspermeter;
        return new LinearDensity(value, LinearDensityUnit.MicrogramPerMeter);
    }
    /// <summary>
    ///     Get LinearDensity from MicrogramsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerMillimeter->FromMicrogramPerMillimeter")]
    public static LinearDensity FromMicrogramsPerMillimeter(double microgramspermillimeter)
    {
        var value = (double)microgramspermillimeter;
        return new LinearDensity(value, LinearDensityUnit.MicrogramPerMillimeter);
    }
    /// <summary>
    ///     Get LinearDensity from MilligramsPerCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerCentimeter->FromMilligramPerCentimeter")]
    public static LinearDensity FromMilligramsPerCentimeter(double milligramspercentimeter)
    {
        var value = (double)milligramspercentimeter;
        return new LinearDensity(value, LinearDensityUnit.MilligramPerCentimeter);
    }
    /// <summary>
    ///     Get LinearDensity from MilligramsPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerMeter->FromMilligramPerMeter")]
    public static LinearDensity FromMilligramsPerMeter(double milligramspermeter)
    {
        var value = (double)milligramspermeter;
        return new LinearDensity(value, LinearDensityUnit.MilligramPerMeter);
    }
    /// <summary>
    ///     Get LinearDensity from MilligramsPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerMillimeter->FromMilligramPerMillimeter")]
    public static LinearDensity FromMilligramsPerMillimeter(double milligramspermillimeter)
    {
        var value = (double)milligramspermillimeter;
        return new LinearDensity(value, LinearDensityUnit.MilligramPerMillimeter);
    }
    /// <summary>
    ///     Get LinearDensity from PoundsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerFoot->FromPoundPerFoot")]
    public static LinearDensity FromPoundsPerFoot(double poundsperfoot)
    {
        var value = (double)poundsperfoot;
        return new LinearDensity(value, LinearDensityUnit.PoundPerFoot);
    }
    /// <summary>
    ///     Get LinearDensity from PoundsPerInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerInch->FromPoundPerInch")]
    public static LinearDensity FromPoundsPerInch(double poundsperinch)
    {
        var value = (double)poundsperinch;
        return new LinearDensity(value, LinearDensityUnit.PoundPerInch);
    }
}
