using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class UnknownUnit
    {
        public BaseUnit baseUnit { get; set; }

        public double Value => baseUnit.Value;

        public double As(UnknownUnit a) => baseUnit.As(a.baseUnit);
        public UnitSystem unitsystem => baseUnit.Unit;

        public decimal ValueLocalUnit => baseUnit.ValueLocalUnit;        

        public UnknownUnit()
        {
            baseUnit = new BaseUnit();
        }

        public UnknownUnit(decimal valueLocalUnit)
        {
            baseUnit = new BaseUnit(valueLocalUnit);
        }


        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right) => left.baseUnit * right.baseUnit;
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right) => left.baseUnit / right.baseUnit;
        public static UnknownUnit operator +(UnknownUnit left, UnknownUnit right) => left.baseUnit + right.baseUnit;
        public static UnknownUnit operator -(UnknownUnit left, UnknownUnit right) => left.baseUnit - right.baseUnit;

        public static UnknownUnit operator *(UnknownUnit left, double right) => left.baseUnit * right;
        public static UnknownUnit operator /(UnknownUnit left, double right) => left.baseUnit / right;
        public static UnknownUnit operator *(double left, UnknownUnit right) => left * right.baseUnit;
        public static UnknownUnit operator /(double left, UnknownUnit right) => left / right.baseUnit;

        public static bool operator ==(UnknownUnit left, UnknownUnit right) => left.baseUnit == right.baseUnit;
        public static bool operator !=(UnknownUnit left, UnknownUnit right) => left.baseUnit != right.baseUnit;

        public static bool operator <=(UnknownUnit left, UnknownUnit right) => left.baseUnit <= right.baseUnit;
        public static bool operator >=(UnknownUnit left, UnknownUnit right) => left.baseUnit >= right.baseUnit;
        public static bool operator < (UnknownUnit left, UnknownUnit right) => left.baseUnit < right.baseUnit;
        public static bool operator > (UnknownUnit left, UnknownUnit right) => left.baseUnit > right.baseUnit;

        public static explicit operator double(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException("Units did not result in Double!");
            }

            return  Unit.baseUnit.Value;
        }

        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException("Units did not result in Double!");
            }

            return (decimal)Unit.baseUnit.Value;
        }

        public override string ToString()
        {
            return baseUnit.ToString();
        }
    }
}
