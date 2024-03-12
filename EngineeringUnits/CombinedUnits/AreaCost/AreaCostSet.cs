using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class AreaCost
{  

/// <summary>
/// Get AreaCost from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaCost? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new AreaCost((double)SI, AreaCostUnit.SI);
}                     
/// <summary>
/// Get AreaCost from USDollarPerSquareMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaCost? FromUSDollarPerSquareMeter(double? USDollarPerSquareMeter)
{
    if (USDollarPerSquareMeter is null)
        return null;

    return new AreaCost((double)USDollarPerSquareMeter, AreaCostUnit.USDollarPerSquareMeter);
}                     
/// <summary>
/// Get AreaCost from MillionUSDollarPerSquareMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaCost? FromMillionUSDollarPerSquareMeter(double? MillionUSDollarPerSquareMeter)
{
    if (MillionUSDollarPerSquareMeter is null)
        return null;

    return new AreaCost((double)MillionUSDollarPerSquareMeter, AreaCostUnit.MillionUSDollarPerSquareMeter);
}                     
/// <summary>
/// Get AreaCost from EuroPerSquareMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaCost? FromEuroPerSquareMeter(double? EuroPerSquareMeter)
{
    if (EuroPerSquareMeter is null)
        return null;

    return new AreaCost((double)EuroPerSquareMeter, AreaCostUnit.EuroPerSquareMeter);
}                     

}                     