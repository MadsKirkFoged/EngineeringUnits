using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Energy
{  

/// <summary>
/// Get Energy from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static Energy? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Energy((double)SI, EnergyUnit.SI);
}                     
/// <summary>
/// Get Energy from Millijoule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Millijoule))]
public static Energy? FromMillijoule(double? Millijoule)
{
    if (Millijoule is null)
        return null;

    return new Energy((double)Millijoule, EnergyUnit.Millijoule);
}                     
/// <summary>
/// Get Energy from Joule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Joule))]
public static Energy? FromJoule(double? Joule)
{
    if (Joule is null)
        return null;

    return new Energy((double)Joule, EnergyUnit.Joule);
}                     
/// <summary>
/// Get Energy from Kilojoule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Kilojoule))]
public static Energy? FromKilojoule(double? Kilojoule)
{
    if (Kilojoule is null)
        return null;

    return new Energy((double)Kilojoule, EnergyUnit.Kilojoule);
}                     
/// <summary>
/// Get Energy from Megajoule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Megajoule))]
public static Energy? FromMegajoule(double? Megajoule)
{
    if (Megajoule is null)
        return null;

    return new Energy((double)Megajoule, EnergyUnit.Megajoule);
}                     
/// <summary>
/// Get Energy from Gigajoule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Gigajoule))]
public static Energy? FromGigajoule(double? Gigajoule)
{
    if (Gigajoule is null)
        return null;

    return new Energy((double)Gigajoule, EnergyUnit.Gigajoule);
}                     
/// <summary>
/// Get Energy from Terajoule.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Terajoule))]
public static Energy? FromTerajoule(double? Terajoule)
{
    if (Terajoule is null)
        return null;

    return new Energy((double)Terajoule, EnergyUnit.Terajoule);
}                     
/// <summary>
/// Get Energy from BritishThermalUnit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(BritishThermalUnit))]
public static Energy? FromBritishThermalUnit(double? BritishThermalUnit)
{
    if (BritishThermalUnit is null)
        return null;

    return new Energy((double)BritishThermalUnit, EnergyUnit.BritishThermalUnit);
}                     
/// <summary>
/// Get Energy from KilobritishThermalUnit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(KilobritishThermalUnit))]
public static Energy? FromKilobritishThermalUnit(double? KilobritishThermalUnit)
{
    if (KilobritishThermalUnit is null)
        return null;

    return new Energy((double)KilobritishThermalUnit, EnergyUnit.KilobritishThermalUnit);
}                     
/// <summary>
/// Get Energy from MegabritishThermalUnit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(MegabritishThermalUnit))]
public static Energy? FromMegabritishThermalUnit(double? MegabritishThermalUnit)
{
    if (MegabritishThermalUnit is null)
        return null;

    return new Energy((double)MegabritishThermalUnit, EnergyUnit.MegabritishThermalUnit);
}                     
/// <summary>
/// Get Energy from GigabritishThermalUnit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(GigabritishThermalUnit))]
public static Energy? FromGigabritishThermalUnit(double? GigabritishThermalUnit)
{
    if (GigabritishThermalUnit is null)
        return null;

    return new Energy((double)GigabritishThermalUnit, EnergyUnit.GigabritishThermalUnit);
}                     
/// <summary>
/// Get Energy from ElectronVolt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(ElectronVolt))]
public static Energy? FromElectronVolt(double? ElectronVolt)
{
    if (ElectronVolt is null)
        return null;

    return new Energy((double)ElectronVolt, EnergyUnit.ElectronVolt);
}                     
/// <summary>
/// Get Energy from KiloelectronVolt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(KiloelectronVolt))]
public static Energy? FromKiloelectronVolt(double? KiloelectronVolt)
{
    if (KiloelectronVolt is null)
        return null;

    return new Energy((double)KiloelectronVolt, EnergyUnit.KiloelectronVolt);
}                     
/// <summary>
/// Get Energy from MegaelectronVolt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(MegaelectronVolt))]
public static Energy? FromMegaelectronVolt(double? MegaelectronVolt)
{
    if (MegaelectronVolt is null)
        return null;

    return new Energy((double)MegaelectronVolt, EnergyUnit.MegaelectronVolt);
}                     
/// <summary>
/// Get Energy from GigaelectronVolt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(GigaelectronVolt))]
public static Energy? FromGigaelectronVolt(double? GigaelectronVolt)
{
    if (GigaelectronVolt is null)
        return null;

    return new Energy((double)GigaelectronVolt, EnergyUnit.GigaelectronVolt);
}                     
/// <summary>
/// Get Energy from TeraelectronVolt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(TeraelectronVolt))]
public static Energy? FromTeraelectronVolt(double? TeraelectronVolt)
{
    if (TeraelectronVolt is null)
        return null;

    return new Energy((double)TeraelectronVolt, EnergyUnit.TeraelectronVolt);
}                     
/// <summary>
/// Get Energy from Calorie.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Calorie))]
public static Energy? FromCalorie(double? Calorie)
{
    if (Calorie is null)
        return null;

    return new Energy((double)Calorie, EnergyUnit.Calorie);
}                     
/// <summary>
/// Get Energy from Kilocalorie.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Kilocalorie))]
public static Energy? FromKilocalorie(double? Kilocalorie)
{
    if (Kilocalorie is null)
        return null;

    return new Energy((double)Kilocalorie, EnergyUnit.Kilocalorie);
}                     
/// <summary>
/// Get Energy from Megacalorie.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Megacalorie))]
public static Energy? FromMegacalorie(double? Megacalorie)
{
    if (Megacalorie is null)
        return null;

    return new Energy((double)Megacalorie, EnergyUnit.Megacalorie);
}                     
/// <summary>
/// Get Energy from WattDay.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(WattDay))]
public static Energy? FromWattDay(double? WattDay)
{
    if (WattDay is null)
        return null;

    return new Energy((double)WattDay, EnergyUnit.WattDay);
}                     
/// <summary>
/// Get Energy from KilowattDay.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(KilowattDay))]
public static Energy? FromKilowattDay(double? KilowattDay)
{
    if (KilowattDay is null)
        return null;

    return new Energy((double)KilowattDay, EnergyUnit.KilowattDay);
}                     
/// <summary>
/// Get Energy from MegawattDay.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(MegawattDay))]
public static Energy? FromMegawattDay(double? MegawattDay)
{
    if (MegawattDay is null)
        return null;

    return new Energy((double)MegawattDay, EnergyUnit.MegawattDay);
}                     
/// <summary>
/// Get Energy from GigawattDay.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(GigawattDay))]
public static Energy? FromGigawattDay(double? GigawattDay)
{
    if (GigawattDay is null)
        return null;

    return new Energy((double)GigawattDay, EnergyUnit.GigawattDay);
}                     
/// <summary>
/// Get Energy from TerawattDay.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(TerawattDay))]
public static Energy? FromTerawattDay(double? TerawattDay)
{
    if (TerawattDay is null)
        return null;

    return new Energy((double)TerawattDay, EnergyUnit.TerawattDay);
}                     
/// <summary>
/// Get Energy from WattHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(WattHour))]
public static Energy? FromWattHour(double? WattHour)
{
    if (WattHour is null)
        return null;

    return new Energy((double)WattHour, EnergyUnit.WattHour);
}                     
/// <summary>
/// Get Energy from KilowattHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(KilowattHour))]
public static Energy? FromKilowattHour(double? KilowattHour)
{
    if (KilowattHour is null)
        return null;

    return new Energy((double)KilowattHour, EnergyUnit.KilowattHour);
}                     
/// <summary>
/// Get Energy from MegawattHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(MegawattHour))]
public static Energy? FromMegawattHour(double? MegawattHour)
{
    if (MegawattHour is null)
        return null;

    return new Energy((double)MegawattHour, EnergyUnit.MegawattHour);
}                     
/// <summary>
/// Get Energy from GigawattHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(GigawattHour))]
public static Energy? FromGigawattHour(double? GigawattHour)
{
    if (GigawattHour is null)
        return null;

    return new Energy((double)GigawattHour, EnergyUnit.GigawattHour);
}                     
/// <summary>
/// Get Energy from TerawattHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(TerawattHour))]
public static Energy? FromTerawattHour(double? TerawattHour)
{
    if (TerawattHour is null)
        return null;

    return new Energy((double)TerawattHour, EnergyUnit.TerawattHour);
}                     
/// <summary>
/// Get Energy from FootPound.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(FootPound))]
public static Energy? FromFootPound(double? FootPound)
{
    if (FootPound is null)
        return null;

    return new Energy((double)FootPound, EnergyUnit.FootPound);
}                     
/// <summary>
/// Get Energy from DecathermEc.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DecathermEc))]
public static Energy? FromDecathermEc(double? DecathermEc)
{
    if (DecathermEc is null)
        return null;

    return new Energy((double)DecathermEc, EnergyUnit.DecathermEc);
}                     
/// <summary>
/// Get Energy from DecathermImperial.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DecathermImperial))]
public static Energy? FromDecathermImperial(double? DecathermImperial)
{
    if (DecathermImperial is null)
        return null;

    return new Energy((double)DecathermImperial, EnergyUnit.DecathermImperial);
}                     
/// <summary>
/// Get Energy from DecathermUs.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DecathermUs))]
public static Energy? FromDecathermUs(double? DecathermUs)
{
    if (DecathermUs is null)
        return null;

    return new Energy((double)DecathermUs, EnergyUnit.DecathermUs);
}                     
/// <summary>
/// Get Energy from ThermEc.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(ThermEc))]
public static Energy? FromThermEc(double? ThermEc)
{
    if (ThermEc is null)
        return null;

    return new Energy((double)ThermEc, EnergyUnit.ThermEc);
}                     
/// <summary>
/// Get Energy from ThermImperial.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(ThermImperial))]
public static Energy? FromThermImperial(double? ThermImperial)
{
    if (ThermImperial is null)
        return null;

    return new Energy((double)ThermImperial, EnergyUnit.ThermImperial);
}                     
/// <summary>
/// Get Energy from ThermUs.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(ThermUs))]
public static Energy? FromThermUs(double? ThermUs)
{
    if (ThermUs is null)
        return null;

    return new Energy((double)ThermUs, EnergyUnit.ThermUs);
}                     
/// <summary>
/// Get Energy from Erg.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Erg))]
public static Energy? FromErg(double? Erg)
{
    if (Erg is null)
        return null;

    return new Energy((double)Erg, EnergyUnit.Erg);
}                     
/// <summary>
/// Get Energy from HorsepowerHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(HorsepowerHour))]
public static Energy? FromHorsepowerHour(double? HorsepowerHour)
{
    if (HorsepowerHour is null)
        return null;

    return new Energy((double)HorsepowerHour, EnergyUnit.HorsepowerHour);
}                     

}                     