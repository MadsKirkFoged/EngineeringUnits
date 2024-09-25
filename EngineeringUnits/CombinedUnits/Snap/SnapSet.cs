using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class Snap
{

    /// <summary>
    /// Get Snap from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Snap? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Snap((double)SI, SnapUnit.SI);
    }
    /// <summary>
    /// Get Snap from KilometerPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilometerPerSecond4))]
    public static Snap? FromKilometerPerSecond4(double? KilometerPerSecond4)
    {
        if (KilometerPerSecond4 is null)
            return null;
        
        return new Snap((double)KilometerPerSecond4, SnapUnit.KilometerPerSecond4);
    }
    /// <summary>
    /// Get Snap from MeterPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MeterPerSecond4))]
    public static Snap? FromMeterPerSecond4(double? MeterPerSecond4)
    {
        if (MeterPerSecond4 is null)
            return null;
        
        return new Snap((double)MeterPerSecond4, SnapUnit.MeterPerSecond4);
    }
    /// <summary>
    /// Get Snap from DecimeterPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecimeterPerSecond4))]
    public static Snap? FromDecimeterPerSecond4(double? DecimeterPerSecond4)
    {
        if (DecimeterPerSecond4 is null)
            return null;
        
        return new Snap((double)DecimeterPerSecond4, SnapUnit.DecimeterPerSecond4);
    }
    /// <summary>
    /// Get Snap from CentimeterPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentimeterPerSecond4))]
    public static Snap? FromCentimeterPerSecond4(double? CentimeterPerSecond4)
    {
        if (CentimeterPerSecond4 is null)
            return null;
        
        return new Snap((double)CentimeterPerSecond4, SnapUnit.CentimeterPerSecond4);
    }
    /// <summary>
    /// Get Snap from MicrometerPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrometerPerSecond4))]
    public static Snap? FromMicrometerPerSecond4(double? MicrometerPerSecond4)
    {
        if (MicrometerPerSecond4 is null)
            return null;
        
        return new Snap((double)MicrometerPerSecond4, SnapUnit.MicrometerPerSecond4);
    }
    /// <summary>
    /// Get Snap from MillimeterPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MillimeterPerSecond4))]
    public static Snap? FromMillimeterPerSecond4(double? MillimeterPerSecond4)
    {
        if (MillimeterPerSecond4 is null)
            return null;
        
        return new Snap((double)MillimeterPerSecond4, SnapUnit.MillimeterPerSecond4);
    }
    /// <summary>
    /// Get Snap from NanometerPerSecond4.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanometerPerSecond4))]
    public static Snap? FromNanometerPerSecond4(double? NanometerPerSecond4)
    {
        if (NanometerPerSecond4 is null)
            return null;
        
        return new Snap((double)NanometerPerSecond4, SnapUnit.NanometerPerSecond4);
    }

}