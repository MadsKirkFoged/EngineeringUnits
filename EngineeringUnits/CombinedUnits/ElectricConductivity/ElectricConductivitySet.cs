using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricConductivity
{  

/// <summary>
/// Get ElectricConductivity from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricConductivity? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ElectricConductivity((double)SI, ElectricConductivityUnit.SI);
}                     
/// <summary>
/// Get ElectricConductivity from SiemensPerMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricConductivity? FromSiemensPerMeter(double? SiemensPerMeter)
{
    if (SiemensPerMeter is null)
        return null;

    return new ElectricConductivity((double)SiemensPerMeter, ElectricConductivityUnit.SiemensPerMeter);
}                     
/// <summary>
/// Get ElectricConductivity from SiemensPerInch.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricConductivity? FromSiemensPerInch(double? SiemensPerInch)
{
    if (SiemensPerInch is null)
        return null;

    return new ElectricConductivity((double)SiemensPerInch, ElectricConductivityUnit.SiemensPerInch);
}                     
/// <summary>
/// Get ElectricConductivity from SiemensPerFoot.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ElectricConductivity? FromSiemensPerFoot(double? SiemensPerFoot)
{
    if (SiemensPerFoot is null)
        return null;

    return new ElectricConductivity((double)SiemensPerFoot, ElectricConductivityUnit.SiemensPerFoot);
}                     

}                     