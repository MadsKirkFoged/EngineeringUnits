using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class LengthCost
{

    /// <summary>
    /// Get LengthCost from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static LengthCost? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new LengthCost((double)SI, LengthCostUnit.SI);
    }
    /// <summary>
    /// Get LengthCost from USDollarPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerMeter))]
    public static LengthCost? FromUSDollarPerMeter(double? USDollarPerMeter)
    {
        if (USDollarPerMeter is null)
            return null;
        
        return new LengthCost((double)USDollarPerMeter, LengthCostUnit.USDollarPerMeter);
    }
    /// <summary>
    /// Get LengthCost from EuroPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(EuroPerMeter))]
    public static LengthCost? FromEuroPerMeter(double? EuroPerMeter)
    {
        if (EuroPerMeter is null)
            return null;
        
        return new LengthCost((double)EuroPerMeter, LengthCostUnit.EuroPerMeter);
    }

}