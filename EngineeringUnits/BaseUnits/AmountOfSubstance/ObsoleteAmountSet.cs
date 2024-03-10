using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class AmountOfSubstance
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static AmountOfSubstance FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new AmountOfSubstance(value, AmountOfSubstanceUnit.SI);
    //}

    /// <summary>
    ///     Get AmountOfSubstance from Centimoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>

    [Obsolete("Use without the 's' - FromCentimoles->FromCentimole")]
    public static AmountOfSubstance FromCentimoles(double centimoles)
    {
        var value = (double)centimoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Centimole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from CentipoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentipoundMoles->FromCentipoundMole")]
    public static AmountOfSubstance FromCentipoundMoles(double centipoundmoles)
    {
        var value = (double)centipoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.CentipoundMole);
    }

    /// <summary>
    ///     Get AmountOfSubstance from Decimoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecimoles->FromDecimole")]
    public static AmountOfSubstance FromDecimoles(double decimoles)
    {
        var value = (double)decimoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Decimole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from DecipoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecipoundMoles->FromDecipoundMole")]
    public static AmountOfSubstance FromDecipoundMoles(double decipoundmoles)
    {
        var value = (double)decipoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.DecipoundMole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Kilomoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilomoles->FromKilomole")]
    public static AmountOfSubstance FromKilomoles(double kilomoles)
    {
        var value = (double)kilomoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Kilomole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from KilopoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundMoles->FromKilopoundMole")]
    public static AmountOfSubstance FromKilopoundMoles(double kilopoundmoles)
    {
        var value = (double)kilopoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.KilopoundMole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Megamoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegamoles->FromMegamole")]
    public static AmountOfSubstance FromMegamoles(double megamoles)
    {
        var value = (double)megamoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Megamole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Micromoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicromoles->FromMicromole")]
    public static AmountOfSubstance FromMicromoles(double micromoles)
    {
        var value = (double)micromoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Micromole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from MicropoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicropoundMoles->FromMicropoundMole")]
    public static AmountOfSubstance FromMicropoundMoles(double micropoundmoles)
    {
        var value = (double)micropoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.MicropoundMole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Millimoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillimoles->FromMillimole")]
    public static AmountOfSubstance FromMillimoles(double millimoles)
    {
        var value = (double)millimoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Millimole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from MillipoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillipoundMoles->FromMillipoundMole")]
    public static AmountOfSubstance FromMillipoundMoles(double millipoundmoles)
    {
        var value = (double)millipoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.MillipoundMole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Moles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMoles->FromMole")]
    public static AmountOfSubstance FromMoles(double moles)
    {
        var value = (double)moles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Mole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from Nanomoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanomoles->FromNanomole")]
    public static AmountOfSubstance FromNanomoles(double nanomoles)
    {
        var value = (double)nanomoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.Nanomole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from NanopoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanopoundMoles->FromNanopoundMole")]
    public static AmountOfSubstance FromNanopoundMoles(double nanopoundmoles)
    {
        var value = (double)nanopoundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.NanopoundMole);
    }
    /// <summary>
    ///     Get AmountOfSubstance from PoundMoles.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundMoles->FromPoundMole")]
    public static AmountOfSubstance FromPoundMoles(double poundmoles)
    {
        var value = (double)poundmoles;
        return new AmountOfSubstance(value, AmountOfSubstanceUnit.PoundMole);
    }
}
