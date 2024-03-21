using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class MagneticField
{

    /// <summary>
    /// Get MagneticField from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static MagneticField? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new MagneticField((double)SI, MagneticFieldUnit.SI);
    }
    /// <summary>
    /// Get MagneticField from Tesla.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Tesla))]
    public static MagneticField? FromTesla(double? Tesla)
    {
        if (Tesla is null)
            return null;
        
        return new MagneticField((double)Tesla, MagneticFieldUnit.Tesla);
    }
    /// <summary>
    /// Get MagneticField from Gauss.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gauss))]
    public static MagneticField? FromGauss(double? Gauss)
    {
        if (Gauss is null)
            return null;
        
        return new MagneticField((double)Gauss, MagneticFieldUnit.Gauss);
    }
    /// <summary>
    /// Get MagneticField from Milligauss.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Milligauss))]
    public static MagneticField? FromMilligauss(double? Milligauss)
    {
        if (Milligauss is null)
            return null;
        
        return new MagneticField((double)Milligauss, MagneticFieldUnit.Milligauss);
    }
    /// <summary>
    /// Get MagneticField from Microtesla.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microtesla))]
    public static MagneticField? FromMicrotesla(double? Microtesla)
    {
        if (Microtesla is null)
            return null;
        
        return new MagneticField((double)Microtesla, MagneticFieldUnit.Microtesla);
    }
    /// <summary>
    /// Get MagneticField from Millitesla.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Millitesla))]
    public static MagneticField? FromMillitesla(double? Millitesla)
    {
        if (Millitesla is null)
            return null;
        
        return new MagneticField((double)Millitesla, MagneticFieldUnit.Millitesla);
    }
    /// <summary>
    /// Get MagneticField from Nanotesla.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanotesla))]
    public static MagneticField? FromNanotesla(double? Nanotesla)
    {
        if (Nanotesla is null)
            return null;
        
        return new MagneticField((double)Nanotesla, MagneticFieldUnit.Nanotesla);
    }

}