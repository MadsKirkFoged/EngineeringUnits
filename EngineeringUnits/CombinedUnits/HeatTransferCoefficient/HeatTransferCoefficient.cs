using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class HeatTransferCoefficient : BaseUnit
{
    public HeatTransferCoefficient() { }
    public HeatTransferCoefficient(decimal value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(int value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(UnknownUnit value) : base(value) { }

    public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static HeatTransferCoefficient? From(double? value, HeatTransferCoefficientUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(HeatTransferCoefficientUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static HeatTransferCoefficient Zero => new(0, HeatTransferCoefficientUnit.SI);
    public static HeatTransferCoefficient NaN => new(double.NaN, HeatTransferCoefficientUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator HeatTransferCoefficient?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, HeatTransferCoefficientUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(HeatTransferCoefficient? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<HeatTransferCoefficientUnit>(_unit);
}
