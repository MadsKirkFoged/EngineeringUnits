using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class EnergyDensity
{

    /// <summary>
    /// Get EnergyDensity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static EnergyDensity? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new EnergyDensity((double)SI, EnergyDensityUnit.SI);
    }
    /// <summary>
    /// Get EnergyDensity from JoulePerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(JoulePerCubicMeter))]
    public static EnergyDensity? FromJoulePerCubicMeter(double? JoulePerCubicMeter)
    {
        if (JoulePerCubicMeter is null)
            return null;

        return new EnergyDensity((double)JoulePerCubicMeter, EnergyDensityUnit.JoulePerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from KilojoulePerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilojoulePerCubicMeter))]
    public static EnergyDensity? FromKilojoulePerCubicMeter(double? KilojoulePerCubicMeter)
    {
        if (KilojoulePerCubicMeter is null)
            return null;

        return new EnergyDensity((double)KilojoulePerCubicMeter, EnergyDensityUnit.KilojoulePerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from MegajoulePerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegajoulePerCubicMeter))]
    public static EnergyDensity? FromMegajoulePerCubicMeter(double? MegajoulePerCubicMeter)
    {
        if (MegajoulePerCubicMeter is null)
            return null;

        return new EnergyDensity((double)MegajoulePerCubicMeter, EnergyDensityUnit.MegajoulePerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from WattHourPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattHourPerCubicMeter))]
    public static EnergyDensity? FromWattHourPerCubicMeter(double? WattHourPerCubicMeter)
    {
        if (WattHourPerCubicMeter is null)
            return null;

        return new EnergyDensity((double)WattHourPerCubicMeter, EnergyDensityUnit.WattHourPerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from KilowattHourPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattHourPerCubicMeter))]
    public static EnergyDensity? FromKilowattHourPerCubicMeter(double? KilowattHourPerCubicMeter)
    {
        if (KilowattHourPerCubicMeter is null)
            return null;

        return new EnergyDensity((double)KilowattHourPerCubicMeter, EnergyDensityUnit.KilowattHourPerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from MegawattHourPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattHourPerCubicMeter))]
    public static EnergyDensity? FromMegawattHourPerCubicMeter(double? MegawattHourPerCubicMeter)
    {
        if (MegawattHourPerCubicMeter is null)
            return null;

        return new EnergyDensity((double)MegawattHourPerCubicMeter, EnergyDensityUnit.MegawattHourPerCubicMeter);
    }
    /// <summary>
    /// Get EnergyDensity from GigawattHourPerCubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigawattHourPerCubicMeter))]
    public static EnergyDensity? FromGigawattHourPerCubicMeter(double? GigawattHourPerCubicMeter)
    {
        if (GigawattHourPerCubicMeter is null)
            return null;

        return new EnergyDensity((double)GigawattHourPerCubicMeter, EnergyDensityUnit.GigawattHourPerCubicMeter);
    }

}
