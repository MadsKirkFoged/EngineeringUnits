using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class KinematicViscosity : BaseUnit
{
    public KinematicViscosity() { }
    public KinematicViscosity(Fraction value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public KinematicViscosity(decimal value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public KinematicViscosity(double value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public KinematicViscosity(int value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public KinematicViscosity(UnknownUnit value) : base(value) { }

    public static KinematicViscosity From(double value, KinematicViscosityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static KinematicViscosity? From(double? value, KinematicViscosityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(KinematicViscosityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public KinematicViscosity ToUnit(KinematicViscosityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static KinematicViscosity Zero => new(0, KinematicViscosityUnit.SI);
    public static KinematicViscosity NaN => new(double.NaN, KinematicViscosityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator KinematicViscosity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, KinematicViscosityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(KinematicViscosity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<KinematicViscosityUnit>(_unit);
}
