using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Dimensionless
    {

        /// <summary>
        ///     Get LuminousIntensity in Candela.
        /// </summary>
        public double dimensionless => As(DimensionlessUnit.Dimensionless);
        
    }
}
