using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ApparentPower
    {
        /// <summary>
        ///     Get ApparentPower in Gigavoltamperes.
        /// </summary>
        [Obsolete("Use without the 's' - Gigavoltamperes->Gigavoltampere")]
        public double Gigavoltamperes => As(ApparentPowerUnit.Gigavoltampere);

        /// <summary>
        ///     Get ApparentPower in Kilovoltamperes.
        /// </summary>
        [Obsolete("Use without the 's' - Kilovoltamperes->Kilovoltampere")]
        public double Kilovoltamperes => As(ApparentPowerUnit.Kilovoltampere);

        /// <summary>
        ///     Get ApparentPower in Megavoltamperes.
        /// </summary>
        [Obsolete("Use without the 's' - Megavoltamperes->Megavoltampere")]
        public double Megavoltamperes => As(ApparentPowerUnit.Megavoltampere);

        /// <summary>
        ///     Get ApparentPower in Voltamperes.
        /// </summary>
        [Obsolete("Use without the 's' - Voltamperes->Voltampere")]
        public double Voltamperes => As(ApparentPowerUnit.Voltampere);

        /// <summary>
        ///     Get ApparentPower in SI Unit (Voltamperes).
        /// </summary>
       // public double SI => As(ApparentPowerUnit.SI);

    }
}
