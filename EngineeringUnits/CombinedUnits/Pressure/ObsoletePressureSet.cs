﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Pressure
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Pressure FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Pressure(value, PressureUnit.SI);
    //}

    /// <summary>
    ///     Get Pressure from Atmospheres.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAtmospheres->FromAtmosphere")]
    public static Pressure FromAtmospheres(double atmospheres)
    {
        var value = (double)atmospheres;
        return new Pressure(value, PressureUnit.Atmosphere);
    }

    /// <summary>
    ///     Get Pressure from Bars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBars->FromBar")]
    public static Pressure FromBars(double bars)
    {
        var value = (double)bars;
        return new Pressure(value, PressureUnit.Bar);
    }

    /// <summary>
    ///     Get Pressure from Centibars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentibars->FromCentibar")]
    public static Pressure FromCentibars(double centibars)
    {
        var value = (double)centibars;
        return new Pressure(value, PressureUnit.Centibar);
    }

    /// <summary>
    ///     Get Pressure from Decapascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecapascals->FromDecapascal")]
    public static Pressure FromDecapascals(double decapascals)
    {
        var value = (double)decapascals;
        return new Pressure(value, PressureUnit.Decapascal);
    }

    /// <summary>
    ///     Get Pressure from Decibars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecibars->FromDecibar")]
    public static Pressure FromDecibars(double decibars)
    {
        var value = (double)decibars;
        return new Pressure(value, PressureUnit.Decibar);
    }

    /// <summary>
    ///     Get Pressure from DynesPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDynesPerSquareCentimeter->FromDynePerSquareCentimeter")]
    public static Pressure FromDynesPerSquareCentimeter(double dynespersquarecentimeter)
    {
        var value = (double)dynespersquarecentimeter;
        return new Pressure(value, PressureUnit.DynePerSquareCentimeter);
    }

    /// <summary>
    ///     Get Pressure from FeetOfElevation.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Pressure FromFeetOfElevation(double feetofelevation)
    //{
    //    double value = (double)feetofelevation;
    //    return new Pressure(value, PressureUnit.FootOfElevation);
    //}

    /// <summary>
    ///     Get Pressure from FeetOfHead.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromFeetOfHead->FromFootOfHead")]
    public static Pressure FromFeetOfHead(double feetofhead)
    {
        var value = (double)feetofhead;
        return new Pressure(value, PressureUnit.FootOfHead);
    }

    /// <summary>
    ///     Get Pressure from Gigapascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigapascals->FromGigapascal")]
    public static Pressure FromGigapascals(double gigapascals)
    {
        var value = (double)gigapascals;
        return new Pressure(value, PressureUnit.Gigapascal);
    }

    /// <summary>
    ///     Get Pressure from Hectopascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectopascals->FromHectopascal")]
    public static Pressure FromHectopascals(double hectopascals)
    {
        var value = (double)hectopascals;
        return new Pressure(value, PressureUnit.Hectopascal);
    }

    /// <summary>
    ///     Get Pressure from InchesOfMercury.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromInchesOfMercury->FromInchOfMercury")]
    public static Pressure FromInchesOfMercury(double inchesofmercury)
    {
        var value = (double)inchesofmercury;
        return new Pressure(value, PressureUnit.InchOfMercury);
    }

    /// <summary>
    ///     Get Pressure from InchesOfWaterColumn.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromInchesOfWaterColumn->FromInchOfWaterColumn")]
    public static Pressure FromInchesOfWaterColumn(double inchesofwatercolumn)
    {
        var value = (double)inchesofwatercolumn;
        return new Pressure(value, PressureUnit.InchOfWaterColumn);
    }

    /// <summary>
    ///     Get Pressure from Kilobars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilobars->FromKilobar")]
    public static Pressure FromKilobars(double kilobars)
    {
        var value = (double)kilobars;
        return new Pressure(value, PressureUnit.Kilobar);
    }

    /// <summary>
    ///     Get Pressure from KilogramsForcePerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerSquareCentimeter->FromKilogramForcePerSquareCentimeter")]
    public static Pressure FromKilogramsForcePerSquareCentimeter(double kilogramsforcepersquarecentimeter)
    {
        var value = (double)kilogramsforcepersquarecentimeter;
        return new Pressure(value, PressureUnit.KilogramForcePerSquareCentimeter);
    }

    /// <summary>
    ///     Get Pressure from KilogramsForcePerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerSquareMeter->FromKilogramForcePerSquareMeter")]
    public static Pressure FromKilogramsForcePerSquareMeter(double kilogramsforcepersquaremeter)
    {
        var value = (double)kilogramsforcepersquaremeter;
        return new Pressure(value, PressureUnit.KilogramForcePerSquareMeter);
    }

    /// <summary>
    ///     Get Pressure from KilogramsForcePerSquareMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsForcePerSquareMillimeter->FromKilogramForcePerSquareMillimeter")]
    public static Pressure FromKilogramsForcePerSquareMillimeter(double kilogramsforcepersquaremillimeter)
    {
        var value = (double)kilogramsforcepersquaremillimeter;
        return new Pressure(value, PressureUnit.KilogramForcePerSquareMillimeter);
    }

    /// <summary>
    ///     Get Pressure from KilonewtonsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerSquareCentimeter->FromKilonewtonPerSquareCentimeter")]
    public static Pressure FromKilonewtonsPerSquareCentimeter(double kilonewtonspersquarecentimeter)
    {
        var value = (double)kilonewtonspersquarecentimeter;
        return new Pressure(value, PressureUnit.KilonewtonPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Pressure from KilonewtonsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerSquareMeter->FromKilonewtonPerSquareMeter")]
    public static Pressure FromKilonewtonsPerSquareMeter(double kilonewtonspersquaremeter)
    {
        var value = (double)kilonewtonspersquaremeter;
        return new Pressure(value, PressureUnit.KilonewtonPerSquareMeter);
    }

    /// <summary>
    ///     Get Pressure from KilonewtonsPerSquareMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerSquareMillimeter->FromKilonewtonPerSquareMillimeter")]
    public static Pressure FromKilonewtonsPerSquareMillimeter(double kilonewtonspersquaremillimeter)
    {
        var value = (double)kilonewtonspersquaremillimeter;
        return new Pressure(value, PressureUnit.KilonewtonPerSquareMillimeter);
    }

    /// <summary>
    ///     Get Pressure from Kilopascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopascals->FromKilopascal")]
    public static Pressure FromKilopascals(double kilopascals)
    {
        var value = (double)kilopascals;
        return new Pressure(value, PressureUnit.Kilopascal);
    }

    /// <summary>
    ///     Get Pressure from KilopoundsForcePerSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerSquareFoot->FromKilopoundForcePerSquareFoot")]
    public static Pressure FromKilopoundsForcePerSquareFoot(double kilopoundsforcepersquarefoot)
    {
        var value = (double)kilopoundsforcepersquarefoot;
        return new Pressure(value, PressureUnit.KilopoundForcePerSquareFoot);
    }

    /// <summary>
    ///     Get Pressure from KilopoundsForcePerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerSquareInch->FromKilopoundForcePerSquareInch")]
    public static Pressure FromKilopoundsForcePerSquareInch(double kilopoundsforcepersquareinch)
    {
        var value = (double)kilopoundsforcepersquareinch;
        return new Pressure(value, PressureUnit.KilopoundForcePerSquareInch);
    }

    /// <summary>
    ///     Get Pressure from Megabars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegabars->FromMegabar")]
    public static Pressure FromMegabars(double megabars)
    {
        var value = (double)megabars;
        return new Pressure(value, PressureUnit.Megabar);
    }

    /// <summary>
    ///     Get Pressure from MeganewtonsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMeganewtonsPerSquareMeter->FromMeganewtonPerSquareMeter")]
    public static Pressure FromMeganewtonsPerSquareMeter(double meganewtonspersquaremeter)
    {
        var value = (double)meganewtonspersquaremeter;
        return new Pressure(value, PressureUnit.MeganewtonPerSquareMeter);
    }

    /// <summary>
    ///     Get Pressure from Megapascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapascals->FromMegapascal")]
    public static Pressure FromMegapascals(double megapascals)
    {
        var value = (double)megapascals;
        return new Pressure(value, PressureUnit.Megapascal);
    }

    /// <summary>
    ///     Get Pressure from MetersOfElevation.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Pressure FromMetersOfElevation(double metersofelevation)
    //{
    //    double value = (double)metersofelevation;
    //    return new Pressure(value, PressureUnit.MeterOfElevation);
    //}

    /// <summary>
    ///     Get Pressure from MetersOfHead.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMetersOfHead->FromMeterOfHead")]
    public static Pressure FromMetersOfHead(double metersofhead)
    {
        var value = (double)metersofhead;
        return new Pressure(value, PressureUnit.MeterOfHead);
    }

    /// <summary>
    ///     Get Pressure from Microbars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrobars->FromMicrobar")]
    public static Pressure FromMicrobars(double microbars)
    {
        var value = (double)microbars;
        return new Pressure(value, PressureUnit.Microbar);
    }

    /// <summary>
    ///     Get Pressure from Micropascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicropascals->FromMicropascal")]
    public static Pressure FromMicropascals(double micropascals)
    {
        var value = (double)micropascals;
        return new Pressure(value, PressureUnit.Micropascal);
    }

    /// <summary>
    ///     Get Pressure from Millibars.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillibars->FromMillibar")]
    public static Pressure FromMillibars(double millibars)
    {
        var value = (double)millibars;
        return new Pressure(value, PressureUnit.Millibar);
    }

    /// <summary>
    ///     Get Pressure from MillimetersOfMercury.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillimetersOfMercury->FromMillimeterOfMercury")]
    public static Pressure FromMillimetersOfMercury(double millimetersofmercury)
    {
        var value = (double)millimetersofmercury;
        return new Pressure(value, PressureUnit.MillimeterOfMercury);
    }

    /// <summary>
    ///     Get Pressure from Millipascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillipascals->FromMillipascal")]
    public static Pressure FromMillipascals(double millipascals)
    {
        var value = (double)millipascals;
        return new Pressure(value, PressureUnit.Millipascal);
    }

    /// <summary>
    ///     Get Pressure from NewtonsPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerSquareCentimeter->FromNewtonPerSquareCentimeter")]
    public static Pressure FromNewtonsPerSquareCentimeter(double newtonspersquarecentimeter)
    {
        var value = (double)newtonspersquarecentimeter;
        return new Pressure(value, PressureUnit.NewtonPerSquareCentimeter);
    }

    /// <summary>
    ///     Get Pressure from NewtonsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerSquareMeter->FromNewtonPerSquareMeter")]
    public static Pressure FromNewtonsPerSquareMeter(double newtonspersquaremeter)
    {
        var value = (double)newtonspersquaremeter;
        return new Pressure(value, PressureUnit.NewtonPerSquareMeter);
    }

    /// <summary>
    ///     Get Pressure from NewtonsPerSquareMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerSquareMillimeter->FromNewtonPerSquareMillimeter")]
    public static Pressure FromNewtonsPerSquareMillimeter(double newtonspersquaremillimeter)
    {
        var value = (double)newtonspersquaremillimeter;
        return new Pressure(value, PressureUnit.NewtonPerSquareMillimeter);
    }

    /// <summary>
    ///     Get Pressure from Pascals.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPascals->FromPascal")]
    public static Pressure FromPascals(double pascals)
    {
        var value = (double)pascals;
        return new Pressure(value, PressureUnit.Pascal);
    }

    /// <summary>
    ///     Get Pressure from PoundsForcePerSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerSquareFoot->FromPoundForcePerSquareFoot")]
    public static Pressure FromPoundsForcePerSquareFoot(double poundsforcepersquarefoot)
    {
        var value = (double)poundsforcepersquarefoot;
        return new Pressure(value, PressureUnit.PoundForcePerSquareFoot);
    }

    /// <summary>
    ///     Get Pressure from PoundsForcePerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerSquareInch->FromPoundForcePerSquareInch")]
    public static Pressure FromPoundsForcePerSquareInch(double poundsforcepersquareinch)
    {
        var value = (double)poundsforcepersquareinch;
        return new Pressure(value, PressureUnit.PoundForcePerSquareInch);
    }

    /// <summary>
    ///     Get Pressure from PoundsPerInchSecondSquared.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerInchSecondSquared->FromPoundPerInchSecondSquared")]
    public static Pressure FromPoundsPerInchSecondSquared(double poundsperinchsecondsquared)
    {
        var value = (double)poundsperinchsecondsquared;
        return new Pressure(value, PressureUnit.PoundPerInchSecondSquared);
    }

    /// <summary>
    ///     Get Pressure from TechnicalAtmospheres.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTechnicalAtmospheres->FromTechnicalAtmosphere")]
    public static Pressure FromTechnicalAtmospheres(double technicalatmospheres)
    {
        var value = (double)technicalatmospheres;
        return new Pressure(value, PressureUnit.TechnicalAtmosphere);
    }

    /// <summary>
    ///     Get Pressure from TonnesForcePerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerSquareCentimeter->FromTonneForcePerSquareCentimeter")]
    public static Pressure FromTonnesForcePerSquareCentimeter(double tonnesforcepersquarecentimeter)
    {
        var value = (double)tonnesforcepersquarecentimeter;
        return new Pressure(value, PressureUnit.TonneForcePerSquareCentimeter);
    }

    /// <summary>
    ///     Get Pressure from TonnesForcePerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerSquareMeter->FromTonneForcePerSquareMeter")]
    public static Pressure FromTonnesForcePerSquareMeter(double tonnesforcepersquaremeter)
    {
        var value = (double)tonnesforcepersquaremeter;
        return new Pressure(value, PressureUnit.TonneForcePerSquareMeter);
    }

    /// <summary>
    ///     Get Pressure from TonnesForcePerSquareMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesForcePerSquareMillimeter->FromTonneForcePerSquareMillimeter")]
    public static Pressure FromTonnesForcePerSquareMillimeter(double tonnesforcepersquaremillimeter)
    {
        var value = (double)tonnesforcepersquaremillimeter;
        return new Pressure(value, PressureUnit.TonneForcePerSquareMillimeter);
    }

    /// <summary>
    ///     Get Pressure from Torrs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTorrs->FromTorr")]
    public static Pressure FromTorrs(double torrs)
    {
        var value = (double)torrs;
        return new Pressure(value, PressureUnit.Torr);
    }
}
