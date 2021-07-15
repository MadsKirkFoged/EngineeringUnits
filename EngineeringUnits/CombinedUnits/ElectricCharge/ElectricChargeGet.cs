using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCharge
    {
        /// <summary>
        ///     Get ElectricCharge in AmpereHours.
        /// </summary>
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Get ElectricCharge in Coulombs.
        /// </summary>
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Get ElectricCharge in KiloampereHours.
        /// </summary>
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Get ElectricCharge in MegaampereHours.
        /// </summary>
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Get ElectricCharge in MilliampereHours.
        /// </summary>
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

    }
}
