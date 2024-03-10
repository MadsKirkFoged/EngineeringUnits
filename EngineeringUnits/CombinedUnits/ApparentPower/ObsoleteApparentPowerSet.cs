using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ApparentPower
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ApparentPower FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ApparentPower(value, ApparentPowerUnit.SI);
    //}

    /// <summary>
    ///     Get ApparentPower from Gigavoltamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigavoltamperes->FromGigavoltampere")]
    public static ApparentPower FromGigavoltamperes(double gigavoltamperes)
    {
        var value = (double)gigavoltamperes;
        return new ApparentPower(value, ApparentPowerUnit.Gigavoltampere);
    }
    /// <summary>
    ///     Get ApparentPower from Kilovoltamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilovoltamperes->FromKilovoltampere")]
    public static ApparentPower FromKilovoltamperes(double kilovoltamperes)
    {
        var value = (double)kilovoltamperes;
        return new ApparentPower(value, ApparentPowerUnit.Kilovoltampere);
    }
    /// <summary>
    ///     Get ApparentPower from Megavoltamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegavoltamperes->FromMegavoltampere")]
    public static ApparentPower FromMegavoltamperes(double megavoltamperes)
    {
        var value = (double)megavoltamperes;
        return new ApparentPower(value, ApparentPowerUnit.Megavoltampere);
    }
    /// <summary>
    ///     Get ApparentPower from Voltamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromVoltamperes->FromVoltampere")]
    public static ApparentPower FromVoltamperes(double voltamperes)
    {
        var value = (double)voltamperes;
        return new ApparentPower(value, ApparentPowerUnit.Voltampere);
    }
}
