using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LapseRate
    {
        /// <summary>
        ///     Get LapseRate in DegreesCelciusPerKilometer.
        /// </summary>
        public double DegreesCelciusPerKilometer => As(LapseRateUnit.DegreeCelsiusPerKilometer);


        /// <summary>
        ///     Get LapseRate in SI Unit (KelvinCelciusPerKilometer).
        /// </summary>
        public double SI => As(LapseRateUnit.SI);

    }
}
