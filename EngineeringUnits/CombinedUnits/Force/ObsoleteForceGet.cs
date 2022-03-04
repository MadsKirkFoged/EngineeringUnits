using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Force
    {
        /// <summary>
        ///     Get Force in Decanewtons.
        /// </summary>
        [Obsolete("Use without the 's' - Decanewtons->Decanewton")]
        public double Decanewtons => As(ForceUnit.Decanewton);

        /// <summary>
        ///     Get Force in Dyne.
        /// </summary>
        [Obsolete("Use without the 's' - Dyne->Dyn")]
        public double Dyne => As(ForceUnit.Dyn);

        /// <summary>
        ///     Get Force in KilogramsForce.
        /// </summary>
        [Obsolete("Use without the 's' - KilogramsForce->KilogramForce")]
        public double KilogramsForce => As(ForceUnit.KilogramForce);

        /// <summary>
        ///     Get Force in Kilonewtons.
        /// </summary>
        [Obsolete("Use without the 's' - Kilonewtons->Kilonewton")]
        public double Kilonewtons => As(ForceUnit.Kilonewton);

        /// <summary>
        ///     Get Force in KiloPonds.
        /// </summary>
        [Obsolete("Use without the 's' - KiloPonds->KiloPond")]
        public double KiloPonds => As(ForceUnit.KiloPond);

        /// <summary>
        ///     Get Force in KilopoundsForce.
        /// </summary>
        [Obsolete("Use without the 's' - KilopoundsForce->KilopoundForce")]
        public double KilopoundsForce => As(ForceUnit.KilopoundForce);

        /// <summary>
        ///     Get Force in Meganewtons.
        /// </summary>
        [Obsolete("Use without the 's' - Meganewtons->Meganewton")]
        public double Meganewtons => As(ForceUnit.Meganewton);

        /// <summary>
        ///     Get Force in Micronewtons.
        /// </summary>
        [Obsolete("Use without the 's' - Micronewtons->Micronewton")]
        public double Micronewtons => As(ForceUnit.Micronewton);

        /// <summary>
        ///     Get Force in Millinewtons.
        /// </summary>
        [Obsolete("Use without the 's' - Millinewtons->Millinewton")]
        public double Millinewtons => As(ForceUnit.Millinewton);

        /// <summary>
        ///     Get Force in Newtons.
        /// </summary>
        [Obsolete("Use without the 's' - Newtons->Newton")]
        public double Newtons => As(ForceUnit.Newton);

        /// <summary>
        ///     Get Force in SI Unit (Newtons).
        /// </summary>
        //public double SI => As(ForceUnit.SI);

        /// <summary>
        ///     Get Force in OunceForce.
        /// </summary>
        //public double OunceForce => As(ForceUnit.OunceForce);

        /// <summary>
        ///     Get Force in Poundals.
        /// </summary>
        [Obsolete("Use without the 's' - Poundals->Poundal")]
        public double Poundals => As(ForceUnit.Poundal);

        /// <summary>
        ///     Get Force in PoundsForce.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsForce->PoundForce")]
        public double PoundsForce => As(ForceUnit.PoundForce);

        /// <summary>
        ///     Get Force in ShortTonsForce.
        /// </summary>
        [Obsolete("Use without the 's' - ShortTonsForce->ShortTonForce")]
        public double ShortTonsForce => As(ForceUnit.ShortTonForce);

        /// <summary>
        ///     Get Force in TonnesForce.
        /// </summary>
        [Obsolete("Use without the 's' - TonnesForce->TonneForce")]
        public double TonnesForce => As(ForceUnit.TonneForce);

    }
}
