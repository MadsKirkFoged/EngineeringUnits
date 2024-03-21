using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class PowerCost
{

    /// <summary>
    /// Get PowerCost from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static PowerCost? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new PowerCost((double)SI, PowerCostUnit.SI);
    }
    /// <summary>
    /// Get PowerCost from USDollarPerKilowatt.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerKilowatt))]
    public static PowerCost? FromUSDollarPerKilowatt(double? USDollarPerKilowatt)
    {
        if (USDollarPerKilowatt is null)
            return null;
        
        return new PowerCost((double)USDollarPerKilowatt, PowerCostUnit.USDollarPerKilowatt);
    }
    /// <summary>
    /// Get PowerCost from USDollarPerWatt.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(USDollarPerWatt))]
    public static PowerCost? FromUSDollarPerWatt(double? USDollarPerWatt)
    {
        if (USDollarPerWatt is null)
            return null;
        
        return new PowerCost((double)USDollarPerWatt, PowerCostUnit.USDollarPerWatt);
    }

}