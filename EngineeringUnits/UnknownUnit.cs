using System;

namespace EngineeringUnits;

// All calculations between two units gets converted into an UnknownUnit
// --> ex lenght / duration turns into a UnknownUnit
// --> because at this time the unit is Unknown
// --> If you try to convert it into a Power then you get a WrongUnitException
// --> You can only convert it into the correct unit (in this case 'Speed')

public class UnknownUnit : BaseUnit
{

    public UnknownUnit() : base() { }

    //public UnknownUnit(double valueLocalUnit) : base(valueLocalUnit) { }
    public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) : base(valueLocalUnit, unitsystem) { }
    public UnknownUnit(decimal valueLocalUnit, UnitSystem unitsystem) : base(valueLocalUnit, unitsystem) { }
    public UnknownUnit(DecimalSafe valueLocalUnit, UnitSystem unitsystem) : base(valueLocalUnit, unitsystem) { }
    public UnknownUnit(BaseUnit baseunit) : base(baseunit) { }

    public override string ToString()
    {
        BaseUnit? CastingUnit = this.IntelligentCast();

        if (CastingUnit is null)
            return base.ToString();

        return CastingUnit.ToString();
    }
    public override string ToString(IFormatProvider provider)
    {
        BaseUnit? CastingUnit = this.IntelligentCast();

        if (CastingUnit is null)
            return base.ToString(provider);

        return CastingUnit.ToString(provider);
    }
    public override string ToString(string format)
    {
        BaseUnit? CastingUnit = this.IntelligentCast();

        if (CastingUnit is null)
            return base.ToString(format);

        return CastingUnit.ToString(format);
    }
    public override string ToString(string? format, IFormatProvider? provider)
    {
        BaseUnit? CastingUnit = this.IntelligentCast();

        if (CastingUnit is null)
            return base.ToString(format, provider);

        return CastingUnit.ToString(format, provider);
    }


    public static explicit operator int(UnknownUnit Unit)
    {
        if (UnitSystemExtensions.UnitsystemForDouble != Unit)
            throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return (int)Unit.GetValueAs(UnitSystemExtensions.UnitsystemForDouble);
    }
    public static explicit operator double(UnknownUnit Unit)
    {
        if (UnitSystemExtensions.UnitsystemForDouble != Unit)
            throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return Unit.GetValueAsDouble(UnitSystemExtensions.UnitsystemForDouble);
    }
    public static explicit operator decimal(UnknownUnit Unit)
    {
        if (new UnitSystem() != Unit.Unit)
            throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");

        return Unit.GetValueAs2(new UnitSystem());
    }
}
