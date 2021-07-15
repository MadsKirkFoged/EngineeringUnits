using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Irradiance
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromSI(double si)
        {
            double value = (double)si;
            return new Irradiance(value, IrradianceUnit.SI);
        }


        /// <summary>
        ///     Get Irradiance from KilowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromKilowattsPerSquareCentimeter(double kilowattspersquarecentimeter)
        {
            double value = (double)kilowattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.KilowattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from KilowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromKilowattsPerSquareMeter(double kilowattspersquaremeter)
        {
            double value = (double)kilowattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.KilowattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from MegawattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMegawattsPerSquareCentimeter(double megawattspersquarecentimeter)
        {
            double value = (double)megawattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.MegawattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from MegawattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMegawattsPerSquareMeter(double megawattspersquaremeter)
        {
            double value = (double)megawattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.MegawattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from MicrowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMicrowattsPerSquareCentimeter(double microwattspersquarecentimeter)
        {
            double value = (double)microwattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.MicrowattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from MicrowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMicrowattsPerSquareMeter(double microwattspersquaremeter)
        {
            double value = (double)microwattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.MicrowattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from MilliwattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMilliwattsPerSquareCentimeter(double milliwattspersquarecentimeter)
        {
            double value = (double)milliwattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.MilliwattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from MilliwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMilliwattsPerSquareMeter(double milliwattspersquaremeter)
        {
            double value = (double)milliwattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.MilliwattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from NanowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromNanowattsPerSquareCentimeter(double nanowattspersquarecentimeter)
        {
            double value = (double)nanowattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.NanowattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from NanowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromNanowattsPerSquareMeter(double nanowattspersquaremeter)
        {
            double value = (double)nanowattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.NanowattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from PicowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromPicowattsPerSquareCentimeter(double picowattspersquarecentimeter)
        {
            double value = (double)picowattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.PicowattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from PicowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromPicowattsPerSquareMeter(double picowattspersquaremeter)
        {
            double value = (double)picowattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.PicowattPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiance from WattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromWattsPerSquareCentimeter(double wattspersquarecentimeter)
        {
            double value = (double)wattspersquarecentimeter;
            return new Irradiance(value, IrradianceUnit.WattPerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiance from WattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromWattsPerSquareMeter(double wattspersquaremeter)
        {
            double value = (double)wattspersquaremeter;
            return new Irradiance(value, IrradianceUnit.WattPerSquareMeter);
        }

    }
}
