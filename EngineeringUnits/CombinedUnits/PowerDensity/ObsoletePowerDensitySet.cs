using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class PowerDensity
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static PowerDensity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new PowerDensity(value, PowerDensityUnit.SI);
    //}

    /// <summary>
    ///     Get PowerDensity from DecawattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecawattsPerCubicFoot->FromDecawattPerCubicFoot")]
    public static PowerDensity FromDecawattsPerCubicFoot(double decawattspercubicfoot)
    {
        var value = (double)decawattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from DecawattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecawattsPerCubicInch->FromDecawattPerCubicInch")]
    public static PowerDensity FromDecawattsPerCubicInch(double decawattspercubicinch)
    {
        var value = (double)decawattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from DecawattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecawattsPerCubicMeter->FromDecawattPerCubicMeter")]
    public static PowerDensity FromDecawattsPerCubicMeter(double decawattspercubicmeter)
    {
        var value = (double)decawattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from DecawattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecawattsPerLiter->FromDecawattPerLiter")]
    public static PowerDensity FromDecawattsPerLiter(double decawattsperliter)
    {
        var value = (double)decawattsperliter;
        return new PowerDensity(value, PowerDensityUnit.DecawattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from DeciwattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwattsPerCubicFoot->FromDeciwattPerCubicFoot")]
    public static PowerDensity FromDeciwattsPerCubicFoot(double deciwattspercubicfoot)
    {
        var value = (double)deciwattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from DeciwattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwattsPerCubicInch->FromDeciwattPerCubicInch")]
    public static PowerDensity FromDeciwattsPerCubicInch(double deciwattspercubicinch)
    {
        var value = (double)deciwattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from DeciwattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwattsPerCubicMeter->FromDeciwattPerCubicMeter")]
    public static PowerDensity FromDeciwattsPerCubicMeter(double deciwattspercubicmeter)
    {
        var value = (double)deciwattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from DeciwattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwattsPerLiter->FromDeciwattPerLiter")]
    public static PowerDensity FromDeciwattsPerLiter(double deciwattsperliter)
    {
        var value = (double)deciwattsperliter;
        return new PowerDensity(value, PowerDensityUnit.DeciwattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from GigawattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerCubicFoot->FromGigawattPerCubicFoot")]
    public static PowerDensity FromGigawattsPerCubicFoot(double gigawattspercubicfoot)
    {
        var value = (double)gigawattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from GigawattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerCubicInch->FromGigawattPerCubicInch")]
    public static PowerDensity FromGigawattsPerCubicInch(double gigawattspercubicinch)
    {
        var value = (double)gigawattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from GigawattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerCubicMeter->FromGigawattPerCubicMeter")]
    public static PowerDensity FromGigawattsPerCubicMeter(double gigawattspercubicmeter)
    {
        var value = (double)gigawattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from GigawattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattsPerLiter->FromGigawattPerLiter")]
    public static PowerDensity FromGigawattsPerLiter(double gigawattsperliter)
    {
        var value = (double)gigawattsperliter;
        return new PowerDensity(value, PowerDensityUnit.GigawattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from KilowattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerCubicFoot->FromKilowattPerCubicFoot")]
    public static PowerDensity FromKilowattsPerCubicFoot(double kilowattspercubicfoot)
    {
        var value = (double)kilowattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from KilowattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerCubicInch->FromKilowattPerCubicInch")]
    public static PowerDensity FromKilowattsPerCubicInch(double kilowattspercubicinch)
    {
        var value = (double)kilowattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from KilowattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerCubicMeter->FromKilowattPerCubicMeter")]
    public static PowerDensity FromKilowattsPerCubicMeter(double kilowattspercubicmeter)
    {
        var value = (double)kilowattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from KilowattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerLiter->FromKilowattPerLiter")]
    public static PowerDensity FromKilowattsPerLiter(double kilowattsperliter)
    {
        var value = (double)kilowattsperliter;
        return new PowerDensity(value, PowerDensityUnit.KilowattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from MegawattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerCubicFoot->FromMegawattPerCubicFoot")]
    public static PowerDensity FromMegawattsPerCubicFoot(double megawattspercubicfoot)
    {
        var value = (double)megawattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from MegawattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerCubicInch->FromMegawattPerCubicInch")]
    public static PowerDensity FromMegawattsPerCubicInch(double megawattspercubicinch)
    {
        var value = (double)megawattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from MegawattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerCubicMeter->FromMegawattPerCubicMeter")]
    public static PowerDensity FromMegawattsPerCubicMeter(double megawattspercubicmeter)
    {
        var value = (double)megawattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from MegawattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattsPerLiter->FromMegawattPerLiter")]
    public static PowerDensity FromMegawattsPerLiter(double megawattsperliter)
    {
        var value = (double)megawattsperliter;
        return new PowerDensity(value, PowerDensityUnit.MegawattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from MicrowattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerCubicFoot->FromMicrowattPerCubicFoot")]
    public static PowerDensity FromMicrowattsPerCubicFoot(double microwattspercubicfoot)
    {
        var value = (double)microwattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from MicrowattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerCubicInch->FromMicrowattPerCubicInch")]
    public static PowerDensity FromMicrowattsPerCubicInch(double microwattspercubicinch)
    {
        var value = (double)microwattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from MicrowattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerCubicMeter->FromMicrowattPerCubicMeter")]
    public static PowerDensity FromMicrowattsPerCubicMeter(double microwattspercubicmeter)
    {
        var value = (double)microwattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from MicrowattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerLiter->FromMicrowattPerLiter")]
    public static PowerDensity FromMicrowattsPerLiter(double microwattsperliter)
    {
        var value = (double)microwattsperliter;
        return new PowerDensity(value, PowerDensityUnit.MicrowattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from MilliwattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerCubicFoot->FromMilliwattPerCubicFoot")]
    public static PowerDensity FromMilliwattsPerCubicFoot(double milliwattspercubicfoot)
    {
        var value = (double)milliwattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from MilliwattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerCubicInch->FromMilliwattPerCubicInch")]
    public static PowerDensity FromMilliwattsPerCubicInch(double milliwattspercubicinch)
    {
        var value = (double)milliwattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from MilliwattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerCubicMeter->FromMilliwattPerCubicMeter")]
    public static PowerDensity FromMilliwattsPerCubicMeter(double milliwattspercubicmeter)
    {
        var value = (double)milliwattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from MilliwattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerLiter->FromMilliwattPerLiter")]
    public static PowerDensity FromMilliwattsPerLiter(double milliwattsperliter)
    {
        var value = (double)milliwattsperliter;
        return new PowerDensity(value, PowerDensityUnit.MilliwattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from NanowattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerCubicFoot->FromNanowattPerCubicFoot")]
    public static PowerDensity FromNanowattsPerCubicFoot(double nanowattspercubicfoot)
    {
        var value = (double)nanowattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from NanowattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerCubicInch->FromNanowattPerCubicInch")]
    public static PowerDensity FromNanowattsPerCubicInch(double nanowattspercubicinch)
    {
        var value = (double)nanowattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from NanowattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerCubicMeter->FromNanowattPerCubicMeter")]
    public static PowerDensity FromNanowattsPerCubicMeter(double nanowattspercubicmeter)
    {
        var value = (double)nanowattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from NanowattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerLiter->FromNanowattPerLiter")]
    public static PowerDensity FromNanowattsPerLiter(double nanowattsperliter)
    {
        var value = (double)nanowattsperliter;
        return new PowerDensity(value, PowerDensityUnit.NanowattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from PicowattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerCubicFoot->FromPicowattPerCubicFoot")]
    public static PowerDensity FromPicowattsPerCubicFoot(double picowattspercubicfoot)
    {
        var value = (double)picowattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from PicowattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerCubicInch->FromPicowattPerCubicInch")]
    public static PowerDensity FromPicowattsPerCubicInch(double picowattspercubicinch)
    {
        var value = (double)picowattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from PicowattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerCubicMeter->FromPicowattPerCubicMeter")]
    public static PowerDensity FromPicowattsPerCubicMeter(double picowattspercubicmeter)
    {
        var value = (double)picowattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from PicowattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowattsPerLiter->FromPicowattPerLiter")]
    public static PowerDensity FromPicowattsPerLiter(double picowattsperliter)
    {
        var value = (double)picowattsperliter;
        return new PowerDensity(value, PowerDensityUnit.PicowattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from TerawattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattsPerCubicFoot->FromTerawattPerCubicFoot")]
    public static PowerDensity FromTerawattsPerCubicFoot(double terawattspercubicfoot)
    {
        var value = (double)terawattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from TerawattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattsPerCubicInch->FromTerawattPerCubicInch")]
    public static PowerDensity FromTerawattsPerCubicInch(double terawattspercubicinch)
    {
        var value = (double)terawattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from TerawattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattsPerCubicMeter->FromTerawattPerCubicMeter")]
    public static PowerDensity FromTerawattsPerCubicMeter(double terawattspercubicmeter)
    {
        var value = (double)terawattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from TerawattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattsPerLiter->FromTerawattPerLiter")]
    public static PowerDensity FromTerawattsPerLiter(double terawattsperliter)
    {
        var value = (double)terawattsperliter;
        return new PowerDensity(value, PowerDensityUnit.TerawattPerLiter);
    }

    /// <summary>
    ///     Get PowerDensity from WattsPerCubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerCubicFoot->FromWattPerCubicFoot")]
    public static PowerDensity FromWattsPerCubicFoot(double wattspercubicfoot)
    {
        var value = (double)wattspercubicfoot;
        return new PowerDensity(value, PowerDensityUnit.WattPerCubicFoot);
    }

    /// <summary>
    ///     Get PowerDensity from WattsPerCubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerCubicInch->FromWattPerCubicInch")]
    public static PowerDensity FromWattsPerCubicInch(double wattspercubicinch)
    {
        var value = (double)wattspercubicinch;
        return new PowerDensity(value, PowerDensityUnit.WattPerCubicInch);
    }

    /// <summary>
    ///     Get PowerDensity from WattsPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerCubicMeter->FromWattPerCubicMeter")]
    public static PowerDensity FromWattsPerCubicMeter(double wattspercubicmeter)
    {
        var value = (double)wattspercubicmeter;
        return new PowerDensity(value, PowerDensityUnit.WattPerCubicMeter);
    }

    /// <summary>
    ///     Get PowerDensity from WattsPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerLiter->FromWattPerLiter")]
    public static PowerDensity FromWattsPerLiter(double wattsperliter)
    {
        var value = (double)wattsperliter;
        return new PowerDensity(value, PowerDensityUnit.WattPerLiter);
    }
}
