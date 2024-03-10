using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricInductance
{
    /// <summary>
    ///     Get ElectricInductance in Henries.
    /// </summary>
    [Obsolete("Use without the 's' - Henries->Henry")]
    public double Henries => As(ElectricInductanceUnit.Henry);

    /// <summary>
    ///     Get ElectricInductance in SI Unit (Henries).
    /// </summary>
    //public double SI => As(ElectricInductanceUnit.SI);

    /// <summary>
    ///     Get ElectricInductance in Microhenries.
    /// </summary>
    [Obsolete("Use without the 's' - Microhenries->Microhenry")]
    public double Microhenries => As(ElectricInductanceUnit.Microhenry);

    /// <summary>
    ///     Get ElectricInductance in Millihenries.
    /// </summary>
    [Obsolete("Use without the 's' - Millihenries->Millihenry")]
    public double Millihenries => As(ElectricInductanceUnit.Millihenry);

    /// <summary>
    ///     Get ElectricInductance in Nanohenries.
    /// </summary>
    [Obsolete("Use without the 's' - Nanohenries->Nanohenry")]
    public double Nanohenries => As(ElectricInductanceUnit.Nanohenry);

}
