using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Irradiation
    {
        /// <summary>
        ///     Get Irradiation in JoulesPerSquareCentimeter.
        /// </summary>
        public double JoulesPerSquareCentimeter => As(IrradiationUnit.JoulePerSquareCentimeter);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMeter.
        /// </summary>
        public double JoulesPerSquareMeter => As(IrradiationUnit.JoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMillimeter.
        /// </summary>
        public double JoulesPerSquareMillimeter => As(IrradiationUnit.JoulePerSquareMillimeter);

        /// <summary>
        ///     Get Irradiation in KilojoulesPerSquareMeter.
        /// </summary>
        public double KilojoulesPerSquareMeter => As(IrradiationUnit.KilojoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in KilowattHoursPerSquareMeter.
        /// </summary>
        public double KilowattHoursPerSquareMeter => As(IrradiationUnit.KilowattHourPerSquareMeter);

        /// <summary>
        ///     Get Irradiation in MillijoulesPerSquareCentimeter.
        /// </summary>
        public double MillijoulesPerSquareCentimeter => As(IrradiationUnit.MillijoulePerSquareCentimeter);

        /// <summary>
        ///     Get Irradiation in WattHoursPerSquareMeter.
        /// </summary>
        public double WattHoursPerSquareMeter => As(IrradiationUnit.WattHourPerSquareMeter);

    }
}
