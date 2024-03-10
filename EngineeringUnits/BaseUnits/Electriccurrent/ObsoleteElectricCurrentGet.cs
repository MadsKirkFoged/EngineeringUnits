using EngineeringUnits.Units;
using System;
namespace EngineeringUnits;

public partial class ElectricCurrent
{

    /// <summary>
    ///     Get ElectricCurrent in Amperes.
    /// </summary>
    [Obsolete("Use without the 's' - Amperes->Ampere")]
    public double Amperes => As(ElectricCurrentUnit.Ampere);

    /// <summary>
    ///     Get ElectricCurrent in SI Unit (Amperes).
    /// </summary>

    // public double SI => As(ElectricCurrentUnit.SI);

    /// <summary>
    ///     Get ElectricCurrent in Centiamperes.
    /// </summary>

    [Obsolete("Use without the 's' - Centiamperes->Centiampere")]
    public double Centiamperes => As(ElectricCurrentUnit.Centiampere);

    /// <summary>
    ///     Get ElectricCurrent in Kiloamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Kiloamperes->Kiloampere")]

    public double Kiloamperes => As(ElectricCurrentUnit.Kiloampere);

    /// <summary>
    ///     Get ElectricCurrent in Megaamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Megaamperes->Megaampere")]

    public double Megaamperes => As(ElectricCurrentUnit.Megaampere);

    /// <summary>
    ///     Get ElectricCurrent in Microamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Microamperes->Microampere")]

    public double Microamperes => As(ElectricCurrentUnit.Microampere);

    /// <summary>
    ///     Get ElectricCurrent in Milliamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Milliamperes->Milliampere")]

    public double Milliamperes => As(ElectricCurrentUnit.Milliampere);

    /// <summary>
    ///     Get ElectricCurrent in Nanoamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Nanoamperes->Nanoampere")]

    public double Nanoamperes => As(ElectricCurrentUnit.Nanoampere);

    /// <summary>
    ///     Get ElectricCurrent in Picoamperes.
    /// </summary>
    [Obsolete("Use without the 's' - Picoamperes->Picoampere")]

    public double Picoamperes => As(ElectricCurrentUnit.Picoampere);

}
