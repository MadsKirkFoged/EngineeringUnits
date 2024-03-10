﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Length
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Length FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Length(value, LengthUnit.SI);
    //}

    // <summary>
    ///     Get Length from AstronomicalUnits.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAstronomicalUnits->FromAstronomicalUnit")]
    public static Length FromAstronomicalUnits(double astronomicalunits)
    {
        var value = (double)astronomicalunits;
        return new Length(value, LengthUnit.AstronomicalUnit);
    }
    /// <summary>
    ///     Get Length from Centimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentimeters->FromCentimeter")]
    public static Length FromCentimeters(double centimeters)
    {
        var value = (double)centimeters;
        return new Length(value, LengthUnit.Centimeter);
    }
    /// <summary>
    ///     Get Length from Chains.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromChains->FromChain")]
    public static Length FromChains(double chains)
    {
        var value = (double)chains;
        return new Length(value, LengthUnit.Chain);
    }
    /// <summary>
    ///     Get Length from Decimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecimeters->FromDecimeter")]
    public static Length FromDecimeters(double decimeters)
    {
        var value = (double)decimeters;
        return new Length(value, LengthUnit.Decimeter);
    }
    /// <summary>
    ///     Get Length from DtpPicas.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromdDtpPicas->FromdDtpPica")]
    public static Length fromdtppicas(double dtppicas)
    {
        var value = (double)dtppicas;
        return new Length(value, LengthUnit.DtpPica);
    }
    /// <summary>
    ///     Get Length from DtpPoints.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDtpPoints->FromDtpPoint")]
    public static Length FromDtpPoints(double dtppoints)
    {
        var value = (double)dtppoints;
        return new Length(value, LengthUnit.DtpPoint);
    }
    /// <summary>
    ///     Get Length from Fathoms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromFathoms->FromFathom")]
    public static Length FromFathoms(double fathoms)
    {
        var value = (double)fathoms;
        return new Length(value, LengthUnit.Fathom);
    }
    /// <summary>
    ///     Get Length from Feet.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromFeet->FromFoot")]
    public static Length FromFeet(double feet)
    {
        var value = (double)feet;
        return new Length(value, LengthUnit.Foot);
    }
    /// <summary>
    ///     Get Length from Hands.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHands->FromHand")]
    public static Length FromHands(double hands)
    {
        var value = (double)hands;
        return new Length(value, LengthUnit.Hand);
    }
    /// <summary>
    ///     Get Length from Hectometers.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectometers->FromHectometer")]
    public static Length FromHectometers(double hectometers)
    {
        var value = (double)hectometers;
        return new Length(value, LengthUnit.Hectometer);
    }
    /// <summary>
    ///     Get Length from Inches.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromInches->FromInch")]
    public static Length FromInches(double inches)
    {
        var value = (double)inches;
        return new Length(value, LengthUnit.Inch);
    }
    /// <summary>
    ///     Get Length from KilolightYears.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilolightYears->FromKilolightYear")]
    public static Length FromKilolightYears(double kilolightyears)
    {
        var value = (double)kilolightyears;
        return new Length(value, LengthUnit.KilolightYear);
    }
    /// <summary>
    ///     Get Length from Kilometers.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilometers->FromKilometer")]
    public static Length FromKilometers(double kilometers)
    {
        var value = (double)kilometers;
        return new Length(value, LengthUnit.Kilometer);
    }
    /// <summary>
    ///     Get Length from Kiloparsecs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloparsecs->FromKiloparsec")]
    public static Length FromKiloparsecs(double kiloparsecs)
    {
        var value = (double)kiloparsecs;
        return new Length(value, LengthUnit.Kiloparsec);
    }
    /// <summary>
    ///     Get Length from LightYears.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLightYears->FromLightYear")]
    public static Length FromLightYears(double lightyears)
    {
        var value = (double)lightyears;
        return new Length(value, LengthUnit.LightYear);
    }
    /// <summary>
    ///     Get Length from MegalightYears.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegalightYear->FromMegalightYears")]
    public static Length FromMegalightYears(double megalightyears)
    {
        var value = (double)megalightyears;
        return new Length(value, LengthUnit.MegalightYear);
    }
    /// <summary>
    ///     Get Length from Megaparsecs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaparsecs->FromMegaparsec")]
    public static Length FromMegaparsecs(double megaparsecs)
    {
        var value = (double)megaparsecs;
        return new Length(value, LengthUnit.Megaparsec);
    }
    /// <summary>
    ///     Get Length from Meters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeters->FromMeter")]
    public static Length FromMeters(double meters)
    {
        var value = (double)meters;
        return new Length(value, LengthUnit.Meter);
    }
    /// <summary>
    ///     Get Length from Microinches.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroinches->FromMicroinch")]
    public static Length FromMicroinches(double microinches)
    {
        var value = (double)microinches;
        return new Length(value, LengthUnit.Microinch);
    }
    /// <summary>
    ///     Get Length from Micrometers.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrometers->FromMicrometer")]
    public static Length FromMicrometers(double micrometers)
    {
        var value = (double)micrometers;
        return new Length(value, LengthUnit.Micrometer);
    }
    /// <summary>
    ///     Get Length from Mils.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMils->FromMil")]
    public static Length FromMils(double mils)
    {
        var value = (double)mils;
        return new Length(value, LengthUnit.Mil);
    }
    /// <summary>
    ///     Get Length from Miles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMiles->FromMile")]
    public static Length FromMiles(double miles)
    {
        var value = (double)miles;
        return new Length(value, LengthUnit.Mile);
    }
    /// <summary>
    ///     Get Length from Millimeters.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillimeters->FromMillimeter")]
    public static Length FromMillimeters(double millimeters)
    {
        var value = (double)millimeters;
        return new Length(value, LengthUnit.Millimeter);
    }
    /// <summary>
    ///     Get Length from Nanometers.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanometers->FromNanometer")]
    public static Length FromNanometers(double nanometers)
    {
        var value = (double)nanometers;
        return new Length(value, LengthUnit.Nanometer);
    }
    /// <summary>
    ///     Get Length from NauticalMiles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNauticalMiles->FromNauticalMile")]
    public static Length FromNauticalMiles(double nauticalmiles)
    {
        var value = (double)nauticalmiles;
        return new Length(value, LengthUnit.NauticalMile);
    }
    /// <summary>
    ///     Get Length from Parsecs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromParsecs->FromParsec")]
    public static Length FromParsecs(double parsecs)
    {
        var value = (double)parsecs;
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
    [Obsolete("Use without the 's' - FromShackles->FromShackle")]
    public static Length FromShackles(double shackles)
    {
        var value = (double)shackles;
        return new Length(value, LengthUnit.Shackle);
    }
    /// <summary>
    ///     Get Length from SolarRadiuses.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromSolarRadiuses->FromSolarRadius")]
    public static Length FromSolarRadiuses(double solarradiuses)
    {
        var value = (double)solarradiuses;
        return new Length(value, LengthUnit.SolarRadius);
    }
    /// <summary>
    ///     Get Length from Twips.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTwips->FromTwip")]
    public static Length FromTwips(double twips)
    {
        var value = (double)twips;
        return new Length(value, LengthUnit.Twip);
    }
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
    [Obsolete("Use without the 's' - FromYards->FromYard")]
    public static Length FromYards(double yards)
    {
        var value = (double)yards;
        return new Length(value, LengthUnit.Yard);
    }
}
