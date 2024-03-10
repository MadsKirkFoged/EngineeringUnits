using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricPotential
{
    /// <summary>
    ///     Get ElectricPotential in Kilovolts.
    /// </summary>
    [Obsolete("Use without the 's' - Kilovolts->Kilovolt")]
    public double Kilovolts => As(ElectricPotentialUnit.Kilovolt);

    /// <summary>
    ///     Get ElectricPotential in Megavolts.
    /// </summary>
    [Obsolete("Use without the 's' - Megavolts->Megavolt")]
    public double Megavolts => As(ElectricPotentialUnit.Megavolt);

    /// <summary>
    ///     Get ElectricPotential in Microvolts.
    /// </summary>
    [Obsolete("Use without the 's' - Microvolts->Microvolt")]
    public double Microvolts => As(ElectricPotentialUnit.Microvolt);

    /// <summary>
    ///     Get ElectricPotential in Millivolts.
    /// </summary>
    [Obsolete("Use without the 's' - Millivolts->Millivolt")]
    public double Millivolts => As(ElectricPotentialUnit.Millivolt);

    /// <summary>
    ///     Get ElectricPotential in Volts.
    /// </summary>
    [Obsolete("Use without the 's' - Volts->Volt")]
    public double Volts => As(ElectricPotentialUnit.Volt);

    /// <summary>
    ///     Get ElectricPotential in SI Unit (Volts).
    /// </summary>
   // public double SI => As(ElectricPotentialUnit.SI);

}
