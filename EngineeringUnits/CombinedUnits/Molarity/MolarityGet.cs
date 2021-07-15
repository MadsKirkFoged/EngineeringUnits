using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Molarity
    {
        /// <summary>
        ///     Get Molarity in CentimolesPerLiter.
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolesPerLiter);

        /// <summary>
        ///     Get Molarity in DecimolesPerLiter.
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MicromolesPerLiter.
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolesPerLiter);

        /// <summary>
        ///     Get Molarity in MillimolesPerLiter.
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MolesPerCubicMeter.
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolesPerCubicMeter);

        /// <summary>
        ///     Get Molarity in SI Unit (MolesPerCubicMeter).
        /// </summary>
        public double SI => As(MolarityUnit.SI);

        /// <summary>
        ///     Get Molarity in MolesPerLiter.
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolesPerLiter);

        /// <summary>
        ///     Get Molarity in NanomolesPerLiter.
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolesPerLiter);

        /// <summary>
        ///     Get Molarity in PicomolesPerLiter.
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolesPerLiter);

    }
}
