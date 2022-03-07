using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Volume
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Volume FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Volume(value, VolumeUnit.SI);
        //}


        /// <summary>
        ///     Get Volume from AcreFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromAcreFeet->FromAcreFoot")]
        public static Volume FromAcreFeet(double acrefeet)
        {
            double value = (double)acrefeet;
            return new Volume(value, VolumeUnit.AcreFoot);
        }
        /// <summary>
        ///     Get Volume from AuTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromAuTablespoons->FromAuTablespoon")]
        public static Volume FromAuTablespoons(double autablespoons)
        {
            double value = (double)autablespoons;
            return new Volume(value, VolumeUnit.AuTablespoon);
        }
        /// <summary>
        ///     Get Volume from BoardFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromBoardFeet->FromBoardFoot")]
        public static Volume FromBoardFeet(double boardfeet)
        {
            double value = (double)boardfeet;
            return new Volume(value, VolumeUnit.BoardFoot);
        }
        /// <summary>
        ///     Get Volume from Centiliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentiliters->FromCentiliter")]
        public static Volume FromCentiliters(double centiliters)
        {
            double value = (double)centiliters;
            return new Volume(value, VolumeUnit.Centiliter);
        }
        /// <summary>
        ///     Get Volume from CubicCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicCentimeters->FromCubicCentimeter")]
        public static Volume FromCubicCentimeters(double cubiccentimeters)
        {
            double value = (double)cubiccentimeters;
            return new Volume(value, VolumeUnit.CubicCentimeter);
        }
        /// <summary>
        ///     Get Volume from CubicDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicDecimeters->FromCubicDecimeter")]
        public static Volume FromCubicDecimeters(double cubicdecimeters)
        {
            double value = (double)cubicdecimeters;
            return new Volume(value, VolumeUnit.CubicDecimeter);
        }
        /// <summary>
        ///     Get Volume from CubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicFeet->FromCubicFoot")]
        public static Volume FromCubicFeet(double cubicfeet)
        {
            double value = (double)cubicfeet;
            return new Volume(value, VolumeUnit.CubicFoot);
        }
        /// <summary>
        ///     Get Volume from CubicHectometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicHectometers->FromCubicHectometer")]
        public static Volume FromCubicHectometers(double cubichectometers)
        {
            double value = (double)cubichectometers;
            return new Volume(value, VolumeUnit.CubicHectometer);
        }
        /// <summary>
        ///     Get Volume from CubicInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicInches->FromCubicInch")]
        public static Volume FromCubicInches(double cubicinches)
        {
            double value = (double)cubicinches;
            return new Volume(value, VolumeUnit.CubicInch);
        }
        /// <summary>
        ///     Get Volume from CubicKilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicKilometers->FromCubicKilometer")]
        public static Volume FromCubicKilometers(double cubickilometers)
        {
            double value = (double)cubickilometers;
            return new Volume(value, VolumeUnit.CubicKilometer);
        }
        /// <summary>
        ///     Get Volume from CubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicMeters->FromCubicMeter")]
        public static Volume FromCubicMeters(double cubicmeters)
        {
            double value = (double)cubicmeters;
            return new Volume(value, VolumeUnit.CubicMeter);
        }
        /// <summary>
        ///     Get Volume from CubicMicrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicMicrometers->FromCubicMicrometer")]
        public static Volume FromCubicMicrometers(double cubicmicrometers)
        {
            double value = (double)cubicmicrometers;
            return new Volume(value, VolumeUnit.CubicMicrometer);
        }
        /// <summary>
        ///     Get Volume from CubicMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicMiles->FromCubicMile")]
        public static Volume FromCubicMiles(double cubicmiles)
        {
            double value = (double)cubicmiles;
            return new Volume(value, VolumeUnit.CubicMile);
        }
        /// <summary>
        ///     Get Volume from CubicMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicMillimeters->FromCubicMillimeter")]
        public static Volume FromCubicMillimeters(double cubicmillimeters)
        {
            double value = (double)cubicmillimeters;
            return new Volume(value, VolumeUnit.CubicMillimeter);
        }
        /// <summary>
        ///     Get Volume from CubicYards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCubicYards->FromCubicYard")]
        public static Volume FromCubicYards(double cubicyards)
        {
            double value = (double)cubicyards;
            return new Volume(value, VolumeUnit.CubicYard);
        }
        /// <summary>
        ///     Get Volume from DecausGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecausGallons->FromDecausGallon")]
        public static Volume FromDecausGallons(double decausgallons)
        {
            double value = (double)decausgallons;
            return new Volume(value, VolumeUnit.DecausGallon);
        }
        /// <summary>
        ///     Get Volume from Deciliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDeciliters->FromDeciliter")]
        public static Volume FromDeciliters(double deciliters)
        {
            double value = (double)deciliters;
            return new Volume(value, VolumeUnit.Deciliter);
        }
        /// <summary>
        ///     Get Volume from DeciusGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDeciusGallons->FromDeciusGallon")]
        public static Volume FromDeciusGallons(double deciusgallons)
        {
            double value = (double)deciusgallons;
            return new Volume(value, VolumeUnit.DeciusGallon);
        }
        /// <summary>
        ///     Get Volume from HectocubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHectocubicFeet->FromHectocubicFoot")]
        public static Volume FromHectocubicFeet(double hectocubicfeet)
        {
            double value = (double)hectocubicfeet;
            return new Volume(value, VolumeUnit.HectocubicFoot);
        }
        /// <summary>
        ///     Get Volume from HectocubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHectocubicMeters->FromHectocubicMeter")]
        public static Volume FromHectocubicMeters(double hectocubicmeters)
        {
            double value = (double)hectocubicmeters;
            return new Volume(value, VolumeUnit.HectocubicMeter);
        }
        /// <summary>
        ///     Get Volume from Hectoliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHectoliters->FromHectoliter")]
        public static Volume FromHectoliters(double hectoliters)
        {
            double value = (double)hectoliters;
            return new Volume(value, VolumeUnit.Hectoliter);
        }
        /// <summary>
        ///     Get Volume from HectousGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHectousGallons->FromHectousGallon")]
        public static Volume FromHectousGallons(double hectousgallons)
        {
            double value = (double)hectousgallons;
            return new Volume(value, VolumeUnit.HectousGallon);
        }
        /// <summary>
        ///     Get Volume from ImperialBeerBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromImperialBeerBarrels->FromImperialBeerBarrel")]
        public static Volume FromImperialBeerBarrels(double imperialbeerbarrels)
        {
            double value = (double)imperialbeerbarrels;
            return new Volume(value, VolumeUnit.ImperialBeerBarrel);
        }
        /// <summary>
        ///     Get Volume from ImperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromImperialGallons->FromImperialGallon")]
        public static Volume FromImperialGallons(double imperialgallons)
        {
            double value = (double)imperialgallons;
            return new Volume(value, VolumeUnit.ImperialGallon);
        }
        /// <summary>
        ///     Get Volume from ImperialOunces.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromImperialOunces->FromImperialOunce")]
        public static Volume FromImperialOunces(double imperialounces)
        {
            double value = (double)imperialounces;
            return new Volume(value, VolumeUnit.ImperialOunce);
        }
        /// <summary>
        ///     Get Volume from ImperialPints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromImperialPints->FromImperialPint")]
        public static Volume FromImperialPints(double imperialpints)
        {
            double value = (double)imperialpints;
            return new Volume(value, VolumeUnit.ImperialPint);
        }
        /// <summary>
        ///     Get Volume from KilocubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilocubicFeet->FromKilocubicFoot")]
        public static Volume FromKilocubicFeet(double kilocubicfeet)
        {
            double value = (double)kilocubicfeet;
            return new Volume(value, VolumeUnit.KilocubicFoot);
        }
        /// <summary>
        ///     Get Volume from KilocubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilocubicMeters->FromKilocubicMeter")]
        public static Volume FromKilocubicMeters(double kilocubicmeters)
        {
            double value = (double)kilocubicmeters;
            return new Volume(value, VolumeUnit.KilocubicMeter);
        }
        /// <summary>
        ///     Get Volume from KiloimperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKiloimperialGallons->FromKiloimperialGallon")]
        public static Volume FromKiloimperialGallons(double kiloimperialgallons)
        {
            double value = (double)kiloimperialgallons;
            return new Volume(value, VolumeUnit.KiloimperialGallon);
        }
        /// <summary>
        ///     Get Volume from Kiloliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKiloliters->FromKiloliter")]
        public static Volume FromKiloliters(double kiloliters)
        {
            double value = (double)kiloliters;
            return new Volume(value, VolumeUnit.Kiloliter);
        }
        /// <summary>
        ///     Get Volume from KilousGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilousGallons->FromKilousGallon")]
        public static Volume FromKilousGallons(double kilousgallons)
        {
            double value = (double)kilousgallons;
            return new Volume(value, VolumeUnit.KilousGallon);
        }
        /// <summary>
        ///     Get Volume from Liters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromLiters->FromLiter")]
        public static Volume FromLiters(double liters)
        {
            double value = (double)liters;
            return new Volume(value, VolumeUnit.Liter);
        }
        /// <summary>
        ///     Get Volume from MegacubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegacubicFeet->FromMegacubicFoot")]
        public static Volume FromMegacubicFeet(double megacubicfeet)
        {
            double value = (double)megacubicfeet;
            return new Volume(value, VolumeUnit.MegacubicFoot);
        }
        /// <summary>
        ///     Get Volume from MegaimperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegaimperialGallons->FromMegaimperialGallon")]
        public static Volume FromMegaimperialGallons(double megaimperialgallons)
        {
            double value = (double)megaimperialgallons;
            return new Volume(value, VolumeUnit.MegaimperialGallon);
        }
        /// <summary>
        ///     Get Volume from Megaliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegaliters->FromMegaliter")]
        public static Volume FromMegaliters(double megaliters)
        {
            double value = (double)megaliters;
            return new Volume(value, VolumeUnit.Megaliter);
        }
        /// <summary>
        ///     Get Volume from MegausGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegausGallons->FromMegausGallon")]
        public static Volume FromMegausGallons(double megausgallons)
        {
            double value = (double)megausgallons;
            return new Volume(value, VolumeUnit.MegausGallon);
        }
        /// <summary>
        ///     Get Volume from MetricCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetricCups->FromMetricCup")]
        public static Volume FromMetricCups(double metriccups)
        {
            double value = (double)metriccups;
            return new Volume(value, VolumeUnit.MetricCup);
        }
        /// <summary>
        ///     Get Volume from MetricTeaspoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetricTeaspoons->FromMetricTeaspoon")]
        public static Volume FromMetricTeaspoons(double metricteaspoons)
        {
            double value = (double)metricteaspoons;
            return new Volume(value, VolumeUnit.MetricTeaspoon);
        }
        /// <summary>
        ///     Get Volume from Microliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicroliters->FromMicroliter")]
        public static Volume FromMicroliters(double microliters)
        {
            double value = (double)microliters;
            return new Volume(value, VolumeUnit.Microliter);
        }
        /// <summary>
        ///     Get Volume from Milliliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilliliters->FromMilliliter")]
        public static Volume FromMilliliters(double milliliters)
        {
            double value = (double)milliliters;
            return new Volume(value, VolumeUnit.Milliliter);
        }
        /// <summary>
        ///     Get Volume from OilBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromOilBarrels->FromOilBarrel")]
        public static Volume FromOilBarrels(double oilbarrels)
        {
            double value = (double)oilbarrels;
            return new Volume(value, VolumeUnit.OilBarrel);
        }
        /// <summary>
        ///     Get Volume from UkTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUkTablespoons->FromUkTablespoon")]
        public static Volume FromUkTablespoons(double uktablespoons)
        {
            double value = (double)uktablespoons;
            return new Volume(value, VolumeUnit.UkTablespoon);
        }
        /// <summary>
        ///     Get Volume from UsBeerBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsBeerBarrels->FromUsBeerBarrel")]
        public static Volume FromUsBeerBarrels(double usbeerbarrels)
        {
            double value = (double)usbeerbarrels;
            return new Volume(value, VolumeUnit.UsBeerBarrel);
        }
        /// <summary>
        ///     Get Volume from UsCustomaryCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsCustomaryCups->FromUsCustomaryCup")]
        public static Volume FromUsCustomaryCups(double uscustomarycups)
        {
            double value = (double)uscustomarycups;
            return new Volume(value, VolumeUnit.UsCustomaryCup);
        }
        /// <summary>
        ///     Get Volume from UsGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsGallons->FromUsGallon")]
        public static Volume FromUsGallons(double usgallons)
        {
            double value = (double)usgallons;
            return new Volume(value, VolumeUnit.UsGallon);
        }
        /// <summary>
        ///     Get Volume from UsLegalCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsLegalCups->FromUsLegalCup")]
        public static Volume FromUsLegalCups(double uslegalcups)
        {
            double value = (double)uslegalcups;
            return new Volume(value, VolumeUnit.UsLegalCup);
        }
        /// <summary>
        ///     Get Volume from UsOunces.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsOunces->FromUsOunce")]
        public static Volume FromUsOunces(double usounces)
        {
            double value = (double)usounces;
            return new Volume(value, VolumeUnit.UsOunce);
        }
        /// <summary>
        ///     Get Volume from UsPints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsPints->FromUsPint")]
        public static Volume FromUsPints(double uspints)
        {
            double value = (double)uspints;
            return new Volume(value, VolumeUnit.UsPint);
        }
        /// <summary>
        ///     Get Volume from UsQuarts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsQuarts->FromUsQuart")]
        public static Volume FromUsQuarts(double usquarts)
        {
            double value = (double)usquarts;
            return new Volume(value, VolumeUnit.UsQuart);
        }
        /// <summary>
        ///     Get Volume from UsTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsTablespoons->FromUsTablespoon")]
        public static Volume FromUsTablespoons(double ustablespoons)
        {
            double value = (double)ustablespoons;
            return new Volume(value, VolumeUnit.UsTablespoon);
        }
        /// <summary>
        ///     Get Volume from UsTeaspoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromUsTeaspoons->FromUsTeaspoon")]
        public static Volume FromUsTeaspoons(double usteaspoons)
        {
            double value = (double)usteaspoons;
            return new Volume(value, VolumeUnit.UsTeaspoon);
        }

    }
}
