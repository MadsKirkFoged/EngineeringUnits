using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ElectricSurfaceChargeDensity FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.SI);
        //}

        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCoulombsPerSquareCentimeter->FromCoulombPerSquareCentimeter")]
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareCentimeter(double coulombspersquarecentimeter)
        {
            double value = (double)coulombspersquarecentimeter;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);
        }
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCoulombsPerSquareInch->FromCoulombPerSquareInch")]
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareInch(double coulombspersquareinch)
        {
            double value = (double)coulombspersquareinch;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);
        }
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCoulombsPerSquareMeter->FromCoulombPerSquareMeter")]
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareMeter(double coulombspersquaremeter)
        {
            double value = (double)coulombspersquaremeter;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);
        }

    }
}
