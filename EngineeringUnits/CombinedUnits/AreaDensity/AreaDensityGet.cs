
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class AreaDensity
    {

 

            /// <summary>
            ///     Get AreaDensity in SI.
            /// </summary>
            public double SI => As(AreaDensityUnit.SI);
            /// <summary>
            ///     Get AreaDensity in KilogramPerSquareMeter.
            /// </summary>
            public double KilogramPerSquareMeter => As(AreaDensityUnit.KilogramPerSquareMeter);
    }
}


