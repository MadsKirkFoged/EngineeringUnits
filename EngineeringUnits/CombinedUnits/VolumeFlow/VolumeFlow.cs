using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, 3, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class VolumeFlow : BaseUnit
{
    public VolumeFlow() { }
    public VolumeFlow(Fraction value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeFlow(decimal value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeFlow(double value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeFlow(int value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeFlow(UnknownUnit value) : base(value) { }

    public static VolumeFlow From(double value, VolumeFlowUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static VolumeFlow? From(double? value, VolumeFlowUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(VolumeFlowUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumeFlow ToUnit(VolumeFlowUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumeFlow Zero => new(0, VolumeFlowUnit.SI);
    public static VolumeFlow NaN => new(double.NaN, VolumeFlowUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator VolumeFlow?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, VolumeFlowUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(VolumeFlow? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeFlowUnit>(_unit);
}
