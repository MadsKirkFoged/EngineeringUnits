using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LapseRate
{  

/// <summary>
/// Get LapseRate from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static LapseRate FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new LapseRate((double)SI, LapseRateUnit.SI);
}                     
/// <summary>
/// Get LapseRate from DegreeCelsiusPerKilometer.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static LapseRate FromDegreeCelsiusPerKilometer(double? DegreeCelsiusPerKilometer)
{
    if (DegreeCelsiusPerKilometer is null)
        return null;

    return new LapseRate((double)DegreeCelsiusPerKilometer, LapseRateUnit.DegreeCelsiusPerKilometer);
}                     

}                     