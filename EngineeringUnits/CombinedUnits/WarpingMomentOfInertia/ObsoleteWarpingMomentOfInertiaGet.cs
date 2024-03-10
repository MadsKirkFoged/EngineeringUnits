using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class WarpingMomentOfInertia
{
    /// <summary>
    ///     Get WarpingMomentOfInertia in CentimetersToTheSixth.
    /// </summary>
    [Obsolete("Use without the 's' - CentimetersToTheSixth->CentimeterToTheSixth")]
    public double CentimetersToTheSixth => As(WarpingMomentOfInertiaUnit.CentimeterToTheSixth);

    /// <summary>
    ///     Get WarpingMomentOfInertia in DecimetersToTheSixth.
    /// </summary>
    [Obsolete("Use without the 's' - DecimetersToTheSixth->DecimeterToTheSixth")]
    public double DecimetersToTheSixth => As(WarpingMomentOfInertiaUnit.DecimeterToTheSixth);

    /// <summary>
    ///     Get WarpingMomentOfInertia in FeetToTheSixth.
    /// </summary>
    [Obsolete("Use singular form - FeetToTheSixth->FootToTheSixth")]
    public double FeetToTheSixth => As(WarpingMomentOfInertiaUnit.FootToTheSixth);

    /// <summary>
    ///     Get WarpingMomentOfInertia in InchesToTheSixth.
    /// </summary>
    [Obsolete("Use without the 's' - InchesToTheSixth->InchToTheSixth")]
    public double InchesToTheSixth => As(WarpingMomentOfInertiaUnit.InchToTheSixth);

    /// <summary>
    ///     Get WarpingMomentOfInertia in MetersToTheSixth.
    /// </summary>
    [Obsolete("Use without the 's' - MetersToTheSixth->MeterToTheSixth")]
    public double MetersToTheSixth => As(WarpingMomentOfInertiaUnit.MeterToTheSixth);

    /// <summary>
    ///     Get WarpingMomentOfInertia in SI unit (MetersToTheSixth).
    /// </summary>
    //public double SI => As(WarpingMomentOfInertiaUnit.SI);

    /// <summary>
    ///     Get WarpingMomentOfInertia in MillimetersToTheSixth.
    /// </summary>
    [Obsolete("Use without the 's' - MillimetersToTheSixth->MillimeterToTheSixth")]
    public double MillimetersToTheSixth => As(WarpingMomentOfInertiaUnit.MillimeterToTheSixth);

}
