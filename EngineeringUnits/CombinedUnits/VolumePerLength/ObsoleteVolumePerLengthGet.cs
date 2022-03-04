using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class VolumePerLength
    {
        /// <summary>
        ///     Get VolumePerLength in CubicMetersPerMeter.
        /// </summary>
        [Obsolete("Use without the 's' - CubicMetersPerMeter->CubicMeterPerMeter")]
        public double CubicMetersPerMeter => As(VolumePerLengthUnit.CubicMeterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in SI unit (CubicMetersPerMeter).
        /// </summary>
        //public double SI => As(VolumePerLengthUnit.SI);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerFoot.
        /// </summary>
        [Obsolete("Use without the 's' - CubicYardsPerFoot->CubicYardPerFoot")]
        public double CubicYardsPerFoot => As(VolumePerLengthUnit.CubicYardPerFoot);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerUsSurveyFoot.
        /// </summary>
        [Obsolete("Use without the 's' - CubicYardsPerUsSurveyFoot->CubicYardPerUsSurveyFoot")]
        public double CubicYardsPerUsSurveyFoot => As(VolumePerLengthUnit.CubicYardPerUsSurveyFoot);

        /// <summary>
        ///     Get VolumePerLength in LitersPerKilometer.
        /// </summary>
        [Obsolete("Use without the 's' - LitersPerKilometer->LiterPerKilometer")]
        public double LitersPerKilometer => As(VolumePerLengthUnit.LiterPerKilometer);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMeter.
        /// </summary>
        [Obsolete("Use without the 's' - LitersPerMeter->LiterPerMeter")]
        public double LitersPerMeter => As(VolumePerLengthUnit.LiterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMillimeter.
        /// </summary>
        [Obsolete("Use without the 's' - LitersPerMillimeter->LiterPerMillimeter")]
        public double LitersPerMillimeter => As(VolumePerLengthUnit.LiterPerMillimeter);

        /// <summary>
        ///     Get VolumePerLength in OilBarrelsPerFoot.
        /// </summary>
        [Obsolete("Use without the 's' - OilBarrelsPerFoot->OilBarrelPerFoot")]
        public double OilBarrelsPerFoot => As(VolumePerLengthUnit.OilBarrelPerFoot);

    }
}
