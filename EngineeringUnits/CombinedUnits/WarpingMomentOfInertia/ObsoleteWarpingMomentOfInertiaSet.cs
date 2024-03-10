using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class WarpingMomentOfInertia
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static WarpingMomentOfInertia FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.SI);
    //}

    /// <summary>
    ///     Get WarpingMomentOfInertia from CentimetersToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentimetersToTheSixth->FromCentimeterToTheSixth")]
    public static WarpingMomentOfInertia FromCentimetersToTheSixth(double centimeterstothesixth)
    {
        var value = (double)centimeterstothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.CentimeterToTheSixth);
    }
    /// <summary>
    ///     Get WarpingMomentOfInertia from DecimetersToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecimetersToTheSixth->FromDecimeterToTheSixth")]
    public static WarpingMomentOfInertia FromDecimetersToTheSixth(double decimeterstothesixth)
    {
        var value = (double)decimeterstothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.DecimeterToTheSixth);
    }
    /// <summary>
    ///     Get WarpingMomentOfInertia from FeetToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromFeetToTheSixth->FromFootToTheSixth")]
    public static WarpingMomentOfInertia FromFeetToTheSixth(double feettothesixth)
    {
        var value = (double)feettothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.FootToTheSixth);
    }
    /// <summary>
    ///     Get WarpingMomentOfInertia from InchesToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromInchesToTheSixth->FromInchToTheSixth")]
    public static WarpingMomentOfInertia FromInchesToTheSixth(double inchestothesixth)
    {
        var value = (double)inchestothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.InchToTheSixth);
    }
    /// <summary>
    ///     Get WarpingMomentOfInertia from MetersToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMetersToTheSixth->FromMeterToTheSixth")]
    public static WarpingMomentOfInertia FromMetersToTheSixth(double meterstothesixth)
    {
        var value = (double)meterstothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MeterToTheSixth);
    }
    /// <summary>
    ///     Get WarpingMomentOfInertia from MillimetersToTheSixth.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillimetersToTheSixth->FromMillimeterToTheSixth")]
    public static WarpingMomentOfInertia FromMillimetersToTheSixth(double millimeterstothesixth)
    {
        var value = (double)millimeterstothesixth;
        return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MillimeterToTheSixth);
    }
}
