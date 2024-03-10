using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Permeability
{
    /// <summary>
    ///     Get Permeability in HenriesPerMeter.
    /// </summary>
    [Obsolete("Use without the 's' - HenriesPerMeter->HenryPerMeter")]
    public double HenriesPerMeter => As(PermeabilityUnit.HenryPerMeter);

    /// <summary>
    ///     Get Permeability in SI Unit (HenriesPerMeter).
    /// </summary>
    //public double SI => As(PermeabilityUnit.SI);

}
