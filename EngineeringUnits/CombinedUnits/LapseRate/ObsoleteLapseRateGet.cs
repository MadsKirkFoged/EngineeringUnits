using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class LapseRate
    {
        /// <summary>
        ///     Get LapseRate in DegreesCelciusPerKilometer.
        /// </summary>

        [Obsolete("Use without the 's' - DegreesCelciusPerKilometer->DegreeCelsiusPerKilometer")]
        public double DegreesCelciusPerKilometer => As(LapseRateUnit.DegreeCelsiusPerKilometer);


        /// <summary>
        ///     Get LapseRate in SI Unit (KelvinCelciusPerKilometer).
        /// </summary>
        //public double SI => As(LapseRateUnit.SI);

    }
}
