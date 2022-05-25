
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Irradiation
    {

 

            /// <summary>
            ///     Get Irradiation from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromSI(double SI)
            {
                double value= (double)SI;
                return new Irradiation(value, IrradiationUnit.SI);
            }
            /// <summary>
            ///     Get Irradiation from JoulePerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromJoulePerSquareMeter(double JoulePerSquareMeter)
            {
                double value= (double)JoulePerSquareMeter;
                return new Irradiation(value, IrradiationUnit.JoulePerSquareMeter);
            }
            /// <summary>
            ///     Get Irradiation from JoulePerSquareCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromJoulePerSquareCentimeter(double JoulePerSquareCentimeter)
            {
                double value= (double)JoulePerSquareCentimeter;
                return new Irradiation(value, IrradiationUnit.JoulePerSquareCentimeter);
            }
            /// <summary>
            ///     Get Irradiation from JoulePerSquareMillimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromJoulePerSquareMillimeter(double JoulePerSquareMillimeter)
            {
                double value= (double)JoulePerSquareMillimeter;
                return new Irradiation(value, IrradiationUnit.JoulePerSquareMillimeter);
            }
            /// <summary>
            ///     Get Irradiation from KilojoulePerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromKilojoulePerSquareMeter(double KilojoulePerSquareMeter)
            {
                double value= (double)KilojoulePerSquareMeter;
                return new Irradiation(value, IrradiationUnit.KilojoulePerSquareMeter);
            }
            /// <summary>
            ///     Get Irradiation from KilowattHourPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromKilowattHourPerSquareMeter(double KilowattHourPerSquareMeter)
            {
                double value= (double)KilowattHourPerSquareMeter;
                return new Irradiation(value, IrradiationUnit.KilowattHourPerSquareMeter);
            }
            /// <summary>
            ///     Get Irradiation from MillijoulePerSquareCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromMillijoulePerSquareCentimeter(double MillijoulePerSquareCentimeter)
            {
                double value= (double)MillijoulePerSquareCentimeter;
                return new Irradiation(value, IrradiationUnit.MillijoulePerSquareCentimeter);
            }
            /// <summary>
            ///     Get Irradiation from WattHourPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Irradiation FromWattHourPerSquareMeter(double WattHourPerSquareMeter)
            {
                double value= (double)WattHourPerSquareMeter;
                return new Irradiation(value, IrradiationUnit.WattHourPerSquareMeter);
            }
    }
}


