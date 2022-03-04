using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class MolarMass
    {
        /// <summary>
        ///     Get MolarMass in CentigramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - CentigramsPerMole->CentigramPerMole")]
        public double CentigramsPerMole => As(MolarMassUnit.CentigramPerMole);

        /// <summary>
        ///     Get MolarMass in DecagramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - DecagramsPerMole->DecagramPerMole")]
        public double DecagramsPerMole => As(MolarMassUnit.DecagramPerMole);

        /// <summary>
        ///     Get MolarMass in DecigramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - DecigramsPerMole->DecigramPerMole")]
        public double DecigramsPerMole => As(MolarMassUnit.DecigramPerMole);

        /// <summary>
        ///     Get MolarMass in GramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - GramsPerMole->GramPerMole")]
        public double GramsPerMole => As(MolarMassUnit.GramPerMole);

        /// <summary>
        ///     Get MolarMass in HectogramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - HectogramsPerMole->HectogramPerMole")]
        public double HectogramsPerMole => As(MolarMassUnit.HectogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilogramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - KilogramsPerMole->KilogramPerMole")]
        public double KilogramsPerMole => As(MolarMassUnit.KilogramPerMole);

        /// <summary>
        ///     Get MolarMass in SI Unit (KilogramsPerMole).
        /// </summary>
        //public double SI => As(MolarMassUnit.SI);

        /// <summary>
        ///     Get MolarMass in KilopoundsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - KilopoundsPerMole->KilopoundPerMole")]
        public double KilopoundsPerMole => As(MolarMassUnit.KilopoundPerMole);

        /// <summary>
        ///     Get MolarMass in MegapoundsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - MegapoundsPerMole->MegapoundPerMole")]
        public double MegapoundsPerMole => As(MolarMassUnit.MegapoundPerMole);

        /// <summary>
        ///     Get MolarMass in MicrogramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - MicrogramsPerMole->MicrogramPerMole")]
        public double MicrogramsPerMole => As(MolarMassUnit.MicrogramPerMole);

        /// <summary>
        ///     Get MolarMass in MilligramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - MilligramsPerMole->MilligramPerMole")]
        public double MilligramsPerMole => As(MolarMassUnit.MilligramPerMole);

        /// <summary>
        ///     Get MolarMass in NanogramsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - NanogramsPerMole->NanogramPerMole")]
        public double NanogramsPerMole => As(MolarMassUnit.NanogramPerMole);

        /// <summary>
        ///     Get MolarMass in PoundsPerMole.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsPerMole->PoundPerMole")]
        public double PoundsPerMole => As(MolarMassUnit.PoundPerMole);

    }
}
