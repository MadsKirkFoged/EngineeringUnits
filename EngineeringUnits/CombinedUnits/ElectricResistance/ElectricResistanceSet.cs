using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricResistance
{

    /// <summary>
    /// Get ElectricResistance from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ElectricResistance? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new ElectricResistance((double)SI, ElectricResistanceUnit.SI);
    }
    /// <summary>
    /// Get ElectricResistance from Ohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Ohm))]
    public static ElectricResistance? FromOhm(double? Ohm)
    {
        if (Ohm is null)
            return null;

        return new ElectricResistance((double)Ohm, ElectricResistanceUnit.Ohm);
    }
    /// <summary>
    /// Get ElectricResistance from Gigaohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gigaohm))]
    public static ElectricResistance? FromGigaohm(double? Gigaohm)
    {
        if (Gigaohm is null)
            return null;

        return new ElectricResistance((double)Gigaohm, ElectricResistanceUnit.Gigaohm);
    }
    /// <summary>
    /// Get ElectricResistance from Kiloohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kiloohm))]
    public static ElectricResistance? FromKiloohm(double? Kiloohm)
    {
        if (Kiloohm is null)
            return null;

        return new ElectricResistance((double)Kiloohm, ElectricResistanceUnit.Kiloohm);
    }
    /// <summary>
    /// Get ElectricResistance from Megaohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Megaohm))]
    public static ElectricResistance? FromMegaohm(double? Megaohm)
    {
        if (Megaohm is null)
            return null;

        return new ElectricResistance((double)Megaohm, ElectricResistanceUnit.Megaohm);
    }
    /// <summary>
    /// Get ElectricResistance from Microohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microohm))]
    public static ElectricResistance? FromMicroohm(double? Microohm)
    {
        if (Microohm is null)
            return null;

        return new ElectricResistance((double)Microohm, ElectricResistanceUnit.Microohm);
    }
    /// <summary>
    /// Get ElectricResistance from Milliohm.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Milliohm))]
    public static ElectricResistance? FromMilliohm(double? Milliohm)
    {
        if (Milliohm is null)
            return null;

        return new ElectricResistance((double)Milliohm, ElectricResistanceUnit.Milliohm);
    }
}