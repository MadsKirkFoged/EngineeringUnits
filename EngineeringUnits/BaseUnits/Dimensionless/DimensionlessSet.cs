using System;
using EngineeringUnits.Units;


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



    }
}
