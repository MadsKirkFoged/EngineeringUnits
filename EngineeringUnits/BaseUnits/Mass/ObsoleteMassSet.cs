﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Mass
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Mass(value, MassUnit.SI);
    //}

    /// <summary>
    ///     Get Mass from Centigrams.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentigrams->FromCentigram")]
    public static Mass FromCentigrams(double centigrams)
    {
        var value = (double)centigrams;
        return new Mass(value, MassUnit.Centigram);
    }
    /// <summary>
    ///     Get Mass from Decagrams.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecagrams->FromDecagram")]
    public static Mass FromDecagrams(double decagrams)
    {
        var value = (double)decagrams;
        return new Mass(value, MassUnit.Decagram);
    }
    /// <summary>
    ///     Get Mass from Decigrams.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecigrams->FromDecigram")]
    public static Mass FromDecigrams(double decigrams)
    {
        var value = (double)decigrams;
        return new Mass(value, MassUnit.Decigram);
    }
    /// <summary>
    ///     Get Mass from EarthMasses.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromEarthMasses->FromEarthMass")]
    public static Mass FromEarthMasses(double earthmasses)
    {
        var value = (double)earthmasses;
        return new Mass(value, MassUnit.EarthMass);
    }
    /// <summary>
    ///     Get Mass from Grains.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGrains->FromGrain")]
    public static Mass FromGrains(double grains)
    {
        var value = (double)grains;
        return new Mass(value, MassUnit.Grain);
    }
    /// <summary>
    ///     Get Mass from Grams.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGrams->FromGram")]
    public static Mass FromGrams(double grams)
    {
        var value = (double)grams;
        return new Mass(value, MassUnit.Gram);
    }
    /// <summary>
    ///     Get Mass from Hectograms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectograms->FromHectogram")]
    public static Mass FromHectograms(double hectograms)
    {
        var value = (double)hectograms;
        return new Mass(value, MassUnit.Hectogram);
    }
    /// <summary>
    ///     Get Mass from Kilograms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilograms->FromKilogram")]
    public static Mass FromKilograms(double kilograms)
    {
        var value = (double)kilograms;
        return new Mass(value, MassUnit.Kilogram);
    }
    /// <summary>
    ///     Get Mass from Kilopounds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromKilopounds(double kilopounds)
    //{
    //    double value = (double)kilopounds;
    //    return new Mass(value, MassUnit.Kilopound);
    //}
    /// <summary>
    ///     Get Mass from Kilotonnes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromKilotonnes(double kilotonnes)
    //{
    //    double value = (double)kilotonnes;
    //    return new Mass(value, MassUnit.Kilotonne);
    //}
    /// <summary>
    ///     Get Mass from LongHundredweight.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromLongHundredweight(double longhundredweight)
    //{
    //    double value = (double)longhundredweight;
    //    return new Mass(value, MassUnit.LongHundredweight);
    //}
    /// <summary>
    ///     Get Mass from LongTons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromLongTons(double longtons)
    //{
    //    double value = (double)longtons;
    //    return new Mass(value, MassUnit.LongTon);
    //}
    /// <summary>
    ///     Get Mass from Megapounds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromMegapounds(double megapounds)
    //{
    //    double value = (double)megapounds;
    //    return new Mass(value, MassUnit.Megapound);
    //}
    /// <summary>
    ///     Get Mass from Megatonnes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromMegatonnes(double megatonnes)
    //{
    //    double value = (double)megatonnes;
    //    return new Mass(value, MassUnit.Megatonne);
    //}
    /// <summary>
    ///     Get Mass from Micrograms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrograms->FromMicrogram")]
    public static Mass FromMicrograms(double micrograms)
    {
        var value = (double)micrograms;
        return new Mass(value, MassUnit.Microgram);
    }
    /// <summary>
    ///     Get Mass from Milligrams.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligrams->FromMilligram")]
    public static Mass FromMilligrams(double milligrams)
    {
        var value = (double)milligrams;
        return new Mass(value, MassUnit.Milligram);
    }
    /// <summary>
    ///     Get Mass from Nanograms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanograms->FromNanogram")]
    public static Mass FromNanograms(double nanograms)
    {
        var value = (double)nanograms;
        return new Mass(value, MassUnit.Nanogram);
    }
    /// <summary>
    ///     Get Mass from Ounces.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOunces->FromOunce")]
    public static Mass FromOunces(double ounces)
    {
        var value = (double)ounces;
        return new Mass(value, MassUnit.Ounce);
    }
    /// <summary>
    ///     Get Mass from Pounds.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPounds->FromPounds")]
    public static Mass FromPounds(double pounds)
    {
        var value = (double)pounds;
        return new Mass(value, MassUnit.Pound);
    }
    /// <summary>
    ///     Get Mass from ShortHundredweight.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromShortHundredweight(double shorthundredweight)
    //{
    //    double value = (double)shorthundredweight;
    //    return new Mass(value, MassUnit.ShortHundredweight);
    //}
    /// <summary>
    ///     Get Mass from ShortTons.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromShortTons->FromShortTon")]
    public static Mass FromShortTons(double shorttons)
    {
        var value = (double)shorttons;
        return new Mass(value, MassUnit.ShortTon);
    }
    /// <summary>
    ///     Get Mass from Slugs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromSlugs(double slugs)
    //{
    //    double value = (double)slugs;
    //    return new Mass(value, MassUnit.Slug);
    //}
    /// <summary>
    ///     Get Mass from SolarMasses.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromSolarMasses(double solarmasses)
    //{
    //    double value = (double)solarmasses;
    //    return new Mass(value, MassUnit.SolarMass);
    //}
    /// <summary>
    ///     Get Mass from Stone.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Mass FromStone(double stone)
    //{
    //    double value = (double)stone;
    //    return new Mass(value, MassUnit.Stone);
    //}
    /// <summary>
    ///     Get Mass from Tonnes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnes->FromTonne")]
    public static Mass FromTonnes(double tonnes)
    {
        var value = (double)tonnes;
        return new Mass(value, MassUnit.Tonne);
    }
}
