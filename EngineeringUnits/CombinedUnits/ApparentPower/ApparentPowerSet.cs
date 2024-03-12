using EngineeringUnits.Units; 
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ApparentPower
{  

/// <summary>
/// Get ApparentPower from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(SI))]
public static ApparentPower? FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new ApparentPower((double)SI, ApparentPowerUnit.SI);
}                     
/// <summary>
/// Get ApparentPower from Voltampere.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Voltampere))]
public static ApparentPower? FromVoltampere(double? Voltampere)
{
    if (Voltampere is null)
        return null;

    return new ApparentPower((double)Voltampere, ApparentPowerUnit.Voltampere);
}                     
/// <summary>
/// Get ApparentPower from Megavoltampere.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Megavoltampere))]
public static ApparentPower? FromMegavoltampere(double? Megavoltampere)
{
    if (Megavoltampere is null)
        return null;

    return new ApparentPower((double)Megavoltampere, ApparentPowerUnit.Megavoltampere);
}                     
/// <summary>
/// Get ApparentPower from Kilovoltampere.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Kilovoltampere))]
public static ApparentPower? FromKilovoltampere(double? Kilovoltampere)
{
    if (Kilovoltampere is null)
        return null;

    return new ApparentPower((double)Kilovoltampere, ApparentPowerUnit.Kilovoltampere);
}                     
/// <summary>
/// Get ApparentPower from Gigavoltampere.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
[return: NotNullIfNotNull(nameof(Gigavoltampere))]
public static ApparentPower? FromGigavoltampere(double? Gigavoltampere)
{
    if (Gigavoltampere is null)
        return null;

    return new ApparentPower((double)Gigavoltampere, ApparentPowerUnit.Gigavoltampere);
}                     

}                     