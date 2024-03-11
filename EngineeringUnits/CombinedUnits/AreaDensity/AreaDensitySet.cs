using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class AreaDensity
{  

/// <summary>
/// Get AreaDensity from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaDensity FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new AreaDensity((double)SI, AreaDensityUnit.SI);
}

/// <summary>
/// Get AreaDensity from KilogramPerSquareMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static AreaDensity FromKilogramPerSquareMeter(double? KilogramPerSquareMeter)
{
    if (KilogramPerSquareMeter is null)
        return null;

    return new AreaDensity((double)KilogramPerSquareMeter, AreaDensityUnit.KilogramPerSquareMeter);
}


}                     