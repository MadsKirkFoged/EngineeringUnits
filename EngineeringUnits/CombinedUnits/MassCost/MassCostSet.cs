using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MassCost
{  

/// <summary>
/// Get MassCost from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static MassCost? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new MassCost((double)SI, MassCostUnit.SI);
}                     
/// <summary>
/// Get MassCost from EuroPerKilogram.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(EuroPerKilogram))]
public static MassCost? FromEuroPerKilogram(double? EuroPerKilogram)
{
    if (EuroPerKilogram is null)
        return null;

    return new MassCost((double)EuroPerKilogram, MassCostUnit.EuroPerKilogram);
}                     
/// <summary>
/// Get MassCost from USDollarPerKilogram.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(USDollarPerKilogram))]
public static MassCost? FromUSDollarPerKilogram(double? USDollarPerKilogram)
{
    if (USDollarPerKilogram is null)
        return null;

    return new MassCost((double)USDollarPerKilogram, MassCostUnit.USDollarPerKilogram);
}                     
/// <summary>
/// Get MassCost from USDollarPerTonne.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(USDollarPerTonne))]
public static MassCost? FromUSDollarPerTonne(double? USDollarPerTonne)
{
    if (USDollarPerTonne is null)
        return null;

    return new MassCost((double)USDollarPerTonne, MassCostUnit.USDollarPerTonne);
}                     
/// <summary>
/// Get MassCost from MillionUSDollarPerTonne.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(MillionUSDollarPerTonne))]
public static MassCost? FromMillionUSDollarPerTonne(double? MillionUSDollarPerTonne)
{
    if (MillionUSDollarPerTonne is null)
        return null;

    return new MassCost((double)MillionUSDollarPerTonne, MassCostUnit.MillionUSDollarPerTonne);
}                     

}                     