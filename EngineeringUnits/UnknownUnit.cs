using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using System;

namespace EngineeringUnits
{
    public class UnknownUnit: IUnitSystem
    {
        public BaseUnit _baseUnit { get; init; }


        public UnknownUnit() => _baseUnit = new BaseUnit();
        public UnknownUnit(double valueLocalUnit) => _baseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) => _baseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(decimal valueLocalUnit, UnitSystem unitsystem) => _baseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(BaseUnit baseunit) => _baseUnit = baseunit;
 

        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right) => left._baseUnit * right._baseUnit;
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right) => left._baseUnit / right._baseUnit;
        public static UnknownUnit operator +(UnknownUnit left, UnknownUnit right) => left._baseUnit + right._baseUnit;
        public static UnknownUnit operator -(UnknownUnit left, UnknownUnit right) => left._baseUnit - right._baseUnit;

        public static bool operator ==(UnknownUnit left, UnknownUnit right) => left._baseUnit == right._baseUnit;
        public static bool operator !=(UnknownUnit left, UnknownUnit right) => left._baseUnit != right._baseUnit;
        public static bool operator <=(UnknownUnit left, UnknownUnit right) => left._baseUnit <= right._baseUnit;
        public static bool operator >=(UnknownUnit left, UnknownUnit right) => left._baseUnit >= right._baseUnit;
        public static bool operator < (UnknownUnit left, UnknownUnit right) => left._baseUnit < right._baseUnit;
        public static bool operator > (UnknownUnit left, UnknownUnit right) => left._baseUnit > right._baseUnit;


        public static implicit operator double(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit._baseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");
            }

            return (double)Unit._baseUnit.ToTheOutSide(new UnitSystem());
        }
        public static implicit operator UnknownUnit(double Unit) => new (Unit);
        public static implicit operator UnknownUnit(int Unit) => new (Unit);
        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit._baseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");
            }

            return Unit._baseUnit.ToTheOutSide(new UnitSystem());
        }
        public static explicit operator BaseUnit(UnknownUnit Unit) => Unit._baseUnit;

        //public UnitSystem Unit => _baseUnit.Unit;

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => _baseUnit.Value;
        public decimal SI => _baseUnit.SI;

        public UnitSystem Unit 
        { 
            get => _baseUnit.Unit; 
            init => throw new MemberAccessException("UnknownUnit cant init the Unitsystem!"); 
        }

        public override string ToString()
        {
            if (_baseUnit.Unit.Symbol is not null)
            {
                return _baseUnit.ToString();
            }

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }

        public override int GetHashCode() => _baseUnit.GetHashCode();


    }
}
