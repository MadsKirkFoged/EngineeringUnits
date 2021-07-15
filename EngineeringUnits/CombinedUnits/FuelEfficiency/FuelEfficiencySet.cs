using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class FuelEfficiency
    {
        /// <summary>
        ///     Get FuelEfficiency from KilometersPerLiters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static FuelEfficiency FromKilometersPerLiters(double kilometersperliters)
        {
            double value = (double)kilometersperliters;
            return new FuelEfficiency(value, FuelEfficiencyUnit.KilometerPerLiter);
        }
        /// <summary>
        ///     Get FuelEfficiency from LitersPer100Kilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static FuelEfficiency FromLitersPer100Kilometers(double litersper100kilometers)
        //{
        //    double value = (double)litersper100kilometers;
        //    return new FuelEfficiency(value, FuelEfficiencyUnit.LiterPer100Kilometers);
        //}
        /// <summary>
        ///     Get FuelEfficiency from MilesPerUkGallon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static FuelEfficiency FromMilesPerUkGallon(double milesperukgallon)
        {
            double value = (double)milesperukgallon;
            return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUkGallon);
        }
        /// <summary>
        ///     Get FuelEfficiency from MilesPerUsGallon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static FuelEfficiency FromMilesPerUsGallon(double milesperusgallon)
        {
            double value = (double)milesperusgallon;
            return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUsGallon);
        }

    }
}
