
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class FuelEfficiency
    {

 

            /// <summary>
            ///     Get FuelEfficiency from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static FuelEfficiency FromSI(double SI)
            {
                double value= (double)SI;
                return new FuelEfficiency(value, FuelEfficiencyUnit.SI);
            }
            /// <summary>
            ///     Get FuelEfficiency from KilometerPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static FuelEfficiency FromKilometerPerLiter(double KilometerPerLiter)
            {
                double value= (double)KilometerPerLiter;
                return new FuelEfficiency(value, FuelEfficiencyUnit.KilometerPerLiter);
            }
            /// <summary>
            ///     Get FuelEfficiency from MilePerUkGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static FuelEfficiency FromMilePerUkGallon(double MilePerUkGallon)
            {
                double value= (double)MilePerUkGallon;
                return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUkGallon);
            }
            /// <summary>
            ///     Get FuelEfficiency from MilePerUsGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static FuelEfficiency FromMilePerUsGallon(double MilePerUsGallon)
            {
                double value= (double)MilePerUsGallon;
                return new FuelEfficiency(value, FuelEfficiencyUnit.MilePerUsGallon);
            }
    }
}


