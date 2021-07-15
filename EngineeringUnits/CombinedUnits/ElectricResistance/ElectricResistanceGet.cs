using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricResistance
    {
        /// <summary>
        ///     Get ElectricResistance in Gigaohms.
        /// </summary>
        public double Gigaohms => As(ElectricResistanceUnit.Gigaohm);

        /// <summary>
        ///     Get ElectricResistance in Kiloohms.
        /// </summary>
        public double Kiloohms => As(ElectricResistanceUnit.Kiloohm);

        /// <summary>
        ///     Get ElectricResistance in Megaohms.
        /// </summary>
        public double Megaohms => As(ElectricResistanceUnit.Megaohm);

        /// <summary>
        ///     Get ElectricResistance in Microohms.
        /// </summary>
        public double Microohms => As(ElectricResistanceUnit.Microohm);

        /// <summary>
        ///     Get ElectricResistance in Milliohms.
        /// </summary>
        public double Milliohms => As(ElectricResistanceUnit.Milliohm);

        /// <summary>
        ///     Get ElectricResistance in Ohms.
        /// </summary>
        public double Ohms => As(ElectricResistanceUnit.Ohm);

        /// <summary>
        ///     Get ElectricResistance in SI Unit (Ohms).
        /// </summary>
        public double SI => As(ElectricResistanceUnit.SI);

    }
}
