using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ReactivePower
    {
        /// <summary>
        ///     Get ReactivePower in GigavoltamperesReactive.
        /// </summary>
        public double GigavoltamperesReactive => As(ReactivePowerUnit.GigavoltampereReactive);

        /// <summary>
        ///     Get ReactivePower in KilovoltamperesReactive.
        /// </summary>
        public double KilovoltamperesReactive => As(ReactivePowerUnit.KilovoltampereReactive);

        /// <summary>
        ///     Get ReactivePower in MegavoltamperesReactive.
        /// </summary>
        public double MegavoltamperesReactive => As(ReactivePowerUnit.MegavoltampereReactive);

        /// <summary>
        ///     Get ReactivePower in VoltamperesReactive.
        /// </summary>
        public double VoltamperesReactive => As(ReactivePowerUnit.VoltampereReactive);

    }
}
