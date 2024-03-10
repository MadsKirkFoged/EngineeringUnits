using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MolarEntropy
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static MolarEntropy FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new MolarEntropy(value, MolarEntropyUnit.SI);
    //}

    /// <summary>
    ///     Get MolarEntropy from JoulesPerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerMoleKelvin->FromJoulePerMoleKelvin")]
    public static MolarEntropy FromJoulesPerMoleKelvin(double joulespermolekelvin)
    {
        var value = (double)joulespermolekelvin;
        return new MolarEntropy(value, MolarEntropyUnit.JoulePerMoleKelvin);
    }
    /// <summary>
    ///     Get MolarEntropy from KilojoulesPerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerMoleKelvin->FromKilojoulePerMoleKelvin")]
    public static MolarEntropy FromKilojoulesPerMoleKelvin(double kilojoulespermolekelvin)
    {
        var value = (double)kilojoulespermolekelvin;
        return new MolarEntropy(value, MolarEntropyUnit.KilojoulePerMoleKelvin);
    }
    /// <summary>
    ///     Get MolarEntropy from MegajoulesPerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerMoleKelvin->FromMegajoulePerMoleKelvin")]
    public static MolarEntropy FromMegajoulesPerMoleKelvin(double megajoulespermolekelvin)
    {
        var value = (double)megajoulespermolekelvin;
        return new MolarEntropy(value, MolarEntropyUnit.MegajoulePerMoleKelvin);
    }
}
