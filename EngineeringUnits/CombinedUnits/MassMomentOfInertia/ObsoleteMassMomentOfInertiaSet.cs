using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class MassMomentOfInertia
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static MassMomentOfInertia FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.SI);
        //}


        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramSquareCentimeters->FromGramSquareCentimeter")]
        public static MassMomentOfInertia FromGramSquareCentimeters(double gramsquarecentimeters)
        {
            double value = (double)gramsquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.GramSquareCentimeter);
        }
       
        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramSquareDecimeters->FromGramSquareDecimeter")]
        public static MassMomentOfInertia FromGramSquareDecimeters(double gramsquaredecimeters)
        {
            double value = (double)gramsquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.GramSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramSquareMeters->FromGramSquareMeter")]
        public static MassMomentOfInertia FromGramSquareMeters(double gramsquaremeters)
        {
            double value = (double)gramsquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.GramSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramSquareMillimeters->FromGramSquareMillimeter")]
        public static MassMomentOfInertia FromGramSquareMillimeters(double gramsquaremillimeters)
        {
            double value = (double)gramsquaremillimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.GramSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramSquareCentimeters->FromKilogramSquareCentimeter")]
        public static MassMomentOfInertia FromKilogramSquareCentimeters(double kilogramsquarecentimeters)
        {
            double value = (double)kilogramsquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilogramSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramSquareDecimeters->FromKilogramSquareDecimeter")]
        public static MassMomentOfInertia FromKilogramSquareDecimeters(double kilogramsquaredecimeters)
        {
            double value = (double)kilogramsquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilogramSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramSquareMeters->FromKilogramSquareMeter")]
        public static MassMomentOfInertia FromKilogramSquareMeters(double kilogramsquaremeters)
        {
            double value = (double)kilogramsquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilogramSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramSquareMillimeters->FromKilogramSquareMillimeter")]
        public static MassMomentOfInertia FromKilogramSquareMillimeters(double kilogramsquaremillimeters)
        {
            double value = (double)kilogramsquaremillimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilogramSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilotonneSquareCentimeters->FromKilotonneSquareCentimeter")]
        public static MassMomentOfInertia FromKilotonneSquareCentimeters(double kilotonnesquarecentimeters)
        {
            double value = (double)kilotonnesquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilotonneSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilotonneSquareDecimeters->FromKilotonneSquareDecimeter")]
        public static MassMomentOfInertia FromKilotonneSquareDecimeters(double kilotonnesquaredecimeters)
        {
            double value = (double)kilotonnesquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilotonneSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilotonneSquareMeters->FromKilotonneSquareMeter")]
        public static MassMomentOfInertia FromKilotonneSquareMeters(double kilotonnesquaremeters)
        {
            double value = (double)kilotonnesquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilotonneSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilotonneSquareMilimeters->FromKilotonneSquareMilimeter")]
        public static MassMomentOfInertia FromKilotonneSquareMilimeters(double kilotonnesquaremilimeters)
        {
            double value = (double)kilotonnesquaremilimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.KilotonneSquareMilimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegatonneSquareCentimeters->FromMegatonneSquareCentimeter")]
        public static MassMomentOfInertia FromMegatonneSquareCentimeters(double megatonnesquarecentimeters)
        {
            double value = (double)megatonnesquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MegatonneSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegatonneSquareDecimeters->FromMegatonneSquareDecimeter")]
        public static MassMomentOfInertia FromMegatonneSquareDecimeters(double megatonnesquaredecimeters)
        {
            double value = (double)megatonnesquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MegatonneSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegatonneSquareMeters->FromMegatonneSquareMeter")]
        public static MassMomentOfInertia FromMegatonneSquareMeters(double megatonnesquaremeters)
        {
            double value = (double)megatonnesquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MegatonneSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegatonneSquareMilimeters->FromMegatonneSquareMilimeter")]
        public static MassMomentOfInertia FromMegatonneSquareMilimeters(double megatonnesquaremilimeters)
        {
            double value = (double)megatonnesquaremilimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MegatonneSquareMilimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramSquareCentimeters->FromMilligramSquareCentimeter")]
        public static MassMomentOfInertia FromMilligramSquareCentimeters(double milligramsquarecentimeters)
        {
            double value = (double)milligramsquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MilligramSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramSquareDecimeters->FromMilligramSquareDecimeter")]
        public static MassMomentOfInertia FromMilligramSquareDecimeters(double milligramsquaredecimeters)
        {
            double value = (double)milligramsquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MilligramSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramSquareMeters->FromMilligramSquareMeter")]
        public static MassMomentOfInertia FromMilligramSquareMeters(double milligramsquaremeters)
        {
            double value = (double)milligramsquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MilligramSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramSquareMillimeters->FromMilligramSquareMillimeter")]
        public static MassMomentOfInertia FromMilligramSquareMillimeters(double milligramsquaremillimeters)
        {
            double value = (double)milligramsquaremillimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.MilligramSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from PoundSquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromPoundSquareFeet->FromPoundSquareFoot")]
        public static MassMomentOfInertia FromPoundSquareFeet(double poundsquarefeet)
        {
            double value = (double)poundsquarefeet;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.PoundSquareFoot);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from PoundSquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundSquareInches->FromPoundSquareInch")]
        public static MassMomentOfInertia FromPoundSquareInches(double poundsquareinches)
        {
            double value = (double)poundsquareinches;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.PoundSquareInch);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from SlugSquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromSlugSquareFeet->FromSlugSquareFoot")]
        public static MassMomentOfInertia FromSlugSquareFeet(double slugsquarefeet)
        {
            double value = (double)slugsquarefeet;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.SlugSquareFoot);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from SlugSquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSlugSquareInches->FromSlugSquareInch")]
        public static MassMomentOfInertia FromSlugSquareInches(double slugsquareinches)
        {
            double value = (double)slugsquareinches;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.SlugSquareInch);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonneSquareCentimeters->FromTonneSquareCentimeter")]
        public static MassMomentOfInertia FromTonneSquareCentimeters(double tonnesquarecentimeters)
        {
            double value = (double)tonnesquarecentimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.TonneSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonneSquareDecimeters->FromTonneSquareDecimeter")]
        public static MassMomentOfInertia FromTonneSquareDecimeters(double tonnesquaredecimeters)
        {
            double value = (double)tonnesquaredecimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.TonneSquareDecimeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonneSquareMeters->FromTonneSquareMeter")]
        public static MassMomentOfInertia FromTonneSquareMeters(double tonnesquaremeters)
        {
            double value = (double)tonnesquaremeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.TonneSquareMeter);
        }
        
        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonneSquareMilimeters->FromTonneSquareMilimeter")]
        public static MassMomentOfInertia FromTonneSquareMilimeters(double tonnesquaremilimeters)
        {
            double value = (double)tonnesquaremilimeters;
            return new MassMomentOfInertia(value, MassMomentOfInertiaUnit.TonneSquareMilimeter);
        }

    }
}
