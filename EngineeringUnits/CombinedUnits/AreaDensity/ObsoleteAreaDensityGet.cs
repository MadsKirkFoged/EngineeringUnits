using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class AreaDensity
{
    /// <summary>
    ///     Get AreaDensity in KilogramsPerSquareMeter.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsPerSquareMeter->KilogramPerSquareMeter")]
    public double KilogramsPerSquareMeter => As(AreaDensityUnit.KilogramPerSquareMeter);

    /// <summary>
    ///     Get AreaDensity in SI Unit (KilogramsPerSquareMeter).
    /// </summary>
   // public double SI => As(AreaDensityUnit.SI);
}
