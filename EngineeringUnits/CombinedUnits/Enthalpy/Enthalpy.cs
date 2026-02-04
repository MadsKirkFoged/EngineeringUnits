using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Enthalpy : BaseUnit
{
    public Enthalpy() { }
    public Enthalpy(Fraction value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Enthalpy(decimal value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Enthalpy(double value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Enthalpy(int value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Enthalpy(UnknownUnit value) : base(value) { }

    public static Enthalpy From(double value, EnthalpyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Enthalpy? From(double? value, EnthalpyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(EnthalpyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Enthalpy ToUnit(EnthalpyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Enthalpy Zero => new(0, EnthalpyUnit.SI);
    public static Enthalpy NaN => new(double.NaN, EnthalpyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Enthalpy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, EnthalpyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Enthalpy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<EnthalpyUnit>(_unit, format);

    public static Enthalpy Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Enthalpy, EnthalpyUnit>(
         input,
         (v, u) => new Enthalpy(v, u),
         EnthalpyUnit.SI,
         culture);
    }
}
