
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticFlux
    {

 

            /// <summary>
            ///     Get MagneticFlux from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticFlux FromSI(double SI)
            {
                double value= (double)SI;
                return new MagneticFlux(value, MagneticFluxUnit.SI);
            }
            /// <summary>
            ///     Get MagneticFlux from Weber.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticFlux FromWeber(double Weber)
            {
                double value= (double)Weber;
                return new MagneticFlux(value, MagneticFluxUnit.Weber);
            }
    }
}


