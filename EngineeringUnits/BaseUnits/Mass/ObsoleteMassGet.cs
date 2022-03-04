using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Mass
    {


        /// <summary>
        ///     Get Mass in Centigrams.
        /// </summary>
        [Obsolete("Use without the 's' - Centigrams->Centigram")]

        public double Centigrams => As(MassUnit.Centigram);

        /// <summary>
        ///     Get Mass in Decagrams.
        /// </summary>
        //public double Decagrams => As(MassUnit.Decagram);

        /// <summary>
        ///     Get Mass in Decigrams.
        /// </summary>
        [Obsolete("Use without the 's' - Decigrams->Decigram")]

        public double Decigrams => As(MassUnit.Decigram);

        /// <summary>
        ///     Get Mass in EarthMasses.
        /// </summary>
        [Obsolete("Use without the 'es' - EarthMasses->EarthMass")]

        public double EarthMasses => As(MassUnit.EarthMass);

        /// <summary>
        ///     Get Mass in Grains.
        /// </summary>
        [Obsolete("Use without the 's' - Grains->Grain")]

        public double Grains => As(MassUnit.Grain);

        /// <summary>
        ///     Get Mass in Grams.
        /// </summary>
        [Obsolete("Use without the 's' - Grams->Gram")]

        public double Grams => As(MassUnit.Gram);

        /// <summary>
        ///     Get Mass in Hectograms.
        /// </summary>
        [Obsolete("Use without the 's' - Hectograms->Hectogram")]

        public double Hectograms => As(MassUnit.Hectogram);

        /// <summary>
        ///     Get Mass in Kilograms.
        /// </summary>
        [Obsolete("Use without the 's' - Kilograms->Kilogram")]

        public double Kilograms => As(MassUnit.Kilogram);

        /// <summary>
        ///     Get Mass in SI Unit (Kilograms).
        /// </summary>

        //public double SI => As(MassUnit.SI);

        /// <summary>
        ///     Get Mass in Kilopounds.
        /// </summary>
        //public double Kilopounds => As(MassUnit.Kilopound);

        /// <summary>
        ///     Get Mass in Kilotonnes.
        /// </summary>
        //public double Kilotonnes => As(MassUnit.Kilotonne);

        /// <summary>
        ///     Get Mass in LongHundredweight.
        /// </summary>
        //public double LongHundredweight => As(MassUnit.LongHundredweight);

        /// <summary>
        ///     Get Mass in LongTons.
        /// </summary>
        //public double LongTons => As(MassUnit.LongTon);

        /// <summary>
        ///     Get Mass in Megapounds.
        /// </summary>
        //public double Megapounds => As(MassUnit.Megapound);

        /// <summary>
        ///     Get Mass in Megatonnes.
        /// </summary>
        //public double Megatonnes => As(MassUnit.Megatonne);

        /// <summary>
        ///     Get Mass in Micrograms.
        /// </summary>
        [Obsolete("Use without the 's' - Micrograms->Microgram")]

        public double Micrograms => As(MassUnit.Microgram);

        /// <summary>
        ///     Get Mass in Milligrams.
        /// </summary>
        [Obsolete("Use without the 's' - Milligrams->Milligram")]
        public double Milligrams => As(MassUnit.Milligram);

        /// <summary>
        ///     Get Mass in Nanograms.
        /// </summary>
        [Obsolete("Use without the 's' - Nanograms->Nanogram")]
        public double Nanograms => As(MassUnit.Nanogram);

        /// <summary>
        ///     Get Mass in Ounces.
        /// </summary>
        [Obsolete("Use without the 's' - Ounces->Ounce")]
        public double Ounces => As(MassUnit.Ounce);

        /// <summary>
        ///     Get Mass in Pounds.
        /// </summary>
        [Obsolete("Use without the 's' - Pounds->Pound")]
        public double Pounds => As(MassUnit.Pound);

        /// <summary>
        ///     Get Mass in ShortHundredweight.
        /// </summary>
        //public double ShortHundredweight => As(MassUnit.ShortHundredweight);

        /// <summary>
        ///     Get Mass in ShortTons.
        /// </summary>
        [Obsolete("Use without the 's' - ShortTon->ShortTon")]
        public double ShortTons => As(MassUnit.ShortTon);

        /// <summary>
        ///     Get Mass in Slugs.
        /// </summary>
        //public double Slugs => As(MassUnit.Slug);

        /// <summary>
        ///     Get Mass in SolarMasses.
        /// </summary>
        //public double SolarMasses => As(MassUnit.SolarMass);

        /// <summary>
        ///     Get Mass in Stone.
        /// </summary>
        //public double Stone => As(MassUnit.Stone);

        /// <summary>
        ///     Get Mass in Tonnes.
        /// </summary>
        [Obsolete("Use without the 's' - Tonnes->Tonne")]
        public double Tonnes => As(MassUnit.Tonne);



    }
}
