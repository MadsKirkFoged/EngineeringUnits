using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class DynamicViscosity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static DynamicViscosity FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new DynamicViscosity(value, DynamicViscosityUnit.SI);
        //}

        /// <summary>
        ///     Get DynamicViscosity from Centipoise.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static DynamicViscosity FromCentipoise(double centipoise)
        //{
        //    double value = (double)centipoise;
        //    return new DynamicViscosity(value, DynamicViscosityUnit.Centipoise);
        //}
        /// <summary>
        ///     Get DynamicViscosity from MicropascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicropascalSeconds->FromMicropascalSecond")]
        public static DynamicViscosity FromMicropascalSeconds(double micropascalseconds)
        {
            double value = (double)micropascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.MicropascalSecond);
        }
        /// <summary>
        ///     Get DynamicViscosity from MillipascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillipascalSeconds->FromMillipascalSecond")]
        public static DynamicViscosity FromMillipascalSeconds(double millipascalseconds)
        {
            double value = (double)millipascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.MillipascalSecond);
        }
        /// <summary>
        ///     Get DynamicViscosity from NewtonSecondsPerMeterSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNewtonSecondsPerMeterSquared->FromNewtonSecondPerMeterSquared")]
        public static DynamicViscosity FromNewtonSecondsPerMeterSquared(double newtonsecondspermetersquared)
        {
            double value = (double)newtonsecondspermetersquared;
            return new DynamicViscosity(value, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
        }
        /// <summary>
        ///     Get DynamicViscosity from PascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPascalSeconds->FromPascalSecond")]
        public static DynamicViscosity FromPascalSeconds(double pascalseconds)
        {
            double value = (double)pascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.PascalSecond);
        }
        /// <summary>
        ///     Get DynamicViscosity from Poise.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static DynamicViscosity FromPoise(double poise)
        //{
        //    double value = (double)poise;
        //    return new DynamicViscosity(value, DynamicViscosityUnit.Poise);
        //}
        /// <summary>
        ///     Get DynamicViscosity from PoundsForceSecondPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsForceSecondPerSquareFoot->FromPoundForceSecondPerSquareFoot")]
        public static DynamicViscosity FromPoundsForceSecondPerSquareFoot(double poundsforcesecondpersquarefoot)
        {
            double value = (double)poundsforcesecondpersquarefoot;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
        }
        /// <summary>
        ///     Get DynamicViscosity from PoundsForceSecondPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsForceSecondPerSquareInch->FromPoundForceSecondPerSquareInch")]
        public static DynamicViscosity FromPoundsForceSecondPerSquareInch(double poundsforcesecondpersquareinch)
        {
            double value = (double)poundsforcesecondpersquareinch;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareInch);
        }
        /// <summary>
        ///     Get DynamicViscosity from PoundsPerFootSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerFootSecond->FromVFromPoundPerFootSecondoltampere")]
        public static DynamicViscosity FromPoundsPerFootSecond(double poundsperfootsecond)
        {
            double value = (double)poundsperfootsecond;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundPerFootSecond);
        }
        /// <summary>
        ///     Get DynamicViscosity from Reyns.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromReyns->FromReyn")]
        public static DynamicViscosity FromReyns(double reyns)
        {
            double value = (double)reyns;
            return new DynamicViscosity(value, DynamicViscosityUnit.Reyn);
        }

    }
}
