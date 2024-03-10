using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MolarEnergy
{
    /// <summary>
    ///     Get MolarEnergy in JoulesPerMole.
    /// </summary>
    [Obsolete("Use without the 's' - JoulesPerMole->JoulePerMole")]
    public double JoulesPerMole => As(MolarEnergyUnit.JoulePerMole);

    /// <summary>
    ///     Get MolarEnergy in SI Unit (JoulesPerMole).
    /// </summary>
    //public double SI => As(MolarEnergyUnit.SI);

    /// <summary>
    ///     Get MolarEnergy in KilojoulesPerMole.
    /// </summary>
    [Obsolete("Use without the 's' - KilojoulesPerMole->KilojoulePerMole")]
    public double KilojoulesPerMole => As(MolarEnergyUnit.KilojoulePerMole);

    /// <summary>
    ///     Get MolarEnergy in MegajoulesPerMole.
    /// </summary>
    [Obsolete("Use without the 's' - MegajoulesPerMole->MegajoulePerMole")]
    public double MegajoulesPerMole => As(MolarEnergyUnit.MegajoulePerMole);

}
