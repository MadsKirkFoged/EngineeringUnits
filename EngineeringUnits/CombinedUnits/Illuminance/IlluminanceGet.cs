using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Illuminance
    {
        /// <summary>
        ///     Get Illuminance in Kilolux.
        /// </summary>
        public double Kilolux => As(IlluminanceUnit.Kilolux);

        /// <summary>
        ///     Get Illuminance in Lux.
        /// </summary>
        public double Lux => As(IlluminanceUnit.Lux);

        /// <summary>
        ///     Get Illuminance in Megalux.
        /// </summary>
        public double Megalux => As(IlluminanceUnit.Megalux);

        /// <summary>
        ///     Get Illuminance in Millilux.
        /// </summary>
        public double Millilux => As(IlluminanceUnit.Millilux);

    }
}
