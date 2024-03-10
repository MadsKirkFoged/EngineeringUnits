using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricPotential
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricPotential FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricPotential(value, ElectricPotentialUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricPotential from Kilovolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilovolts->FromKilovolt")]
    public static ElectricPotential FromKilovolts(double kilovolts)
    {
        var value = (double)kilovolts;
        return new ElectricPotential(value, ElectricPotentialUnit.Kilovolt);
    }
    /// <summary>
    ///     Get ElectricPotential from Megavolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegavolts->FromMegavolt")]
    public static ElectricPotential FromMegavolts(double megavolts)
    {
        var value = (double)megavolts;
        return new ElectricPotential(value, ElectricPotentialUnit.Megavolt);
    }
    /// <summary>
    ///     Get ElectricPotential from Microvolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrovolts->FromMicrovolt")]
    public static ElectricPotential FromMicrovolts(double microvolts)
    {
        var value = (double)microvolts;
        return new ElectricPotential(value, ElectricPotentialUnit.Microvolt);
    }
    /// <summary>
    ///     Get ElectricPotential from Millivolts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillivolts->FromMillivolt")]
    public static ElectricPotential FromMillivolts(double millivolts)
    {
        var value = (double)millivolts;
        return new ElectricPotential(value, ElectricPotentialUnit.Millivolt);
    }
    /// <summary>
    ///     Get ElectricPotential from Volts.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromVolts->FromVolt")]
    public static ElectricPotential FromVolts(double volts)
    {
        var value = (double)volts;
        return new ElectricPotential(value, ElectricPotentialUnit.Volt);
    }
}
