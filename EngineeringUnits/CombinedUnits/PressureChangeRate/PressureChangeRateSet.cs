using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class PressureChangeRate
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromSI(double si)
        {
            double value = (double)si;
            return new PressureChangeRate(value, PressureChangeRateUnit.SI);
        }

        /// <summary>
        ///     Get PressureChangeRate from AtmospheresPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromAtmospheresPerSecond(double atmospherespersecond)
        {
            double value = (double)atmospherespersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.AtmospherePerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from KilopascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopascalsPerMinute(double kilopascalsperminute)
        {
            double value = (double)kilopascalsperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.KilopascalPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from KilopascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopascalsPerSecond(double kilopascalspersecond)
        {
            double value = (double)kilopascalspersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.KilopascalPerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopoundsForcePerSquareInchPerMinute(double kilopoundsforcepersquareinchperminute)
        {
            double value = (double)kilopoundsforcepersquareinchperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopoundsForcePerSquareInchPerSecond(double kilopoundsforcepersquareinchpersecond)
        {
            double value = (double)kilopoundsforcepersquareinchpersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from MegapascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapascalsPerMinute(double megapascalsperminute)
        {
            double value = (double)megapascalsperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.MegapascalPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from MegapascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapascalsPerSecond(double megapascalspersecond)
        {
            double value = (double)megapascalspersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.MegapascalPerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapoundsForcePerSquareInchPerMinute(double megapoundsforcepersquareinchperminute)
        {
            double value = (double)megapoundsforcepersquareinchperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapoundsForcePerSquareInchPerSecond(double megapoundsforcepersquareinchpersecond)
        {
            double value = (double)megapoundsforcepersquareinchpersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from PascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPascalsPerMinute(double pascalsperminute)
        {
            double value = (double)pascalsperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.PascalPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from PascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPascalsPerSecond(double pascalspersecond)
        {
            double value = (double)pascalspersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.PascalPerSecond);
        }
        /// <summary>
        ///     Get PressureChangeRate from PoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPoundsForcePerSquareInchPerMinute(double poundsforcepersquareinchperminute)
        {
            double value = (double)poundsforcepersquareinchperminute;
            return new PressureChangeRate(value, PressureChangeRateUnit.PoundForcePerSquareInchPerMinute);
        }
        /// <summary>
        ///     Get PressureChangeRate from PoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPoundsForcePerSquareInchPerSecond(double poundsforcepersquareinchpersecond)
        {
            double value = (double)poundsforcepersquareinchpersecond;
            return new PressureChangeRate(value, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
        }

    }
}
