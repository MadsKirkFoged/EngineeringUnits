using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MolarEnergy
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static MolarEnergy FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new MolarEnergy(value, MolarEnergyUnit.SI);
    //}

    /// <summary>
    ///     Get MolarEnergy from JoulesPerMole.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerMole->FromJoulePerMole")]
    public static MolarEnergy FromJoulesPerMole(double joulespermole)
    {
        var value = (double)joulespermole;
        return new MolarEnergy(value, MolarEnergyUnit.JoulePerMole);
    }
    /// <summary>
    ///     Get MolarEnergy from KilojoulesPerMole.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerMole->FromKilojoulePerMole")]
    public static MolarEnergy FromKilojoulesPerMole(double kilojoulespermole)
    {
        var value = (double)kilojoulespermole;
        return new MolarEnergy(value, MolarEnergyUnit.KilojoulePerMole);
    }
    /// <summary>
    ///     Get MolarEnergy from MegajoulesPerMole.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerMole->FromMegajoulePerMole")]
    public static MolarEnergy FromMegajoulesPerMole(double megajoulespermole)
    {
        var value = (double)megajoulespermole;
        return new MolarEnergy(value, MolarEnergyUnit.MegajoulePerMole);
    }
}
