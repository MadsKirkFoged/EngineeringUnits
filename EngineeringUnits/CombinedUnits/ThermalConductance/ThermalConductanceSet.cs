using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class ThermalConductance
{

    /// <summary>
    /// Get ThermalConductance from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ThermalConductance? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new ThermalConductance((double)SI, ThermalConductanceUnit.SI);
    }
    /// <summary>
    /// Get ThermalConductance from WattPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattPerKelvin))]
    public static ThermalConductance? FromWattPerKelvin(double? WattPerKelvin)
    {
        if (WattPerKelvin is null)
            return null;

        return new ThermalConductance((double)WattPerKelvin, ThermalConductanceUnit.WattPerKelvin);
    }
    /// <summary>
    /// Get ThermalConductance from KilowattPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattPerKelvin))]
    public static ThermalConductance? FromKilowattPerKelvin(double? KilowattPerKelvin)
    {
        if (KilowattPerKelvin is null)
            return null;

        return new ThermalConductance((double)KilowattPerKelvin, ThermalConductanceUnit.KilowattPerKelvin);
    }
    /// <summary>
    /// Get ThermalConductance from MegawattPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattPerKelvin))]
    public static ThermalConductance? FromMegawattPerKelvin(double? MegawattPerKelvin)
    {
        if (MegawattPerKelvin is null)
            return null;

        return new ThermalConductance((double)MegawattPerKelvin, ThermalConductanceUnit.MegawattPerKelvin);
    }
    /// <summary>
    /// Get ThermalConductance from MilliwattPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MilliwattPerKelvin))]
    public static ThermalConductance? FromMilliwattPerKelvin(double? MilliwattPerKelvin)
    {
        if (MilliwattPerKelvin is null)
            return null;

        return new ThermalConductance((double)MilliwattPerKelvin, ThermalConductanceUnit.MilliwattPerKelvin);
    }
    /// <summary>
    /// Get ThermalConductance from MicrowattPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrowattPerKelvin))]
    public static ThermalConductance? FromMicrowattPerKelvin(double? MicrowattPerKelvin)
    {
        if (MicrowattPerKelvin is null)
            return null;

        return new ThermalConductance((double)MicrowattPerKelvin, ThermalConductanceUnit.MicrowattPerKelvin);
    }
    /// <summary>
    /// Get ThermalConductance from WattPerDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattPerDegreeCelsius))]
    public static ThermalConductance? FromWattPerDegreeCelsius(double? WattPerDegreeCelsius)
    {
        if (WattPerDegreeCelsius is null)
            return null;

        return new ThermalConductance((double)WattPerDegreeCelsius, ThermalConductanceUnit.WattPerDegreeCelsius);
    }
    /// <summary>
    /// Get ThermalConductance from KilowattPerDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattPerDegreeCelsius))]
    public static ThermalConductance? FromKilowattPerDegreeCelsius(double? KilowattPerDegreeCelsius)
    {
        if (KilowattPerDegreeCelsius is null)
            return null;

        return new ThermalConductance((double)KilowattPerDegreeCelsius, ThermalConductanceUnit.KilowattPerDegreeCelsius);
    }
    /// <summary>
    /// Get ThermalConductance from BtuPerHourDegreeFahrenheit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(BtuPerHourDegreeFahrenheit))]
    public static ThermalConductance? FromBtuPerHourDegreeFahrenheit(double? BtuPerHourDegreeFahrenheit)
    {
        if (BtuPerHourDegreeFahrenheit is null)
            return null;

        return new ThermalConductance((double)BtuPerHourDegreeFahrenheit, ThermalConductanceUnit.BtuPerHourDegreeFahrenheit);
    }

}
