using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricCurrentDensity
{  

/// <summary>
/// Get ElectricCurrentDensity from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCurrentDensity? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ElectricCurrentDensity((double)SI, ElectricCurrentDensityUnit.SI);
}                     
/// <summary>
/// Get ElectricCurrentDensity from AmperePerSquareMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCurrentDensity? FromAmperePerSquareMeter(double? AmperePerSquareMeter)
{
    if (AmperePerSquareMeter is null)
        return null;

    return new ElectricCurrentDensity((double)AmperePerSquareMeter, ElectricCurrentDensityUnit.AmperePerSquareMeter);
}                     
/// <summary>
/// Get ElectricCurrentDensity from AmperePerSquareInch.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCurrentDensity? FromAmperePerSquareInch(double? AmperePerSquareInch)
{
    if (AmperePerSquareInch is null)
        return null;

    return new ElectricCurrentDensity((double)AmperePerSquareInch, ElectricCurrentDensityUnit.AmperePerSquareInch);
}                     
/// <summary>
/// Get ElectricCurrentDensity from AmperePerSquareFoot.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricCurrentDensity? FromAmperePerSquareFoot(double? AmperePerSquareFoot)
{
    if (AmperePerSquareFoot is null)
        return null;

    return new ElectricCurrentDensity((double)AmperePerSquareFoot, ElectricCurrentDensityUnit.AmperePerSquareFoot);
}                     

}                     