using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class DynamicViscosity : BaseUnit
{
    public DynamicViscosity() { }
    public DynamicViscosity(decimal value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DynamicViscosity(double value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DynamicViscosity(int value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DynamicViscosity(UnknownUnit value) : base(value) { }

    public static DynamicViscosity From(double value, DynamicViscosityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static DynamicViscosity? From(double? value, DynamicViscosityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(DynamicViscosityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public DynamicViscosity ToUnit(DynamicViscosityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static DynamicViscosity Zero => new(0, DynamicViscosityUnit.SI);
    public static DynamicViscosity NaN => new(double.NaN, DynamicViscosityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator DynamicViscosity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, DynamicViscosityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(DynamicViscosity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DynamicViscosityUnit>(_unit);
}
