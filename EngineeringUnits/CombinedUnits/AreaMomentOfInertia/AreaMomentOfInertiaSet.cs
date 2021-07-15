using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AreaMomentOfInertia
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromSI(double si)
        {
            double value = (double)si;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.SI);
        }

        /// <summary>
        ///     Get AreaMomentOfInertia from CentimetersToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromCentimetersToTheFourth(double centimeterstothefourth)
        {
            double value = (double)centimeterstothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.CentimeterToTheFourth);
        }
        /// <summary>
        ///     Get AreaMomentOfInertia from DecimetersToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromDecimetersToTheFourth(double decimeterstothefourth)
        {
            double value = (double)decimeterstothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.DecimeterToTheFourth);
        }
        /// <summary>
        ///     Get AreaMomentOfInertia from FeetToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromFeetToTheFourth(double feettothefourth)
        {
            double value = (double)feettothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.FootToTheFourth);
        }
        /// <summary>
        ///     Get AreaMomentOfInertia from InchesToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromInchesToTheFourth(double inchestothefourth)
        {
            double value = (double)inchestothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.InchToTheFourth);
        }
        /// <summary>
        ///     Get AreaMomentOfInertia from MetersToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromMetersToTheFourth(double meterstothefourth)
        {
            double value = (double)meterstothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.MeterToTheFourth);
        }
        /// <summary>
        ///     Get AreaMomentOfInertia from MillimetersToTheFourth.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromMillimetersToTheFourth(double millimeterstothefourth)
        {
            double value = (double)millimeterstothefourth;
            return new AreaMomentOfInertia(value, AreaMomentOfInertiaUnit.MillimeterToTheFourth);
        }

    }
}
