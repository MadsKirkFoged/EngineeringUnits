using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MagneticField
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromSI(double si)
        {
            double value = (double)si;
            return new MagneticField(value, MagneticFieldUnit.SI);
        }

        /// <summary>
        ///     Get MagneticField from Gausses.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromGausses(double gausses)
        {
            double value = (double)gausses;
            return new MagneticField(value, MagneticFieldUnit.Gauss);
        }
        /// <summary>
        ///     Get MagneticField from Microteslas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMicroteslas(double microteslas)
        {
            double value = (double)microteslas;
            return new MagneticField(value, MagneticFieldUnit.Microtesla);
        }
        /// <summary>
        ///     Get MagneticField from Milligausses.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMilligausses(double milligausses)
        {
            double value = (double)milligausses;
            return new MagneticField(value, MagneticFieldUnit.Milligauss);
        }
        /// <summary>
        ///     Get MagneticField from Milliteslas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMilliteslas(double milliteslas)
        {
            double value = (double)milliteslas;
            return new MagneticField(value, MagneticFieldUnit.Millitesla);
        }
        /// <summary>
        ///     Get MagneticField from Nanoteslas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromNanoteslas(double nanoteslas)
        {
            double value = (double)nanoteslas;
            return new MagneticField(value, MagneticFieldUnit.Nanotesla);
        }
        /// <summary>
        ///     Get MagneticField from Teslas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromTeslas(double teslas)
        {
            double value = (double)teslas;
            return new MagneticField(value, MagneticFieldUnit.Tesla);
        }

    }
}
