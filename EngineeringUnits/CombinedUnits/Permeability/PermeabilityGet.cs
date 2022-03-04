
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Permeability
    {

 

            /// <summary>
            ///     Get Permeability in SI.
            /// </summary>
            public double SI => As(PermeabilityUnit.SI);
            /// <summary>
            ///     Get Permeability in HenryPerMeter.
            /// </summary>
            public double HenryPerMeter => As(PermeabilityUnit.HenryPerMeter);
    }
}


