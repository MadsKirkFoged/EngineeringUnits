using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class MolarEntropy : BaseUnit
{
    public MolarEntropy() { }
    public MolarEntropy(decimal value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEntropy(double value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEntropy(int value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEntropy(UnknownUnit value) : base(value) { }

    public static MolarEntropy From(double value, MolarEntropyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MolarEntropy? From(double? value, MolarEntropyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MolarEntropyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MolarEntropy ToUnit(MolarEntropyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MolarEntropy Zero => new(0, MolarEntropyUnit.SI);
    public static MolarEntropy NaN => new(double.NaN, MolarEntropyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MolarEntropy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MolarEntropyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MolarEntropy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarEntropyUnit>(_unit);
}
