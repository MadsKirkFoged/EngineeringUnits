
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificVolume
    {

 

            /// <summary>
            ///     Get SpecificVolume from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificVolume FromSI(double SI)
            {
                double value= (double)SI;
                return new SpecificVolume(value, SpecificVolumeUnit.SI);
            }
            /// <summary>
            ///     Get SpecificVolume from CubicMeterPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificVolume FromCubicMeterPerKilogram(double CubicMeterPerKilogram)
            {
                double value= (double)CubicMeterPerKilogram;
                return new SpecificVolume(value, SpecificVolumeUnit.CubicMeterPerKilogram);
            }
    }
}


