using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MagneticFlux
{  

/// <summary>
/// Get MagneticFlux from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MagneticFlux FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new MagneticFlux((double)SI, MagneticFluxUnit.SI);
}                     
/// <summary>
/// Get MagneticFlux from Weber.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MagneticFlux FromWeber(double? Weber)
{
    if (Weber is null)
        return null;

    return new MagneticFlux((double)Weber, MagneticFluxUnit.Weber);
}                     

}                     