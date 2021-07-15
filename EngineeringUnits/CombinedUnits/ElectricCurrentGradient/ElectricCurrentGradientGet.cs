using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient
    {
        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerMicrosecond.
        /// </summary>
        public double AmperesPerMicrosecond => As(ElectricCurrentGradientUnit.AmperePerMicrosecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerMillisecond.
        /// </summary>
        public double AmperesPerMillisecond => As(ElectricCurrentGradientUnit.AmperePerMillisecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerNanosecond.
        /// </summary>
        public double AmperesPerNanosecond => As(ElectricCurrentGradientUnit.AmperePerNanosecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerSecond.
        /// </summary>
        public double AmperesPerSecond => As(ElectricCurrentGradientUnit.AmperePerSecond);


        /// <summary>
        ///     Get ElectricCurrentGradient in SI Unit (AmperesPerSecond).
        /// </summary>
        public double SI => As(ElectricCurrentGradientUnit.SI);

    }
}
