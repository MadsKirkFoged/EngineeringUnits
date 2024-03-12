using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ReactiveEnergy
{  

/// <summary>
/// Get ReactiveEnergy from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ReactiveEnergy? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ReactiveEnergy((double)SI, ReactiveEnergyUnit.SI);
}                     
/// <summary>
/// Get ReactiveEnergy from VoltampereReactiveHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ReactiveEnergy? FromVoltampereReactiveHour(double? VoltampereReactiveHour)
{
    if (VoltampereReactiveHour is null)
        return null;

    return new ReactiveEnergy((double)VoltampereReactiveHour, ReactiveEnergyUnit.VoltampereReactiveHour);
}                     
/// <summary>
/// Get ReactiveEnergy from MegavoltampereReactiveHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ReactiveEnergy? FromMegavoltampereReactiveHour(double? MegavoltampereReactiveHour)
{
    if (MegavoltampereReactiveHour is null)
        return null;

    return new ReactiveEnergy((double)MegavoltampereReactiveHour, ReactiveEnergyUnit.MegavoltampereReactiveHour);
}                     
/// <summary>
/// Get ReactiveEnergy from KilovoltampereReactiveHour.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static ReactiveEnergy? FromKilovoltampereReactiveHour(double? KilovoltampereReactiveHour)
{
    if (KilovoltampereReactiveHour is null)
        return null;

    return new ReactiveEnergy((double)KilovoltampereReactiveHour, ReactiveEnergyUnit.KilovoltampereReactiveHour);
}                     

}                     