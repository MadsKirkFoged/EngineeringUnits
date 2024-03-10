using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Energy
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Energy FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Energy(value, EnergyUnit.SI);
    //}

    /// <summary>
    ///     Get Energy from BritishThermalUnits.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBritishThermalUnits->FromBritishThermalUnit")]
    public static Energy FromBritishThermalUnits(double britishthermalunits)
    {
        var value = (double)britishthermalunits;
        return new Energy(value, EnergyUnit.BritishThermalUnit);
    }
    /// <summary>
    ///     Get Energy from Calories.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCalories->FromCalorie")]
    public static Energy FromCalories(double calories)
    {
        var value = (double)calories;
        return new Energy(value, EnergyUnit.Calorie);
    }
    /// <summary>
    ///     Get Energy from DecathermsEc.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecathermsEc->FromDecathermEc")]
    public static Energy FromDecathermsEc(double decathermsec)
    {
        var value = (double)decathermsec;
        return new Energy(value, EnergyUnit.DecathermEc);
    }
    /// <summary>
    ///     Get Energy from DecathermsImperial.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecathermsImperial->FromDecathermImperial")]
    public static Energy FromDecathermsImperial(double decathermsimperial)
    {
        var value = (double)decathermsimperial;
        return new Energy(value, EnergyUnit.DecathermImperial);
    }
    /// <summary>
    ///     Get Energy from DecathermsUs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecathermsUs->FromDecathermUs")]
    public static Energy FromDecathermsUs(double decathermsus)
    {
        var value = (double)decathermsus;
        return new Energy(value, EnergyUnit.DecathermUs);
    }
    /// <summary>
    ///     Get Energy from ElectronVolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromElectronVolts->FromElectronVolt")]
    public static Energy FromElectronVolts(double electronvolts)
    {
        var value = (double)electronvolts;
        return new Energy(value, EnergyUnit.ElectronVolt);
    }
    /// <summary>
    ///     Get Energy from Ergs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromErgs->FromErg")]
    public static Energy FromErgs(double ergs)
    {
        var value = (double)ergs;
        return new Energy(value, EnergyUnit.Erg);
    }
    /// <summary>
    ///     Get Energy from FootPounds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromFootPounds->FromFootPound")]
    public static Energy FromFootPounds(double footpounds)
    {
        var value = (double)footpounds;
        return new Energy(value, EnergyUnit.FootPound);
    }
    /// <summary>
    ///     Get Energy from GigabritishThermalUnits.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigabritishThermalUnits->FromGigabritishThermalUnit")]
    public static Energy FromGigabritishThermalUnits(double gigabritishthermalunits)
    {
        var value = (double)gigabritishthermalunits;
        return new Energy(value, EnergyUnit.GigabritishThermalUnit);
    }
    /// <summary>
    ///     Get Energy from GigaelectronVolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigaelectronVolts->FromGigaelectronVolt")]
    public static Energy FromGigaelectronVolts(double gigaelectronvolts)
    {
        var value = (double)gigaelectronvolts;
        return new Energy(value, EnergyUnit.GigaelectronVolt);
    }
    /// <summary>
    ///     Get Energy from Gigajoules.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigajoules->FromGigajoule")]
    public static Energy FromGigajoules(double gigajoules)
    {
        var value = (double)gigajoules;
        return new Energy(value, EnergyUnit.Gigajoule);
    }
    /// <summary>
    ///     Get Energy from GigawattDays.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattDays->FromGigawattDay")]
    public static Energy FromGigawattDays(double gigawattdays)
    {
        var value = (double)gigawattdays;
        return new Energy(value, EnergyUnit.GigawattDay);
    }
    /// <summary>
    ///     Get Energy from GigawattHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigawattHours->FromGigawattHour")]
    public static Energy FromGigawattHours(double gigawatthours)
    {
        var value = (double)gigawatthours;
        return new Energy(value, EnergyUnit.GigawattHour);
    }
    /// <summary>
    ///     Get Energy from HorsepowerHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHorsepowerHours->FromHorsepowerHour")]
    public static Energy FromHorsepowerHours(double horsepowerhours)
    {
        var value = (double)horsepowerhours;
        return new Energy(value, EnergyUnit.HorsepowerHour);
    }
    /// <summary>
    ///     Get Energy from Joules.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoules->FromJoule")]
    public static Energy FromJoules(double joules)
    {
        var value = (double)joules;
        return new Energy(value, EnergyUnit.Joule);
    }
    /// <summary>
    ///     Get Energy from KilobritishThermalUnits.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilobritishThermalUnits->FromKilobritishThermalUnit")]
    public static Energy FromKilobritishThermalUnits(double kilobritishthermalunits)
    {
        var value = (double)kilobritishthermalunits;
        return new Energy(value, EnergyUnit.KilobritishThermalUnit);
    }
    /// <summary>
    ///     Get Energy from Kilocalories.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilocalories->FromKilocalorie")]
    public static Energy FromKilocalories(double kilocalories)
    {
        var value = (double)kilocalories;
        return new Energy(value, EnergyUnit.Kilocalorie);
    }
    /// <summary>
    ///     Get Energy from KiloelectronVolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloelectronVolts->FromKiloelectronVolt")]
    public static Energy FromKiloelectronVolts(double kiloelectronvolts)
    {
        var value = (double)kiloelectronvolts;
        return new Energy(value, EnergyUnit.KiloelectronVolt);
    }
    /// <summary>
    ///     Get Energy from Kilojoules.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoules->FromKilojoule")]
    public static Energy FromKilojoules(double kilojoules)
    {
        var value = (double)kilojoules;
        return new Energy(value, EnergyUnit.Kilojoule);
    }
    /// <summary>
    ///     Get Energy from KilowattDays.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattDays->FromKilowattDay")]
    public static Energy FromKilowattDays(double kilowattdays)
    {
        var value = (double)kilowattdays;
        return new Energy(value, EnergyUnit.KilowattDay);
    }
    /// <summary>
    ///     Get Energy from KilowattHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattHours->FromKilowattHour")]
    public static Energy FromKilowattHours(double kilowatthours)
    {
        var value = (double)kilowatthours;
        return new Energy(value, EnergyUnit.KilowattHour);
    }
    /// <summary>
    ///     Get Energy from MegabritishThermalUnits.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegabritishThermalUnits->FromMegabritishThermalUnit")]
    public static Energy FromMegabritishThermalUnits(double megabritishthermalunits)
    {
        var value = (double)megabritishthermalunits;
        return new Energy(value, EnergyUnit.MegabritishThermalUnit);
    }
    /// <summary>
    ///     Get Energy from Megacalories.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegacalories->FromMegacalorie")]
    public static Energy FromMegacalories(double megacalories)
    {
        var value = (double)megacalories;
        return new Energy(value, EnergyUnit.Megacalorie);
    }
    /// <summary>
    ///     Get Energy from MegaelectronVolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaelectronVolts->FromMegaelectronVolt")]
    public static Energy FromMegaelectronVolts(double megaelectronvolts)
    {
        var value = (double)megaelectronvolts;
        return new Energy(value, EnergyUnit.MegaelectronVolt);
    }
    /// <summary>
    ///     Get Energy from Megajoules.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoules->FromMegajoule")]
    public static Energy FromMegajoules(double megajoules)
    {
        var value = (double)megajoules;
        return new Energy(value, EnergyUnit.Megajoule);
    }
    /// <summary>
    ///     Get Energy from MegawattDays.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattDay->FromMegawattDay")]
    public static Energy FromMegawattDays(double megawattdays)
    {
        var value = (double)megawattdays;
        return new Energy(value, EnergyUnit.MegawattDay);
    }
    /// <summary>
    ///     Get Energy from MegawattHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegawattHours->FromMegawattHour")]
    public static Energy FromMegawattHours(double megawatthours)
    {
        var value = (double)megawatthours;
        return new Energy(value, EnergyUnit.MegawattHour);
    }
    /// <summary>
    ///     Get Energy from Millijoules.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillijoules->FromMillijoule")]
    public static Energy FromMillijoules(double millijoules)
    {
        var value = (double)millijoules;
        return new Energy(value, EnergyUnit.Millijoule);
    }
    /// <summary>
    ///     Get Energy from TeraelectronVolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTeraelectronVolts->FromTeraelectronVolt")]
    public static Energy FromTeraelectronVolts(double teraelectronvolts)
    {
        var value = (double)teraelectronvolts;
        return new Energy(value, EnergyUnit.TeraelectronVolt);
    }
    /// <summary>
    ///     Get Energy from TerawattDays.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattDays->FromTerawattDay")]
    public static Energy FromTerawattDays(double terawattdays)
    {
        var value = (double)terawattdays;
        return new Energy(value, EnergyUnit.TerawattDay);
    }
    /// <summary>
    ///     Get Energy from TerawattHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTerawattHours->FromTerawattHour")]
    public static Energy FromTerawattHours(double terawatthours)
    {
        var value = (double)terawatthours;
        return new Energy(value, EnergyUnit.TerawattHour);
    }
    /// <summary>
    ///     Get Energy from ThermsEc.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromThermsEc->FromThermEc")]
    public static Energy FromThermsEc(double thermsec)
    {
        var value = (double)thermsec;
        return new Energy(value, EnergyUnit.ThermEc);
    }
    /// <summary>
    ///     Get Energy from ThermsImperial.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromThermsImperial->FromThermImperial")]
    public static Energy FromThermsImperial(double thermsimperial)
    {
        var value = (double)thermsimperial;
        return new Energy(value, EnergyUnit.ThermImperial);
    }
    /// <summary>
    ///     Get Energy from ThermsUs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromThermsUs->FromThermUs")]
    public static Energy FromThermsUs(double thermsus)
    {
        var value = (double)thermsus;
        return new Energy(value, EnergyUnit.ThermUs);
    }
    /// <summary>
    ///     Get Energy from WattDays.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattDays->FromWattDay")]
    public static Energy FromWattDays(double wattdays)
    {
        var value = (double)wattdays;
        return new Energy(value, EnergyUnit.WattDay);
    }
    /// <summary>
    ///     Get Energy from WattHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattHours->FromWattHour")]
    public static Energy FromWattHours(double watthours)
    {
        var value = (double)watthours;
        return new Energy(value, EnergyUnit.WattHour);
    }
}
