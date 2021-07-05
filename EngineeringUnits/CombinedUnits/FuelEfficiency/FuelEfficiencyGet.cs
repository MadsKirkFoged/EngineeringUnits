using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class FuelEfficiency
    {
        /// <summary>
        ///     Get FuelEfficiency in KilometersPerLiters.
        /// </summary>
        public double KilometersPerLiters => As(FuelEfficiencyUnit.KilometerPerLiter);

        /// <summary>
        ///     Get FuelEfficiency in LitersPer100Kilometers.
        /// </summary>
        //public double LitersPer100Kilometers => As(FuelEfficiencyUnit.LiterPer100Kilometers);

        /// <summary>
        ///     Get FuelEfficiency in MilesPerUkGallon.
        /// </summary>
        public double MilesPerUkGallon => As(FuelEfficiencyUnit.MilePerUkGallon);

        /// <summary>
        ///     Get FuelEfficiency in MilesPerUsGallon.
        /// </summary>
        public double MilesPerUsGallon => As(FuelEfficiencyUnit.MilePerUsGallon);

    }
}
