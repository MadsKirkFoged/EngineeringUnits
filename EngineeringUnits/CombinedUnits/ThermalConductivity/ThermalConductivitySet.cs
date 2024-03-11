using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ThermalConductivity
{  

/// <summary>
/// Get ThermalConductivity from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ThermalConductivity FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ThermalConductivity((double)SI, ThermalConductivityUnit.SI);
}                     
/// <summary>
/// Get ThermalConductivity from WattPerMeterKelvin.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ThermalConductivity FromWattPerMeterKelvin(double? WattPerMeterKelvin)
{
    if (WattPerMeterKelvin is null)
        return null;

    return new ThermalConductivity((double)WattPerMeterKelvin, ThermalConductivityUnit.WattPerMeterKelvin);
}                     
/// <summary>
/// Get ThermalConductivity from BtuPerHourFootFahrenheit.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ThermalConductivity FromBtuPerHourFootFahrenheit(double? BtuPerHourFootFahrenheit)
{
    if (BtuPerHourFootFahrenheit is null)
        return null;

    return new ThermalConductivity((double)BtuPerHourFootFahrenheit, ThermalConductivityUnit.BtuPerHourFootFahrenheit);
}                     

}                     