using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Length
    {

        // <summary>
        ///     Get Length from AstronomicalUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromAstronomicalUnits(double astronomicalunits)
        {
            double value = (double)astronomicalunits;
            return new Length(value, LengthUnit.AstronomicalUnit);
        }
        /// <summary>
        ///     Get Length from Centimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromCentimeters(double centimeters)
        {
            double value = (double)centimeters;
            return new Length(value, LengthUnit.Centimeter);
        }
        /// <summary>
        ///     Get Length from Chains.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromChains(double chains)
        {
            double value = (double)chains;
            return new Length(value, LengthUnit.Chain);
        }
        /// <summary>
        ///     Get Length from Decimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromDecimeters(double decimeters)
        {
            double value = (double)decimeters;
            return new Length(value, LengthUnit.Decimeter);
        }
        /// <summary>
        ///     Get Length from DtpPicas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromDtpPicas(double dtppicas)
        //{
        //    double value = (double)dtppicas;
        //    return new Length(value, LengthUnit.DtpPica);
        //}
        /// <summary>
        ///     Get Length from DtpPoints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromDtpPoints(double dtppoints)
        //{
        //    double value = (double)dtppoints;
        //    return new Length(value, LengthUnit.DtpPoint);
        //}
        /// <summary>
        ///     Get Length from Fathoms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromFathoms(double fathoms)
        //{
        //    double value = (double)fathoms;
        //    return new Length(value, LengthUnit.Fathom);
        //}
        /// <summary>
        ///     Get Length from Feet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromFeet(double feet)
        {
            double value = (double)feet;
            return new Length(value, LengthUnit.Foot);
        }
        /// <summary>
        ///     Get Length from Hands.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromHands(double hands)
        {
            double value = (double)hands;
            return new Length(value, LengthUnit.Hand);
        }
        /// <summary>
        ///     Get Length from Hectometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromHectometers(double hectometers)
        //{
        //    double value = (double)hectometers;
        //    return new Length(value, LengthUnit.Hectometer);
        //}
        /// <summary>
        ///     Get Length from Inches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromInches(double inches)
        {
            double value = (double)inches;
            return new Length(value, LengthUnit.Inch);
        }
        /// <summary>
        ///     Get Length from KilolightYears.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromKilolightYears(double kilolightyears)
        //{
        //    double value = (double)kilolightyears;
        //    return new Length(value, LengthUnit.KilolightYear);
        //}
        /// <summary>
        ///     Get Length from Kilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromKilometers(double kilometers)
        {
            double value = (double)kilometers;
            return new Length(value, LengthUnit.Kilometer);
        }
        /// <summary>
        ///     Get Length from Kiloparsecs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromKiloparsecs(double kiloparsecs)
        //{
        //    double value = (double)kiloparsecs;
        //    return new Length(value, LengthUnit.Kiloparsec);
        //}
        /// <summary>
        ///     Get Length from LightYears.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromLightYears(double lightyears)
        {
            double value = (double)lightyears;
            return new Length(value, LengthUnit.LightYear);
        }
        /// <summary>
        ///     Get Length from MegalightYears.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromMegalightYears(double megalightyears)
        //{
        //    double value = (double)megalightyears;
        //    return new Length(value, LengthUnit.MegalightYear);
        //}
        /// <summary>
        ///     Get Length from Megaparsecs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromMegaparsecs(double megaparsecs)
        //{
        //    double value = (double)megaparsecs;
        //    return new Length(value, LengthUnit.Megaparsec);
        //}
        /// <summary>
        ///     Get Length from Meters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMeters(double meters)
        {
            double value = (double)meters;
            return new Length(value, LengthUnit.Meter);
        }
        /// <summary>
        ///     Get Length from Microinches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromMicroinches(double microinches)
        //{
        //    double value = (double)microinches;
        //    return new Length(value, LengthUnit.Microinch);
        //}
        /// <summary>
        ///     Get Length from Micrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromMicrometers(double micrometers)
        //{
        //    double value = (double)micrometers;
        //    return new Length(value, LengthUnit.Micrometer);
        //}
        /// <summary>
        ///     Get Length from Mils.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromMils(double mils)
        //{
        //    double value = (double)mils;
        //    return new Length(value, LengthUnit.Mil);
        //}
        /// <summary>
        ///     Get Length from Miles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMiles(double miles)
        {
            double value = (double)miles;
            return new Length(value, LengthUnit.Mile);
        }
        /// <summary>
        ///     Get Length from Millimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMillimeters(double millimeters)
        {
            double value = (double)millimeters;
            return new Length(value, LengthUnit.Millimeter);
        }
        /// <summary>
        ///     Get Length from Nanometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromNanometers(double nanometers)
        {
            double value = (double)nanometers;
            return new Length(value, LengthUnit.Nanometer);
        }
        /// <summary>
        ///     Get Length from NauticalMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromNauticalMiles(double nauticalmiles)
        //{
        //    double value = (double)nauticalmiles;
        //    return new Length(value, LengthUnit.NauticalMile);
        //}
        /// <summary>
        ///     Get Length from Parsecs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromParsecs(double parsecs)
        {
            double value = (double)parsecs;
            return new Length(value, LengthUnit.Parsec);
        }
        /// <summary>
        ///     Get Length from PrinterPicas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromPrinterPicas(double printerpicas)
        //{
        //    double value = (double)printerpicas;
        //    return new Length(value, LengthUnit.PrinterPica);
        //}
        /// <summary>
        ///     Get Length from PrinterPoints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromPrinterPoints(double printerpoints)
        //{
        //    double value = (double)printerpoints;
        //    return new Length(value, LengthUnit.PrinterPoint);
        //}
        /// <summary>
        ///     Get Length from Shackles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromShackles(double shackles)
        //{
        //    double value = (double)shackles;
        //    return new Length(value, LengthUnit.Shackle);
        //}
        /// <summary>
        ///     Get Length from SolarRadiuses.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromSolarRadiuses(double solarradiuses)
        //{
        //    double value = (double)solarradiuses;
        //    return new Length(value, LengthUnit.SolarRadius);
        //}
        /// <summary>
        ///     Get Length from Twips.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromTwips(double twips)
        //{
        //    double value = (double)twips;
        //    return new Length(value, LengthUnit.Twip);
        //}
        /// <summary>
        ///     Get Length from UsSurveyFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Length FromUsSurveyFeet(double ussurveyfeet)
        //{
        //    double value = (double)ussurveyfeet;
        //    return new Length(value, LengthUnit.UsSurveyFoot);
        //}
        /// <summary>
        ///     Get Length from Yards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromYards(double yards)
        {
            double value = (double)yards;
            return new Length(value, LengthUnit.Yard);
        }


    }
}
