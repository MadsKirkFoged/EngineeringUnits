
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticField
    {

 

            /// <summary>
            ///     Get MagneticField from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromSI(double SI)
            {
                double value= (double)SI;
                return new MagneticField(value, MagneticFieldUnit.SI);
            }
            /// <summary>
            ///     Get MagneticField from Tesla.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromTesla(double Tesla)
            {
                double value= (double)Tesla;
                return new MagneticField(value, MagneticFieldUnit.Tesla);
            }
            /// <summary>
            ///     Get MagneticField from Gauss.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromGauss(double Gauss)
            {
                double value= (double)Gauss;
                return new MagneticField(value, MagneticFieldUnit.Gauss);
            }
            /// <summary>
            ///     Get MagneticField from Milligauss.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromMilligauss(double Milligauss)
            {
                double value= (double)Milligauss;
                return new MagneticField(value, MagneticFieldUnit.Milligauss);
            }
            /// <summary>
            ///     Get MagneticField from Microtesla.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromMicrotesla(double Microtesla)
            {
                double value= (double)Microtesla;
                return new MagneticField(value, MagneticFieldUnit.Microtesla);
            }
            /// <summary>
            ///     Get MagneticField from Millitesla.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromMillitesla(double Millitesla)
            {
                double value= (double)Millitesla;
                return new MagneticField(value, MagneticFieldUnit.Millitesla);
            }
            /// <summary>
            ///     Get MagneticField from Nanotesla.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static MagneticField FromNanotesla(double Nanotesla)
            {
                double value= (double)Nanotesla;
                return new MagneticField(value, MagneticFieldUnit.Nanotesla);
            }
    }
}


