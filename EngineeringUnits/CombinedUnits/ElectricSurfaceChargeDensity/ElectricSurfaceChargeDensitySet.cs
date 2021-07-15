using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity
    {
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareCentimeter(double coulombspersquarecentimeter)
        {
            double value = (double)coulombspersquarecentimeter;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);
        }
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareInch(double coulombspersquareinch)
        {
            double value = (double)coulombspersquareinch;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);
        }
        /// <summary>
        ///     Get ElectricSurfaceChargeDensity from CoulombsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricSurfaceChargeDensity FromCoulombsPerSquareMeter(double coulombspersquaremeter)
        {
            double value = (double)coulombspersquaremeter;
            return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);
        }

    }
}
