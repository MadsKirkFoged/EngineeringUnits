using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Irradiation
    {
        /// <summary>
        ///     Get Irradiation from JoulesPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareCentimeter(double joulespersquarecentimeter)
        {
            double value = (double)joulespersquarecentimeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareMeter(double joulespersquaremeter)
        {
            double value = (double)joulespersquaremeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulesPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareMillimeter(double joulespersquaremillimeter)
        {
            double value = (double)joulespersquaremillimeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareMillimeter);
        }
        /// <summary>
        ///     Get Irradiation from KilojoulesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilojoulesPerSquareMeter(double kilojoulespersquaremeter)
        {
            double value = (double)kilojoulespersquaremeter;
            return new Irradiation(value, IrradiationUnit.KilojoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from KilowattHoursPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilowattHoursPerSquareMeter(double kilowatthourspersquaremeter)
        {
            double value = (double)kilowatthourspersquaremeter;
            return new Irradiation(value, IrradiationUnit.KilowattHourPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from MillijoulesPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromMillijoulesPerSquareCentimeter(double millijoulespersquarecentimeter)
        {
            double value = (double)millijoulespersquarecentimeter;
            return new Irradiation(value, IrradiationUnit.MillijoulePerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiation from WattHoursPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromWattHoursPerSquareMeter(double watthourspersquaremeter)
        {
            double value = (double)watthourspersquaremeter;
            return new Irradiation(value, IrradiationUnit.WattHourPerSquareMeter);
        }

    }
}
