using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Power
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Power(value, PowerUnit.SI);
    //}

    /// <summary>
    ///     Get Power from BoilerHorsepower.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromBoilerHorsepower(double boilerhorsepower)
    //{
    //    decimal value = (decimal)boilerhorsepower;
    //    return new Power(value, PowerUnit.BoilerHorsepower);
    //}

    /// <summary>
    ///     Get Power from BritishThermalUnitsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBritishThermalUnitsPerHour->FromBritishThermalUnitPerHour")]
    public static Power FromBritishThermalUnitsPerHour(double britishthermalunitsperhour)
    {
        var value = (decimal)britishthermalunitsperhour;
        return new Power(value, PowerUnit.BritishThermalUnitPerHour);
    }

    /// <summary>
    ///     Get Power from Decawatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecawatts->FromDecawatt")]
    public static Power FromDecawatts(double decawatts)
    {
        var value = (decimal)decawatts;
        return new Power(value, PowerUnit.Decawatt);
    }

    /// <summary>
    ///     Get Power from Deciwatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwatts->FromDeciwatt")]
    public static Power FromDeciwatts(double deciwatts)
    {
        var value = (decimal)deciwatts;
        return new Power(value, PowerUnit.Deciwatt);
    }

    /// <summary>
    ///     Get Power from ElectricalHorsepower.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromElectricalHorsepower(double electricalhorsepower)
    //{
    //    decimal value = (decimal)electricalhorsepower;
    //    return new Power(value, PowerUnit.ElectricalHorsepower);
    //}

    /// <summary>
    ///     Get Power from Femtowatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromFemtowatts->FromFemtowatt")]
    public static Power FromFemtowatts(double femtowatts)
    {
        var value = (decimal)femtowatts;
        return new Power(value, PowerUnit.Femtowatt);
    }

    /// <summary>
    ///     Get Power from GigajoulesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigajoulesPerHour->FromGigajoulePerHour")]
    public static Power FromGigajoulesPerHour(double gigajoulesperhour)
    {
        var value = (decimal)gigajoulesperhour;
        return new Power(value, PowerUnit.GigajoulePerHour);
    }

    /// <summary>
    ///     Get Power from Gigawatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawatts->FromGigawatt")]
    public static Power FromGigawatts(double gigawatts)
    {
        var value = (decimal)gigawatts;
        return new Power(value, PowerUnit.Gigawatt);
    }

    /// <summary>
    ///     Get Power from HydraulicHorsepower.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromHydraulicHorsepower(double hydraulichorsepower)
    //{
    //    decimal value = (decimal)hydraulichorsepower;
    //    return new Power(value, PowerUnit.HydraulicHorsepower);
    //}

    /// <summary>
    ///     Get Power from JoulesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerHour->FromJoulePerHour")]
    public static Power FromJoulesPerHour(double joulesperhour)
    {
        var value = (decimal)joulesperhour;
        return new Power(value, PowerUnit.JoulePerHour);
    }

    /// <summary>
    ///     Get Power from KilobritishThermalUnitsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilobritishThermalUnitsPerHour->FromKilobritishThermalUnitPerHour")]
    public static Power FromKilobritishThermalUnitsPerHour(double kilobritishthermalunitsperhour)
    {
        var value = (decimal)kilobritishthermalunitsperhour;
        return new Power(value, PowerUnit.KilobritishThermalUnitPerHour);
    }

    /// <summary>
    ///     Get Power from KilojoulesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerHour->FromKilojoulePerHour")]
    public static Power FromKilojoulesPerHour(double kilojoulesperhour)
    {
        var value = (decimal)kilojoulesperhour;
        return new Power(value, PowerUnit.KilojoulePerHour);
    }

    /// <summary>
    ///     Get Power from Kilowatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowatts->FromKilowatt")]
    public static Power FromKilowatts(double kilowatts)
    {
        var value = (decimal)kilowatts;
        return new Power(value, PowerUnit.Kilowatt);
    }

    /// <summary>
    ///     Get Power from MechanicalHorsepower.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromMechanicalHorsepower(double mechanicalhorsepower)
    //{
    //    decimal value = (decimal)mechanicalhorsepower;
    //    return new Power(value, PowerUnit.MechanicalHorsepower);
    //}

    /// <summary>
    ///     Get Power from MegajoulesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerHour->FromMegajoulePerHour")]
    public static Power FromMegajoulesPerHour(double megajoulesperhour)
    {
        var value = (decimal)megajoulesperhour;
        return new Power(value, PowerUnit.MegajoulePerHour);
    }

    /// <summary>
    ///     Get Power from Megawatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawatts->FromMegawatt")]
    public static Power FromMegawatts(double megawatts)
    {
        var value = (decimal)megawatts;
        return new Power(value, PowerUnit.Megawatt);
    }

    /// <summary>
    ///     Get Power from MetricHorsepower.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Power FromMetricHorsepower(double metrichorsepower)
    //{
    //    decimal value = (decimal)metrichorsepower;
    //    return new Power(value, PowerUnit.MetricHorsepower);
    //}

    /// <summary>
    ///     Get Power from Microwatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowatts->FromMicrowatt")]
    public static Power FromMicrowatts(double microwatts)
    {
        var value = (decimal)microwatts;
        return new Power(value, PowerUnit.Microwatt);
    }

    /// <summary>
    ///     Get Power from MillijoulesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillijoulesPerHour->FromMillijoulePerHour")]
    public static Power FromMillijoulesPerHour(double millijoulesperhour)
    {
        var value = (decimal)millijoulesperhour;
        return new Power(value, PowerUnit.MillijoulePerHour);
    }

    /// <summary>
    ///     Get Power from Milliwatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwatts->FromMilliwatt")]
    public static Power FromMilliwatts(double milliwatts)
    {
        var value = (decimal)milliwatts;
        return new Power(value, PowerUnit.Milliwatt);
    }

    /// <summary>
    ///     Get Power from Nanowatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowatts->FromNanowatt")]
    public static Power FromNanowatts(double nanowatts)
    {
        var value = (decimal)nanowatts;
        return new Power(value, PowerUnit.Nanowatt);
    }

    /// <summary>
    ///     Get Power from Petawatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPetawatts->FromPetawatt")]
    public static Power FromPetawatts(double petawatts)
    {
        var value = (decimal)petawatts;
        return new Power(value, PowerUnit.Petawatt);
    }

    /// <summary>
    ///     Get Power from Picowatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicowatts->FromPicowatt")]
    public static Power FromPicowatts(double picowatts)
    {
        var value = (decimal)picowatts;
        return new Power(value, PowerUnit.Picowatt);
    }

    /// <summary>
    ///     Get Power from Terawatts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawatts->FromTerawatt")]
    public static Power FromTerawatts(double terawatts)
    {
        var value = (decimal)terawatts;
        return new Power(value, PowerUnit.Terawatt);
    }

    /// <summary>
    ///     Get Power from Watts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWatts->FromWatt")]
    public static Power FromWatts(double watts)
    {
        var value = (decimal)watts;
        return new Power(value, PowerUnit.Watt);
    }
}
