using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarFlow
{  

/// <summary>
/// Get MolarFlow from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarFlow FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new MolarFlow((double)SI, MolarFlowUnit.SI);
}                     
/// <summary>
/// Get MolarFlow from MolePerSecond.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static MolarFlow FromMolePerSecond(double? MolePerSecond)
{
    if (MolePerSecond is null)
        return null;

    return new MolarFlow((double)MolePerSecond, MolarFlowUnit.MolePerSecond);
}                     

}                     