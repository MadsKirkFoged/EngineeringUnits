using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class VolumePerLength
    {
        /// <summary>
        ///     Get VolumePerLength in CubicMetersPerMeter.
        /// </summary>
        public double CubicMetersPerMeter => As(VolumePerLengthUnit.CubicMeterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in SI unit (CubicMetersPerMeter).
        /// </summary>
        public double SI => As(VolumePerLengthUnit.SI);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerFoot.
        /// </summary>
        public double CubicYardsPerFoot => As(VolumePerLengthUnit.CubicYardPerFoot);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerUsSurveyFoot.
        /// </summary>
        public double CubicYardsPerUsSurveyFoot => As(VolumePerLengthUnit.CubicYardPerUsSurveyFoot);

        /// <summary>
        ///     Get VolumePerLength in LitersPerKilometer.
        /// </summary>
        public double LitersPerKilometer => As(VolumePerLengthUnit.LiterPerKilometer);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMeter.
        /// </summary>
        public double LitersPerMeter => As(VolumePerLengthUnit.LiterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMillimeter.
        /// </summary>
        public double LitersPerMillimeter => As(VolumePerLengthUnit.LiterPerMillimeter);

        /// <summary>
        ///     Get VolumePerLength in OilBarrelsPerFoot.
        /// </summary>
        public double OilBarrelsPerFoot => As(VolumePerLengthUnit.OilBarrelPerFoot);

    }
}
