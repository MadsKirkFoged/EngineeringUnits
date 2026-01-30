using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 2, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class BrakeSpecificFuelConsumption : BaseUnit
{
    public BrakeSpecificFuelConsumption() { }
    public BrakeSpecificFuelConsumption(decimal value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BrakeSpecificFuelConsumption(double value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BrakeSpecificFuelConsumption(int value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BrakeSpecificFuelConsumption(UnknownUnit value) : base(value) { }

    public static BrakeSpecificFuelConsumption From(double value, BrakeSpecificFuelConsumptionUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static BrakeSpecificFuelConsumption? From(double? value, BrakeSpecificFuelConsumptionUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(BrakeSpecificFuelConsumptionUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public BrakeSpecificFuelConsumption ToUnit(BrakeSpecificFuelConsumptionUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static BrakeSpecificFuelConsumption Zero => new(0, BrakeSpecificFuelConsumptionUnit.SI);
    public static BrakeSpecificFuelConsumption NaN => new(double.NaN, BrakeSpecificFuelConsumptionUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator BrakeSpecificFuelConsumption?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, BrakeSpecificFuelConsumptionUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(BrakeSpecificFuelConsumption? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<BrakeSpecificFuelConsumptionUnit>(_unit);
}
