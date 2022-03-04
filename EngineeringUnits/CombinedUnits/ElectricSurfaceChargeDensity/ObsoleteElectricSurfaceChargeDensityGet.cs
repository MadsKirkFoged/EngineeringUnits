using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity
    {
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity in CoulombsPerSquareCentimeter.
        /// </summary>
        [Obsolete("Use without the 's' - CoulombsPerSquareCentimeter->CoulombPerSquareCentimeter")]
        public double CoulombsPerSquareCentimeter => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);

        /// <summary>
        ///     Get ElectricSurfaceChargeDensity in CoulombsPerSquareInch.
        /// </summary>
        [Obsolete("Use without the 's' - CoulombsPerSquareInch->CoulombPerSquareInch")]
        public double CoulombsPerSquareInch => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);

        /// <summary>
        ///     Get ElectricSurfaceChargeDensity in CoulombsPerSquareMeter.
        /// </summary>
        [Obsolete("Use without the 's' - CoulombsPerSquareMeter->CoulombPerSquareMeter")]
        public double CoulombsPerSquareMeter => As(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);

        /// <summary>
        ///     Get ElectricSurfaceChargeDensity in SI Unit (CoulombsPerSquareMeter).
        /// </summary>
       // public double SI => As(ElectricSurfaceChargeDensityUnit.SI);

    }
}
