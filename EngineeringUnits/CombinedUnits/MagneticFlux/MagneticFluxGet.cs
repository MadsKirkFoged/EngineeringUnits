
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticFlux
    {

 

            /// <summary>
            ///     Get MagneticFlux in SI.
            /// </summary>
            public double SI => As(MagneticFluxUnit.SI);
            /// <summary>
            ///     Get MagneticFlux in Weber.
            /// </summary>
            public double Weber => As(MagneticFluxUnit.Weber);
    }
}


