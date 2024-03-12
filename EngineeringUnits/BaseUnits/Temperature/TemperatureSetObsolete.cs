
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Temperature
{

    /// <summary>
    ///     Get Temperature from Kelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static Temperature? FromKelvins(double? Kelvin)
    {
        if (Kelvin is null)
            return null;

        return new Temperature((double)Kelvin, TemperatureUnit.Kelvin);
    }

    /// <summary>
    ///     Get Temperature from DegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static Temperature? FromDegreesCelsius(double? DegreeCelsius)
    {
        if (DegreeCelsius is null)
            return null;

        return new Temperature((double)DegreeCelsius, TemperatureUnit.DegreeCelsius);
    }
    /// <summary>
    ///     Get Temperature from DegreeFahrenheit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static Temperature? FromDegreesFahrenheit(double? DegreeFahrenheit)
    {
        if (DegreeFahrenheit is null)
            return null;

        return new Temperature((double)DegreeFahrenheit, TemperatureUnit.DegreeFahrenheit);
    }
    /// <summary>
    ///     Get Temperature from DegreeRankine.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static Temperature? FromDegreesRankine(double? DegreeRankine)
    {
        if (DegreeRankine is null)
            return null;

        return new Temperature((double)DegreeRankine, TemperatureUnit.DegreeRankine);
    }
}

