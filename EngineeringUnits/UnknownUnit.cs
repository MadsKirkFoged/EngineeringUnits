using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using System;

namespace EngineeringUnits
{
    public class UnknownUnit
    {
        public BaseUnit baseUnit { get; set; }


        public UnknownUnit() => baseUnit = new BaseUnit();
        public UnknownUnit(double valueLocalUnit) => baseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) => baseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(BaseUnit baseunit) => baseUnit = baseunit;

        
        //Add .ToUnit()


        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right) => left.baseUnit * right.baseUnit;
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right) => left.baseUnit / right.baseUnit;
        public static UnknownUnit operator +(UnknownUnit left, UnknownUnit right) => left.baseUnit + right.baseUnit;
        public static UnknownUnit operator -(UnknownUnit left, UnknownUnit right) => left.baseUnit - right.baseUnit;



        public static bool operator ==(UnknownUnit left, UnknownUnit right) => left.baseUnit == right.baseUnit;
        public static bool operator !=(UnknownUnit left, UnknownUnit right) => left.baseUnit != right.baseUnit;

        public static bool operator <=(UnknownUnit left, UnknownUnit right) => left.baseUnit <= right.baseUnit;
        public static bool operator >=(UnknownUnit left, UnknownUnit right) => left.baseUnit >= right.baseUnit;
        public static bool operator < (UnknownUnit left, UnknownUnit right) => left.baseUnit < right.baseUnit;
        public static bool operator > (UnknownUnit left, UnknownUnit right) => left.baseUnit > right.baseUnit;




        public static implicit operator double(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.baseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return (double)Unit.baseUnit.ToTheOutSide(new UnitSystem());
            //return (double)Unit.baseUnit.BaseunitValue;
        }

        public static implicit operator UnknownUnit(double Unit) => new (Unit);

        public static implicit operator UnknownUnit(int Unit) => new (Unit);
 

        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.baseUnit.Unit)
            {
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return Unit.baseUnit.ToTheOutSide(new UnitSystem());
            //return (decimal)Unit.baseUnit.BaseunitValue;
        }

        //Im not sure about this!
        public static explicit operator BaseUnit(UnknownUnit Unit) => Unit.baseUnit;


        public double As(Enumeration a) => baseUnit.As(a.Unit);

        public UnitSystem unitsystem => baseUnit.Unit;

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => baseUnit.Value;

        public double SI => (double)(baseUnit.NEWValue * (decimal)unitsystem.SumConstant());

        public override string ToString()
        {
            if (baseUnit.Unit.Symbol is not null)
            {
                return baseUnit.ToString();
            }

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }

        public UnknownUnit Pow(int toPower) => baseUnit.Pow(toPower);

        //public UnknownUnit Sqrt() => baseUnit.Sqrt();

        public UnknownUnit Abs() => baseUnit.Abs();

        public UnknownUnit InRangeOf(UnknownUnit Min, UnknownUnit Max) => baseUnit.InRangeOf(Min, Max);

        public bool IsZero() => baseUnit.IsZero();

        public bool IsNotZero() => baseUnit.IsNotZero();

        public override int GetHashCode() => baseUnit.GetHashCode();


    }
}
