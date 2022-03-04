using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Irradiation
    {
        /// <summary>
        ///     Get Irradiation in JoulesPerSquareCentimeter.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerSquareCentimeter->JoulePerSquareCentimeter")]
        public double JoulesPerSquareCentimeter => As(IrradiationUnit.JoulePerSquareCentimeter);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerSquareMeter->JoulePerSquareMeter")]
        public double JoulesPerSquareMeter => As(IrradiationUnit.JoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in SI Unit (JoulesPerSquareMeter).
        /// </summary>
        //public double SI => As(IrradiationUnit.SI);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMillimeter.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerSquareMillimeter->JoulePerSquareMillimeter")]
        public double JoulesPerSquareMillimeter => As(IrradiationUnit.JoulePerSquareMillimeter);

        /// <summary>
        ///     Get Irradiation in KilojoulesPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - KilojoulesPerSquareMeter->KilojoulePerSquareMeter")]
        public double KilojoulesPerSquareMeter => As(IrradiationUnit.KilojoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in KilowattHoursPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - KilowattHoursPerSquareMeter->KilowattHourPerSquareMeter")]
        public double KilowattHoursPerSquareMeter => As(IrradiationUnit.KilowattHourPerSquareMeter);

        /// <summary>
        ///     Get Irradiation in MillijoulesPerSquareCentimeter.
        /// </summary>
        [Obsolete("Use without the 's' - MillijoulesPerSquareCentimeter->MillijoulePerSquareCentimeter")]
        public double MillijoulesPerSquareCentimeter => As(IrradiationUnit.MillijoulePerSquareCentimeter);

        /// <summary>
        ///     Get Irradiation in WattHoursPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - WattHoursPerSquareMeter->WattHourPerSquareMeter")]
        public double WattHoursPerSquareMeter => As(IrradiationUnit.WattHourPerSquareMeter);

    }
}
