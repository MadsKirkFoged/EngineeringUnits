using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricCharge
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricCharge FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricCharge(value, ElectricChargeUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricCharge from AmpereHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmpereHours->FromAmpereHour")]
    public static ElectricCharge FromAmpereHours(double amperehours)
    {
        var value = (double)amperehours;
        return new ElectricCharge(value, ElectricChargeUnit.AmpereHour);
    }
    /// <summary>
    ///     Get ElectricCharge from Coulombs.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCoulombs->FromCoulomb")]
    public static ElectricCharge FromCoulombs(double coulombs)
    {
        var value = (double)coulombs;
        return new ElectricCharge(value, ElectricChargeUnit.Coulomb);
    }
    /// <summary>
    ///     Get ElectricCharge from KiloampereHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloampereHours->FromKiloampereHour")]
    public static ElectricCharge FromKiloampereHours(double kiloamperehours)
    {
        var value = (double)kiloamperehours;
        return new ElectricCharge(value, ElectricChargeUnit.KiloampereHour);
    }
    /// <summary>
    ///     Get ElectricCharge from MegaampereHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaampereHours->FromMegaampereHour")]
    public static ElectricCharge FromMegaampereHours(double megaamperehours)
    {
        var value = (double)megaamperehours;
        return new ElectricCharge(value, ElectricChargeUnit.MegaampereHour);
    }
    /// <summary>
    ///     Get ElectricCharge from MilliampereHours.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliampereHours->FromMilliampereHour")]
    public static ElectricCharge FromMilliampereHours(double milliamperehours)
    {
        var value = (double)milliamperehours;
        return new ElectricCharge(value, ElectricChargeUnit.MilliampereHour);
    }
}
