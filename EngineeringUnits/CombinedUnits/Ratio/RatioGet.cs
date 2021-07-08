using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Ratio
    {
        /// <summary>
        ///     Get Ratio in DecimalFractions.
        /// </summary>
        public double DecimalFractions => As(RatioUnit.DecimalFraction);

        /// <summary>
        ///     Get Ratio in PartsPerBillion.
        /// </summary>
        public double PartsPerBillion => As(RatioUnit.PartPerBillion);

        /// <summary>
        ///     Get Ratio in PartsPerMillion.
        /// </summary>
        public double PartsPerMillion => As(RatioUnit.PartPerMillion);

        /// <summary>
        ///     Get Ratio in PartsPerThousand.
        /// </summary>
        public double PartsPerThousand => As(RatioUnit.PartPerThousand);

        /// <summary>
        ///     Get Ratio in PartsPerTrillion.
        /// </summary>
        public double PartsPerTrillion => As(RatioUnit.PartPerTrillion);

        /// <summary>
        ///     Get Ratio in Percent.
        /// </summary>
        public double Percent => As(RatioUnit.Percent);

    }
}
