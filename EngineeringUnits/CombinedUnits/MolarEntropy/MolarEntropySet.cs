using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarEntropy
{

    /// <summary>
    /// Get MolarEntropy from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static MolarEntropy? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new MolarEntropy((double)SI, MolarEntropyUnit.SI);
    }
    /// <summary>
    /// Get MolarEntropy from JoulePerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(JoulePerMoleKelvin))]
    public static MolarEntropy? FromJoulePerMoleKelvin(double? JoulePerMoleKelvin)
    {
        if (JoulePerMoleKelvin is null)
            return null;
        
        return new MolarEntropy((double)JoulePerMoleKelvin, MolarEntropyUnit.JoulePerMoleKelvin);
    }
    /// <summary>
    /// Get MolarEntropy from KilojoulePerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilojoulePerMoleKelvin))]
    public static MolarEntropy? FromKilojoulePerMoleKelvin(double? KilojoulePerMoleKelvin)
    {
        if (KilojoulePerMoleKelvin is null)
            return null;
        
        return new MolarEntropy((double)KilojoulePerMoleKelvin, MolarEntropyUnit.KilojoulePerMoleKelvin);
    }
    /// <summary>
    /// Get MolarEntropy from MegajoulePerMoleKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegajoulePerMoleKelvin))]
    public static MolarEntropy? FromMegajoulePerMoleKelvin(double? MegajoulePerMoleKelvin)
    {
        if (MegajoulePerMoleKelvin is null)
            return null;
        
        return new MolarEntropy((double)MegajoulePerMoleKelvin, MolarEntropyUnit.MegajoulePerMoleKelvin);
    }

}