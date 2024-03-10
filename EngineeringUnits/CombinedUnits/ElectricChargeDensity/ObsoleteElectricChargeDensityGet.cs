using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricChargeDensity
{
    /// <summary>
    ///     Get ElectricChargeDensity in CoulombsPerCubicMeter.
    /// </summary>
    [Obsolete("Use without the 's' - CoulombsPerCubicMeter->CoulombPerCubicMeter")]
    public double CoulombsPerCubicMeter => As(ElectricChargeDensityUnit.CoulombPerCubicMeter);

    /// <summary>
    ///     Get ElectricChargeDensity in SI Unit (CoulombsPerCubicMeter).
    /// </summary>
   // public double SI => As(ElectricChargeDensityUnit.SI);

}
