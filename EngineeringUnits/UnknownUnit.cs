using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using System;

namespace EngineeringUnits
{
    public class UnknownUnit : IUnitSystem
    {
        public BaseUnit BaseUnit { get; init; }


        public UnknownUnit() => BaseUnit = new BaseUnit();
        public UnknownUnit(double valueLocalUnit) => BaseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) => BaseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(decimal valueLocalUnit, UnitSystem unitsystem) => BaseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(BaseUnit baseunit) => BaseUnit = baseunit;
 

        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right) => left.BaseUnit * right.BaseUnit;
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right) => left.BaseUnit / right.BaseUnit;
        public static UnknownUnit operator +(UnknownUnit left, UnknownUnit right) => left.BaseUnit + right.BaseUnit;
        public static UnknownUnit operator -(UnknownUnit left, UnknownUnit right) => left.BaseUnit - right.BaseUnit;

        public static bool operator ==(UnknownUnit left, UnknownUnit right) => left.BaseUnit == right.BaseUnit;
        public static bool operator !=(UnknownUnit left, UnknownUnit right) => left.BaseUnit != right.BaseUnit;
        public static bool operator <=(UnknownUnit left, UnknownUnit right) => left.BaseUnit <= right.BaseUnit;
        public static bool operator >=(UnknownUnit left, UnknownUnit right) => left.BaseUnit >= right.BaseUnit;
        public static bool operator < (UnknownUnit left, UnknownUnit right) => left.BaseUnit < right.BaseUnit;
        public static bool operator > (UnknownUnit left, UnknownUnit right) => left.BaseUnit > right.BaseUnit;


        public static implicit operator double(UnknownUnit Unit)
        {
            if (UnitSystem.UnitsystemForDouble != Unit.BaseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");
            }

            return (double)Unit.BaseUnit.ToTheOutSide(UnitSystem.UnitsystemForDouble);
        }
        public static implicit operator UnknownUnit(double Unit) => new (Unit);
        public static implicit operator UnknownUnit(int Unit) => new (Unit);
        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.BaseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");
            }

            return Unit.BaseUnit.ToTheOutSide(new UnitSystem());
        }
        public static explicit operator BaseUnit(UnknownUnit Unit) => Unit.BaseUnit;

        //public UnitSystem Unit => _baseUnit.Unit;

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => BaseUnit.Value;
        public decimal SI => BaseUnit.SI;

        public UnitSystem Unit 
        { 
            get => BaseUnit.Unit; 
            init => throw new MemberAccessException("UnknownUnit cant init the Unitsystem!"); 
        }

        public override string ToString()
        {
            if (BaseUnit.Unit.Symbol is not null)
            {
                return BaseUnit.ToString();
            }

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }

        public override int GetHashCode() => BaseUnit.GetHashCode();


    }
}
