using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, -2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class MassFlux : BaseUnit
{
    public MassFlux() { }
    public MassFlux(Fraction value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlux(decimal value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlux(double value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlux(int value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlux(UnknownUnit value) : base(value) { }

    public static MassFlux From(double value, MassFluxUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MassFlux? From(double? value, MassFluxUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MassFluxUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MassFlux ToUnit(MassFluxUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MassFlux Zero => new(0, MassFluxUnit.SI);
    public static MassFlux NaN => new(double.NaN, MassFluxUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MassFlux?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MassFluxUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MassFlux? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassFluxUnit>(_unit);
}
