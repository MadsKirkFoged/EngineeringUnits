using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ApparentPower
    {
        /// <summary>
        ///     Get ApparentPower in Gigavoltamperes.
        /// </summary>
        public double Gigavoltamperes => As(ApparentPowerUnit.Gigavoltampere);

        /// <summary>
        ///     Get ApparentPower in Kilovoltamperes.
        /// </summary>
        public double Kilovoltamperes => As(ApparentPowerUnit.Kilovoltampere);

        /// <summary>
        ///     Get ApparentPower in Megavoltamperes.
        /// </summary>
        public double Megavoltamperes => As(ApparentPowerUnit.Megavoltampere);

        /// <summary>
        ///     Get ApparentPower in Voltamperes.
        /// </summary>
        public double Voltamperes => As(ApparentPowerUnit.Voltampere);

        /// <summary>
        ///     Get ApparentPower in SI Unit (Voltamperes).
        /// </summary>
        public double SI => As(ApparentPowerUnit.SI);

    }
}
