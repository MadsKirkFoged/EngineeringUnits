using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricCharge
    {
        /// <summary>
        ///     Get ElectricCharge in AmpereHours.
        /// </summary>
        [Obsolete("Use without the 's' - AmpereHours->AmpereHour")]
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Get ElectricCharge in Coulombs.
        /// </summary>
        [Obsolete("Use without the 's' - Coulombs->Coulomb")]
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Get ElectricCharge in SI Unit (Coulombs).
        /// </summary>
       // public double SI => As(ElectricChargeUnit.SI);

        /// <summary>
        ///     Get ElectricCharge in KiloampereHours.
        /// </summary>
        [Obsolete("Use without the 's' - KiloampereHours->KiloampereHour")]
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Get ElectricCharge in MegaampereHours.
        /// </summary>
        [Obsolete("Use without the 's' - MegaampereHours->MegaampereHour")]
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Get ElectricCharge in MilliampereHours.
        /// </summary>
        [Obsolete("Use without the 's' - MilliampereHours->MilliampereHour")]
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

    }
}
