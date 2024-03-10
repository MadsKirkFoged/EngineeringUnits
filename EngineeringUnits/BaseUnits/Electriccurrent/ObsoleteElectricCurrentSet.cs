using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricCurrent
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricCurrent FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricCurrent(value, ElectricCurrentUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricCurrent from Amperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperes->FromAmpere")]
    public static ElectricCurrent FromAmperes(double amperes)
    {
        var value = (double)amperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Ampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Centiamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentiamperes->FromCentiampere")]
    public static ElectricCurrent FromCentiamperes(double centiamperes)
    {
        var value = (double)centiamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Centiampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Kiloamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKiloamperes->FromKiloampere")]
    public static ElectricCurrent FromKiloamperes(double kiloamperes)
    {
        var value = (double)kiloamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Kiloampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Megaamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaamperes->FromMegaampere")]
    public static ElectricCurrent FromMegaamperes(double megaamperes)
    {
        var value = (double)megaamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Megaampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Microamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicroamperes->FromMicroampere")]
    public static ElectricCurrent FromMicroamperes(double microamperes)
    {
        var value = (double)microamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Microampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Milliamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliamperes->FromMilliampere")]
    public static ElectricCurrent FromMilliamperes(double milliamperes)
    {
        var value = (double)milliamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Milliampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Nanoamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanoamperes->FromNanoampere")]
    public static ElectricCurrent FromNanoamperes(double nanoamperes)
    {
        var value = (double)nanoamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Nanoampere);
    }
    /// <summary>
    ///     Get ElectricCurrent from Picoamperes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPicoamperes->FromPicoampere")]
    public static ElectricCurrent FromPicoamperes(double picoamperes)
    {
        var value = (double)picoamperes;
        return new ElectricCurrent(value, ElectricCurrentUnit.Picoampere);
    }
}
