using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Capacitance
{
    /// <summary>
    ///     Get Capacitance in Farads.
    /// </summary>
    [Obsolete("Use without the 's' - Farads->Farad")]
    public double Farads => As(CapacitanceUnit.Farad);

    /// <summary>
    ///     Get Capacitance in SI Unit (Farads).
    /// </summary>
   // public double SI => As(CapacitanceUnit.SI);

    /// <summary>
    ///     Get Capacitance in Kilofarads.
    /// </summary>
    [Obsolete("Use without the 's' - Kilofarads->Kilofarad")]
    public double Kilofarads => As(CapacitanceUnit.Kilofarad);

    /// <summary>
    ///     Get Capacitance in Megafarads.
    /// </summary>
    [Obsolete("Use without the 's' - Megafarads->Megafarad")]
    public double Megafarads => As(CapacitanceUnit.Megafarad);

    /// <summary>
    ///     Get Capacitance in Microfarads.
    /// </summary>
    [Obsolete("Use without the 's' - Microfarads->Microfarad")]
    public double Microfarads => As(CapacitanceUnit.Microfarad);

    /// <summary>
    ///     Get Capacitance in Millifarads.
    /// </summary>
    [Obsolete("Use without the 's' - Millifarads->Millifarad")]
    public double Millifarads => As(CapacitanceUnit.Millifarad);

    /// <summary>
    ///     Get Capacitance in Nanofarads.
    /// </summary>
    [Obsolete("Use without the 's' - Nanofarads->Nanofarad")]
    public double Nanofarads => As(CapacitanceUnit.Nanofarad);

    /// <summary>
    ///     Get Capacitance in Picofarads.
    /// </summary>
    [Obsolete("Use without the 's' - Picofarads->Picofarad")]
    public double Picofarads => As(CapacitanceUnit.Picofarad);

}
