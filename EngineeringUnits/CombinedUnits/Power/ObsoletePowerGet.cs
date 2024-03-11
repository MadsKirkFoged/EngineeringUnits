using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Power
{
    /// <summary>
    ///     Get Power in BoilerHorsepower.
    /// </summary>
    //public double BoilerHorsepower => this.As(PowerUnit.BoilerHorsepower);

    /// <summary>
    ///     Get Power in BritishThermalUnitsPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - BritishThermalUnitsPerHour->BritishThermalUnitPerHour")]
    public double BritishThermalUnitsPerHour => As(PowerUnit.BritishThermalUnitPerHour);

    /// <summary>
    ///     Get Power in Decawatts.
    /// </summary>
    [Obsolete("Use without the 's' - Decawatts->Decawatt")]
    public double Decawatts => As(PowerUnit.Decawatt);

    /// <summary>
    ///     Get Power in Deciwatts.
    /// </summary>
    [Obsolete("Use without the 's' - Deciwatts->Deciwatt")]
    public double Deciwatts => As(PowerUnit.Deciwatt);

    /// <summary>
    ///     Get Power in ElectricalHorsepower.
    /// </summary>
    //public double ElectricalHorsepower => this.As(PowerUnit.ElectricalHorsepower);

    /// <summary>
    ///     Get Power in Femtowatts.
    /// </summary>
    [Obsolete("Use without the 's' - Femtowatts->Femtowatt")]
    public double Femtowatts => As(PowerUnit.Femtowatt);

    /// <summary>
    ///     Get Power in GigajoulesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - GigajoulesPerHour->GigajoulePerHour")]
    public double GigajoulesPerHour => As(PowerUnit.GigajoulePerHour);

    /// <summary>
    ///     Get Power in Gigawatts.
    /// </summary>
    [Obsolete("Use without the 's' - Gigawatts->Gigawatt")]
    public double Gigawatts => As(PowerUnit.Gigawatt);

    /// <summary>
    ///     Get Power in HydraulicHorsepower.
    /// </summary>
    //public double HydraulicHorsepower => this.As(PowerUnit.HydraulicHorsepower);

    /// <summary>
    ///     Get Power in JoulesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - JoulesPerHour->JoulePerHour")]
    public double JoulesPerHour => As(PowerUnit.JoulePerHour);

    /// <summary>
    ///     Get Power in KilobritishThermalUnitsPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - KilobritishThermalUnitsPerHour->KilobritishThermalUnitPerHour")]
    public double KilobritishThermalUnitsPerHour => As(PowerUnit.KilobritishThermalUnitPerHour);

    /// <summary>
    ///     Get Power in KilojoulesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - KilojoulesPerHour->KilojoulePerHour")]
    public double KilojoulesPerHour => As(PowerUnit.KilojoulePerHour);

    /// <summary>
    ///     Get Power in Kilowatts.
    /// </summary>
    [Obsolete("Use without the 's' - Kilowatts->Kilowatt")]
    public double Kilowatts => As(PowerUnit.Kilowatt);

    /// <summary>
    ///     Get Power in MechanicalHorsepower.
    /// </summary>
    //public double MechanicalHorsepower => this.As(PowerUnit.MechanicalHorsepower);

    /// <summary>
    ///     Get Power in MegajoulesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - MegajoulesPerHour->MegajoulePerHour")]
    public double MegajoulesPerHour => As(PowerUnit.MegajoulePerHour);

    /// <summary>
    ///     Get Power in Megawatts.
    /// </summary>
    [Obsolete("Use without the 's' - Megawatts->Megawatt")]
    public double Megawatts => As(PowerUnit.Megawatt);

    /// <summary>
    ///     Get Power in MetricHorsepower.
    /// </summary>
    //public double MetricHorsepower => this.As(PowerUnit.MetricHorsepower);

    /// <summary>
    ///     Get Power in Microwatts.
    /// </summary>
    [Obsolete("Use without the 's' - Microwatts->Microwatt")]
    public double Microwatts => As(PowerUnit.Microwatt);

    /// <summary>
    ///     Get Power in MillijoulesPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - MillijoulesPerHour->MillijoulePerHour")]
    public double MillijoulesPerHour => As(PowerUnit.MillijoulePerHour);

    /// <summary>
    ///     Get Power in Milliwatts.
    /// </summary>
    [Obsolete("Use without the 's' - Milliwatts->Milliwatt")]
    public double Milliwatts => As(PowerUnit.Milliwatt);

    /// <summary>
    ///     Get Power in Nanowatts.
    /// </summary>
    [Obsolete("Use without the 's' - Nanowatts->Nanowatt")]
    public double Nanowatts => As(PowerUnit.Nanowatt);

    /// <summary>
    ///     Get Power in Petawatts.
    /// </summary>
    [Obsolete("Use without the 's' - Petawatts->Petawatt")]
    public double Petawatts => As(PowerUnit.Petawatt);

    /// <summary>
    ///     Get Power in Picowatts.
    /// </summary>
    [Obsolete("Use without the 's' - Picowatts->Picowatt")]
    public double Picowatts => As(PowerUnit.Picowatt);

    /// <summary>
    ///     Get Power in Terawatts.
    /// </summary>
    [Obsolete("Use without the 's' - Terawatts->Terawatt")]
    public double Terawatts => As(PowerUnit.Terawatt);

    /// <summary>
    ///     Get Power in Watts.
    /// </summary>
    [Obsolete("Use without the 's' - Watts->Watt")]
    public double Watts => As(PowerUnit.Watt);

    /// <summary>
    ///     Get Power in SI unit (Watts).
    /// </summary>
    //public double SI => this.As(PowerUnit.SI);

}
