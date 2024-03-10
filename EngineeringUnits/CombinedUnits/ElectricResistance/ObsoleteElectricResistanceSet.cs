using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricResistance
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricResistance FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricResistance(value, ElectricResistanceUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricResistance from Gigaohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGigaohms->FromGigaohm")]
    public static ElectricResistance FromGigaohms(double gigaohms)
    {
        var value = (double)gigaohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Gigaohm);
    }
    /// <summary>
    ///     Get ElectricResistance from Kiloohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloohms->FromKiloohm")]
    public static ElectricResistance FromKiloohms(double kiloohms)
    {
        var value = (double)kiloohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Kiloohm);
    }
    /// <summary>
    ///     Get ElectricResistance from Megaohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaohms->FromMegaohm")]
    public static ElectricResistance FromMegaohms(double megaohms)
    {
        var value = (double)megaohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Megaohm);
    }
    /// <summary>
    ///     Get ElectricResistance from Microohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroohms->FromMicroohm")]
    public static ElectricResistance FromMicroohms(double microohms)
    {
        var value = (double)microohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Microohm);
    }
    /// <summary>
    ///     Get ElectricResistance from Milliohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliohms->FromMilliohm")]
    public static ElectricResistance FromMilliohms(double milliohms)
    {
        var value = (double)milliohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Milliohm);
    }
    /// <summary>
    ///     Get ElectricResistance from Ohms.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOhms->FromOhm")]
    public static ElectricResistance FromOhms(double ohms)
    {
        var value = (double)ohms;
        return new ElectricResistance(value, ElectricResistanceUnit.Ohm);
    }
}
