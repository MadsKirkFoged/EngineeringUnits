using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricCharge
{  

/// <summary>
/// Get ElectricCharge from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ElectricCharge((double)SI, ElectricChargeUnit.SI);
}                     
/// <summary>
/// Get ElectricCharge from Coulomb.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromCoulomb(double? Coulomb)
{
    if (Coulomb is null)
        return null;

    return new ElectricCharge((double)Coulomb, ElectricChargeUnit.Coulomb);
}                     
/// <summary>
/// Get ElectricCharge from AmpereHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromAmpereHour(double? AmpereHour)
{
    if (AmpereHour is null)
        return null;

    return new ElectricCharge((double)AmpereHour, ElectricChargeUnit.AmpereHour);
}                     
/// <summary>
/// Get ElectricCharge from KiloampereHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromKiloampereHour(double? KiloampereHour)
{
    if (KiloampereHour is null)
        return null;

    return new ElectricCharge((double)KiloampereHour, ElectricChargeUnit.KiloampereHour);
}                     
/// <summary>
/// Get ElectricCharge from MegaampereHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromMegaampereHour(double? MegaampereHour)
{
    if (MegaampereHour is null)
        return null;

    return new ElectricCharge((double)MegaampereHour, ElectricChargeUnit.MegaampereHour);
}                     
/// <summary>
/// Get ElectricCharge from MilliampereHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCharge FromMilliampereHour(double? MilliampereHour)
{
    if (MilliampereHour is null)
        return null;

    return new ElectricCharge((double)MilliampereHour, ElectricChargeUnit.MilliampereHour);
}                     

}                     