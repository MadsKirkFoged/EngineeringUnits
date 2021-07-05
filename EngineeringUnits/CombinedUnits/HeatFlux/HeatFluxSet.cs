using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class HeatFlux
    {
        /// <summary>
        ///     Get HeatFlux from BtusPerHourSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerHourSquareFoot(double btusperhoursquarefoot)
        {
            double value = (double)btusperhoursquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerHourSquareFoot);
        }
        /// <summary>
        ///     Get HeatFlux from BtusPerMinuteSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerMinuteSquareFoot(double btusperminutesquarefoot)
        {
            double value = (double)btusperminutesquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerMinuteSquareFoot);
        }
        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareFoot(double btuspersecondsquarefoot)
        {
            double value = (double)btuspersecondsquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareFoot);
        }
        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareInch(double btuspersecondsquareinch)
        {
            double value = (double)btuspersecondsquareinch;
            return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareInch);
        }
        /// <summary>
        ///     Get HeatFlux from CaloriesPerSecondSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCaloriesPerSecondSquareCentimeter(double caloriespersecondsquarecentimeter)
        {
            double value = (double)caloriespersecondsquarecentimeter;
            return new HeatFlux(value, HeatFluxUnit.CaloriePerSecondSquareCentimeter);
        }
        /// <summary>
        ///     Get HeatFlux from CentiwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCentiwattsPerSquareMeter(double centiwattspersquaremeter)
        {
            double value = (double)centiwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.CentiwattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from DeciwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromDeciwattsPerSquareMeter(double deciwattspersquaremeter)
        {
            double value = (double)deciwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.DeciwattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerHourSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerHourSquareMeter(double kilocaloriesperhoursquaremeter)
        {
            double value = (double)kilocaloriesperhoursquaremeter;
            return new HeatFlux(value, HeatFluxUnit.KilocaloriePerHourSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(double kilocaloriespersecondsquarecentimeter)
        {
            double value = (double)kilocaloriespersecondsquarecentimeter;
            return new HeatFlux(value, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);
        }
        /// <summary>
        ///     Get HeatFlux from KilowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilowattsPerSquareMeter(double kilowattspersquaremeter)
        {
            double value = (double)kilowattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.KilowattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from MicrowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMicrowattsPerSquareMeter(double microwattspersquaremeter)
        {
            double value = (double)microwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.MicrowattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from MilliwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMilliwattsPerSquareMeter(double milliwattspersquaremeter)
        {
            double value = (double)milliwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.MilliwattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from NanowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromNanowattsPerSquareMeter(double nanowattspersquaremeter)
        {
            double value = (double)nanowattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.NanowattPerSquareMeter);
        }
        /// <summary>
        ///     Get HeatFlux from PoundsForcePerFootSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsForcePerFootSecond(double poundsforceperfootsecond)
        {
            double value = (double)poundsforceperfootsecond;
            return new HeatFlux(value, HeatFluxUnit.PoundForcePerFootSecond);
        }
        /// <summary>
        ///     Get HeatFlux from PoundsPerSecondCubed.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsPerSecondCubed(double poundspersecondcubed)
        {
            double value = (double)poundspersecondcubed;
            return new HeatFlux(value, HeatFluxUnit.PoundPerSecondCubed);
        }
        /// <summary>
        ///     Get HeatFlux from WattsPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareFoot(double wattspersquarefoot)
        {
            double value = (double)wattspersquarefoot;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareFoot);
        }
        /// <summary>
        ///     Get HeatFlux from WattsPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareInch(double wattspersquareinch)
        {
            double value = (double)wattspersquareinch;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareInch);
        }
        /// <summary>
        ///     Get HeatFlux from WattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareMeter(double wattspersquaremeter)
        {
            double value = (double)wattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareMeter);
        }

    }
}
