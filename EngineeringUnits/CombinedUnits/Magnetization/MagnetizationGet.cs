
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Magnetization
    {

 

            /// <summary>
            ///     Get Magnetization in SI.
            /// </summary>
            public double SI => As(MagnetizationUnit.SI);
            /// <summary>
            ///     Get Magnetization in AmperePerMeter.
            /// </summary>
            public double AmperePerMeter => As(MagnetizationUnit.AmperePerMeter);
    }
}


