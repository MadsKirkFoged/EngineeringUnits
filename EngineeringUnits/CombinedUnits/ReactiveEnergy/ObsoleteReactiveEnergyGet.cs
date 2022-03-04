using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ReactiveEnergy
    {
        /// <summary>
        ///     Get ReactiveEnergy in KilovoltampereReactiveHours.
        /// </summary>
        [Obsolete("Use without the 's' - KilovoltampereReactiveHours->KilovoltampereReactiveHour")]
        public double KilovoltampereReactiveHours => As(ReactiveEnergyUnit.KilovoltampereReactiveHour);

        /// <summary>
        ///     Get ReactiveEnergy in MegavoltampereReactiveHours.
        /// </summary>
        [Obsolete("Use without the 's' - MegavoltampereReactiveHours->MegavoltampereReactiveHour")]
        public double MegavoltampereReactiveHours => As(ReactiveEnergyUnit.MegavoltampereReactiveHour);

        /// <summary>
        ///     Get ReactiveEnergy in VoltampereReactiveHours.
        /// </summary>
        [Obsolete("Use without the 's' - VoltampereReactiveHours->VoltampereReactiveHour")]
        public double VoltampereReactiveHours => As(ReactiveEnergyUnit.VoltampereReactiveHour);

        /// <summary>
        ///     Get ReactiveEnergy in SI unit (VoltampereReactiveHours).
        /// </summary>
        //public double SI => As(ReactiveEnergyUnit.SI);

    }
}
