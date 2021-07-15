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

        //public double Value => baseUnit.Value;

        public double As(UnknownUnit a) => baseUnit.As(a.baseUnit);
        public UnitSystem unitsystem => baseUnit.Unit;

        public decimal SymbolValue => baseUnit.SymbolValue;

        public decimal BaseunitValue => baseUnit.BaseunitValue;

        public UnknownUnit()
        {
            baseUnit = new BaseUnit();
        }

        public UnknownUnit(double valueLocalUnit)
        {
            baseUnit = new BaseUnit(valueLocalUnit);
            baseUnit.Unit = new UnitSystem();
            baseUnit.SymbolValue = (decimal)valueLocalUnit;
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
                throw new InvalidOperationException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.unitsystem}] ");
            }

            return (double)Unit.baseUnit.BaseunitValue;

            //return Unit.baseUnit.Value;
            //return  Unit.baseUnit.Value;
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
            return baseUnit.ToString();
        }
    }
}
