using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricInductance
{

    /// <summary>
    /// Get ElectricInductance from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ElectricInductance? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new ElectricInductance((double)SI, ElectricInductanceUnit.SI);
    }
    /// <summary>
    /// Get ElectricInductance from Henry.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Henry))]
    public static ElectricInductance? FromHenry(double? Henry)
    {
        if (Henry is null)
            return null;
        
        return new ElectricInductance((double)Henry, ElectricInductanceUnit.Henry);
    }
    /// <summary>
    /// Get ElectricInductance from Microhenry.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microhenry))]
    public static ElectricInductance? FromMicrohenry(double? Microhenry)
    {
        if (Microhenry is null)
            return null;
        
        return new ElectricInductance((double)Microhenry, ElectricInductanceUnit.Microhenry);
    }
    /// <summary>
    /// Get ElectricInductance from Millihenry.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Millihenry))]
    public static ElectricInductance? FromMillihenry(double? Millihenry)
    {
        if (Millihenry is null)
            return null;
        
        return new ElectricInductance((double)Millihenry, ElectricInductanceUnit.Millihenry);
    }
    /// <summary>
    /// Get ElectricInductance from Nanohenry.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanohenry))]
    public static ElectricInductance? FromNanohenry(double? Nanohenry)
    {
        if (Nanohenry is null)
            return null;
        
        return new ElectricInductance((double)Nanohenry, ElectricInductanceUnit.Nanohenry);
    }

}