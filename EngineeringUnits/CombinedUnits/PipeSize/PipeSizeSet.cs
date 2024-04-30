using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class PipeSize
{

    /// <summary>
    /// Get PipeSize from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static PipeSize? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new PipeSize((double)SI, PipeSizeUnit.SI);
    }
    /// <summary>
    /// Get PipeSize from DN.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DN))]
    public static PipeSize? FromDN(double? DN)
    {
        if (DN is null)
            return null;
        
        return new PipeSize((double)DN, PipeSizeUnit.DN);
    }

}