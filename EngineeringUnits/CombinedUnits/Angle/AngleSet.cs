using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Angle
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromSI(double si)
        {
            double value = (double)si;
            return new Angle(value, AngleUnit.SI);
        }

        /// <summary>
        ///     Get Angle from Arcminutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcminutes(double arcminutes)
        {
            double value = (double)arcminutes;
            return new Angle(value, AngleUnit.Arcminute);
        }
        /// <summary>
        ///     Get Angle from Arcseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcseconds(double arcseconds)
        {
            double value = (double)arcseconds;
            return new Angle(value, AngleUnit.Arcsecond);
        }
        /// <summary>
        ///     Get Angle from Centiradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromCentiradians(double centiradians)
        {
            double value = (double)centiradians;
            return new Angle(value, AngleUnit.Centiradian);
        }
        /// <summary>
        ///     Get Angle from Deciradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDeciradians(double deciradians)
        {
            double value = (double)deciradians;
            return new Angle(value, AngleUnit.Deciradian);
        }
        /// <summary>
        ///     Get Angle from Degrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDegrees(double degrees)
        {
            double value = (double)degrees;
            return new Angle(value, AngleUnit.Degree);
        }
        /// <summary>
        ///     Get Angle from Gradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromGradians(double gradians)
        {
            double value = (double)gradians;
            return new Angle(value, AngleUnit.Gradian);
        }
        /// <summary>
        ///     Get Angle from Microdegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicrodegrees(double microdegrees)
        {
            double value = (double)microdegrees;
            return new Angle(value, AngleUnit.Microdegree);
        }
        /// <summary>
        ///     Get Angle from Microradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicroradians(double microradians)
        {
            double value = (double)microradians;
            return new Angle(value, AngleUnit.Microradian);
        }
        /// <summary>
        ///     Get Angle from Millidegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMillidegrees(double millidegrees)
        {
            double value = (double)millidegrees;
            return new Angle(value, AngleUnit.Millidegree);
        }
        /// <summary>
        ///     Get Angle from Milliradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMilliradians(double milliradians)
        {
            double value = (double)milliradians;
            return new Angle(value, AngleUnit.Milliradian);
        }
        /// <summary>
        ///     Get Angle from Nanodegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanodegrees(double nanodegrees)
        {
            double value = (double)nanodegrees;
            return new Angle(value, AngleUnit.Nanodegree);
        }
        /// <summary>
        ///     Get Angle from Nanoradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanoradians(double nanoradians)
        {
            double value = (double)nanoradians;
            return new Angle(value, AngleUnit.Nanoradian);
        }
        /// <summary>
        ///     Get Angle from Radians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRadians(double radians)
        {
            double value = (double)radians;
            return new Angle(value, AngleUnit.Radian);
        }
        /// <summary>
        ///     Get Angle from Revolutions.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRevolutions(double revolutions)
        {
            double value = (double)revolutions;
            return new Angle(value, AngleUnit.Revolution);
        }
        /// <summary>
        ///     Get Angle from Tilt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Angle FromTilt(double tilt)
        //{
        //    double value = (double)tilt;
        //    return new Angle(value, AngleUnit.Tilt);
        //}

    }
}
