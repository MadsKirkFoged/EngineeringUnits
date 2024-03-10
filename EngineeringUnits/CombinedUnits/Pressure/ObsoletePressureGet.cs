using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Pressure
{
    /// <summary>
    ///     Get Pressure in Atmospheres.
    /// </summary>
    [Obsolete("Use without the 's' - Atmospheres->Atmosphere")]
    public double Atmospheres => As(PressureUnit.Atmosphere);

    /// <summary>
    ///     Get Pressure in Bars.
    /// </summary>
    [Obsolete("Use without the 's' - Bars->Bar")]
    public double Bars => As(PressureUnit.Bar);

    /// <summary>
    ///     Get Pressure in Centibars.
    /// </summary>
    [Obsolete("Use without the 's' - Centibars->Centibar")]
    public double Centibars => As(PressureUnit.Centibar);

    /// <summary>
    ///     Get Pressure in Decapascals.
    /// </summary>
    [Obsolete("Use without the 's' - Decapascals->Decapascal")]
    public double Decapascals => As(PressureUnit.Decapascal);

    /// <summary>
    ///     Get Pressure in Decibars.
    /// </summary>
    [Obsolete("Use without the 's' - Decibars->Decibar")]
    public double Decibars => As(PressureUnit.Decibar);

    /// <summary>
    ///     Get Pressure in DynesPerSquareCentimeter.
    /// </summary>
    [Obsolete("Use without the 's' - DynesPerSquareCentimeter->DynePerSquareCentimeter")]
    public double DynesPerSquareCentimeter => As(PressureUnit.DynePerSquareCentimeter);

    /// <summary>
    ///     Get Pressure in FeetOfElevation.
    /// </summary>
    //public double FeetOfElevation => As(PressureUnit.FootOfElevation);

    /// <summary>
    ///     Get Pressure in FeetOfHead.
    /// </summary>
    [Obsolete("Use singular form - FeetOfHead->FootOfHead")]
    public double FeetOfHead => As(PressureUnit.FootOfHead);

    /// <summary>
    ///     Get Pressure in Gigapascals.
    /// </summary>
    [Obsolete("Use without the 's' - Gigapascals->Gigapascal")]
    public double Gigapascals => As(PressureUnit.Gigapascal);

    /// <summary>
    ///     Get Pressure in Hectopascals.
    /// </summary>
    [Obsolete("Use without the 's' - Hectopascals->Hectopascal")]
    public double Hectopascals => As(PressureUnit.Hectopascal);

    /// <summary>
    ///     Get Pressure in InchesOfMercury.
    /// </summary>
    [Obsolete("Use without the 's' - InchesOfMercury->InchOfMercury")]
    public double InchesOfMercury => As(PressureUnit.InchOfMercury);

    /// <summary>
    ///     Get Pressure in InchesOfWaterColumn.
    /// </summary>
    [Obsolete("Use without the 's' - InchesOfWaterColumn->InchOfWaterColumn")]
    public double InchesOfWaterColumn => As(PressureUnit.InchOfWaterColumn);

    /// <summary>
    ///     Get Pressure in Kilobars.
    /// </summary>
    [Obsolete("Use without the 's' - Kilobars->Kilobar")]
    public double Kilobars => As(PressureUnit.Kilobar);

    /// <summary>
    ///     Get Pressure in KilogramsForcePerSquareCentimeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsForcePerSquareCentimeter->KilogramForcePerSquareCentimeter")]
    public double KilogramsForcePerSquareCentimeter => As(PressureUnit.KilogramForcePerSquareCentimeter);

    /// <summary>
    ///     Get Pressure in KilogramsForcePerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsForcePerSquareMeter->KilogramForcePerSquareMeter")]
    public double KilogramsForcePerSquareMeter => As(PressureUnit.KilogramForcePerSquareMeter);

    /// <summary>
    ///     Get Pressure in KilogramsForcePerSquareMillimeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsForcePerSquareMillimeter->KilogramForcePerSquareMillimeter")]
    public double KilogramsForcePerSquareMillimeter => As(PressureUnit.KilogramForcePerSquareMillimeter);

    /// <summary>
    ///     Get Pressure in KilonewtonsPerSquareCentimeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilonewtonsPerSquareCentimeter->WattPeKilonewtonPerSquareCentimeterrLiter")]
    public double KilonewtonsPerSquareCentimeter => As(PressureUnit.KilonewtonPerSquareCentimeter);

    /// <summary>
    ///     Get Pressure in KilonewtonsPerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilonewtonsPerSquareMeter->KilonewtonPerSquareMeter")]
    public double KilonewtonsPerSquareMeter => As(PressureUnit.KilonewtonPerSquareMeter);

    /// <summary>
    ///     Get Pressure in KilonewtonsPerSquareMillimeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilonewtonsPerSquareMillimeter->KilonewtonPerSquareMillimeter")]
    public double KilonewtonsPerSquareMillimeter => As(PressureUnit.KilonewtonPerSquareMillimeter);

    /// <summary>
    ///     Get Pressure in Kilopascals.
    /// </summary>
    [Obsolete("Use without the 's' - Kilopascals->Kilopascal")]
    public double Kilopascals => As(PressureUnit.Kilopascal);

    /// <summary>
    ///     Get Pressure in KilopoundsForcePerSquareFoot.
    /// </summary>
    [Obsolete("Use without the 's' - KilopoundsForcePerSquareFoot->KilopoundForcePerSquareFoot")]
    public double KilopoundsForcePerSquareFoot => As(PressureUnit.KilopoundForcePerSquareFoot);

    /// <summary>
    ///     Get Pressure in KilopoundsForcePerSquareInch.
    /// </summary>
    [Obsolete("Use without the 's' - KilopoundsForcePerSquareInch->KilopoundForcePerSquareInch")]
    public double KilopoundsForcePerSquareInch => As(PressureUnit.KilopoundForcePerSquareInch);

    /// <summary>
    ///     Get Pressure in Megabars.
    /// </summary>
    [Obsolete("Use without the 's' - Megabars->Megabar")]
    public double Megabars => As(PressureUnit.Megabar);

    /// <summary>
    ///     Get Pressure in MeganewtonsPerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - MeganewtonsPerSquareMeter->MeganewtonPerSquareMeter")]
    public double MeganewtonsPerSquareMeter => As(PressureUnit.MeganewtonPerSquareMeter);

    /// <summary>
    ///     Get Pressure in Megapascals.
    /// </summary>
    [Obsolete("Use without the 's' - Megapascals->Megapascal")]
    public double Megapascals => As(PressureUnit.Megapascal);

    /// <summary>
    ///     Get Pressure in MetersOfElevation.
    /// </summary>
    //public double MetersOfElevation => As(PressureUnit.MeterOfElevation);

    /// <summary>
    ///     Get Pressure in MetersOfHead.
    /// </summary>
    [Obsolete("Use without the 's' - MetersOfHead->MeterOfHead")]
    public double MetersOfHead => As(PressureUnit.MeterOfHead);

    /// <summary>
    ///     Get Pressure in Microbars.
    /// </summary>
    [Obsolete("Use without the 's' - Microbars->Microbar")]
    public double Microbars => As(PressureUnit.Microbar);

    /// <summary>
    ///     Get Pressure in Micropascals.
    /// </summary>
    [Obsolete("Use without the 's' - Micropascals->Micropascal")]
    public double Micropascals => As(PressureUnit.Micropascal);

    /// <summary>
    ///     Get Pressure in Millibars.
    /// </summary>
    [Obsolete("Use without the 's' - Millibars->Millibar")]
    public double Millibars => As(PressureUnit.Millibar);

    /// <summary>
    ///     Get Pressure in MillimetersOfMercury.
    /// </summary>
    [Obsolete("Use without the 's' - MillimetersOfMercury->MillimeterOfMercury")]
    public double MillimetersOfMercury => As(PressureUnit.MillimeterOfMercury);

    /// <summary>
    ///     Get Pressure in Millipascals.
    /// </summary>
    [Obsolete("Use without the 's' - Millipascals->Millipascal")]
    public double Millipascals => As(PressureUnit.Millipascal);

    /// <summary>
    ///     Get Pressure in NewtonsPerSquareCentimeter.
    /// </summary>
    [Obsolete("Use without the 's' - NewtonsPerSquareCentimeter->NewtonPerSquareCentimeter")]
    public double NewtonsPerSquareCentimeter => As(PressureUnit.NewtonPerSquareCentimeter);

    /// <summary>
    ///     Get Pressure in NewtonsPerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - NewtonsPerSquareMeter->NewtonPerSquareMeter")]
    public double NewtonsPerSquareMeter => As(PressureUnit.NewtonPerSquareMeter);

    /// <summary>
    ///     Get Pressure in NewtonsPerSquareMillimeter.
    /// </summary>
    [Obsolete("Use without the 's' - NewtonsPerSquareMillimeter->NewtonPerSquareMillimeter")]
    public double NewtonsPerSquareMillimeter => As(PressureUnit.NewtonPerSquareMillimeter);

    /// <summary>
    ///     Get Pressure in Pascals.
    /// </summary>
    [Obsolete("Use without the 's' - Pascals->Pascal")]
    public double Pascals => As(PressureUnit.Pascal);

    /// <summary>
    ///     Get Pressure in SI unit (Pascals).
    /// </summary>
    //public double SI => As(PressureUnit.SI);

    /// <summary>
    ///     Get Pressure in PoundsForcePerSquareFoot.
    /// </summary>
    [Obsolete("Use without the 's' - PoundsForcePerSquareFoot->PoundForcePerSquareFoot")]
    public double PoundsForcePerSquareFoot => As(PressureUnit.PoundForcePerSquareFoot);

    /// <summary>
    ///     Get Pressure in PoundsForcePerSquareInch.
    /// </summary>
    [Obsolete("Use without the 's' - PoundsForcePerSquareInch->PoundForcePerSquareInch")]
    public double PoundsForcePerSquareInch => As(PressureUnit.PoundForcePerSquareInch);

    /// <summary>
    ///     Get Pressure in PoundsPerInchSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - PoundsPerInchSecondSquared->PoundPerInchSecondSquared")]
    public double PoundsPerInchSecondSquared => As(PressureUnit.PoundPerInchSecondSquared);

    /// <summary>
    ///     Get Pressure in TechnicalAtmospheres.
    /// </summary>
    [Obsolete("Use without the 's' - TechnicalAtmospheres->TechnicalAtmosphere")]
    public double TechnicalAtmospheres => As(PressureUnit.TechnicalAtmosphere);

    /// <summary>
    ///     Get Pressure in TonnesForcePerSquareCentimeter.
    /// </summary>
    [Obsolete("Use without the 's' - TonnesForcePerSquareCentimeter->TonneForcePerSquareCentimeter")]
    public double TonnesForcePerSquareCentimeter => As(PressureUnit.TonneForcePerSquareCentimeter);

    /// <summary>
    ///     Get Pressure in TonnesForcePerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - TonnesForcePerSquareMeter->TonneForcePerSquareMeter")]
    public double TonnesForcePerSquareMeter => As(PressureUnit.TonneForcePerSquareMeter);

    /// <summary>
    ///     Get Pressure in TonnesForcePerSquareMillimeter.
    /// </summary>
    [Obsolete("Use without the 's' - TonnesForcePerSquareMillimeter->TonneForcePerSquareMillimeter")]
    public double TonnesForcePerSquareMillimeter => As(PressureUnit.TonneForcePerSquareMillimeter);

    /// <summary>
    ///     Get Pressure in Torrs.
    /// </summary>
    [Obsolete("Use without the 's' - Torrs->Torr")]
    public double Torrs => As(PressureUnit.Torr);

}
