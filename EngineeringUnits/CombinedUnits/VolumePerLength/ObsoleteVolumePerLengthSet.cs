using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class VolumePerLength
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static VolumePerLength FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new VolumePerLength(value, VolumePerLengthUnit.SI);
    //}

    /// <summary>
    ///     Get VolumePerLength from CubicMetersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMetersPerMeter->FromCubicMeterPerMeter")]
    public static VolumePerLength FromCubicMetersPerMeter(double cubicmeterspermeter)
    {
        var value = (double)cubicmeterspermeter;
        return new VolumePerLength(value, VolumePerLengthUnit.CubicMeterPerMeter);
    }
    /// <summary>
    ///     Get VolumePerLength from CubicYardsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerFoot->FromCubicYardPerFoot")]
    public static VolumePerLength FromCubicYardsPerFoot(double cubicyardsperfoot)
    {
        var value = (double)cubicyardsperfoot;
        return new VolumePerLength(value, VolumePerLengthUnit.CubicYardPerFoot);
    }
    /// <summary>
    ///     Get VolumePerLength from CubicYardsPerUsSurveyFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerUsSurveyFoot->FromCubicYardPerUsSurveyFoot")]
    public static VolumePerLength FromCubicYardsPerUsSurveyFoot(double cubicyardsperussurveyfoot)
    {
        var value = (double)cubicyardsperussurveyfoot;
        return new VolumePerLength(value, VolumePerLengthUnit.CubicYardPerUsSurveyFoot);
    }
    /// <summary>
    ///     Get VolumePerLength from LitersPerKilometer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerKilometer->FromLiterPerKilometer")]
    public static VolumePerLength FromLitersPerKilometer(double litersperkilometer)
    {
        var value = (double)litersperkilometer;
        return new VolumePerLength(value, VolumePerLengthUnit.LiterPerKilometer);
    }
    /// <summary>
    ///     Get VolumePerLength from LitersPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerMeter->FromLiterPerMeter")]
    public static VolumePerLength FromLitersPerMeter(double literspermeter)
    {
        var value = (double)literspermeter;
        return new VolumePerLength(value, VolumePerLengthUnit.LiterPerMeter);
    }
    /// <summary>
    ///     Get VolumePerLength from LitersPerMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerMillimeter->FromLiterPerMillimeter")]
    public static VolumePerLength FromLitersPerMillimeter(double literspermillimeter)
    {
        var value = (double)literspermillimeter;
        return new VolumePerLength(value, VolumePerLengthUnit.LiterPerMillimeter);
    }
    /// <summary>
    ///     Get VolumePerLength from OilBarrelsPerFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOilBarrelsPerFoot->FromOilBarrelPerFoot")]
    public static VolumePerLength FromOilBarrelsPerFoot(double oilbarrelsperfoot)
    {
        var value = (double)oilbarrelsperfoot;
        return new VolumePerLength(value, VolumePerLengthUnit.OilBarrelPerFoot);
    }
}
