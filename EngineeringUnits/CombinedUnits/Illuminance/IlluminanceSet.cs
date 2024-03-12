using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Illuminance
{  

/// <summary>
/// Get Illuminance from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Illuminance? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Illuminance((double)SI, IlluminanceUnit.SI);
}                     
/// <summary>
/// Get Illuminance from Lux.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Illuminance? FromLux(double? Lux)
{
    if (Lux is null)
        return null;

    return new Illuminance((double)Lux, IlluminanceUnit.Lux);
}                     
/// <summary>
/// Get Illuminance from Kilolux.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Illuminance? FromKilolux(double? Kilolux)
{
    if (Kilolux is null)
        return null;

    return new Illuminance((double)Kilolux, IlluminanceUnit.Kilolux);
}                     
/// <summary>
/// Get Illuminance from Megalux.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Illuminance? FromMegalux(double? Megalux)
{
    if (Megalux is null)
        return null;

    return new Illuminance((double)Megalux, IlluminanceUnit.Megalux);
}                     
/// <summary>
/// Get Illuminance from Millilux.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Illuminance? FromMillilux(double? Millilux)
{
    if (Millilux is null)
        return null;

    return new Illuminance((double)Millilux, IlluminanceUnit.Millilux);
}                     

}                     