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


        public double As(UnknownUnit a) => baseUnit.As(a.baseUnit);

        public UnitSystem unitsystem => baseUnit.Unit;

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => baseUnit.Value;


        public UnknownUnit()
        {
            baseUnit = new BaseUnit();
        }

        public UnknownUnit(double valueLocalUnit)
        {
            baseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());

        }

        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem)
        {
            baseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        }

        public UnknownUnit(BaseUnit baseunit)
        {
            baseUnit = baseunit;
        }


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
                throw new InvalidOperationException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return (double)Unit.baseUnit.BaseunitValue;
        }

        public static implicit operator UnknownUnit(double Unit)
        {
            return new UnknownUnit(Unit);
        }

        public static implicit operator UnknownUnit(int Unit)
        {
            return new UnknownUnit(Unit);
        }

        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return (decimal)Unit.baseUnit.BaseunitValue;
        }

        //Im not sure about this!
        public static explicit operator BaseUnit(UnknownUnit Unit)
        {          
            return Unit.baseUnit;
        }

        public override string ToString()
        {
            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }
    }
}
