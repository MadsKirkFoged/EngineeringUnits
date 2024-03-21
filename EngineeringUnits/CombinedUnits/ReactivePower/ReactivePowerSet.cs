using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ReactivePower
{

    /// <summary>
    /// Get ReactivePower from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ReactivePower? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new ReactivePower((double)SI, ReactivePowerUnit.SI);
    }
    /// <summary>
    /// Get ReactivePower from VoltampereReactive.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(VoltampereReactive))]
    public static ReactivePower? FromVoltampereReactive(double? VoltampereReactive)
    {
        if (VoltampereReactive is null)
            return null;
        
        return new ReactivePower((double)VoltampereReactive, ReactivePowerUnit.VoltampereReactive);
    }
    /// <summary>
    /// Get ReactivePower from MegavoltampereReactive.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegavoltampereReactive))]
    public static ReactivePower? FromMegavoltampereReactive(double? MegavoltampereReactive)
    {
        if (MegavoltampereReactive is null)
            return null;
        
        return new ReactivePower((double)MegavoltampereReactive, ReactivePowerUnit.MegavoltampereReactive);
    }
    /// <summary>
    /// Get ReactivePower from KilovoltampereReactive.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilovoltampereReactive))]
    public static ReactivePower? FromKilovoltampereReactive(double? KilovoltampereReactive)
    {
        if (KilovoltampereReactive is null)
            return null;
        
        return new ReactivePower((double)KilovoltampereReactive, ReactivePowerUnit.KilovoltampereReactive);
    }
    /// <summary>
    /// Get ReactivePower from GigavoltampereReactive.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigavoltampereReactive))]
    public static ReactivePower? FromGigavoltampereReactive(double? GigavoltampereReactive)
    {
        if (GigavoltampereReactive is null)
            return null;
        
        return new ReactivePower((double)GigavoltampereReactive, ReactivePowerUnit.GigavoltampereReactive);
    }

}