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
        public UnitSystem unitsystem => baseUnit.unitsystem;

        public UnknownUnit()
        {
            baseUnit = new BaseUnit();
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
            if (new UnitSystem() != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Double!");
            }

            return  Unit.baseUnit.Value;
        }



        public override string ToString()
        {
            return baseUnit.ToString();
        }
    }
}
