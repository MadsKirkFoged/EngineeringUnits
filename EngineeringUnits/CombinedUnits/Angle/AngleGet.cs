using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Angle
    {
        /// <summary>
        ///     Get Angle in Arcminutes.
        /// </summary>
        public double Arcminutes => As(AngleUnit.Arcminute);

        /// <summary>
        ///     Get Angle in Arcseconds.
        /// </summary>
        public double Arcseconds => As(AngleUnit.Arcsecond);

        /// <summary>
        ///     Get Angle in Centiradians.
        /// </summary>
        public double Centiradians => As(AngleUnit.Centiradian);

        /// <summary>
        ///     Get Angle in Deciradians.
        /// </summary>
        public double Deciradians => As(AngleUnit.Deciradian);

        /// <summary>
        ///     Get Angle in Degrees.
        /// </summary>
        public double Degrees => As(AngleUnit.Degree);

        /// <summary>
        ///     Get Angle in Gradians.
        /// </summary>
        public double Gradians => As(AngleUnit.Gradian);

        /// <summary>
        ///     Get Angle in Microdegrees.
        /// </summary>
        public double Microdegrees => As(AngleUnit.Microdegree);

        /// <summary>
        ///     Get Angle in Microradians.
        /// </summary>
        public double Microradians => As(AngleUnit.Microradian);

        /// <summary>
        ///     Get Angle in Millidegrees.
        /// </summary>
        public double Millidegrees => As(AngleUnit.Millidegree);

        /// <summary>
        ///     Get Angle in Milliradians.
        /// </summary>
        public double Milliradians => As(AngleUnit.Milliradian);

        /// <summary>
        ///     Get Angle in Nanodegrees.
        /// </summary>
        public double Nanodegrees => As(AngleUnit.Nanodegree);

        /// <summary>
        ///     Get Angle in Nanoradians.
        /// </summary>
        public double Nanoradians => As(AngleUnit.Nanoradian);

        /// <summary>
        ///     Get Angle in Radians.
        /// </summary>
        public double Radians => As(AngleUnit.Radian);


        /// <summary>
        ///     Get Angle in SI Unit (Radians).
        /// </summary>
        public double SI => As(AngleUnit.SI);

        /// <summary>
        ///     Get Angle in Revolutions.
        /// </summary>
        public double Revolutions => As(AngleUnit.Revolution);

        /// <summary>
        ///     Get Angle in Tilt.
        /// </summary>
        //public double Tilt => As(AngleUnit.Tilt);

    }
}
