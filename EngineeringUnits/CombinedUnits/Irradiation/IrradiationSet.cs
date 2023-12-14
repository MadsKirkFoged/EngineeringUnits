
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
        public static Irradiation FromSI(double? SI)
        {
            if (SI is null)
                return null;

            return new Irradiation((double)SI, IrradiationUnit.SI);
        }
        /// <summary>
        ///     Get Irradiation from JoulePerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulePerSquareMeter(double? JoulePerSquareMeter)
        {
            if (JoulePerSquareMeter is null)
                return null;

            return new Irradiation((double)JoulePerSquareMeter, IrradiationUnit.JoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulePerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulePerSquareCentimeter(double? JoulePerSquareCentimeter)
        {
            if (JoulePerSquareCentimeter is null)
                return null;

            return new Irradiation((double)JoulePerSquareCentimeter, IrradiationUnit.JoulePerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulePerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulePerSquareMillimeter(double? JoulePerSquareMillimeter)
        {
            if (JoulePerSquareMillimeter is null)
                return null;

            return new Irradiation((double)JoulePerSquareMillimeter, IrradiationUnit.JoulePerSquareMillimeter);
        }
        /// <summary>
        ///     Get Irradiation from KilojoulePerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilojoulePerSquareMeter(double? KilojoulePerSquareMeter)
        {
            if (KilojoulePerSquareMeter is null)
                return null;

            return new Irradiation((double)KilojoulePerSquareMeter, IrradiationUnit.KilojoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from KilowattHourPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilowattHourPerSquareMeter(double? KilowattHourPerSquareMeter)
        {
            if (KilowattHourPerSquareMeter is null)
                return null;

            return new Irradiation((double)KilowattHourPerSquareMeter, IrradiationUnit.KilowattHourPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from MillijoulePerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromMillijoulePerSquareCentimeter(double? MillijoulePerSquareCentimeter)
        {
            if (MillijoulePerSquareCentimeter is null)
                return null;

            return new Irradiation((double)MillijoulePerSquareCentimeter, IrradiationUnit.MillijoulePerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiation from WattHourPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromWattHourPerSquareMeter(double? WattHourPerSquareMeter)
        {
            if (WattHourPerSquareMeter is null)
                return null;

            return new Irradiation((double)WattHourPerSquareMeter, IrradiationUnit.WattHourPerSquareMeter);
        }
    }
}


