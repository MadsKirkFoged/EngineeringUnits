using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ThermalResistance
{

    /// <summary>
    /// Get ThermalResistance from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ThermalResistance? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new ThermalResistance((double)SI, ThermalResistanceUnit.SI);
    }
    /// <summary>
    /// Get ThermalResistance from SquareMeterDegreeCelsiusPerWatt.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SquareMeterDegreeCelsiusPerWatt))]
    public static ThermalResistance? FromSquareMeterDegreeCelsiusPerWatt(double? SquareMeterDegreeCelsiusPerWatt)
    {
        if (SquareMeterDegreeCelsiusPerWatt is null)
            return null;

        return new ThermalResistance((double)SquareMeterDegreeCelsiusPerWatt, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
    }
    /// <summary>
    /// Get ThermalResistance from SquareMeterKelvinPerKilowatt.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SquareMeterKelvinPerKilowatt))]
    public static ThermalResistance? FromSquareMeterKelvinPerKilowatt(double? SquareMeterKelvinPerKilowatt)
    {
        if (SquareMeterKelvinPerKilowatt is null)
            return null;

        return new ThermalResistance((double)SquareMeterKelvinPerKilowatt, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
    }
    /// <summary>
    /// Get ThermalResistance from SquareCentimeterKelvinPerWatt.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SquareCentimeterKelvinPerWatt))]
    public static ThermalResistance? FromSquareCentimeterKelvinPerWatt(double? SquareCentimeterKelvinPerWatt)
    {
        if (SquareCentimeterKelvinPerWatt is null)
            return null;

        return new ThermalResistance((double)SquareCentimeterKelvinPerWatt, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
    }
    /// <summary>
    /// Get ThermalResistance from SquareCentimeterHourDegreeCelsiusPerKilocalorie.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SquareCentimeterHourDegreeCelsiusPerKilocalorie))]
    public static ThermalResistance? FromSquareCentimeterHourDegreeCelsiusPerKilocalorie(double? SquareCentimeterHourDegreeCelsiusPerKilocalorie)
    {
        if (SquareCentimeterHourDegreeCelsiusPerKilocalorie is null)
            return null;

        return new ThermalResistance((double)SquareCentimeterHourDegreeCelsiusPerKilocalorie, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
    }
    /// <summary>
    /// Get ThermalResistance from HourSquareFeetDegreeFahrenheitPerBtu.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HourSquareFeetDegreeFahrenheitPerBtu))]
    public static ThermalResistance? FromHourSquareFeetDegreeFahrenheitPerBtu(double? HourSquareFeetDegreeFahrenheitPerBtu)
    {
        if (HourSquareFeetDegreeFahrenheitPerBtu is null)
            return null;

        return new ThermalResistance((double)HourSquareFeetDegreeFahrenheitPerBtu, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
    }
}