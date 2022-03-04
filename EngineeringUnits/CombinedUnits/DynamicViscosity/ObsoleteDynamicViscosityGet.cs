using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class DynamicViscosity
    {
        /// <summary>
        ///     Get DynamicViscosity in Centipoise.
        /// </summary>
        //public double Centipoise => As(DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Get DynamicViscosity in MicropascalSeconds.
        /// </summary>
        [Obsolete("Use without the 's' - MicropascalSeconds->MicropascalSecond")]
        public double MicropascalSeconds => As(DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in MillipascalSeconds.
        /// </summary>
        [Obsolete("Use without the 's' - MillipascalSeconds->MillipascalSecond")]
        public double MillipascalSeconds => As(DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in NewtonSecondsPerMeterSquared.
        /// </summary>
        [Obsolete("Use without the 's' - NewtonSecondsPerMeterSquared->NewtonSecondPerMeterSquared")]
        public double NewtonSecondsPerMeterSquared => As(DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Get DynamicViscosity in PascalSeconds.
        /// </summary>
        [Obsolete("Use without the 's' - PascalSeconds->PascalSecond")]
        public double PascalSeconds => As(DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in Poise.
        /// </summary>
       // public double Poise => As(DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Get DynamicViscosity in SI Unit (Poise).
        /// </summary>
        //public double SI => As(DynamicViscosityUnit.SI);

        /// <summary>
        ///     Get DynamicViscosity in PoundsForceSecondPerSquareFoot.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsForceSecondPerSquareFoot->PoundForceSecondPerSquareFoot")]
        public double PoundsForceSecondPerSquareFoot => As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Get DynamicViscosity in PoundsForceSecondPerSquareInch.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsForceSecondPerSquareInch->PoundForceSecondPerSquareInch")]
        public double PoundsForceSecondPerSquareInch => As(DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Get DynamicViscosity in PoundsPerFootSecond.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsPerFootSecond->PoundPerFootSecond")]
        public double PoundsPerFootSecond => As(DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Get DynamicViscosity in Reyns.
        /// </summary>
        [Obsolete("Use without the 's' - Reyns->Reyn")]
        public double Reyns => As(DynamicViscosityUnit.Reyn);

    }
}
