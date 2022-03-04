
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class FuelEfficiency
    {

 

            /// <summary>
            ///     Get FuelEfficiency in SI.
            /// </summary>
            public double SI => As(FuelEfficiencyUnit.SI);
            /// <summary>
            ///     Get FuelEfficiency in KilometerPerLiter.
            /// </summary>
            public double KilometerPerLiter => As(FuelEfficiencyUnit.KilometerPerLiter);
            /// <summary>
            ///     Get FuelEfficiency in MilePerUkGallon.
            /// </summary>
            public double MilePerUkGallon => As(FuelEfficiencyUnit.MilePerUkGallon);
            /// <summary>
            ///     Get FuelEfficiency in MilePerUsGallon.
            /// </summary>
            public double MilePerUsGallon => As(FuelEfficiencyUnit.MilePerUsGallon);
    }
}


