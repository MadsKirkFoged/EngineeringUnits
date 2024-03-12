using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LuminousFlux
{

    /// <summary>
    /// Get LuminousFlux from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static LuminousFlux? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new LuminousFlux((double)SI, LuminousFluxUnit.SI);
    }
    /// <summary>
    /// Get LuminousFlux from Lumen.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Lumen))]
    public static LuminousFlux? FromLumen(double? Lumen)
    {
        if (Lumen is null)
            return null;

        return new LuminousFlux((double)Lumen, LuminousFluxUnit.Lumen);
    }
}