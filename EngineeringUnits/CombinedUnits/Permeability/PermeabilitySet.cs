
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Permeability
    {

 

            /// <summary>
            ///     Get Permeability from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Permeability FromSI(double SI)
            {
                double value= (double)SI;
                return new Permeability(value, PermeabilityUnit.SI);
            }
            /// <summary>
            ///     Get Permeability from HenryPerMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Permeability FromHenryPerMeter(double HenryPerMeter)
            {
                double value= (double)HenryPerMeter;
                return new Permeability(value, PermeabilityUnit.HenryPerMeter);
            }
    }
}


