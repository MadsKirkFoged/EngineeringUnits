using System;
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

    }
}
