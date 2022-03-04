using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient
    {
        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerMicrosecond.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerMicrosecond->AmperePerMicrosecond")]
        public double AmperesPerMicrosecond => As(ElectricCurrentGradientUnit.AmperePerMicrosecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerMillisecond.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerMillisecond->AmperePerMillisecond")]
        public double AmperesPerMillisecond => As(ElectricCurrentGradientUnit.AmperePerMillisecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerNanosecond.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerNanosecond->AmperePerNanosecond")]
        public double AmperesPerNanosecond => As(ElectricCurrentGradientUnit.AmperePerNanosecond);

        /// <summary>
        ///     Get ElectricCurrentGradient in AmperesPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerSecond->AmperePerSecond")]
        public double AmperesPerSecond => As(ElectricCurrentGradientUnit.AmperePerSecond);


        /// <summary>
        ///     Get ElectricCurrentGradient in SI Unit (AmperesPerSecond).
        /// </summary>
        //public double SI => As(ElectricCurrentGradientUnit.SI);

    }
}
