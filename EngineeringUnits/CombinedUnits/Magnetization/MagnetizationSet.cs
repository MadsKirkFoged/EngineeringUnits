using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Magnetization
{  

/// <summary>
/// Get Magnetization from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Magnetization FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Magnetization((double)SI, MagnetizationUnit.SI);
}

/// <summary>
/// Get Magnetization from AmperePerMeter.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Magnetization FromAmperePerMeter(double? AmperePerMeter)
{
    if (AmperePerMeter is null)
        return null;

    return new Magnetization((double)AmperePerMeter, MagnetizationUnit.AmperePerMeter);
}


}                     