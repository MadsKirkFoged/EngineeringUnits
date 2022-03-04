
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LapseRate
    {

 

            /// <summary>
            ///     Get LapseRate in SI.
            /// </summary>
            public double SI => As(LapseRateUnit.SI);
            /// <summary>
            ///     Get LapseRate in DegreeCelsiusPerKilometer.
            /// </summary>
            public double DegreeCelsiusPerKilometer => As(LapseRateUnit.DegreeCelsiusPerKilometer);
    }
}


