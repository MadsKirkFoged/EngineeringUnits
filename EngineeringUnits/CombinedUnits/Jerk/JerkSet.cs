using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Jerk
{

    /// <summary>
    /// Get Jerk from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Jerk? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Jerk((double)SI, JerkUnit.SI);
    }
    /// <summary>
    /// Get Jerk from KilometerPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilometerPerSecondCubed))]
    public static Jerk? FromKilometerPerSecondCubed(double? KilometerPerSecondCubed)
    {
        if (KilometerPerSecondCubed is null)
            return null;
        
        return new Jerk((double)KilometerPerSecondCubed, JerkUnit.KilometerPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from MeterPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MeterPerSecondCubed))]
    public static Jerk? FromMeterPerSecondCubed(double? MeterPerSecondCubed)
    {
        if (MeterPerSecondCubed is null)
            return null;
        
        return new Jerk((double)MeterPerSecondCubed, JerkUnit.MeterPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from DecimeterPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecimeterPerSecondCubed))]
    public static Jerk? FromDecimeterPerSecondCubed(double? DecimeterPerSecondCubed)
    {
        if (DecimeterPerSecondCubed is null)
            return null;
        
        return new Jerk((double)DecimeterPerSecondCubed, JerkUnit.DecimeterPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from CentimeterPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentimeterPerSecondCubed))]
    public static Jerk? FromCentimeterPerSecondCubed(double? CentimeterPerSecondCubed)
    {
        if (CentimeterPerSecondCubed is null)
            return null;
        
        return new Jerk((double)CentimeterPerSecondCubed, JerkUnit.CentimeterPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from MicrometerPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrometerPerSecondCubed))]
    public static Jerk? FromMicrometerPerSecondCubed(double? MicrometerPerSecondCubed)
    {
        if (MicrometerPerSecondCubed is null)
            return null;
        
        return new Jerk((double)MicrometerPerSecondCubed, JerkUnit.MicrometerPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from MillimeterPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MillimeterPerSecondCubed))]
    public static Jerk? FromMillimeterPerSecondCubed(double? MillimeterPerSecondCubed)
    {
        if (MillimeterPerSecondCubed is null)
            return null;
        
        return new Jerk((double)MillimeterPerSecondCubed, JerkUnit.MillimeterPerSecondCubed);
    }
    /// <summary>
    /// Get Jerk from NanometerPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanometerPerSecondCubed))]
    public static Jerk? FromNanometerPerSecondCubed(double? NanometerPerSecondCubed)
    {
        if (NanometerPerSecondCubed is null)
            return null;
        
        return new Jerk((double)NanometerPerSecondCubed, JerkUnit.NanometerPerSecondCubed);
    }

}