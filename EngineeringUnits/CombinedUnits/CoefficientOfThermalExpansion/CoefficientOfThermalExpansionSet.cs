using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class CoefficientOfThermalExpansion
{  

/// <summary>
/// Get CoefficientOfThermalExpansion from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static CoefficientOfThermalExpansion? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new CoefficientOfThermalExpansion((double)SI, CoefficientOfThermalExpansionUnit.SI);
}                     
/// <summary>
/// Get CoefficientOfThermalExpansion from InverseKelvin.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(InverseKelvin))]
public static CoefficientOfThermalExpansion? FromInverseKelvin(double? InverseKelvin)
{
    if (InverseKelvin is null)
        return null;

    return new CoefficientOfThermalExpansion((double)InverseKelvin, CoefficientOfThermalExpansionUnit.InverseKelvin);
}                     
/// <summary>
/// Get CoefficientOfThermalExpansion from InverseDegreeFahrenheit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(InverseDegreeFahrenheit))]
public static CoefficientOfThermalExpansion? FromInverseDegreeFahrenheit(double? InverseDegreeFahrenheit)
{
    if (InverseDegreeFahrenheit is null)
        return null;

    return new CoefficientOfThermalExpansion((double)InverseDegreeFahrenheit, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
}                     
/// <summary>
/// Get CoefficientOfThermalExpansion from InverseDegreeCelsius.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(InverseDegreeCelsius))]
public static CoefficientOfThermalExpansion? FromInverseDegreeCelsius(double? InverseDegreeCelsius)
{
    if (InverseDegreeCelsius is null)
        return null;

    return new CoefficientOfThermalExpansion((double)InverseDegreeCelsius, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);
}                     

}                     