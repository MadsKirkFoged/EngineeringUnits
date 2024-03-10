using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ThermalResistance
{

    /// <summary>
    ///     Get ThermalResistance in HourSquareFeetDegreesFahrenheitPerBtu.
    /// </summary>
    [Obsolete("Use without the 's' - HourSquareFeetDegreesFahrenheitPerBtu->HourSquareFeetDegreeFahrenheitPerBtu")]
    public double HourSquareFeetDegreesFahrenheitPerBtu => As(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);

    /// <summary>
    ///     Get ThermalResistance in SquareCentimeterHourDegreesCelsiusPerKilocalorie.
    /// </summary>
    [Obsolete("Use without the 's' - SquareCentimeterHourDegreesCelsiusPerKilocalorie->SquareCentimeterHourDegreeCelsiusPerKilocalorie")]
    public double SquareCentimeterHourDegreesCelsiusPerKilocalorie => As(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);

    /// <summary>
    ///     Get ThermalResistance in SquareCentimeterKelvinsPerWatt.
    /// </summary>
    [Obsolete("Use without the 's' - SquareCentimeterKelvinsPerWatt->SquareCentimeterKelvinPerWatt")]
    public double SquareCentimeterKelvinsPerWatt => As(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

    /// <summary>
    ///     Get ThermalResistance in SquareMeterDegreesCelsiusPerWatt.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMeterDegreesCelsiusPerWatt->SquareMeterDegreeCelsiusPerWatt")]
    public double SquareMeterDegreesCelsiusPerWatt => As(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);

    /// <summary>
    ///     Get ThermalResistance in SquareMeterKelvinsPerKilowatt.
    /// </summary>
    [Obsolete("Use without the 's' - SquareMeterKelvinsPerKilowatt->SquareMeterKelvinPerKilowatt")]
    public double SquareMeterKelvinsPerKilowatt => As(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);

    /// <summary>
    ///     Get ThermalResistance in SI unit (SquareMeterKelvinsPerKilowatt).
    /// </summary>
    //public double SI => As(ThermalResistanceUnit.SI);
}
