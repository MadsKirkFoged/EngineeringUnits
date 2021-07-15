using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area
    {

        /// <summary>
        ///     Get Area in Acres.
        /// </summary>
        public double Acres => As(AreaUnit.Acre);

        /// <summary>
        ///     Get Area in Hectares.
        /// </summary>
        public double Hectares => As(AreaUnit.Hectare);

        /// <summary>
        ///     Get Area in SquareCentimeters.
        /// </summary>
        public double SquareCentimeters => As(AreaUnit.SquareCentimeter);

        /// <summary>
        ///     Get Area in SquareDecimeters.
        /// </summary>
        public double SquareDecimeters => As(AreaUnit.SquareDecimeter);

        /// <summary>
        ///     Get Area in SquareFeet.
        /// </summary>
        public double SquareFeet => As(AreaUnit.SquareFoot);

        /// <summary>
        ///     Get Area in SquareInches.
        /// </summary>
        public double SquareInches => As(AreaUnit.SquareInch);

        /// <summary>
        ///     Get Area in SquareKilometers.
        /// </summary>
        public double SquareKilometers => As(AreaUnit.SquareKilometer);

        /// <summary>
        ///     Get Area in SquareMeters.
        /// </summary>
        public double SquareMeters => As(AreaUnit.SquareMeter);


        /// <summary>
        ///     Get Area in SI Unit (SquareMeters).
        /// </summary>
        public double SI => As(AreaUnit.SI);

        /// <summary>
        ///     Get Area in SquareMicrometers.
        /// </summary>
        public double SquareMicrometers => As(AreaUnit.SquareMicrometer);

        /// <summary>
        ///     Get Area in SquareMiles.
        /// </summary>
        public double SquareMiles => As(AreaUnit.SquareMile);

        /// <summary>
        ///     Get Area in SquareMillimeters.
        /// </summary>
        public double SquareMillimeters => As(AreaUnit.SquareMillimeter);

        /// <summary>
        ///     Get Area in SquareNauticalMiles.
        /// </summary>
        public double SquareNauticalMiles => As(AreaUnit.SquareNauticalMile);

        /// <summary>
        ///     Get Area in SquareYards.
        /// </summary>
        public double SquareYards => As(AreaUnit.SquareYard);

        /// <summary>
        ///     Get Area in UsSurveySquareFeet.
        /// </summary>
        //public double UsSurveySquareFeet => As(AreaUnit.UsSurveySquareFoot);

    }
}
