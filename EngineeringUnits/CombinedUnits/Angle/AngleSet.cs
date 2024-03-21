using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Angle
{

    /// <summary>
    /// Get Angle from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Angle? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Angle((double)SI, AngleUnit.SI);
    }
    /// <summary>
    /// Get Angle from Arcminute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Arcminute))]
    public static Angle? FromArcminute(double? Arcminute)
    {
        if (Arcminute is null)
            return null;
        
        return new Angle((double)Arcminute, AngleUnit.Arcminute);
    }
    /// <summary>
    /// Get Angle from Arcsecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Arcsecond))]
    public static Angle? FromArcsecond(double? Arcsecond)
    {
        if (Arcsecond is null)
            return null;
        
        return new Angle((double)Arcsecond, AngleUnit.Arcsecond);
    }
    /// <summary>
    /// Get Angle from Gradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gradian))]
    public static Angle? FromGradian(double? Gradian)
    {
        if (Gradian is null)
            return null;
        
        return new Angle((double)Gradian, AngleUnit.Gradian);
    }
    /// <summary>
    /// Get Angle from Radian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Radian))]
    public static Angle? FromRadian(double? Radian)
    {
        if (Radian is null)
            return null;
        
        return new Angle((double)Radian, AngleUnit.Radian);
    }
    /// <summary>
    /// Get Angle from Centiradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Centiradian))]
    public static Angle? FromCentiradian(double? Centiradian)
    {
        if (Centiradian is null)
            return null;
        
        return new Angle((double)Centiradian, AngleUnit.Centiradian);
    }
    /// <summary>
    /// Get Angle from Deciradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Deciradian))]
    public static Angle? FromDeciradian(double? Deciradian)
    {
        if (Deciradian is null)
            return null;
        
        return new Angle((double)Deciradian, AngleUnit.Deciradian);
    }
    /// <summary>
    /// Get Angle from Microradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microradian))]
    public static Angle? FromMicroradian(double? Microradian)
    {
        if (Microradian is null)
            return null;
        
        return new Angle((double)Microradian, AngleUnit.Microradian);
    }
    /// <summary>
    /// Get Angle from Milliradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Milliradian))]
    public static Angle? FromMilliradian(double? Milliradian)
    {
        if (Milliradian is null)
            return null;
        
        return new Angle((double)Milliradian, AngleUnit.Milliradian);
    }
    /// <summary>
    /// Get Angle from Nanoradian.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanoradian))]
    public static Angle? FromNanoradian(double? Nanoradian)
    {
        if (Nanoradian is null)
            return null;
        
        return new Angle((double)Nanoradian, AngleUnit.Nanoradian);
    }
    /// <summary>
    /// Get Angle from Degree.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Degree))]
    public static Angle? FromDegree(double? Degree)
    {
        if (Degree is null)
            return null;
        
        return new Angle((double)Degree, AngleUnit.Degree);
    }
    /// <summary>
    /// Get Angle from Microdegree.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microdegree))]
    public static Angle? FromMicrodegree(double? Microdegree)
    {
        if (Microdegree is null)
            return null;
        
        return new Angle((double)Microdegree, AngleUnit.Microdegree);
    }
    /// <summary>
    /// Get Angle from Millidegree.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Millidegree))]
    public static Angle? FromMillidegree(double? Millidegree)
    {
        if (Millidegree is null)
            return null;
        
        return new Angle((double)Millidegree, AngleUnit.Millidegree);
    }
    /// <summary>
    /// Get Angle from Nanodegree.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanodegree))]
    public static Angle? FromNanodegree(double? Nanodegree)
    {
        if (Nanodegree is null)
            return null;
        
        return new Angle((double)Nanodegree, AngleUnit.Nanodegree);
    }
    /// <summary>
    /// Get Angle from Revolution.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Revolution))]
    public static Angle? FromRevolution(double? Revolution)
    {
        if (Revolution is null)
            return null;
        
        return new Angle((double)Revolution, AngleUnit.Revolution);
    }

}