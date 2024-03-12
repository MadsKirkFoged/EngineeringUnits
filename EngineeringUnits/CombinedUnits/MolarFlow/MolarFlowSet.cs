using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarFlow
{

    /// <summary>
    /// Get MolarFlow from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static MolarFlow? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new MolarFlow((double)SI, MolarFlowUnit.SI);
    }
    /// <summary>
    /// Get MolarFlow from MolePerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MolePerSecond))]
    public static MolarFlow? FromMolePerSecond(double? MolePerSecond)
    {
        if (MolePerSecond is null)
            return null;

        return new MolarFlow((double)MolePerSecond, MolarFlowUnit.MolePerSecond);
    }
}