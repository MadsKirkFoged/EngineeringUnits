using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class FuelEfficiency
{  

/// <summary>
/// Get FuelEfficiency from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static FuelEfficiency FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new FuelEfficiency((double)SI, FuelEfficiencyUnit.SI);
}

/// <summary>
/// Get FuelEfficiency from KilometerPerLiter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static FuelEfficiency FromKilometerPerLiter(double? KilometerPerLiter)
{
    if (KilometerPerLiter is null)
        return null;

    return new FuelEfficiency((double)KilometerPerLiter, FuelEfficiencyUnit.KilometerPerLiter);
}

/// <summary>
/// Get FuelEfficiency from MilePerUkGallon.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static FuelEfficiency FromMilePerUkGallon(double? MilePerUkGallon)
{
    if (MilePerUkGallon is null)
        return null;

    return new FuelEfficiency((double)MilePerUkGallon, FuelEfficiencyUnit.MilePerUkGallon);
}

/// <summary>
/// Get FuelEfficiency from MilePerUsGallon.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static FuelEfficiency FromMilePerUsGallon(double? MilePerUsGallon)
{
    if (MilePerUsGallon is null)
        return null;

    return new FuelEfficiency((double)MilePerUsGallon, FuelEfficiencyUnit.MilePerUsGallon);
}


}                     