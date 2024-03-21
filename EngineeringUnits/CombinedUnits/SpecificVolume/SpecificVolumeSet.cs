using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class SpecificVolume
{

    /// <summary>
    /// Get SpecificVolume from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static SpecificVolume? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new SpecificVolume((double)SI, SpecificVolumeUnit.SI);
    }
    /// <summary>
    /// Get SpecificVolume from CubicMeterPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicMeterPerKilogram))]
    public static SpecificVolume? FromCubicMeterPerKilogram(double? CubicMeterPerKilogram)
    {
        if (CubicMeterPerKilogram is null)
            return null;
        
        return new SpecificVolume((double)CubicMeterPerKilogram, SpecificVolumeUnit.CubicMeterPerKilogram);
    }

}