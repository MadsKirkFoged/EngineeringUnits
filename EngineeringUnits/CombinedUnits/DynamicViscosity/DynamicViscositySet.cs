using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class DynamicViscosity
{

    /// <summary>
    /// Get DynamicViscosity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static DynamicViscosity? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new DynamicViscosity((double)SI, DynamicViscosityUnit.SI);
    }
    /// <summary>
    /// Get DynamicViscosity from PascalSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PascalSecond))]
    public static DynamicViscosity? FromPascalSecond(double? PascalSecond)
    {
        if (PascalSecond is null)
            return null;
        
        return new DynamicViscosity((double)PascalSecond, DynamicViscosityUnit.PascalSecond);
    }
    /// <summary>
    /// Get DynamicViscosity from MicropascalSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicropascalSecond))]
    public static DynamicViscosity? FromMicropascalSecond(double? MicropascalSecond)
    {
        if (MicropascalSecond is null)
            return null;
        
        return new DynamicViscosity((double)MicropascalSecond, DynamicViscosityUnit.MicropascalSecond);
    }
    /// <summary>
    /// Get DynamicViscosity from MillipascalSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MillipascalSecond))]
    public static DynamicViscosity? FromMillipascalSecond(double? MillipascalSecond)
    {
        if (MillipascalSecond is null)
            return null;
        
        return new DynamicViscosity((double)MillipascalSecond, DynamicViscosityUnit.MillipascalSecond);
    }
    /// <summary>
    /// Get DynamicViscosity from PoundPerFootSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PoundPerFootSecond))]
    public static DynamicViscosity? FromPoundPerFootSecond(double? PoundPerFootSecond)
    {
        if (PoundPerFootSecond is null)
            return null;
        
        return new DynamicViscosity((double)PoundPerFootSecond, DynamicViscosityUnit.PoundPerFootSecond);
    }
    /// <summary>
    /// Get DynamicViscosity from Poise.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Poise))]
    public static DynamicViscosity? FromPoise(double? Poise)
    {
        if (Poise is null)
            return null;
        
        return new DynamicViscosity((double)Poise, DynamicViscosityUnit.Poise);
    }
    /// <summary>
    /// Get DynamicViscosity from Centipoise.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Centipoise))]
    public static DynamicViscosity? FromCentipoise(double? Centipoise)
    {
        if (Centipoise is null)
            return null;
        
        return new DynamicViscosity((double)Centipoise, DynamicViscosityUnit.Centipoise);
    }
    /// <summary>
    /// Get DynamicViscosity from NewtonSecondPerMeterSquared.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NewtonSecondPerMeterSquared))]
    public static DynamicViscosity? FromNewtonSecondPerMeterSquared(double? NewtonSecondPerMeterSquared)
    {
        if (NewtonSecondPerMeterSquared is null)
            return null;
        
        return new DynamicViscosity((double)NewtonSecondPerMeterSquared, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
    }
    /// <summary>
    /// Get DynamicViscosity from PoundForceSecondPerSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PoundForceSecondPerSquareFoot))]
    public static DynamicViscosity? FromPoundForceSecondPerSquareFoot(double? PoundForceSecondPerSquareFoot)
    {
        if (PoundForceSecondPerSquareFoot is null)
            return null;
        
        return new DynamicViscosity((double)PoundForceSecondPerSquareFoot, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
    }
    /// <summary>
    /// Get DynamicViscosity from PoundForceSecondPerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PoundForceSecondPerSquareInch))]
    public static DynamicViscosity? FromPoundForceSecondPerSquareInch(double? PoundForceSecondPerSquareInch)
    {
        if (PoundForceSecondPerSquareInch is null)
            return null;
        
        return new DynamicViscosity((double)PoundForceSecondPerSquareInch, DynamicViscosityUnit.PoundForceSecondPerSquareInch);
    }
    /// <summary>
    /// Get DynamicViscosity from Reyn.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Reyn))]
    public static DynamicViscosity? FromReyn(double? Reyn)
    {
        if (Reyn is null)
            return null;
        
        return new DynamicViscosity((double)Reyn, DynamicViscosityUnit.Reyn);
    }

}