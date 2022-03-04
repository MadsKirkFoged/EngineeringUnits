
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LuminousIntensity
    {

 

            /// <summary>
            ///     Get LuminousIntensity in SI.
            /// </summary>
            public double SI => As(LuminousIntensityUnit.SI);
            /// <summary>
            ///     Get LuminousIntensity in Candela.
            /// </summary>
            public double Candela => As(LuminousIntensityUnit.Candela);
    }
}


