using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Permeability
{

    /// <summary>
    /// Get Permeability from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Permeability? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new Permeability((double)SI, PermeabilityUnit.SI);
    }
    /// <summary>
    /// Get Permeability from HenryPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HenryPerMeter))]
    public static Permeability? FromHenryPerMeter(double? HenryPerMeter)
    {
        if (HenryPerMeter is null)
            return null;

        return new Permeability((double)HenryPerMeter, PermeabilityUnit.HenryPerMeter);
    }
}