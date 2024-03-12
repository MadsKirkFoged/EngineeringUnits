using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarEnergy
{  

/// <summary>
/// Get MolarEnergy from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarEnergy? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new MolarEnergy((double)SI, MolarEnergyUnit.SI);
}                     
/// <summary>
/// Get MolarEnergy from JoulePerMole.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarEnergy? FromJoulePerMole(double? JoulePerMole)
{
    if (JoulePerMole is null)
        return null;

    return new MolarEnergy((double)JoulePerMole, MolarEnergyUnit.JoulePerMole);
}                     
/// <summary>
/// Get MolarEnergy from KilojoulePerMole.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarEnergy? FromKilojoulePerMole(double? KilojoulePerMole)
{
    if (KilojoulePerMole is null)
        return null;

    return new MolarEnergy((double)KilojoulePerMole, MolarEnergyUnit.KilojoulePerMole);
}                     
/// <summary>
/// Get MolarEnergy from MegajoulePerMole.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarEnergy? FromMegajoulePerMole(double? MegajoulePerMole)
{
    if (MegajoulePerMole is null)
        return null;

    return new MolarEnergy((double)MegajoulePerMole, MolarEnergyUnit.MegajoulePerMole);
}                     

}                     