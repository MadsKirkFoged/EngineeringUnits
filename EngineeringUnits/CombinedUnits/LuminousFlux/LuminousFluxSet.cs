
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LuminousFlux
    {

 

            /// <summary>
            ///     Get LuminousFlux from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LuminousFlux FromSI(double SI)
            {
                double value= (double)SI;
                return new LuminousFlux(value, LuminousFluxUnit.SI);
            }
            /// <summary>
            ///     Get LuminousFlux from Lumen.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LuminousFlux FromLumen(double Lumen)
            {
                double value= (double)Lumen;
                return new LuminousFlux(value, LuminousFluxUnit.Lumen);
            }
    }
}


