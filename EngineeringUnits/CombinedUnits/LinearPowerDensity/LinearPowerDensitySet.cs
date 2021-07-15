using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LinearPowerDensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromSI(double si)
        {
            double value = (double)si;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.SI);
        }

        /// <summary>
        ///     Get LinearPowerDensity from GigawattsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromGigawattsPerCentimeter(double gigawattspercentimeter)
        {
            double value = (double)gigawattspercentimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerCentimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from GigawattsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromGigawattsPerFoot(double gigawattsperfoot)
        {
            double value = (double)gigawattsperfoot;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerFoot);
        }
        /// <summary>
        ///     Get LinearPowerDensity from GigawattsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromGigawattsPerInch(double gigawattsperinch)
        {
            double value = (double)gigawattsperinch;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerInch);
        }
        /// <summary>
        ///     Get LinearPowerDensity from GigawattsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromGigawattsPerMeter(double gigawattspermeter)
        {
            double value = (double)gigawattspermeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerMeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from GigawattsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromGigawattsPerMillimeter(double gigawattspermillimeter)
        {
            double value = (double)gigawattspermillimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.GigawattPerMillimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from KilowattsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromKilowattsPerCentimeter(double kilowattspercentimeter)
        {
            double value = (double)kilowattspercentimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerCentimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from KilowattsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromKilowattsPerFoot(double kilowattsperfoot)
        {
            double value = (double)kilowattsperfoot;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerFoot);
        }
        /// <summary>
        ///     Get LinearPowerDensity from KilowattsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromKilowattsPerInch(double kilowattsperinch)
        {
            double value = (double)kilowattsperinch;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerInch);
        }
        /// <summary>
        ///     Get LinearPowerDensity from KilowattsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromKilowattsPerMeter(double kilowattspermeter)
        {
            double value = (double)kilowattspermeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerMeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from KilowattsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromKilowattsPerMillimeter(double kilowattspermillimeter)
        {
            double value = (double)kilowattspermillimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.KilowattPerMillimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MegawattsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMegawattsPerCentimeter(double megawattspercentimeter)
        {
            double value = (double)megawattspercentimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerCentimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MegawattsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMegawattsPerFoot(double megawattsperfoot)
        {
            double value = (double)megawattsperfoot;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerFoot);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MegawattsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMegawattsPerInch(double megawattsperinch)
        {
            double value = (double)megawattsperinch;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerInch);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MegawattsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMegawattsPerMeter(double megawattspermeter)
        {
            double value = (double)megawattspermeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerMeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MegawattsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMegawattsPerMillimeter(double megawattspermillimeter)
        {
            double value = (double)megawattspermillimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MegawattPerMillimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MilliwattsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMilliwattsPerCentimeter(double milliwattspercentimeter)
        {
            double value = (double)milliwattspercentimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerCentimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MilliwattsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMilliwattsPerFoot(double milliwattsperfoot)
        {
            double value = (double)milliwattsperfoot;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerFoot);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MilliwattsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMilliwattsPerInch(double milliwattsperinch)
        {
            double value = (double)milliwattsperinch;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerInch);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MilliwattsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMilliwattsPerMeter(double milliwattspermeter)
        {
            double value = (double)milliwattspermeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerMeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from MilliwattsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromMilliwattsPerMillimeter(double milliwattspermillimeter)
        {
            double value = (double)milliwattspermillimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.MilliwattPerMillimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from WattsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromWattsPerCentimeter(double wattspercentimeter)
        {
            double value = (double)wattspercentimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerCentimeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from WattsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromWattsPerFoot(double wattsperfoot)
        {
            double value = (double)wattsperfoot;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerFoot);
        }
        /// <summary>
        ///     Get LinearPowerDensity from WattsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromWattsPerInch(double wattsperinch)
        {
            double value = (double)wattsperinch;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerInch);
        }
        /// <summary>
        ///     Get LinearPowerDensity from WattsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromWattsPerMeter(double wattspermeter)
        {
            double value = (double)wattspermeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerMeter);
        }
        /// <summary>
        ///     Get LinearPowerDensity from WattsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearPowerDensity FromWattsPerMillimeter(double wattspermillimeter)
        {
            double value = (double)wattspermillimeter;
            return new LinearPowerDensity(value, LinearPowerDensityUnit.WattPerMillimeter);
        }

    }
}
