using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ElectricChargeDensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ElectricChargeDensity FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ElectricChargeDensity(value, ElectricChargeDensityUnit.SI);
        //}

        /// <summary>
        ///     Get ElectricChargeDensity from CoulombsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCoulombsPerCubicMeter->FromCoulombPerCubicMeter")]
        public static ElectricChargeDensity FromCoulombsPerCubicMeter(double coulombspercubicmeter)
        {
            double value = (double)coulombspercubicmeter;
            return new ElectricChargeDensity(value, ElectricChargeDensityUnit.CoulombPerCubicMeter);
        }
    }
}
