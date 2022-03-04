
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEntropy
    {

 

            /// <summary>
            ///     Get MolarEntropy in SI.
            /// </summary>
            public double SI => As(MolarEntropyUnit.SI);
            /// <summary>
            ///     Get MolarEntropy in JoulePerMoleKelvin.
            /// </summary>
            public double JoulePerMoleKelvin => As(MolarEntropyUnit.JoulePerMoleKelvin);
            /// <summary>
            ///     Get MolarEntropy in KilojoulePerMoleKelvin.
            /// </summary>
            public double KilojoulePerMoleKelvin => As(MolarEntropyUnit.KilojoulePerMoleKelvin);
            /// <summary>
            ///     Get MolarEntropy in MegajoulePerMoleKelvin.
            /// </summary>
            public double MegajoulePerMoleKelvin => As(MolarEntropyUnit.MegajoulePerMoleKelvin);
    }
}


