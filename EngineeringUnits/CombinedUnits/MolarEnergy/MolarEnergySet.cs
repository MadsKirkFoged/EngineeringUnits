
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEnergy
    {

 

            /// <summary>
            ///     Get MolarEnergy from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEnergy FromSI(double SI)
            {
                double value= (double)SI;
                return new MolarEnergy(value, MolarEnergyUnit.SI);
            }
            /// <summary>
            ///     Get MolarEnergy from JoulePerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEnergy FromJoulePerMole(double JoulePerMole)
            {
                double value= (double)JoulePerMole;
                return new MolarEnergy(value, MolarEnergyUnit.JoulePerMole);
            }
            /// <summary>
            ///     Get MolarEnergy from KilojoulePerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEnergy FromKilojoulePerMole(double KilojoulePerMole)
            {
                double value= (double)KilojoulePerMole;
                return new MolarEnergy(value, MolarEnergyUnit.KilojoulePerMole);
            }
            /// <summary>
            ///     Get MolarEnergy from MegajoulePerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarEnergy FromMegajoulePerMole(double MegajoulePerMole)
            {
                double value= (double)MegajoulePerMole;
                return new MolarEnergy(value, MolarEnergyUnit.MegajoulePerMole);
            }
    }
}


