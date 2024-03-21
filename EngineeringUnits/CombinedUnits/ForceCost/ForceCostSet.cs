using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class ForceCost
{

    /// <summary>
    /// Get ForceCost from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ForceCost? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new ForceCost((double)SI, ForceCostUnit.SI);
    }
    /// <summary>
    /// Get ForceCost from USDollarPerNewton.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerNewton))]
    public static ForceCost? FromUSDollarPerNewton(double? USDollarPerNewton)
    {
        if (USDollarPerNewton is null)
            return null;
        
        return new ForceCost((double)USDollarPerNewton, ForceCostUnit.USDollarPerNewton);
    }
    /// <summary>
    /// Get ForceCost from USDollarPerKilonewton.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerKilonewton))]
    public static ForceCost? FromUSDollarPerKilonewton(double? USDollarPerKilonewton)
    {
        if (USDollarPerKilonewton is null)
            return null;
        
        return new ForceCost((double)USDollarPerKilonewton, ForceCostUnit.USDollarPerKilonewton);
    }
    /// <summary>
    /// Get ForceCost from USDollarPerMeganewton.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerMeganewton))]
    public static ForceCost? FromUSDollarPerMeganewton(double? USDollarPerMeganewton)
    {
        if (USDollarPerMeganewton is null)
            return null;
        
        return new ForceCost((double)USDollarPerMeganewton, ForceCostUnit.USDollarPerMeganewton);
    }

}