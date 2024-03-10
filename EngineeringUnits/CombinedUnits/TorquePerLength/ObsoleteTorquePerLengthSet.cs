using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class TorquePerLength
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static TorquePerLength FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new TorquePerLength(value, TorquePerLengthUnit.SI);
    //}

    /// <summary>
    ///     Get TorquePerLength from KilogramForceCentimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceCentimetersPerMeter->FromKilogramForceCentimeterPerMeter")]
    public static TorquePerLength FromKilogramForceCentimetersPerMeter(double kilogramforcecentimeterspermeter)
    {
        var value = (double)kilogramforcecentimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilogramForceCentimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilogramForceMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceMetersPerMeter->FromKilogramForceMeterPerMeter")]
    public static TorquePerLength FromKilogramForceMetersPerMeter(double kilogramforcemeterspermeter)
    {
        var value = (double)kilogramforcemeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilogramForceMeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilogramForceMillimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramForceMillimetersPerMeter->FromKilogramForceMillimeterPerMeter")]
    public static TorquePerLength FromKilogramForceMillimetersPerMeter(double kilogramforcemillimeterspermeter)
    {
        var value = (double)kilogramforcemillimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilogramForceMillimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilonewtonCentimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonCentimetersPerMeter->FromKilonewtonCentimeterPerMeter")]
    public static TorquePerLength FromKilonewtonCentimetersPerMeter(double kilonewtoncentimeterspermeter)
    {
        var value = (double)kilonewtoncentimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilonewtonCentimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilonewtonMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonMetersPerMeter->FromKilonewtonMeterPerMeter")]
    public static TorquePerLength FromKilonewtonMetersPerMeter(double kilonewtonmeterspermeter)
    {
        var value = (double)kilonewtonmeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilonewtonMeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilonewtonMillimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonMillimetersPerMeter->FromKilonewtonMillimeterPerMeter")]
    public static TorquePerLength FromKilonewtonMillimetersPerMeter(double kilonewtonmillimeterspermeter)
    {
        var value = (double)kilonewtonmillimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.KilonewtonMillimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from KilopoundForceFeetPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromKilopoundForceFeetPerFoot->FromKilopoundForceFootPerFoot")]
    public static TorquePerLength FromKilopoundForceFeetPerFoot(double kilopoundforcefeetperfoot)
    {
        var value = (double)kilopoundforcefeetperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.KilopoundForceFootPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from KilopoundForceInchesPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundForceInchesPerFoot->FromKilopoundForceInchPerFoot")]
    public static TorquePerLength FromKilopoundForceInchesPerFoot(double kilopoundforceinchesperfoot)
    {
        var value = (double)kilopoundforceinchesperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.KilopoundForceInchPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from MeganewtonCentimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonCentimetersPerMeter->FromMeganewtonCentimeterPerMeter")]
    public static TorquePerLength FromMeganewtonCentimetersPerMeter(double meganewtoncentimeterspermeter)
    {
        var value = (double)meganewtoncentimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.MeganewtonCentimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from MeganewtonMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonMetersPerMeter->FromMeganewtonMeterPerMeter")]
    public static TorquePerLength FromMeganewtonMetersPerMeter(double meganewtonmeterspermeter)
    {
        var value = (double)meganewtonmeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.MeganewtonMeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from MeganewtonMillimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonMillimetersPerMeter->FromMeganewtonMillimeterPerMeter")]
    public static TorquePerLength FromMeganewtonMillimetersPerMeter(double meganewtonmillimeterspermeter)
    {
        var value = (double)meganewtonmillimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.MeganewtonMillimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from MegapoundForceFeetPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundForceFeetPerFoot->FromMegapoundForceFootPerFoot")]
    public static TorquePerLength FromMegapoundForceFeetPerFoot(double megapoundforcefeetperfoot)
    {
        var value = (double)megapoundforcefeetperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.MegapoundForceFootPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from MegapoundForceInchesPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundForceInchesPerFoot->FromMegapoundForceInchPerFoot")]
    public static TorquePerLength FromMegapoundForceInchesPerFoot(double megapoundforceinchesperfoot)
    {
        var value = (double)megapoundforceinchesperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.MegapoundForceInchPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from NewtonCentimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonCentimetersPerMeter->FromNewtonCentimeterPerMeter")]
    public static TorquePerLength FromNewtonCentimetersPerMeter(double newtoncentimeterspermeter)
    {
        var value = (double)newtoncentimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.NewtonCentimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from NewtonMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonMetersPerMeter->FromNewtonMeterPerMeter")]
    public static TorquePerLength FromNewtonMetersPerMeter(double newtonmeterspermeter)
    {
        var value = (double)newtonmeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.NewtonMeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from NewtonMillimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonMillimetersPerMeter->FromNewtonMillimeterPerMeter")]
    public static TorquePerLength FromNewtonMillimetersPerMeter(double newtonmillimeterspermeter)
    {
        var value = (double)newtonmillimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.NewtonMillimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from PoundForceFeetPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundForceFeetPerFoot->FromPoundForceFootPerFoot")]
    public static TorquePerLength FromPoundForceFeetPerFoot(double poundforcefeetperfoot)
    {
        var value = (double)poundforcefeetperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.PoundForceFootPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from PoundForceInchesPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundForceInchesPerFoot->FromPoundForceInchPerFoot")]
    public static TorquePerLength FromPoundForceInchesPerFoot(double poundforceinchesperfoot)
    {
        var value = (double)poundforceinchesperfoot;
        return new TorquePerLength(value, TorquePerLengthUnit.PoundForceInchPerFoot);
    }

    /// <summary>
    ///     Get TorquePerLength from TonneForceCentimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceCentimetersPerMeter->FromTonneForceCentimeterPerMeter")]
    public static TorquePerLength FromTonneForceCentimetersPerMeter(double tonneforcecentimeterspermeter)
    {
        var value = (double)tonneforcecentimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.TonneForceCentimeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from TonneForceMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceMetersPerMeter->FromTonneForceMeterPerMeter")]
    public static TorquePerLength FromTonneForceMetersPerMeter(double tonneforcemeterspermeter)
    {
        var value = (double)tonneforcemeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.TonneForceMeterPerMeter);
    }

    /// <summary>
    ///     Get TorquePerLength from TonneForceMillimetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonneForceMillimetersPerMeter->FromTonneForceMillimeterPerMeter")]
    public static TorquePerLength FromTonneForceMillimetersPerMeter(double tonneforcemillimeterspermeter)
    {
        var value = (double)tonneforcemillimeterspermeter;
        return new TorquePerLength(value, TorquePerLengthUnit.TonneForceMillimeterPerMeter);
    }
}
