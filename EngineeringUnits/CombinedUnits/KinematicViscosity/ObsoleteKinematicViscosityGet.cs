using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class KinematicViscosity
    {
        /// <summary>
        ///     Get KinematicViscosity in Centistokes.
        /// </summary>
        //public double Centistokes => As(KinematicViscosityUnit.Centistokes);

        ///// <summary>
        /////     Get KinematicViscosity in Decistokes.
        ///// </summary>
        //public double Decistokes => As(KinematicViscosityUnit.Decistokes);

        ///// <summary>
        /////     Get KinematicViscosity in Kilostokes.
        ///// </summary>
        //public double Kilostokes => As(KinematicViscosityUnit.Kilostokes);

        ///// <summary>
        /////     Get KinematicViscosity in Microstokes.
        ///// </summary>
        //public double Microstokes => As(KinematicViscosityUnit.Microstokes);

        ///// <summary>
        /////     Get KinematicViscosity in Millistokes.
        ///// </summary>
        //public double Millistokes => As(KinematicViscosityUnit.Millistokes);

        ///// <summary>
        /////     Get KinematicViscosity in Nanostokes.
        ///// </summary>
        //public double Nanostokes => As(KinematicViscosityUnit.Nanostokes);

        /// <summary>
        ///     Get KinematicViscosity in SquareMetersPerSecond.
        /// </summary>

        [Obsolete("Use without the 's' - SquareMetersPerSecond->SquareMeterPerSecond")]
        public double SquareMetersPerSecond => As(KinematicViscosityUnit.SquareMeterPerSecond);

        /// <summary>
        ///     Get KinematicViscosity in Stokes.
        /// </summary>
        //public double Stokes => As(KinematicViscosityUnit.Stokes);

        ///// <summary>
        /////     Get KinematicViscosity in SI Unit (Stokes).
        ///// </summary>
        //public double SI => As(KinematicViscosityUnit.SI);

    }
}
