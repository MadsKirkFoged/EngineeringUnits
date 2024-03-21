using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class LuminousIntensity
{

    /// <summary>
    /// Get LuminousIntensity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static LuminousIntensity? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new LuminousIntensity((double)SI, LuminousIntensityUnit.SI);
    }
    /// <summary>
    /// Get LuminousIntensity from Candela.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Candela))]
    public static LuminousIntensity? FromCandela(double? Candela)
    {
        if (Candela is null)
            return null;
        
        return new LuminousIntensity((double)Candela, LuminousIntensityUnit.Candela);
    }

}