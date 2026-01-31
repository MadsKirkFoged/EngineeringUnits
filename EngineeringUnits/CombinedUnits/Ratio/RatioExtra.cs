using EngineeringUnits.Units;

namespace EngineeringUnits;
public partial class Ratio : BaseUnit
{

    public static explicit operator Ratio(int Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static explicit operator Ratio(decimal Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static explicit operator Ratio(double Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }


    public static implicit operator int(Ratio Unit)
    {
        if (UnitSystemExtensions.UnitsystemForDouble != Unit)
            throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return (int)Unit.GetValueAs(UnitSystemExtensions.UnitsystemForDouble);
    }
    public static implicit operator double(Ratio Unit)
    {
        if (UnitSystemExtensions.UnitsystemForDouble != Unit)
            throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return Unit.GetValueAsDouble(UnitSystemExtensions.UnitsystemForDouble);
    }
    public static implicit operator decimal(Ratio Unit)
    {
        if (new UnitSystem() != Unit.Unit)
            throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return Unit.GetValueAs2(new UnitSystem());
    }

    public static UnknownUnit? operator /(BaseUnit? left, Ratio? right)
    {
        return left / (decimal)right;
    }

    public static UnknownUnit? operator /(Ratio? left, BaseUnit? right)
    {
        return (decimal)left / right;
    }
}
