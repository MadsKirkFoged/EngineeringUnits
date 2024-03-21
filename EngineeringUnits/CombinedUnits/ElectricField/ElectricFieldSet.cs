using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricField
{

    /// <summary>
    /// Get ElectricField from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static ElectricField? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new ElectricField((double)SI, ElectricFieldUnit.SI);
    }
    /// <summary>
    /// Get ElectricField from VoltPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(VoltPerMeter))]
    public static ElectricField? FromVoltPerMeter(double? VoltPerMeter)
    {
        if (VoltPerMeter is null)
            return null;
        
        return new ElectricField((double)VoltPerMeter, ElectricFieldUnit.VoltPerMeter);
    }

}