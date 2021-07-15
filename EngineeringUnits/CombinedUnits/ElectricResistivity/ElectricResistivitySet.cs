using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricResistivity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromSI(double si)
        {
            double value = (double)si;
            return new ElectricResistivity(value, ElectricResistivityUnit.SI);
        }

        /// <summary>
        ///     Get ElectricResistivity from KiloohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromKiloohmsCentimeter(double kiloohmscentimeter)
        {
            double value = (double)kiloohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from KiloohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromKiloohmMeters(double kiloohmmeters)
        {
            double value = (double)kiloohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MegaohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMegaohmsCentimeter(double megaohmscentimeter)
        {
            double value = (double)megaohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MegaohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMegaohmMeters(double megaohmmeters)
        {
            double value = (double)megaohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MicroohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMicroohmsCentimeter(double microohmscentimeter)
        {
            double value = (double)microohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MicroohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMicroohmMeters(double microohmmeters)
        {
            double value = (double)microohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MilliohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMilliohmsCentimeter(double milliohmscentimeter)
        {
            double value = (double)milliohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MilliohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMilliohmMeters(double milliohmmeters)
        {
            double value = (double)milliohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from NanoohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromNanoohmsCentimeter(double nanoohmscentimeter)
        {
            double value = (double)nanoohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from NanoohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromNanoohmMeters(double nanoohmmeters)
        {
            double value = (double)nanoohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from OhmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromOhmsCentimeter(double ohmscentimeter)
        {
            double value = (double)ohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.OhmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from OhmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromOhmMeters(double ohmmeters)
        {
            double value = (double)ohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.OhmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from PicoohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromPicoohmsCentimeter(double picoohmscentimeter)
        {
            double value = (double)picoohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from PicoohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromPicoohmMeters(double picoohmmeters)
        {
            double value = (double)picoohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmMeter);
        }

    }
}
