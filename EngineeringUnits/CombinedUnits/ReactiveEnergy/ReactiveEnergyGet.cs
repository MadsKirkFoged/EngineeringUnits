using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ReactiveEnergy
    {
        /// <summary>
        ///     Get ReactiveEnergy in KilovoltampereReactiveHours.
        /// </summary>
        public double KilovoltampereReactiveHours => As(ReactiveEnergyUnit.KilovoltampereReactiveHour);

        /// <summary>
        ///     Get ReactiveEnergy in MegavoltampereReactiveHours.
        /// </summary>
        public double MegavoltampereReactiveHours => As(ReactiveEnergyUnit.MegavoltampereReactiveHour);

        /// <summary>
        ///     Get ReactiveEnergy in VoltampereReactiveHours.
        /// </summary>
        public double VoltampereReactiveHours => As(ReactiveEnergyUnit.VoltampereReactiveHour);

    }
}
