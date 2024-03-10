using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class SpecificWeight
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static SpecificWeight FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new SpecificWeight(value, SpecificWeightUnit.SI);
    //}

    /// <summary>
    ///     Get SpecificWeight from KilogramsForcePerCubicCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerCubicCentimeter->FromKilogramForcePerCubicCentimeter")]
    public static SpecificWeight FromKilogramsForcePerCubicCentimeter(double kilogramsforcepercubiccentimeter)
    {
        var value = (double)kilogramsforcepercubiccentimeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicCentimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilogramsForcePerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerCubicMeter->FromKilogramForcePerCubicMeter")]
    public static SpecificWeight FromKilogramsForcePerCubicMeter(double kilogramsforcepercubicmeter)
    {
        var value = (double)kilogramsforcepercubicmeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicMeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilogramsForcePerCubicMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerCubicMillimeter->FromKilogramForcePerCubicMillimeter")]
    public static SpecificWeight FromKilogramsForcePerCubicMillimeter(double kilogramsforcepercubicmillimeter)
    {
        var value = (double)kilogramsforcepercubicmillimeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicMillimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilonewtonsPerCubicCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerCubicCentimeter->FromKilonewtonPerCubicCentimeter")]
    public static SpecificWeight FromKilonewtonsPerCubicCentimeter(double kilonewtonspercubiccentimeter)
    {
        var value = (double)kilonewtonspercubiccentimeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicCentimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilonewtonsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerCubicMeter->FromKilonewtonPerCubicMeter")]
    public static SpecificWeight FromKilonewtonsPerCubicMeter(double kilonewtonspercubicmeter)
    {
        var value = (double)kilonewtonspercubicmeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicMeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilonewtonsPerCubicMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerCubicMillimeter->FromKilonewtonPerCubicMillimeter")]
    public static SpecificWeight FromKilonewtonsPerCubicMillimeter(double kilonewtonspercubicmillimeter)
    {
        var value = (double)kilonewtonspercubicmillimeter;
        return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicMillimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from KilopoundsForcePerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerCubicFoot->FromKilopoundForcePerCubicFoot")]
    public static SpecificWeight FromKilopoundsForcePerCubicFoot(double kilopoundsforcepercubicfoot)
    {
        var value = (double)kilopoundsforcepercubicfoot;
        return new SpecificWeight(value, SpecificWeightUnit.KilopoundForcePerCubicFoot);
    }

    /// <summary>
    ///     Get SpecificWeight from KilopoundsForcePerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerCubicInch->FromKilopoundForcePerCubicInch")]
    public static SpecificWeight FromKilopoundsForcePerCubicInch(double kilopoundsforcepercubicinch)
    {
        var value = (double)kilopoundsforcepercubicinch;
        return new SpecificWeight(value, SpecificWeightUnit.KilopoundForcePerCubicInch);
    }

    /// <summary>
    ///     Get SpecificWeight from MeganewtonsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonsPerCubicMeter->FromMeganewtonPerCubicMeter")]
    public static SpecificWeight FromMeganewtonsPerCubicMeter(double meganewtonspercubicmeter)
    {
        var value = (double)meganewtonspercubicmeter;
        return new SpecificWeight(value, SpecificWeightUnit.MeganewtonPerCubicMeter);
    }

    /// <summary>
    ///     Get SpecificWeight from NewtonsPerCubicCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerCubicCentimeter->FromNewtonPerCubicCentimeter")]
    public static SpecificWeight FromNewtonsPerCubicCentimeter(double newtonspercubiccentimeter)
    {
        var value = (double)newtonspercubiccentimeter;
        return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicCentimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from NewtonsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerCubicMeter->FromNewtonPerCubicMeter")]
    public static SpecificWeight FromNewtonsPerCubicMeter(double newtonspercubicmeter)
    {
        var value = (double)newtonspercubicmeter;
        return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicMeter);
    }

    /// <summary>
    ///     Get SpecificWeight from NewtonsPerCubicMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerCubicMillimeter->FromNewtonPerCubicMillimeter")]
    public static SpecificWeight FromNewtonsPerCubicMillimeter(double newtonspercubicmillimeter)
    {
        var value = (double)newtonspercubicmillimeter;
        return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicMillimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from PoundsForcePerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerCubicFoot->FromPoundForcePerCubicFoot")]
    public static SpecificWeight FromPoundsForcePerCubicFoot(double poundsforcepercubicfoot)
    {
        var value = (double)poundsforcepercubicfoot;
        return new SpecificWeight(value, SpecificWeightUnit.PoundForcePerCubicFoot);
    }

    /// <summary>
    ///     Get SpecificWeight from PoundsForcePerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerCubicInch->FromPoundForcePerCubicInch")]
    public static SpecificWeight FromPoundsForcePerCubicInch(double poundsforcepercubicinch)
    {
        var value = (double)poundsforcepercubicinch;
        return new SpecificWeight(value, SpecificWeightUnit.PoundForcePerCubicInch);
    }

    /// <summary>
    ///     Get SpecificWeight from TonnesForcePerCubicCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerCubicCentimeter->FromTonneForcePerCubicCentimeter")]
    public static SpecificWeight FromTonnesForcePerCubicCentimeter(double tonnesforcepercubiccentimeter)
    {
        var value = (double)tonnesforcepercubiccentimeter;
        return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicCentimeter);
    }

    /// <summary>
    ///     Get SpecificWeight from TonnesForcePerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerCubicMeter->FromTonneForcePerCubicMeter")]
    public static SpecificWeight FromTonnesForcePerCubicMeter(double tonnesforcepercubicmeter)
    {
        var value = (double)tonnesforcepercubicmeter;
        return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicMeter);
    }

    /// <summary>
    ///     Get SpecificWeight from TonnesForcePerCubicMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerCubicMillimeter->FromTonneForcePerCubicMillimeter")]
    public static SpecificWeight FromTonnesForcePerCubicMillimeter(double tonnesforcepercubicmillimeter)
    {
        var value = (double)tonnesforcepercubicmillimeter;
        return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicMillimeter);
    }
}
