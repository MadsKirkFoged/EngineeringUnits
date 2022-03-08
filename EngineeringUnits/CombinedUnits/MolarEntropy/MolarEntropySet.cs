
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEntropy
    {

 

            /// <summary>
            ///     Get MolarEntropy from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEntropy FromSI(double SI)
            {
                double value= (double)SI;
                return new MolarEntropy(value, MolarEntropyUnit.SI);
            }
            /// <summary>
            ///     Get MolarEntropy from JoulePerMoleKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEntropy FromJoulePerMoleKelvin(double JoulePerMoleKelvin)
            {
                double value= (double)JoulePerMoleKelvin;
                return new MolarEntropy(value, MolarEntropyUnit.JoulePerMoleKelvin);
            }
            /// <summary>
            ///     Get MolarEntropy from KilojoulePerMoleKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEntropy FromKilojoulePerMoleKelvin(double KilojoulePerMoleKelvin)
            {
                double value= (double)KilojoulePerMoleKelvin;
                return new MolarEntropy(value, MolarEntropyUnit.KilojoulePerMoleKelvin);
            }
            /// <summary>
            ///     Get MolarEntropy from MegajoulePerMoleKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEntropy FromMegajoulePerMoleKelvin(double MegajoulePerMoleKelvin)
            {
                double value= (double)MegajoulePerMoleKelvin;
                return new MolarEntropy(value, MolarEntropyUnit.MegajoulePerMoleKelvin);
            }
    }
}


