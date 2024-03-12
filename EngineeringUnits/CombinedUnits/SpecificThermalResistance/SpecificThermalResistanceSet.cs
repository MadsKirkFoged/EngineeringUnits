using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class SpecificThermalResistance
{  

/// <summary>
/// Get SpecificThermalResistance from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static SpecificThermalResistance? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new SpecificThermalResistance((double)SI, SpecificThermalResistanceUnit.SI);
}                     
/// <summary>
/// Get SpecificThermalResistance from MeterDegreeCelsiusPerWatt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static SpecificThermalResistance? FromMeterDegreeCelsiusPerWatt(double? MeterDegreeCelsiusPerWatt)
{
    if (MeterDegreeCelsiusPerWatt is null)
        return null;

    return new SpecificThermalResistance((double)MeterDegreeCelsiusPerWatt, SpecificThermalResistanceUnit.MeterDegreeCelsiusPerWatt);
}                     
/// <summary>
/// Get SpecificThermalResistance from MeterKelvinPerKilowatt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static SpecificThermalResistance? FromMeterKelvinPerKilowatt(double? MeterKelvinPerKilowatt)
{
    if (MeterKelvinPerKilowatt is null)
        return null;

    return new SpecificThermalResistance((double)MeterKelvinPerKilowatt, SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
}                     
/// <summary>
/// Get SpecificThermalResistance from CentimeterKelvinPerWatt.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static SpecificThermalResistance? FromCentimeterKelvinPerWatt(double? CentimeterKelvinPerWatt)
{
    if (CentimeterKelvinPerWatt is null)
        return null;

    return new SpecificThermalResistance((double)CentimeterKelvinPerWatt, SpecificThermalResistanceUnit.CentimeterKelvinPerWatt);
}                     

}                     