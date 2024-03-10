﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MagneticFlux
{
    /// <summary>
    ///     Get MagneticFlux in Webers.
    /// </summary>

    [Obsolete("Use without the 's' - Webers->Weber")]
    public double Webers => As(MagneticFluxUnit.Weber);

    /// <summary>
    ///     Get MagneticFlux in SI Unit (Webers).
    /// </summary>
    //public double SI => As(MagneticFluxUnit.SI);
}
