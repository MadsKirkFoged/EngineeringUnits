using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity
    {
        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareFoot.
        /// </summary>
        public double AmperesPerSquareFoot => As(ElectricCurrentDensityUnit.AmperePerSquareFoot);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareInch.
        /// </summary>
        public double AmperesPerSquareInch => As(ElectricCurrentDensityUnit.AmperePerSquareInch);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareMeter.
        /// </summary>
        public double AmperesPerSquareMeter => As(ElectricCurrentDensityUnit.AmperePerSquareMeter);

        /// <summary>
        ///     Get ElectricCurrentDensity in SI Unit (AmperesPerSquareMeter).
        /// </summary>
        public double SI => As(ElectricCurrentDensityUnit.SI);

    }
}
