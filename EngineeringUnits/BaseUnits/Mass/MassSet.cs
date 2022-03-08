
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Mass
    {

 

            /// <summary>
            ///     Get Mass from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromSI(double SI)
            {
                double value= (double)SI;
                return new Mass(value, MassUnit.SI);
            }
            /// <summary>
            ///     Get Mass from Kilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromKilogram(double Kilogram)
            {
                double value= (double)Kilogram;
                return new Mass(value, MassUnit.Kilogram);
            }
            /// <summary>
            ///     Get Mass from Picogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromPicogram(double Picogram)
            {
                double value= (double)Picogram;
                return new Mass(value, MassUnit.Picogram);
            }
            /// <summary>
            ///     Get Mass from Centigram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromCentigram(double Centigram)
            {
                double value= (double)Centigram;
                return new Mass(value, MassUnit.Centigram);
            }
            /// <summary>
            ///     Get Mass from Decagram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromDecagram(double Decagram)
            {
                double value= (double)Decagram;
                return new Mass(value, MassUnit.Decagram);
            }
            /// <summary>
            ///     Get Mass from Decigram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromDecigram(double Decigram)
            {
                double value= (double)Decigram;
                return new Mass(value, MassUnit.Decigram);
            }
            /// <summary>
            ///     Get Mass from Gram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromGram(double Gram)
            {
                double value= (double)Gram;
                return new Mass(value, MassUnit.Gram);
            }
            /// <summary>
            ///     Get Mass from Hectogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromHectogram(double Hectogram)
            {
                double value= (double)Hectogram;
                return new Mass(value, MassUnit.Hectogram);
            }
            /// <summary>
            ///     Get Mass from Microgram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromMicrogram(double Microgram)
            {
                double value= (double)Microgram;
                return new Mass(value, MassUnit.Microgram);
            }
            /// <summary>
            ///     Get Mass from Milligram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromMilligram(double Milligram)
            {
                double value= (double)Milligram;
                return new Mass(value, MassUnit.Milligram);
            }
            /// <summary>
            ///     Get Mass from Nanogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromNanogram(double Nanogram)
            {
                double value= (double)Nanogram;
                return new Mass(value, MassUnit.Nanogram);
            }
            /// <summary>
            ///     Get Mass from Tonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromTonne(double Tonne)
            {
                double value= (double)Tonne;
                return new Mass(value, MassUnit.Tonne);
            }
            /// <summary>
            ///     Get Mass from Kilotonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromKilotonne(double Kilotonne)
            {
                double value= (double)Kilotonne;
                return new Mass(value, MassUnit.Kilotonne);
            }
            /// <summary>
            ///     Get Mass from Megatonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromMegatonne(double Megatonne)
            {
                double value= (double)Megatonne;
                return new Mass(value, MassUnit.Megatonne);
            }
            /// <summary>
            ///     Get Mass from EarthMass.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromEarthMass(double EarthMass)
            {
                double value= (double)EarthMass;
                return new Mass(value, MassUnit.EarthMass);
            }
            /// <summary>
            ///     Get Mass from Ounce.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromOunce(double Ounce)
            {
                double value= (double)Ounce;
                return new Mass(value, MassUnit.Ounce);
            }
            /// <summary>
            ///     Get Mass from Pound.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromPound(double Pound)
            {
                double value= (double)Pound;
                return new Mass(value, MassUnit.Pound);
            }
            /// <summary>
            ///     Get Mass from Stone.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromStone(double Stone)
            {
                double value= (double)Stone;
                return new Mass(value, MassUnit.Stone);
            }
            /// <summary>
            ///     Get Mass from Slug.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromSlug(double Slug)
            {
                double value= (double)Slug;
                return new Mass(value, MassUnit.Slug);
            }
            /// <summary>
            ///     Get Mass from ShortHundredweight.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromShortHundredweight(double ShortHundredweight)
            {
                double value= (double)ShortHundredweight;
                return new Mass(value, MassUnit.ShortHundredweight);
            }
            /// <summary>
            ///     Get Mass from LongHundredweight.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromLongHundredweight(double LongHundredweight)
            {
                double value= (double)LongHundredweight;
                return new Mass(value, MassUnit.LongHundredweight);
            }
            /// <summary>
            ///     Get Mass from Kilopound.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromKilopound(double Kilopound)
            {
                double value= (double)Kilopound;
                return new Mass(value, MassUnit.Kilopound);
            }
            /// <summary>
            ///     Get Mass from ShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromShortTon(double ShortTon)
            {
                double value= (double)ShortTon;
                return new Mass(value, MassUnit.ShortTon);
            }
            /// <summary>
            ///     Get Mass from LongTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromLongTon(double LongTon)
            {
                double value= (double)LongTon;
                return new Mass(value, MassUnit.LongTon);
            }
            /// <summary>
            ///     Get Mass from Megapound.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromMegapound(double Megapound)
            {
                double value= (double)Megapound;
                return new Mass(value, MassUnit.Megapound);
            }
            /// <summary>
            ///     Get Mass from Grain.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Mass FromGrain(double Grain)
            {
                double value= (double)Grain;
                return new Mass(value, MassUnit.Grain);
            }
    }
}


