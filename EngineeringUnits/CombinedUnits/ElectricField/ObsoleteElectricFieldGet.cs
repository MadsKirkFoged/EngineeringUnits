using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricField
{
    /// <summary>
    ///     Get ElectricField in VoltsPerMeter.
    /// </summary>
    [Obsolete("Use without the 's' - VoltsPerMeter->VoltPerMeter")]
    public double VoltsPerMeter => As(ElectricFieldUnit.VoltPerMeter);

    /// <summary>
    ///     Get ElectricField in SI Unit (VoltsPerMeter).
    /// </summary>
    //public double SI => As(ElectricFieldUnit.SI);
}
