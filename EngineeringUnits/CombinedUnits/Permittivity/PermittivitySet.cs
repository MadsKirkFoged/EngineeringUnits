using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Permittivity
{

    /// <summary>
    /// Get Permittivity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Permittivity? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new Permittivity((double)SI, PermittivityUnit.SI);
    }
    /// <summary>
    /// Get Permittivity from FaradPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(FaradPerMeter))]
    public static Permittivity? FromFaradPerMeter(double? FaradPerMeter)
    {
        if (FaradPerMeter is null)
            return null;

        return new Permittivity((double)FaradPerMeter, PermittivityUnit.FaradPerMeter);
    }
}