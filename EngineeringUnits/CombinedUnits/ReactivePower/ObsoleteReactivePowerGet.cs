using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ReactivePower
{
    /// <summary>
    ///     Get ReactivePower in GigavoltamperesReactive.
    /// </summary>
    [Obsolete("Use without the 's' - GigavoltamperesReactive->GigavoltampereReactive")]
    public double GigavoltamperesReactive => As(ReactivePowerUnit.GigavoltampereReactive);

    /// <summary>
    ///     Get ReactivePower in KilovoltamperesReactive.
    /// </summary>
    [Obsolete("Use without the 's' - KilovoltamperesReactive->KilovoltampereReactive")]
    public double KilovoltamperesReactive => As(ReactivePowerUnit.KilovoltampereReactive);

    /// <summary>
    ///     Get ReactivePower in MegavoltamperesReactive.
    /// </summary>
    [Obsolete("Use without the 's' - MegavoltamperesReactive->MegavoltampereReactive")]
    public double MegavoltamperesReactive => As(ReactivePowerUnit.MegavoltampereReactive);

    /// <summary>
    ///     Get ReactivePower in VoltamperesReactive.
    /// </summary>
    [Obsolete("Use without the 's' - VoltamperesReactive->VoltampereReactive")]
    public double VoltamperesReactive => As(ReactivePowerUnit.VoltampereReactive);

    /// <summary>
    ///     Get ReactivePower in SI unit (VoltamperesReactive).
    /// </summary>
    //public double SI => As(ReactivePowerUnit.SI);

}
