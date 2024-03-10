using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Torque
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Torque FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Torque(value, TorqueUnit.SI);
    //}

    /// <summary>
    ///     Get Torque from KilogramForceCentimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceCentimeters->FromKilogramForceCentimeter")]
    public static Torque FromKilogramForceCentimeters(double kilogramforcecentimeters)
    {
        var value = (double)kilogramforcecentimeters;
        return new Torque(value, TorqueUnit.KilogramForceCentimeter);
    }

    /// <summary>
    ///     Get Torque from KilogramForceMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceMeters->FromKilogramForceMeter")]
    public static Torque FromKilogramForceMeters(double kilogramforcemeters)
    {
        var value = (double)kilogramforcemeters;
        return new Torque(value, TorqueUnit.KilogramForceMeter);
    }

    /// <summary>
    ///     Get Torque from KilogramForceMillimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceMillimeters->FromKilogramForceMillimeter")]
    public static Torque FromKilogramForceMillimeters(double kilogramforcemillimeters)
    {
        var value = (double)kilogramforcemillimeters;
        return new Torque(value, TorqueUnit.KilogramForceMillimeter);
    }

    /// <summary>
    ///     Get Torque from KilonewtonCentimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonCentimeters->FromKilonewtonCentimeter")]
    public static Torque FromKilonewtonCentimeters(double kilonewtoncentimeters)
    {
        var value = (double)kilonewtoncentimeters;
        return new Torque(value, TorqueUnit.KilonewtonCentimeter);
    }

    /// <summary>
    ///     Get Torque from KilonewtonMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonMeters->FromKilonewtonMeter")]
    public static Torque FromKilonewtonMeters(double kilonewtonmeters)
    {
        var value = (double)kilonewtonmeters;
        return new Torque(value, TorqueUnit.KilonewtonMeter);
    }

    /// <summary>
    ///     Get Torque from KilonewtonMillimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonMillimeters->FromKilonewtonMillimeter")]
    public static Torque FromKilonewtonMillimeters(double kilonewtonmillimeters)
    {
        var value = (double)kilonewtonmillimeters;
        return new Torque(value, TorqueUnit.KilonewtonMillimeter);
    }

    /// <summary>
    ///     Get Torque from KilopoundForceFeet.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form- FromKilopoundForceFeet->FromKilopoundForceFoot")]
    public static Torque FromKilopoundForceFeet(double kilopoundforcefeet)
    {
        var value = (double)kilopoundforcefeet;
        return new Torque(value, TorqueUnit.KilopoundForceFoot);
    }

    /// <summary>
    ///     Get Torque from KilopoundForceInches.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundForceInches->FromKilopoundForceInch")]
    public static Torque FromKilopoundForceInches(double kilopoundforceinches)
    {
        var value = (double)kilopoundforceinches;
        return new Torque(value, TorqueUnit.KilopoundForceInch);
    }

    /// <summary>
    ///     Get Torque from MeganewtonCentimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonCentimeters->FromMeganewtonCentimeter")]
    public static Torque FromMeganewtonCentimeters(double meganewtoncentimeters)
    {
        var value = (double)meganewtoncentimeters;
        return new Torque(value, TorqueUnit.MeganewtonCentimeter);
    }

    /// <summary>
    ///     Get Torque from MeganewtonMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonMeters->FromMeganewtonMeter")]
    public static Torque FromMeganewtonMeters(double meganewtonmeters)
    {
        var value = (double)meganewtonmeters;
        return new Torque(value, TorqueUnit.MeganewtonMeter);
    }

    /// <summary>
    ///     Get Torque from MeganewtonMillimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonMillimeters->FromMeganewtonMillimeter")]
    public static Torque FromMeganewtonMillimeters(double meganewtonmillimeters)
    {
        var value = (double)meganewtonmillimeters;
        return new Torque(value, TorqueUnit.MeganewtonMillimeter);
    }

    /// <summary>
    ///     Get Torque from MegapoundForceFeet.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromMegapoundForceFeet->FromMegapoundForceFoot")]
    public static Torque FromMegapoundForceFeet(double megapoundforcefeet)
    {
        var value = (double)megapoundforcefeet;
        return new Torque(value, TorqueUnit.MegapoundForceFoot);
    }

    /// <summary>
    ///     Get Torque from MegapoundForceInches.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundForceInches->FromMegapoundForceInch")]
    public static Torque FromMegapoundForceInches(double megapoundforceinches)
    {
        var value = (double)megapoundforceinches;
        return new Torque(value, TorqueUnit.MegapoundForceInch);
    }

    /// <summary>
    ///     Get Torque from NewtonCentimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonCentimeters->FromNewtonCentimeter")]
    public static Torque FromNewtonCentimeters(double newtoncentimeters)
    {
        var value = (double)newtoncentimeters;
        return new Torque(value, TorqueUnit.NewtonCentimeter);
    }

    /// <summary>
    ///     Get Torque from NewtonMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonMeters->FromNewtonMeter")]
    public static Torque FromNewtonMeters(double newtonmeters)
    {
        var value = (double)newtonmeters;
        return new Torque(value, TorqueUnit.NewtonMeter);
    }

    /// <summary>
    ///     Get Torque from NewtonMillimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonMillimeters->FromNewtonMillimeter")]
    public static Torque FromNewtonMillimeters(double newtonmillimeters)
    {
        var value = (double)newtonmillimeters;
        return new Torque(value, TorqueUnit.NewtonMillimeter);
    }

    /// <summary>
    ///     Get Torque from PoundalFeet.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundalFeet->FromPoundalFoot")]
    public static Torque FromPoundalFeet(double poundalfeet)
    {
        var value = (double)poundalfeet;
        return new Torque(value, TorqueUnit.PoundalFoot);
    }

    /// <summary>
    ///     Get Torque from PoundForceFeet.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundForceFeet->FromPoundForceFoot")]
    public static Torque FromPoundForceFeet(double poundforcefeet)
    {
        var value = (double)poundforcefeet;
        return new Torque(value, TorqueUnit.PoundForceFoot);
    }

    /// <summary>
    ///     Get Torque from PoundForceInches.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundForceInches->FromPoundForceInch")]
    public static Torque FromPoundForceInches(double poundforceinches)
    {
        var value = (double)poundforceinches;
        return new Torque(value, TorqueUnit.PoundForceInch);
    }

    /// <summary>
    ///     Get Torque from TonneForceCentimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceCentimeters->FromTonneForceCentimeter")]
    public static Torque FromTonneForceCentimeters(double tonneforcecentimeters)
    {
        var value = (double)tonneforcecentimeters;
        return new Torque(value, TorqueUnit.TonneForceCentimeter);
    }

    /// <summary>
    ///     Get Torque from TonneForceMeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceMeters->FromTonneForceMeter")]
    public static Torque FromTonneForceMeters(double tonneforcemeters)
    {
        var value = (double)tonneforcemeters;
        return new Torque(value, TorqueUnit.TonneForceMeter);
    }

    /// <summary>
    ///     Get Torque from TonneForceMillimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceMillimeters->FromTonneForceMillimeter")]
    public static Torque FromTonneForceMillimeters(double tonneforcemillimeters)
    {
        var value = (double)tonneforcemillimeters;
        return new Torque(value, TorqueUnit.TonneForceMillimeter);
    }
}
