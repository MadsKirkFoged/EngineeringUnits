using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricSurfaceChargeDensity
{

    /// <summary>
    /// Get ElectricSurfaceChargeDensity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ElectricSurfaceChargeDensity? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new ElectricSurfaceChargeDensity((double)SI, ElectricSurfaceChargeDensityUnit.SI);
    }
    /// <summary>
    /// Get ElectricSurfaceChargeDensity from CoulombPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CoulombPerSquareMeter))]
    public static ElectricSurfaceChargeDensity? FromCoulombPerSquareMeter(double? CoulombPerSquareMeter)
    {
        if (CoulombPerSquareMeter is null)
            return null;
        
        return new ElectricSurfaceChargeDensity((double)CoulombPerSquareMeter, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);
    }
    /// <summary>
    /// Get ElectricSurfaceChargeDensity from CoulombPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CoulombPerSquareCentimeter))]
    public static ElectricSurfaceChargeDensity? FromCoulombPerSquareCentimeter(double? CoulombPerSquareCentimeter)
    {
        if (CoulombPerSquareCentimeter is null)
            return null;
        
        return new ElectricSurfaceChargeDensity((double)CoulombPerSquareCentimeter, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);
    }
    /// <summary>
    /// Get ElectricSurfaceChargeDensity from CoulombPerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CoulombPerSquareInch))]
    public static ElectricSurfaceChargeDensity? FromCoulombPerSquareInch(double? CoulombPerSquareInch)
    {
        if (CoulombPerSquareInch is null)
            return null;
        
        return new ElectricSurfaceChargeDensity((double)CoulombPerSquareInch, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);
    }

}