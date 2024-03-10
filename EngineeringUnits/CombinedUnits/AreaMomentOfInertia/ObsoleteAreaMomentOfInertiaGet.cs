using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class AreaMomentOfInertia
{
    /// <summary>
    ///     Get AreaMomentOfInertia in CentimetersToTheFourth.
    /// </summary>
    [Obsolete("Use without the 's' - CentimetersToTheFourth->CentimeterToTheFourth")]
    public double CentimetersToTheFourth => As(AreaMomentOfInertiaUnit.CentimeterToTheFourth);

    /// <summary>
    ///     Get AreaMomentOfInertia in DecimetersToTheFourth.
    /// </summary>
    [Obsolete("Use without the 's' - DecimetersToTheFourth->DecimeterToTheFourth")]
    public double DecimetersToTheFourth => As(AreaMomentOfInertiaUnit.DecimeterToTheFourth);

    /// <summary>
    ///     Get AreaMomentOfInertia in FeetToTheFourth.
    /// </summary>
    [Obsolete("Use the singular form - FeetToTheFourth->FootToTheFourth")]
    public double FeetToTheFourth => As(AreaMomentOfInertiaUnit.FootToTheFourth);

    /// <summary>
    ///     Get AreaMomentOfInertia in InchesToTheFourth.
    /// </summary>
    [Obsolete("Use without the 's' - InchesToTheFourth->IncheToTheFourth")]
    public double InchesToTheFourth => As(AreaMomentOfInertiaUnit.InchToTheFourth);

    /// <summary>
    ///     Get AreaMomentOfInertia in MetersToTheFourth.
    /// </summary>
    [Obsolete("Use without the 's' - MetersToTheFourth->MeterToTheFourth")]
    public double MetersToTheFourth => As(AreaMomentOfInertiaUnit.MeterToTheFourth);

    /// <summary>
    ///     Get AreaMomentOfInertia in SI Unit (MetersToTheFourth).
    /// </summary>
    //public double SI => As(AreaMomentOfInertiaUnit.SI);

    /// <summary>
    ///     Get AreaMomentOfInertia in MillimetersToTheFourth.
    /// </summary>
    [Obsolete("Use without the 's' - MillimetersToTheFourth->MillimeterToTheFourth")]
    public double MillimetersToTheFourth => As(AreaMomentOfInertiaUnit.MillimeterToTheFourth);

}
