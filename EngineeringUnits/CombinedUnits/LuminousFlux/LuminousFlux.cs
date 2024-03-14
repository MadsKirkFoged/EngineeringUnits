using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LuminousFlux : BaseUnit
{
    public LuminousFlux() { }
    public LuminousFlux(decimal value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousFlux(double value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousFlux(int value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousFlux(UnknownUnit value) : base(value) { }

    public static LuminousFlux From(double value, LuminousFluxUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LuminousFlux? From(double? value, LuminousFluxUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LuminousFluxUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LuminousFlux ToUnit(LuminousFluxUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LuminousFlux Zero => new(0, LuminousFluxUnit.SI);
    public static LuminousFlux NaN => new(double.NaN, LuminousFluxUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LuminousFlux?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LuminousFluxUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LuminousFlux? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LuminousFluxUnit>(_unit);
}
