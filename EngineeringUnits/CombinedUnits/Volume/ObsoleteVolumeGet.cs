using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Volume
    {
        /// <summary>
        ///     Get Volume in AcreFeet.
        /// </summary>
        [Obsolete("Use singular form - AcreFeet->AcreFoot")]
        public double AcreFeet => As(VolumeUnit.AcreFoot);

        /// <summary>
        ///     Get Volume in AuTablespoons.
        /// </summary>
        [Obsolete("Use without the 's' - AuTablespoons->AuTablespoon")]
        public double AuTablespoons => As(VolumeUnit.AuTablespoon);

        /// <summary>
        ///     Get Volume in BoardFeet.
        /// </summary>
        [Obsolete("Use singular form - BoardFeet->BoardFoot")]
        public double BoardFeet => As(VolumeUnit.BoardFoot);

        /// <summary>
        ///     Get Volume in Centiliters.
        /// </summary>
        [Obsolete("Use without the 's' - Centiliters->Centiliter")]
        public double Centiliters => As(VolumeUnit.Centiliter);

        /// <summary>
        ///     Get Volume in CubicCentimeters.
        /// </summary>
        [Obsolete("Use without the 's' - CubicCentimeters->CubicCentimeter")]
        public double CubicCentimeters => As(VolumeUnit.CubicCentimeter);

        /// <summary>
        ///     Get Volume in CubicDecimeters.
        /// </summary>
        [Obsolete("Use without the 's' - CubicDecimeters->CubicDecimeter")]
        public double CubicDecimeters => As(VolumeUnit.CubicDecimeter);

        /// <summary>
        ///     Get Volume in CubicFeet.
        /// </summary>
        [Obsolete("Use singular form - CubicFeet->CubicFoot")]
        public double CubicFeet => As(VolumeUnit.CubicFoot);

        /// <summary>
        ///     Get Volume in CubicHectometers.
        /// </summary>
        [Obsolete("Use without the 's' - CubicHectometers->CubicHectometer")]
        public double CubicHectometers => As(VolumeUnit.CubicHectometer);

        /// <summary>
        ///     Get Volume in CubicInches.
        /// </summary>
        [Obsolete("Use without the 's' - CubicInches->CubicInch")]
        public double CubicInches => As(VolumeUnit.CubicInch);

        /// <summary>
        ///     Get Volume in CubicKilometers.
        /// </summary>
        [Obsolete("Use without the 's' - CubicKilometers->CubicKilometer")]
        public double CubicKilometers => As(VolumeUnit.CubicKilometer);

        /// <summary>
        ///     Get Volume in CubicMeters.
        /// </summary>
        [Obsolete("Use without the 's' - CubicMeters->CubicMeter")]
        public double CubicMeters => As(VolumeUnit.CubicMeter);

        /// <summary>
        ///     Get Volume in SI Unit (CubicMeters).
        /// </summary>
        //public double SI => As(VolumeUnit.SI);

        /// <summary>
        ///     Get Volume in CubicMicrometers.
        /// </summary>
        [Obsolete("Use without the 's' - CubicMicrometers->CubicMicrometer")]
        public double CubicMicrometers => As(VolumeUnit.CubicMicrometer);

        /// <summary>
        ///     Get Volume in CubicMiles.
        /// </summary>
        [Obsolete("Use without the 's' - CubicMiles->CubicMile")]
        public double CubicMiles => As(VolumeUnit.CubicMile);

        /// <summary>
        ///     Get Volume in CubicMillimeters.
        /// </summary>
        [Obsolete("Use without the 's' - CubicMillimeters->CubicMillimeter")]
        public double CubicMillimeters => As(VolumeUnit.CubicMillimeter);

        /// <summary>
        ///     Get Volume in CubicYards.
        /// </summary>
        [Obsolete("Use without the 's' - CubicYards->CubicYard")]
        public double CubicYards => As(VolumeUnit.CubicYard);

        /// <summary>
        ///     Get Volume in DecausGallons.
        /// </summary>
        [Obsolete("Use without the 's' - DecausGallons->DecausGallon")]
        public double DecausGallons => As(VolumeUnit.DecausGallon);

        /// <summary>
        ///     Get Volume in Deciliters.
        /// </summary>
        [Obsolete("Use without the 's' - Deciliters->Deciliter")]
        public double Deciliters => As(VolumeUnit.Deciliter);

        /// <summary>
        ///     Get Volume in DeciusGallons.
        /// </summary>
        [Obsolete("Use without the 's' - DeciusGallons->DeciusGallon")]
        public double DeciusGallons => As(VolumeUnit.DeciusGallon);

        /// <summary>
        ///     Get Volume in HectocubicFeet.
        /// </summary>
        [Obsolete("Use singular form - HectocubicFeet->HectocubicFoot")]
        public double HectocubicFeet => As(VolumeUnit.HectocubicFoot);

        /// <summary>
        ///     Get Volume in HectocubicMeters.
        /// </summary>
        [Obsolete("Use without the 's' - HectocubicMeters->HectocubicMeter")]
        public double HectocubicMeters => As(VolumeUnit.HectocubicMeter);

        /// <summary>
        ///     Get Volume in Hectoliters.
        /// </summary>
        [Obsolete("Use without the 's' - Hectoliters->Hectoliter")]
        public double Hectoliters => As(VolumeUnit.Hectoliter);

        /// <summary>
        ///     Get Volume in HectousGallons.
        /// </summary>
        [Obsolete("Use without the 's' - HectousGallons->HectousGallon")]
        public double HectousGallons => As(VolumeUnit.HectousGallon);

        /// <summary>
        ///     Get Volume in ImperialBeerBarrels.
        /// </summary>
        [Obsolete("Use without the 's' - ImperialBeerBarrels->ImperialBeerBarrel")]
        public double ImperialBeerBarrels => As(VolumeUnit.ImperialBeerBarrel);

        /// <summary>
        ///     Get Volume in ImperialGallons.
        /// </summary>
        [Obsolete("Use without the 's' - ImperialGallons->ImperialGallon")]
        public double ImperialGallons => As(VolumeUnit.ImperialGallon);

        /// <summary>
        ///     Get Volume in ImperialOunces.
        /// </summary>
        [Obsolete("Use without the 's' - ImperialOunces->ImperialOunce")]
        public double ImperialOunces => As(VolumeUnit.ImperialOunce);

        /// <summary>
        ///     Get Volume in ImperialPints.
        /// </summary>
        [Obsolete("Use without the 's' - ImperialPints->ImperialPint")]
        public double ImperialPints => As(VolumeUnit.ImperialPint);

        /// <summary>
        ///     Get Volume in KilocubicFeet.
        /// </summary>
        [Obsolete("Use singular form - KilocubicFeet->KilocubicFoot")]
        public double KilocubicFeet => As(VolumeUnit.KilocubicFoot);

        /// <summary>
        ///     Get Volume in KilocubicMeters.
        /// </summary>
        [Obsolete("Use without the 's' - KilocubicMeters->KilocubicMeter")]
        public double KilocubicMeters => As(VolumeUnit.KilocubicMeter);

        /// <summary>
        ///     Get Volume in KiloimperialGallons.
        /// </summary>
        [Obsolete("Use without the 's' - KiloimperialGallons->KiloimperialGallon")]
        public double KiloimperialGallons => As(VolumeUnit.KiloimperialGallon);

        /// <summary>
        ///     Get Volume in Kiloliters.
        /// </summary>
        [Obsolete("Use without the 's' - Kiloliters->Kiloliter")]
        public double Kiloliters => As(VolumeUnit.Kiloliter);

        /// <summary>
        ///     Get Volume in KilousGallons.
        /// </summary>
        [Obsolete("Use without the 's' - KilousGallons->KilousGallon")]
        public double KilousGallons => As(VolumeUnit.KilousGallon);

        /// <summary>
        ///     Get Volume in Liters.
        /// </summary>
        [Obsolete("Use without the 's' - Liters->Liter")]
        public double Liters => As(VolumeUnit.Liter);

        /// <summary>
        ///     Get Volume in MegacubicFeet.
        /// </summary>
        [Obsolete("Use singular form - MegacubicFeet->MegacubicFoot")]
        public double MegacubicFeet => As(VolumeUnit.MegacubicFoot);

        /// <summary>
        ///     Get Volume in MegaimperialGallons.
        /// </summary>
        [Obsolete("Use without the 's' - MegaimperialGallons->MegaimperialGallon")]
        public double MegaimperialGallons => As(VolumeUnit.MegaimperialGallon);

        /// <summary>
        ///     Get Volume in Megaliters.
        /// </summary>
        [Obsolete("Use without the 's' - Megaliters->Megaliter")]
        public double Megaliters => As(VolumeUnit.Megaliter);

        /// <summary>
        ///     Get Volume in MegausGallons.
        /// </summary>
        [Obsolete("Use without the 's' - MegausGallons->MegausGallon")]
        public double MegausGallons => As(VolumeUnit.MegausGallon);

        /// <summary>
        ///     Get Volume in MetricCups.
        /// </summary>
        [Obsolete("Use without the 's' - MetricCups->MetricCup")]
        public double MetricCups => As(VolumeUnit.MetricCup);

        /// <summary>
        ///     Get Volume in MetricTeaspoons.
        /// </summary>
        [Obsolete("Use without the 's' - MetricTeaspoons->MetricTeaspoon")]
        public double MetricTeaspoons => As(VolumeUnit.MetricTeaspoon);

        /// <summary>
        ///     Get Volume in Microliters.
        /// </summary>
        [Obsolete("Use without the 's' - Microliters->Microliter")]
        public double Microliters => As(VolumeUnit.Microliter);

        /// <summary>
        ///     Get Volume in Milliliters.
        /// </summary>
        [Obsolete("Use without the 's' - Milliliters->Milliliter")]
        public double Milliliters => As(VolumeUnit.Milliliter);

        /// <summary>
        ///     Get Volume in OilBarrels.
        /// </summary>
        [Obsolete("Use without the 's' - OilBarrels->OilBarrel")]
        public double OilBarrels => As(VolumeUnit.OilBarrel);

        /// <summary>
        ///     Get Volume in UkTablespoons.
        /// </summary>
        [Obsolete("Use without the 's' - UkTablespoons->UkTablespoon")]
        public double UkTablespoons => As(VolumeUnit.UkTablespoon);

        /// <summary>
        ///     Get Volume in UsBeerBarrels.
        /// </summary>
        [Obsolete("Use without the 's' - UsBeerBarrels->UsBeerBarrel")]
        public double UsBeerBarrels => As(VolumeUnit.UsBeerBarrel);

        /// <summary>
        ///     Get Volume in UsCustomaryCups.
        /// </summary>
        [Obsolete("Use without the 's' - UsCustomaryCups->UsCustomaryCup")]
        public double UsCustomaryCups => As(VolumeUnit.UsCustomaryCup);

        /// <summary>
        ///     Get Volume in UsGallons.
        /// </summary>
        [Obsolete("Use without the 's' - UsGallons->UsGallon")]
        public double UsGallons => As(VolumeUnit.UsGallon);

        /// <summary>
        ///     Get Volume in UsLegalCups.
        /// </summary>
        [Obsolete("Use without the 's' - UsLegalCups->UsLegalCup")]
        public double UsLegalCups => As(VolumeUnit.UsLegalCup);

        /// <summary>
        ///     Get Volume in UsOunces.
        /// </summary>
        [Obsolete("Use without the 's' - UsOunces->UsOunce")]
        public double UsOunces => As(VolumeUnit.UsOunce);

        /// <summary>
        ///     Get Volume in UsPints.
        /// </summary>
        [Obsolete("Use without the 's' - UsPints->UsPint")]
        public double UsPints => As(VolumeUnit.UsPint);

        /// <summary>
        ///     Get Volume in UsQuarts.
        /// </summary>
        [Obsolete("Use without the 's' - UsQuarts->UsQuart")]
        public double UsQuarts => As(VolumeUnit.UsQuart);

        /// <summary>
        ///     Get Volume in UsTablespoons.
        /// </summary>
        [Obsolete("Use without the 's' - UsTablespoons->UsTablespoon")]
        public double UsTablespoons => As(VolumeUnit.UsTablespoon);

        /// <summary>
        ///     Get Volume in UsTeaspoons.
        /// </summary>
        [Obsolete("Use without the 's' - UsTeaspoons->UsTeaspoon")]
        public double UsTeaspoons => As(VolumeUnit.UsTeaspoon);

    }
}
