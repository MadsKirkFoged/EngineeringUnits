using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Pressure
    {
        /// <summary>
        ///     Get Pressure in Atmospheres.
        /// </summary>
        public double Atmospheres => As(PressureUnit.Atmosphere);

        /// <summary>
        ///     Get Pressure in Bars.
        /// </summary>
        public double Bars => As(PressureUnit.Bar);

        /// <summary>
        ///     Get Pressure in Centibars.
        /// </summary>
        public double Centibars => As(PressureUnit.Centibar);

        /// <summary>
        ///     Get Pressure in Decapascals.
        /// </summary>
        public double Decapascals => As(PressureUnit.Decapascal);

        /// <summary>
        ///     Get Pressure in Decibars.
        /// </summary>
        public double Decibars => As(PressureUnit.Decibar);

        /// <summary>
        ///     Get Pressure in DynesPerSquareCentimeter.
        /// </summary>
        public double DynesPerSquareCentimeter => As(PressureUnit.DynePerSquareCentimeter);

        /// <summary>
        ///     Get Pressure in FeetOfElevation.
        /// </summary>
        //public double FeetOfElevation => As(PressureUnit.FootOfElevation);

        /// <summary>
        ///     Get Pressure in FeetOfHead.
        /// </summary>
        public double FeetOfHead => As(PressureUnit.FootOfHead);

        /// <summary>
        ///     Get Pressure in Gigapascals.
        /// </summary>
        public double Gigapascals => As(PressureUnit.Gigapascal);

        /// <summary>
        ///     Get Pressure in Hectopascals.
        /// </summary>
        public double Hectopascals => As(PressureUnit.Hectopascal);

        /// <summary>
        ///     Get Pressure in InchesOfMercury.
        /// </summary>
        public double InchesOfMercury => As(PressureUnit.InchOfMercury);

        /// <summary>
        ///     Get Pressure in InchesOfWaterColumn.
        /// </summary>
        public double InchesOfWaterColumn => As(PressureUnit.InchOfWaterColumn);

        /// <summary>
        ///     Get Pressure in Kilobars.
        /// </summary>
        public double Kilobars => As(PressureUnit.Kilobar);

        /// <summary>
        ///     Get Pressure in KilogramsForcePerSquareCentimeter.
        /// </summary>
        public double KilogramsForcePerSquareCentimeter => As(PressureUnit.KilogramForcePerSquareCentimeter);

        /// <summary>
        ///     Get Pressure in KilogramsForcePerSquareMeter.
        /// </summary>
        public double KilogramsForcePerSquareMeter => As(PressureUnit.KilogramForcePerSquareMeter);

        /// <summary>
        ///     Get Pressure in KilogramsForcePerSquareMillimeter.
        /// </summary>
        public double KilogramsForcePerSquareMillimeter => As(PressureUnit.KilogramForcePerSquareMillimeter);

        /// <summary>
        ///     Get Pressure in KilonewtonsPerSquareCentimeter.
        /// </summary>
        public double KilonewtonsPerSquareCentimeter => As(PressureUnit.KilonewtonPerSquareCentimeter);

        /// <summary>
        ///     Get Pressure in KilonewtonsPerSquareMeter.
        /// </summary>
        public double KilonewtonsPerSquareMeter => As(PressureUnit.KilonewtonPerSquareMeter);

        /// <summary>
        ///     Get Pressure in KilonewtonsPerSquareMillimeter.
        /// </summary>
        public double KilonewtonsPerSquareMillimeter => As(PressureUnit.KilonewtonPerSquareMillimeter);

        /// <summary>
        ///     Get Pressure in Kilopascals.
        /// </summary>
        public double Kilopascals => As(PressureUnit.Kilopascal);

        /// <summary>
        ///     Get Pressure in KilopoundsForcePerSquareFoot.
        /// </summary>
        public double KilopoundsForcePerSquareFoot => As(PressureUnit.KilopoundForcePerSquareFoot);

        /// <summary>
        ///     Get Pressure in KilopoundsForcePerSquareInch.
        /// </summary>
        public double KilopoundsForcePerSquareInch => As(PressureUnit.KilopoundForcePerSquareInch);

        /// <summary>
        ///     Get Pressure in Megabars.
        /// </summary>
        public double Megabars => As(PressureUnit.Megabar);

        /// <summary>
        ///     Get Pressure in MeganewtonsPerSquareMeter.
        /// </summary>
        public double MeganewtonsPerSquareMeter => As(PressureUnit.MeganewtonPerSquareMeter);

        /// <summary>
        ///     Get Pressure in Megapascals.
        /// </summary>
        public double Megapascals => As(PressureUnit.Megapascal);

        /// <summary>
        ///     Get Pressure in MetersOfElevation.
        /// </summary>
//public double MetersOfElevation => As(PressureUnit.MeterOfElevation);

        /// <summary>
        ///     Get Pressure in MetersOfHead.
        /// </summary>
        public double MetersOfHead => As(PressureUnit.MeterOfHead);

        /// <summary>
        ///     Get Pressure in Microbars.
        /// </summary>
        public double Microbars => As(PressureUnit.Microbar);

        /// <summary>
        ///     Get Pressure in Micropascals.
        /// </summary>
        public double Micropascals => As(PressureUnit.Micropascal);

        /// <summary>
        ///     Get Pressure in Millibars.
        /// </summary>
        public double Millibars => As(PressureUnit.Millibar);

        /// <summary>
        ///     Get Pressure in MillimetersOfMercury.
        /// </summary>
        public double MillimetersOfMercury => As(PressureUnit.MillimeterOfMercury);

        /// <summary>
        ///     Get Pressure in Millipascals.
        /// </summary>
        public double Millipascals => As(PressureUnit.Millipascal);

        /// <summary>
        ///     Get Pressure in NewtonsPerSquareCentimeter.
        /// </summary>
        public double NewtonsPerSquareCentimeter => As(PressureUnit.NewtonPerSquareCentimeter);

        /// <summary>
        ///     Get Pressure in NewtonsPerSquareMeter.
        /// </summary>
        public double NewtonsPerSquareMeter => As(PressureUnit.NewtonPerSquareMeter);

        /// <summary>
        ///     Get Pressure in NewtonsPerSquareMillimeter.
        /// </summary>
        public double NewtonsPerSquareMillimeter => As(PressureUnit.NewtonPerSquareMillimeter);

        /// <summary>
        ///     Get Pressure in Pascals.
        /// </summary>
        public double Pascals => As(PressureUnit.Pascal);


        /// <summary>
        ///     Get Pressure in SI unit (Pascals).
        /// </summary>
        public double SI => As(PressureUnit.SI);

        /// <summary>
        ///     Get Pressure in PoundsForcePerSquareFoot.
        /// </summary>
        public double PoundsForcePerSquareFoot => As(PressureUnit.PoundForcePerSquareFoot);

        /// <summary>
        ///     Get Pressure in PoundsForcePerSquareInch.
        /// </summary>
        public double PoundsForcePerSquareInch => As(PressureUnit.PoundForcePerSquareInch);

        /// <summary>
        ///     Get Pressure in PoundsPerInchSecondSquared.
        /// </summary>
        public double PoundsPerInchSecondSquared => As(PressureUnit.PoundPerInchSecondSquared);

        /// <summary>
        ///     Get Pressure in TechnicalAtmospheres.
        /// </summary>
        public double TechnicalAtmospheres => As(PressureUnit.TechnicalAtmosphere);

        /// <summary>
        ///     Get Pressure in TonnesForcePerSquareCentimeter.
        /// </summary>
        public double TonnesForcePerSquareCentimeter => As(PressureUnit.TonneForcePerSquareCentimeter);

        /// <summary>
        ///     Get Pressure in TonnesForcePerSquareMeter.
        /// </summary>
        public double TonnesForcePerSquareMeter => As(PressureUnit.TonneForcePerSquareMeter);

        /// <summary>
        ///     Get Pressure in TonnesForcePerSquareMillimeter.
        /// </summary>
        public double TonnesForcePerSquareMillimeter => As(PressureUnit.TonneForcePerSquareMillimeter);

        /// <summary>
        ///     Get Pressure in Torrs.
        /// </summary>
        public double Torrs => As(PressureUnit.Torr);

    }
}
