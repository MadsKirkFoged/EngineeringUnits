
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Permittivity
    {

 

            /// <summary>
            ///     Get Permittivity in SI.
            /// </summary>
            public double SI => As(PermittivityUnit.SI);
            /// <summary>
            ///     Get Permittivity in FaradPerMeter.
            /// </summary>
            public double FaradPerMeter => As(PermittivityUnit.FaradPerMeter);
    }
}


