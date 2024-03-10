using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricResistance
{
    /// <summary>
    ///     Get ElectricResistance in Gigaohms.
    /// </summary>
    [Obsolete("Use without the 's' - Gigaohms->Gigaohm")]
    public double Gigaohms => As(ElectricResistanceUnit.Gigaohm);

    /// <summary>
    ///     Get ElectricResistance in Kiloohms.
    /// </summary>
    [Obsolete("Use without the 's' - Kiloohms->Kiloohm")]
    public double Kiloohms => As(ElectricResistanceUnit.Kiloohm);

    /// <summary>
    ///     Get ElectricResistance in Megaohms.
    /// </summary>
    [Obsolete("Use without the 's' - Megaohms->Megaohm")]
    public double Megaohms => As(ElectricResistanceUnit.Megaohm);

    /// <summary>
    ///     Get ElectricResistance in Microohms.
    /// </summary>
    [Obsolete("Use without the 's' - Microohms->Microohm")]
    public double Microohms => As(ElectricResistanceUnit.Microohm);

    /// <summary>
    ///     Get ElectricResistance in Milliohms.
    /// </summary>
    [Obsolete("Use without the 's' - Milliohms->Milliohm")]
    public double Milliohms => As(ElectricResistanceUnit.Milliohm);

    /// <summary>
    ///     Get ElectricResistance in Ohms.
    /// </summary>
    [Obsolete("Use without the 's' - Ohms->Ohm")]
    public double Ohms => As(ElectricResistanceUnit.Ohm);

    /// <summary>
    ///     Get ElectricResistance in SI Unit (Ohms).
    /// </summary>
    //public double SI => As(ElectricResistanceUnit.SI);

}
