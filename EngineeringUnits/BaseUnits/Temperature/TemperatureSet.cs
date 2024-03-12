using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Temperature
{  

/// <summary>
/// Get Temperature from Kelvin.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Kelvin))]
public static Temperature? FromKelvin(double? Kelvin)
{
    if (Kelvin is null)
        return null;

    return new Temperature((double)Kelvin, TemperatureUnit.Kelvin);
}                     
/// <summary>
/// Get Temperature from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static Temperature? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Temperature((double)SI, TemperatureUnit.SI);
}                     
/// <summary>
/// Get Temperature from DegreeCelsius.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DegreeCelsius))]
public static Temperature? FromDegreeCelsius(double? DegreeCelsius)
{
    if (DegreeCelsius is null)
        return null;

    return new Temperature((double)DegreeCelsius, TemperatureUnit.DegreeCelsius);
}                     
/// <summary>
/// Get Temperature from DegreeFahrenheit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DegreeFahrenheit))]
public static Temperature? FromDegreeFahrenheit(double? DegreeFahrenheit)
{
    if (DegreeFahrenheit is null)
        return null;

    return new Temperature((double)DegreeFahrenheit, TemperatureUnit.DegreeFahrenheit);
}                     
/// <summary>
/// Get Temperature from DegreeRankine.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(DegreeRankine))]
public static Temperature? FromDegreeRankine(double? DegreeRankine)
{
    if (DegreeRankine is null)
        return null;

    return new Temperature((double)DegreeRankine, TemperatureUnit.DegreeRankine);
}                     

}                     