using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -3, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 1, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Molarity : BaseUnit
{
    public Molarity() { }
    public Molarity(decimal value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Molarity(double value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Molarity(int value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Molarity(UnknownUnit value) : base(value) { }

    public static Molarity From(double value, MolarityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Molarity? From(double? value, MolarityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MolarityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Molarity ToUnit(MolarityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Molarity Zero => new(0, MolarityUnit.SI);
    public static Molarity NaN => new(double.NaN, MolarityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Molarity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MolarityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Molarity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarityUnit>(_unit);
}
