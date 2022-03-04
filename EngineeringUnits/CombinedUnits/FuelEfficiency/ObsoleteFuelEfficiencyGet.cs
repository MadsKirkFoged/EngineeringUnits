using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class FuelEfficiency
    {
        /// <summary>
        ///     Get FuelEfficiency in KilometersPerLiters.
        /// </summary>
        [Obsolete("Use without the 's' - KilometersPerLiters->KilometerPerLiter")]
        public double KilometersPerLiters => As(FuelEfficiencyUnit.KilometerPerLiter);

        /// <summary>
        ///     Get FuelEfficiency in LitersPer100Kilometers.
        /// </summary>
        //public double LitersPer100Kilometers => As(FuelEfficiencyUnit.LiterPer100Kilometers);

        /// <summary>
        ///     Get FuelEfficiency in MilesPerUkGallon.
        /// </summary>
        [Obsolete("Use without the 's' - MilesPerUkGallon->MilePerUkGallon")]
        public double MilesPerUkGallon => As(FuelEfficiencyUnit.MilePerUkGallon);

        /// <summary>
        ///     Get FuelEfficiency in MilesPerUsGallon.
        /// </summary>
        [Obsolete("Use without the 's' - MilesPerUsGallon->MilePerUsGallon")]
        public double MilesPerUsGallon => As(FuelEfficiencyUnit.MilePerUsGallon);

        /// <summary>
        ///     Get FuelEfficiency in SI Unit.
        /// </summary>
        //public double SI => As(FuelEfficiencyUnit.SI);

    }
}
