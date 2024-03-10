using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Area
{

    /// <summary>
    ///     Get Area in Acres.
    /// </summary>
    [Obsolete("Use without the 's' - Acres->Acre")]
    public double Acres => As(AreaUnit.Acre);

    /// <summary>
    ///     Get Area in Hectares.
    /// </summary>
    [Obsolete("Use without the 's' - Hectares->Hectare")]
    public double Hectares => As(AreaUnit.Hectare);

    /// <summary>
    ///     Get Area in SquareCentimeters.
    /// </summary>
    [Obsolete("Use without the 's' - SquareCentimeters->SquareCentimeter")]
    public double SquareCentimeters => As(AreaUnit.SquareCentimeter);

    /// <summary>
    ///     Get Area in SquareDecimeters.
    /// </summary>
    [Obsolete("Use without the 's' - SquareDecimeters->SquareDecimeter")]
    public double SquareDecimeters => As(AreaUnit.SquareDecimeter);

    /// <summary>
    ///     Get Area in SquareFeet.
    /// </summary>
    [Obsolete("Use singular form - SquareFeet->SquareFoot")]
    public double SquareFeet => As(AreaUnit.SquareFoot);

    /// <summary>
    ///     Get Area in SquareInches.
    /// </summary>
    [Obsolete("Use without the 's' - SquareInches->SquareInche")]
    public double SquareInches => As(AreaUnit.SquareInch);

    /// <summary>
    ///     Get Area in SquareKilometers.
    /// </summary>
    [Obsolete("Use without the 's' - SquareKilometers->SquareKilometer")]
    public double SquareKilometers => As(AreaUnit.SquareKilometer);

    /// <summary>
    ///     Get Area in SquareMeters.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMeters->SquareMeter")]
    public double SquareMeters => As(AreaUnit.SquareMeter);

    /// <summary>
    ///     Get Area in SI Unit (SquareMeters).
    /// </summary>
    //public double SI => As(AreaUnit.SI);

    /// <summary>
    ///     Get Area in SquareMicrometers.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMicrometers->SquareMicrometer")]
    public double SquareMicrometers => As(AreaUnit.SquareMicrometer);

    /// <summary>
    ///     Get Area in SquareMiles.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMiles->SquareMile")]
    public double SquareMiles => As(AreaUnit.SquareMile);

    /// <summary>
    ///     Get Area in SquareMillimeters.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMillimeters->SquareMillimeter")]
    public double SquareMillimeters => As(AreaUnit.SquareMillimeter);

    /// <summary>
    ///     Get Area in SquareNauticalMiles.
    /// </summary>
    [Obsolete("Use without the 's' - SquareNauticalMiles->SquareNauticalMile")]
    public double SquareNauticalMiles => As(AreaUnit.SquareNauticalMile);

    /// <summary>
    ///     Get Area in SquareYards.
    /// </summary>
    [Obsolete("Use without the 's' - SquareYards->SquareYard")]
    public double SquareYards => As(AreaUnit.SquareYard);

    /// <summary>
    ///     Get Area in UsSurveySquareFeet.
    /// </summary>
    //public double UsSurveySquareFeet => As(AreaUnit.UsSurveySquareFoot);

}
