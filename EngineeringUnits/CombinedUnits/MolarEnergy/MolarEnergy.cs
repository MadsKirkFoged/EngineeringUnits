using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, -1, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class MolarEnergy : BaseUnit
{
    public MolarEnergy() { }
    public MolarEnergy(Fraction value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEnergy(decimal value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEnergy(double value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEnergy(int value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarEnergy(UnknownUnit value) : base(value) { }

    public static MolarEnergy From(double value, MolarEnergyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MolarEnergy? From(double? value, MolarEnergyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MolarEnergyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MolarEnergy ToUnit(MolarEnergyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MolarEnergy Zero => new(0, MolarEnergyUnit.SI);
    public static MolarEnergy NaN => new(double.NaN, MolarEnergyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MolarEnergy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MolarEnergyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MolarEnergy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<MolarEnergyUnit>(_unit, format);

    public static MolarEnergy Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<MolarEnergy, MolarEnergyUnit>(
         input,
         (v, u) => new MolarEnergy(v, u),
         MolarEnergyUnit.SI,
         culture);
    }
}
