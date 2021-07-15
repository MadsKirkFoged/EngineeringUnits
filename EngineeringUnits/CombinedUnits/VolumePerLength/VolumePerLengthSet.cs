using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class VolumePerLength
    {
        /// <summary>
        ///     Get VolumePerLength from CubicMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicMetersPerMeter(double cubicmeterspermeter)
        {
            double value = (double)cubicmeterspermeter;
            return new VolumePerLength(value, VolumePerLengthUnit.CubicMeterPerMeter);
        }
        /// <summary>
        ///     Get VolumePerLength from CubicYardsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicYardsPerFoot(double cubicyardsperfoot)
        {
            double value = (double)cubicyardsperfoot;
            return new VolumePerLength(value, VolumePerLengthUnit.CubicYardPerFoot);
        }
        /// <summary>
        ///     Get VolumePerLength from CubicYardsPerUsSurveyFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicYardsPerUsSurveyFoot(double cubicyardsperussurveyfoot)
        {
            double value = (double)cubicyardsperussurveyfoot;
            return new VolumePerLength(value, VolumePerLengthUnit.CubicYardPerUsSurveyFoot);
        }
        /// <summary>
        ///     Get VolumePerLength from LitersPerKilometer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerKilometer(double litersperkilometer)
        {
            double value = (double)litersperkilometer;
            return new VolumePerLength(value, VolumePerLengthUnit.LiterPerKilometer);
        }
        /// <summary>
        ///     Get VolumePerLength from LitersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerMeter(double literspermeter)
        {
            double value = (double)literspermeter;
            return new VolumePerLength(value, VolumePerLengthUnit.LiterPerMeter);
        }
        /// <summary>
        ///     Get VolumePerLength from LitersPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerMillimeter(double literspermillimeter)
        {
            double value = (double)literspermillimeter;
            return new VolumePerLength(value, VolumePerLengthUnit.LiterPerMillimeter);
        }
        /// <summary>
        ///     Get VolumePerLength from OilBarrelsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromOilBarrelsPerFoot(double oilbarrelsperfoot)
        {
            double value = (double)oilbarrelsperfoot;
            return new VolumePerLength(value, VolumePerLengthUnit.OilBarrelPerFoot);
        }

    }
}
