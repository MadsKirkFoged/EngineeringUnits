
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LuminousFlux
    {

 

            /// <summary>
            ///     Get LuminousFlux in SI.
            /// </summary>
            public double SI => As(LuminousFluxUnit.SI);
            /// <summary>
            ///     Get LuminousFlux in Lumen.
            /// </summary>
            public double Lumen => As(LuminousFluxUnit.Lumen);
    }
}


