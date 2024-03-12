using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class VolumeCost
{

    /// <summary>
    /// Get VolumeCost from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static VolumeCost? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new VolumeCost((double)SI, VolumeCostUnit.SI);
    }
    /// <summary>
    /// Get VolumeCost from USDollarPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerCubicMeter))]
    public static VolumeCost? FromUSDollarPerCubicMeter(double? USDollarPerCubicMeter)
    {
        if (USDollarPerCubicMeter is null)
            return null;

        return new VolumeCost((double)USDollarPerCubicMeter, VolumeCostUnit.USDollarPerCubicMeter);
    }
    /// <summary>
    /// Get VolumeCost from EuroPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(EuroPerCubicMeter))]
    public static VolumeCost? FromEuroPerCubicMeter(double? EuroPerCubicMeter)
    {
        if (EuroPerCubicMeter is null)
            return null;

        return new VolumeCost((double)EuroPerCubicMeter, VolumeCostUnit.EuroPerCubicMeter);
    }
}