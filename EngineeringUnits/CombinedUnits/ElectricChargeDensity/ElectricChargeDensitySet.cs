using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricChargeDensity
{  

/// <summary>
/// Get ElectricChargeDensity from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricChargeDensity FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ElectricChargeDensity((double)SI, ElectricChargeDensityUnit.SI);
}

/// <summary>
/// Get ElectricChargeDensity from CoulombPerCubicMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricChargeDensity FromCoulombPerCubicMeter(double? CoulombPerCubicMeter)
{
    if (CoulombPerCubicMeter is null)
        return null;

    return new ElectricChargeDensity((double)CoulombPerCubicMeter, ElectricChargeDensityUnit.CoulombPerCubicMeter);
}


}                     