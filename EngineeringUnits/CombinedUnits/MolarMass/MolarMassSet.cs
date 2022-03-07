
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarMass
    {

 

            /// <summary>
            ///     Get MolarMass from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromSI(double SI)
            {
                double value= (double)SI;
                return new MolarMass(value, MolarMassUnit.SI);
            }
            /// <summary>
            ///     Get MolarMass from KilogramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromKilogramPerMole(double KilogramPerMole)
            {
                double value= (double)KilogramPerMole;
                return new MolarMass(value, MolarMassUnit.KilogramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from CentigramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromCentigramPerMole(double CentigramPerMole)
            {
                double value= (double)CentigramPerMole;
                return new MolarMass(value, MolarMassUnit.CentigramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from DecagramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromDecagramPerMole(double DecagramPerMole)
            {
                double value= (double)DecagramPerMole;
                return new MolarMass(value, MolarMassUnit.DecagramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from DecigramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromDecigramPerMole(double DecigramPerMole)
            {
                double value= (double)DecigramPerMole;
                return new MolarMass(value, MolarMassUnit.DecigramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from GramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromGramPerMole(double GramPerMole)
            {
                double value= (double)GramPerMole;
                return new MolarMass(value, MolarMassUnit.GramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from HectogramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromHectogramPerMole(double HectogramPerMole)
            {
                double value= (double)HectogramPerMole;
                return new MolarMass(value, MolarMassUnit.HectogramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from KilopoundPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromKilopoundPerMole(double KilopoundPerMole)
            {
                double value= (double)KilopoundPerMole;
                return new MolarMass(value, MolarMassUnit.KilopoundPerMole);
            }
            /// <summary>
            ///     Get MolarMass from MegapoundPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromMegapoundPerMole(double MegapoundPerMole)
            {
                double value= (double)MegapoundPerMole;
                return new MolarMass(value, MolarMassUnit.MegapoundPerMole);
            }
            /// <summary>
            ///     Get MolarMass from MicrogramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromMicrogramPerMole(double MicrogramPerMole)
            {
                double value= (double)MicrogramPerMole;
                return new MolarMass(value, MolarMassUnit.MicrogramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from MilligramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromMilligramPerMole(double MilligramPerMole)
            {
                double value= (double)MilligramPerMole;
                return new MolarMass(value, MolarMassUnit.MilligramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from NanogramPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromNanogramPerMole(double NanogramPerMole)
            {
                double value= (double)NanogramPerMole;
                return new MolarMass(value, MolarMassUnit.NanogramPerMole);
            }
            /// <summary>
            ///     Get MolarMass from PoundPerMole.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MolarMass FromPoundPerMole(double PoundPerMole)
            {
                double value= (double)PoundPerMole;
                return new MolarMass(value, MolarMassUnit.PoundPerMole);
            }
    }
}


