using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LuminousIntensity
    {

        /// <summary>
        ///     Get LuminousIntensity in Candela.
        /// </summary>
        public double Candela => As(LuminousIntensityUnit.Candela);

        /// <summary>
        ///     Get LuminousIntensity in SI Unit (Candela).
        /// </summary>
        public double SI => As(LuminousIntensityUnit.SI);



    }
}
