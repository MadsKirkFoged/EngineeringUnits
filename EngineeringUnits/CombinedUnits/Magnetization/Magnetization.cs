using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Magnetization : BaseUnit
{
    public Magnetization() { }
    public Magnetization(Fraction value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Magnetization(decimal value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Magnetization(double value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Magnetization(int value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Magnetization(UnknownUnit value) : base(value) { }

    public static Magnetization From(double value, MagnetizationUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Magnetization? From(double? value, MagnetizationUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MagnetizationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Magnetization ToUnit(MagnetizationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Magnetization Zero => new(0, MagnetizationUnit.SI);
    public static Magnetization NaN => new(double.NaN, MagnetizationUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Magnetization?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MagnetizationUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Magnetization? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MagnetizationUnit>(_unit);
}
