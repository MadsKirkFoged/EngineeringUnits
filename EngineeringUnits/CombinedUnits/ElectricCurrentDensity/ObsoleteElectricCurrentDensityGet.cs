using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity
    {
        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareFoot.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerSquareFoot->AmperePerSquareFoot")]
        public double AmperesPerSquareFoot => As(ElectricCurrentDensityUnit.AmperePerSquareFoot);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareInch.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerSquareInch->AmperePerSquareInch")]
        public double AmperesPerSquareInch => As(ElectricCurrentDensityUnit.AmperePerSquareInch);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerSquareMeter->AmperePerSquareMeter")]
        public double AmperesPerSquareMeter => As(ElectricCurrentDensityUnit.AmperePerSquareMeter);

        /// <summary>
        ///     Get ElectricCurrentDensity in SI Unit (AmperesPerSquareMeter).
        /// </summary>
       // public double SI => As(ElectricCurrentDensityUnit.SI);

    }
}
