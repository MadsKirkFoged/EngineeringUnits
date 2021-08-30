using System;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace EngineeringUnits
{
    public partial class Dimensionless
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Dimensionless FromDimensionless(double si)
        {
            double value = (double)si;
            return new Dimensionless(value, DimensionlessUnit.Dimensionless);
        }

        public static implicit operator double (Dimensionless d)
        {
            return Convert.ToDouble(d.BaseunitValue);
        }

    }
}
