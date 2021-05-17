using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class UnknownUnit
    {
        public BaseUnit baseUnit { get; set; }

        public UnknownUnit()
        {
            baseUnit = new BaseUnit();
        }


        public static UnknownUnit operator *(UnknownUnit a, UnknownUnit b) => BaseUnit.Multiply(a.baseUnit, b.baseUnit);
        public static UnknownUnit operator /(UnknownUnit a, UnknownUnit b) => BaseUnit.Divide(a.baseUnit, b.baseUnit);
        public static UnknownUnit operator +(UnknownUnit a, UnknownUnit b) => BaseUnit.Add(a.baseUnit, b.baseUnit);
        public static UnknownUnit operator -(UnknownUnit a, UnknownUnit b) => BaseUnit.Subtract(a.baseUnit, b.baseUnit);


        public static UnknownUnit operator *(UnknownUnit a, double b) => BaseUnit.Multiply(a.baseUnit, b);


        public override string ToString()
        {
            return baseUnit.ToString();
        }
    }
}
