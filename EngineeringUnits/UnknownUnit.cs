using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using System;

namespace EngineeringUnits
{
    public class UnknownUnit
    {
        public BaseUnit _baseUnit { get; init; }


        public UnknownUnit() => _baseUnit = new BaseUnit();
        public UnknownUnit(double valueLocalUnit) => _baseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) => _baseUnit = new BaseUnit(valueLocalUnit, unitsystem);
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
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return (double)Unit._baseUnit.ToTheOutSide(new UnitSystem());
        }

        public static implicit operator UnknownUnit(double Unit) => new (Unit);

        public static implicit operator UnknownUnit(int Unit) => new (Unit);
 

        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit._baseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return Unit._baseUnit.ToTheOutSide(new UnitSystem());
        }

        //Im not sure about this!
        public static explicit operator BaseUnit(UnknownUnit Unit) => Unit._baseUnit;


        //Add .ToUnit()


        public double As(Enumeration a) => _baseUnit.As(a.Unit);

        public UnknownUnit ToUnit(Enumeration selectedUnit) => _baseUnit.ToUnit(selectedUnit);

        public UnitSystem unitsystem => _baseUnit.Unit;

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => _baseUnit.Value;

        public double SI => _baseUnit.SI;

        public override string ToString()
        {
            if (_baseUnit.Unit.Symbol is not null)
            {
                return _baseUnit.ToString();
            }

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }

        public UnknownUnit Pow(int toPower) => _baseUnit.Pow(toPower);

        //public UnknownUnit Sqrt() => baseUnit.Sqrt();

        public UnknownUnit Abs() => _baseUnit.Abs();

        public UnknownUnit InRangeOf(UnknownUnit Min, UnknownUnit Max) => _baseUnit.InRangeOf(Min, Max);

        public bool IsZero() => _baseUnit.IsZero();

        public bool IsNotZero() => _baseUnit.IsNotZero();

        public override int GetHashCode() => _baseUnit.GetHashCode();


    }
}
