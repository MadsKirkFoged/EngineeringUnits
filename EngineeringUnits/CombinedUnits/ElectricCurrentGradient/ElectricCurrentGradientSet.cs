using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricCurrentGradient
{

    /// <summary>
    /// Get ElectricCurrentGradient from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ElectricCurrentGradient? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new ElectricCurrentGradient((double)SI, ElectricCurrentGradientUnit.SI);
    }
    /// <summary>
    /// Get ElectricCurrentGradient from AmperePerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AmperePerSecond))]
    public static ElectricCurrentGradient? FromAmperePerSecond(double? AmperePerSecond)
    {
        if (AmperePerSecond is null)
            return null;

        return new ElectricCurrentGradient((double)AmperePerSecond, ElectricCurrentGradientUnit.AmperePerSecond);
    }
    /// <summary>
    /// Get ElectricCurrentGradient from AmperePerMicrosecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AmperePerMicrosecond))]
    public static ElectricCurrentGradient? FromAmperePerMicrosecond(double? AmperePerMicrosecond)
    {
        if (AmperePerMicrosecond is null)
            return null;

        return new ElectricCurrentGradient((double)AmperePerMicrosecond, ElectricCurrentGradientUnit.AmperePerMicrosecond);
    }
    /// <summary>
    /// Get ElectricCurrentGradient from AmperePerMillisecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AmperePerMillisecond))]
    public static ElectricCurrentGradient? FromAmperePerMillisecond(double? AmperePerMillisecond)
    {
        if (AmperePerMillisecond is null)
            return null;

        return new ElectricCurrentGradient((double)AmperePerMillisecond, ElectricCurrentGradientUnit.AmperePerMillisecond);
    }
    /// <summary>
    /// Get ElectricCurrentGradient from AmperePerNanosecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AmperePerNanosecond))]
    public static ElectricCurrentGradient? FromAmperePerNanosecond(double? AmperePerNanosecond)
    {
        if (AmperePerNanosecond is null)
            return null;

        return new ElectricCurrentGradient((double)AmperePerNanosecond, ElectricCurrentGradientUnit.AmperePerNanosecond);
    }
}