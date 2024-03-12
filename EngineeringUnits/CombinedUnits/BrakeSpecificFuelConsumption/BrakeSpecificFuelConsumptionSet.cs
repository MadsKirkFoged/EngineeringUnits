using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class BrakeSpecificFuelConsumption
{

    /// <summary>
    /// Get BrakeSpecificFuelConsumption from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static BrakeSpecificFuelConsumption? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new BrakeSpecificFuelConsumption((double)SI, BrakeSpecificFuelConsumptionUnit.SI);
    }
    /// <summary>
    /// Get BrakeSpecificFuelConsumption from KilogramPerJoule.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilogramPerJoule))]
    public static BrakeSpecificFuelConsumption? FromKilogramPerJoule(double? KilogramPerJoule)
    {
        if (KilogramPerJoule is null)
            return null;

        return new BrakeSpecificFuelConsumption((double)KilogramPerJoule, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
    }
    /// <summary>
    /// Get BrakeSpecificFuelConsumption from GramPerKiloWattHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GramPerKiloWattHour))]
    public static BrakeSpecificFuelConsumption? FromGramPerKiloWattHour(double? GramPerKiloWattHour)
    {
        if (GramPerKiloWattHour is null)
            return null;

        return new BrakeSpecificFuelConsumption((double)GramPerKiloWattHour, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
    }
    /// <summary>
    /// Get BrakeSpecificFuelConsumption from PoundPerMechanicalHorsepowerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PoundPerMechanicalHorsepowerHour))]
    public static BrakeSpecificFuelConsumption? FromPoundPerMechanicalHorsepowerHour(double? PoundPerMechanicalHorsepowerHour)
    {
        if (PoundPerMechanicalHorsepowerHour is null)
            return null;

        return new BrakeSpecificFuelConsumption((double)PoundPerMechanicalHorsepowerHour, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
    }
}