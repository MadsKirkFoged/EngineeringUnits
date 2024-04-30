using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class PipeSize : BaseUnit
{
    public PipeSize() { }
    public PipeSize(decimal value, PipeSizeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PipeSize(double value, PipeSizeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PipeSize(int value, PipeSizeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PipeSize(UnknownUnit value) : base(value) { }

    public static PipeSize From(double value, PipeSizeUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static PipeSize? From(double? value, PipeSizeUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(PipeSizeUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public PipeSize ToUnit(PipeSizeUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static PipeSize Zero => new(0, PipeSizeUnit.SI);
    public static PipeSize NaN => new(double.NaN, PipeSizeUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator PipeSize?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, PipeSizeUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(PipeSize? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PipeSizeUnit>(_unit);
}
