using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarMass
    {
        /// <summary>
        ///     Get MolarMass from CentigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromCentigramsPerMole(double centigramspermole)
        {
            double value = (double)centigramspermole;
            return new MolarMass(value, MolarMassUnit.CentigramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from DecagramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromDecagramsPerMole(double decagramspermole)
        {
            double value = (double)decagramspermole;
            return new MolarMass(value, MolarMassUnit.DecagramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from DecigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromDecigramsPerMole(double decigramspermole)
        {
            double value = (double)decigramspermole;
            return new MolarMass(value, MolarMassUnit.DecigramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from GramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromGramsPerMole(double gramspermole)
        {
            double value = (double)gramspermole;
            return new MolarMass(value, MolarMassUnit.GramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from HectogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromHectogramsPerMole(double hectogramspermole)
        {
            double value = (double)hectogramspermole;
            return new MolarMass(value, MolarMassUnit.HectogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from KilogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromKilogramsPerMole(double kilogramspermole)
        {
            double value = (double)kilogramspermole;
            return new MolarMass(value, MolarMassUnit.KilogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from KilopoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromKilopoundsPerMole(double kilopoundspermole)
        {
            double value = (double)kilopoundspermole;
            return new MolarMass(value, MolarMassUnit.KilopoundPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MegapoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMegapoundsPerMole(double megapoundspermole)
        {
            double value = (double)megapoundspermole;
            return new MolarMass(value, MolarMassUnit.MegapoundPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MicrogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMicrogramsPerMole(double microgramspermole)
        {
            double value = (double)microgramspermole;
            return new MolarMass(value, MolarMassUnit.MicrogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MilligramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMilligramsPerMole(double milligramspermole)
        {
            double value = (double)milligramspermole;
            return new MolarMass(value, MolarMassUnit.MilligramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from NanogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromNanogramsPerMole(double nanogramspermole)
        {
            double value = (double)nanogramspermole;
            return new MolarMass(value, MolarMassUnit.NanogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from PoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromPoundsPerMole(double poundspermole)
        {
            double value = (double)poundspermole;
            return new MolarMass(value, MolarMassUnit.PoundPerMole);
        }

    }
}
