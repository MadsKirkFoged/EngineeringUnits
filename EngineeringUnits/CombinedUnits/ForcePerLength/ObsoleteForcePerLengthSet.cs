using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ForcePerLength
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ForcePerLength FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ForcePerLength(value, ForcePerLengthUnit.SI);
        //}

        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentinewtonsPerCentimeter->FromCentinewtonPerCentimeter")]
        public static ForcePerLength FromCentinewtonsPerCentimeter(double centinewtonspercentimeter)
        {
            double value = (double)centinewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.CentinewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentinewtonsPerMeter->FromCentinewtonPerMeter")]
        public static ForcePerLength FromCentinewtonsPerMeter(double centinewtonspermeter)
        {
            double value = (double)centinewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.CentinewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentinewtonsPerMillimeter->FromCentinewtonPerMillimeter")]
        public static ForcePerLength FromCentinewtonsPerMillimeter(double centinewtonspermillimeter)
        {
            double value = (double)centinewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.CentinewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecanewtonsPerCentimeter->FromDecanewtonPerCentimeter")]
        public static ForcePerLength FromDecanewtonsPerCentimeter(double decanewtonspercentimeter)
        {
            double value = (double)decanewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecanewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecanewtonsPerMeter->FromDecanewtonPerMeter")]
        public static ForcePerLength FromDecanewtonsPerMeter(double decanewtonspermeter)
        {
            double value = (double)decanewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecanewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecanewtonsPerMillimeter->FromDecanewtonPerMillimeter")]
        public static ForcePerLength FromDecanewtonsPerMillimeter(double decanewtonspermillimeter)
        {
            double value = (double)decanewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecanewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecinewtonsPerCentimeter->FromDecinewtonPerCentimeter")]
        public static ForcePerLength FromDecinewtonsPerCentimeter(double decinewtonspercentimeter)
        {
            double value = (double)decinewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecinewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecinewtonsPerMeter->FromDecinewtonPerMeter")]
        public static ForcePerLength FromDecinewtonsPerMeter(double decinewtonspermeter)
        {
            double value = (double)decinewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecinewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecinewtonsPerMillimeter->FromDecinewtonPerMillimeter")]
        public static ForcePerLength FromDecinewtonsPerMillimeter(double decinewtonspermillimeter)
        {
            double value = (double)decinewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.DecinewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsForcePerCentimeter->FromKilogramForcePerCentimeter")]
        public static ForcePerLength FromKilogramsForcePerCentimeter(double kilogramsforcepercentimeter)
        {
            double value = (double)kilogramsforcepercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilogramForcePerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsForcePerMeter->FromKilogramForcePerMeter")]
        public static ForcePerLength FromKilogramsForcePerMeter(double kilogramsforcepermeter)
        {
            double value = (double)kilogramsforcepermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilogramForcePerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsForcePerMillimeter->FromKilogramForcePerMillimeter")]
        public static ForcePerLength FromKilogramsForcePerMillimeter(double kilogramsforcepermillimeter)
        {
            double value = (double)kilogramsforcepermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilogramForcePerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilonewtonsPerCentimeter->FromKilonewtonPerCentimeter")]
        public static ForcePerLength FromKilonewtonsPerCentimeter(double kilonewtonspercentimeter)
        {
            double value = (double)kilonewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilonewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilonewtonsPerMeter->FromKilonewtonPerMeter")]
        public static ForcePerLength FromKilonewtonsPerMeter(double kilonewtonspermeter)
        {
            double value = (double)kilonewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilonewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilonewtonsPerMillimeter->FromKilonewtonPerMillimeter")]
        public static ForcePerLength FromKilonewtonsPerMillimeter(double kilonewtonspermillimeter)
        {
            double value = (double)kilonewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.KilonewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from KilopoundsForcePerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilopoundsForcePerFoot->FromKilopoundForcePerFoot")]
        public static ForcePerLength FromKilopoundsForcePerFoot(double kilopoundsforceperfoot)
        {
            double value = (double)kilopoundsforceperfoot;
            return new ForcePerLength(value, ForcePerLengthUnit.KilopoundForcePerFoot);
        }
        /// <summary>
        ///     Get ForcePerLength from KilopoundsForcePerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilopoundsForcePerInch->FromKilopoundForcePerInch")]
        public static ForcePerLength FromKilopoundsForcePerInch(double kilopoundsforceperinch)
        {
            double value = (double)kilopoundsforceperinch;
            return new ForcePerLength(value, ForcePerLengthUnit.KilopoundForcePerInch);
        }
        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMeganewtonsPerCentimeter->FromMeganewtonPerCentimeter")]
        public static ForcePerLength FromMeganewtonsPerCentimeter(double meganewtonspercentimeter)
        {
            double value = (double)meganewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MeganewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMeganewtonsPerMeter->FromMeganewtonPerMeter")]
        public static ForcePerLength FromMeganewtonsPerMeter(double meganewtonspermeter)
        {
            double value = (double)meganewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MeganewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMeganewtonsPerMillimeter->FromMeganewtonPerMillimeter")]
        public static ForcePerLength FromMeganewtonsPerMillimeter(double meganewtonspermillimeter)
        {
            double value = (double)meganewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MeganewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicronewtonsPerCentimeter->FromMicronewtonPerCentimeter")]
        public static ForcePerLength FromMicronewtonsPerCentimeter(double micronewtonspercentimeter)
        {
            double value = (double)micronewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MicronewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicronewtonsPerMeter->FromMicronewtonPerMeter")]
        public static ForcePerLength FromMicronewtonsPerMeter(double micronewtonspermeter)
        {
            double value = (double)micronewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MicronewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicronewtonsPerMillimeter->FromMicronewtonPerMillimeter")]
        public static ForcePerLength FromMicronewtonsPerMillimeter(double micronewtonspermillimeter)
        {
            double value = (double)micronewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MicronewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillinewtonsPerCentimeter->FromMillinewtonPerCentimeter")]
        public static ForcePerLength FromMillinewtonsPerCentimeter(double millinewtonspercentimeter)
        {
            double value = (double)millinewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MillinewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillinewtonsPerMeter->FromMillinewtonPerMeter")]
        public static ForcePerLength FromMillinewtonsPerMeter(double millinewtonspermeter)
        {
            double value = (double)millinewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MillinewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillinewtonsPerMillimeter->FromMillinewtonPerMillimeter")]
        public static ForcePerLength FromMillinewtonsPerMillimeter(double millinewtonspermillimeter)
        {
            double value = (double)millinewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.MillinewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanonewtonsPerCentimeter->FromNanonewtonPerCentimeter")]
        public static ForcePerLength FromNanonewtonsPerCentimeter(double nanonewtonspercentimeter)
        {
            double value = (double)nanonewtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NanonewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanonewtonsPerMeter->FromNanonewtonPerMeter")]
        public static ForcePerLength FromNanonewtonsPerMeter(double nanonewtonspermeter)
        {
            double value = (double)nanonewtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NanonewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanonewtonsPerMillimeter->FromNanonewtonPerMillimeter")]
        public static ForcePerLength FromNanonewtonsPerMillimeter(double nanonewtonspermillimeter)
        {
            double value = (double)nanonewtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NanonewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNewtonsPerCentimeter->FromNewtonPerCentimeter")]
        public static ForcePerLength FromNewtonsPerCentimeter(double newtonspercentimeter)
        {
            double value = (double)newtonspercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NewtonPerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNewtonsPerMeter->FromNewtonPerMeter")]
        public static ForcePerLength FromNewtonsPerMeter(double newtonspermeter)
        {
            double value = (double)newtonspermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NewtonPerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from NewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNewtonsPerMillimeter->FromNewtonPerMillimeter")]
        public static ForcePerLength FromNewtonsPerMillimeter(double newtonspermillimeter)
        {
            double value = (double)newtonspermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.NewtonPerMillimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsForcePerFoot->FromPoundForcePerFoot")]
        public static ForcePerLength FromPoundsForcePerFoot(double poundsforceperfoot)
        {
            double value = (double)poundsforceperfoot;
            return new ForcePerLength(value, ForcePerLengthUnit.PoundForcePerFoot);
        }
        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsForcePerInch->FromPoundForcePerInch")]
        public static ForcePerLength FromPoundsForcePerInch(double poundsforceperinch)
        {
            double value = (double)poundsforceperinch;
            return new ForcePerLength(value, ForcePerLengthUnit.PoundForcePerInch);
        }
        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerYard.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsForcePerYard->FromPoundForcePerYard")]
        public static ForcePerLength FromPoundsForcePerYard(double poundsforceperyard)
        {
            double value = (double)poundsforceperyard;
            return new ForcePerLength(value, ForcePerLengthUnit.PoundForcePerYard);
        }
        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesForcePerCentimeter->FromTonneForcePerCentimeter")]
        public static ForcePerLength FromTonnesForcePerCentimeter(double tonnesforcepercentimeter)
        {
            double value = (double)tonnesforcepercentimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.TonneForcePerCentimeter);
        }
        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesForcePerMeter->FromTonneForcePerMeter")]
        public static ForcePerLength FromTonnesForcePerMeter(double tonnesforcepermeter)
        {
            double value = (double)tonnesforcepermeter;
            return new ForcePerLength(value, ForcePerLengthUnit.TonneForcePerMeter);
        }
        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesForcePerMillimeter->FromTonneForcePerMillimeter")]
        public static ForcePerLength FromTonnesForcePerMillimeter(double tonnesforcepermillimeter)
        {
            double value = (double)tonnesforcepermillimeter;
            return new ForcePerLength(value, ForcePerLengthUnit.TonneForcePerMillimeter);
        }

    }
}
