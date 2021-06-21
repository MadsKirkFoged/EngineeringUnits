using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricPotential
    {
        /// <summary>
        ///     Get ElectricPotential in Kilovolts.
        /// </summary>
        public double Kilovolts => As(ElectricPotentialUnit.Kilovolt);

        /// <summary>
        ///     Get ElectricPotential in Megavolts.
        /// </summary>
        public double Megavolts => As(ElectricPotentialUnit.Megavolt);

        /// <summary>
        ///     Get ElectricPotential in Microvolts.
        /// </summary>
        public double Microvolts => As(ElectricPotentialUnit.Microvolt);

        /// <summary>
        ///     Get ElectricPotential in Millivolts.
        /// </summary>
        public double Millivolts => As(ElectricPotentialUnit.Millivolt);

        /// <summary>
        ///     Get ElectricPotential in Volts.
        /// </summary>
        public double Volts => As(ElectricPotentialUnit.Volt);

    }
}
