using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class HeatTransferCoefficient
{  

/// <summary>
/// Get HeatTransferCoefficient from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static HeatTransferCoefficient FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new HeatTransferCoefficient((double)SI, HeatTransferCoefficientUnit.SI);
}

/// <summary>
/// Get HeatTransferCoefficient from WattPerSquareMeterKelvin.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static HeatTransferCoefficient FromWattPerSquareMeterKelvin(double? WattPerSquareMeterKelvin)
{
    if (WattPerSquareMeterKelvin is null)
        return null;

    return new HeatTransferCoefficient((double)WattPerSquareMeterKelvin, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
}

/// <summary>
/// Get HeatTransferCoefficient from WattPerSquareMeterCelsius.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static HeatTransferCoefficient FromWattPerSquareMeterCelsius(double? WattPerSquareMeterCelsius)
{
    if (WattPerSquareMeterCelsius is null)
        return null;

    return new HeatTransferCoefficient((double)WattPerSquareMeterCelsius, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);
}

/// <summary>
/// Get HeatTransferCoefficient from BtuPerSquareFootDegreeFahrenheit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static HeatTransferCoefficient FromBtuPerSquareFootDegreeFahrenheit(double? BtuPerSquareFootDegreeFahrenheit)
{
    if (BtuPerSquareFootDegreeFahrenheit is null)
        return null;

    return new HeatTransferCoefficient((double)BtuPerSquareFootDegreeFahrenheit, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
}


}                     