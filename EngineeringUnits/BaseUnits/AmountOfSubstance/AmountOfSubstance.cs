using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 1, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class AmountOfSubstance : BaseUnit
{
    public AmountOfSubstance() { }
    public AmountOfSubstance(Fraction value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(decimal value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(int value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(UnknownUnit value) : base(value) { }

    public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static AmountOfSubstance? From(double? value, AmountOfSubstanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AmountOfSubstanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static AmountOfSubstance Zero => new(0, AmountOfSubstanceUnit.SI);
    public static AmountOfSubstance NaN => new(double.NaN, AmountOfSubstanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator AmountOfSubstance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AmountOfSubstanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(AmountOfSubstance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AmountOfSubstanceUnit>(_unit);
}
