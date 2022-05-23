
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LapseRate
    {

 

            /// <summary>
            ///     Get LapseRate from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LapseRate FromSI(double SI)
            {
                double value= (double)SI;
                return new LapseRate(value, LapseRateUnit.SI);
            }
            /// <summary>
            ///     Get LapseRate from DegreeCelsiusPerKilometer.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LapseRate FromDegreeCelsiusPerKilometer(double DegreeCelsiusPerKilometer)
            {
                double value= (double)DegreeCelsiusPerKilometer;
                return new LapseRate(value, LapseRateUnit.DegreeCelsiusPerKilometer);
            }
    }
}


