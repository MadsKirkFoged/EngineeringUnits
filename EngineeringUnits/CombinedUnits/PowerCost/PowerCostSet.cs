using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class PowerCost
{  

/// <summary>
/// Get PowerCost from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static PowerCost FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new PowerCost((double)SI, PowerCostUnit.SI);
}                     
/// <summary>
/// Get PowerCost from USDollarPerKilowatt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static PowerCost FromUSDollarPerKilowatt(double? USDollarPerKilowatt)
{
    if (USDollarPerKilowatt is null)
        return null;

    return new PowerCost((double)USDollarPerKilowatt, PowerCostUnit.USDollarPerKilowatt);
}                     
/// <summary>
/// Get PowerCost from USDollarPerWatt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static PowerCost FromUSDollarPerWatt(double? USDollarPerWatt)
{
    if (USDollarPerWatt is null)
        return null;

    return new PowerCost((double)USDollarPerWatt, PowerCostUnit.USDollarPerWatt);
}                     

}                     