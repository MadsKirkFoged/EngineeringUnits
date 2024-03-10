using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Force
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Force FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Force(value, ForceUnit.SI);
    //}

    /// <summary>
    ///     Get Force from Decanewtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecanewtons->FromDecanewton")]
    public static Force FromDecanewtons(double decanewtons)
    {
        var value = (double)decanewtons;
        return new Force(value, ForceUnit.Decanewton);
    }
    /// <summary>
    ///     Get Force from Dyne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Force FromDyne(double dyne)
    //{
    //    double value = (double)dyne;
    //    return new Force(value, ForceUnit.Dyn);
    //}
    /// <summary>
    ///     Get Force from KilogramsForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForce->FromKilogramForce")]
    public static Force FromKilogramsForce(double kilogramsforce)
    {
        var value = (double)kilogramsforce;
        return new Force(value, ForceUnit.KilogramForce);
    }
    /// <summary>
    ///     Get Force from Kilonewtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtons->FromKilonewton")]
    public static Force FromKilonewtons(double kilonewtons)
    {
        var value = (double)kilonewtons;
        return new Force(value, ForceUnit.Kilonewton);
    }
    /// <summary>
    ///     Get Force from KiloPonds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloPonds->FromKiloPond")]
    public static Force FromKiloPonds(double kiloponds)
    {
        var value = (double)kiloponds;
        return new Force(value, ForceUnit.KiloPond);
    }
    /// <summary>
    ///     Get Force from KilopoundsForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForce->FromKilopoundForce")]
    public static Force FromKilopoundsForce(double kilopoundsforce)
    {
        var value = (double)kilopoundsforce;
        return new Force(value, ForceUnit.KilopoundForce);
    }
    /// <summary>
    ///     Get Force from Meganewtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtons->FromMeganewton")]
    public static Force FromMeganewtons(double meganewtons)
    {
        var value = (double)meganewtons;
        return new Force(value, ForceUnit.Meganewton);
    }
    /// <summary>
    ///     Get Force from Micronewtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicronewtons->FromMicronewton")]
    public static Force FromMicronewtons(double micronewtons)
    {
        var value = (double)micronewtons;
        return new Force(value, ForceUnit.Micronewton);
    }
    /// <summary>
    ///     Get Force from Millinewtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillinewtons->FromMillinewton")]
    public static Force FromMillinewtons(double millinewtons)
    {
        var value = (double)millinewtons;
        return new Force(value, ForceUnit.Millinewton);
    }
    /// <summary>
    ///     Get Force from Newtons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtons->FromNewton")]
    public static Force FromNewtons(double newtons)
    {
        var value = (double)newtons;
        return new Force(value, ForceUnit.Newton);
    }
    /// <summary>
    ///     Get Force from OunceForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Force FromOunceForce(double ounceforce)
    //{
    //    double value = (double)ounceforce;
    //    return new Force(value, ForceUnit.OunceForce);
    //}
    /// <summary>
    ///     Get Force from Poundals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundals->FromPoundal")]
    public static Force FromPoundals(double poundals)
    {
        var value = (double)poundals;
        return new Force(value, ForceUnit.Poundal);
    }
    /// <summary>
    ///     Get Force from PoundsForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForce->FromPoundForce")]
    public static Force FromPoundsForce(double poundsforce)
    {
        var value = (double)poundsforce;
        return new Force(value, ForceUnit.PoundForce);
    }
    /// <summary>
    ///     Get Force from ShortTonsForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromShortTonsForce->FromShortTonForce")]
    public static Force FromShortTonsForce(double shorttonsforce)
    {
        var value = (double)shorttonsforce;
        return new Force(value, ForceUnit.ShortTonForce);
    }
    /// <summary>
    ///     Get Force from TonnesForce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForce->FromTonneForce")]
    public static Force FromTonnesForce(double tonnesforce)
    {
        var value = (double)tonnesforce;
        return new Force(value, ForceUnit.TonneForce);
    }
}
