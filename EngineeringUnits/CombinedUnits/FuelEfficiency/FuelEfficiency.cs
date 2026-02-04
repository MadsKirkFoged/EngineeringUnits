using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class FuelEfficiency : BaseUnit
{
    public FuelEfficiency() { }
    public FuelEfficiency(Fraction value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public FuelEfficiency(decimal value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public FuelEfficiency(double value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public FuelEfficiency(int value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public FuelEfficiency(UnknownUnit value) : base(value) { }

    public static FuelEfficiency From(double value, FuelEfficiencyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static FuelEfficiency? From(double? value, FuelEfficiencyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(FuelEfficiencyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public FuelEfficiency ToUnit(FuelEfficiencyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static FuelEfficiency Zero => new(0, FuelEfficiencyUnit.SI);
    public static FuelEfficiency NaN => new(double.NaN, FuelEfficiencyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator FuelEfficiency?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, FuelEfficiencyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(FuelEfficiency? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<FuelEfficiencyUnit>(_unit, format);

    public static FuelEfficiency Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<FuelEfficiency, FuelEfficiencyUnit>(
         input,
         (v, u) => new FuelEfficiency(v, u),
         FuelEfficiencyUnit.SI,
         culture);
    }
}
