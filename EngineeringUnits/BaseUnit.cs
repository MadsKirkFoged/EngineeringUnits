using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnit
    {
        public UnitStore UnitList { get; set;}

        public double Value { get; set; }

        public BaseUnit()
        {
            UnitList = new UnitStore();
        }

        public static UnknownUnit Add(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                UnitList = UnitStore.Add(a.UnitList, b.UnitList),
                Value = a.Value + (b.Value * UnitStore.VectorDifferent(b.UnitList, a.UnitList))
            };

        }
        public static UnknownUnit Subtract(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                UnitList = UnitStore.Subtract(a.UnitList, b.UnitList),
                Value = a.Value - (b.Value * UnitStore.VectorDifferent(b.UnitList, a.UnitList))
            };

        }
        public static UnknownUnit Multiply(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                UnitList = UnitStore.Multiply(a.UnitList, b.UnitList),
                Value = a.Value * (b.Value * UnitStore.VectorDifferent(b.UnitList, a.UnitList))
            };

        }

        public static UnknownUnit Multiply(BaseUnit a, double b)
        {
            return new BaseUnit
            {
                UnitList = a.UnitList.Copy(),
                Value = a.Value * b,
            };

        }

        public static UnknownUnit Divide(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                UnitList = UnitStore.Divide(a.UnitList, b.UnitList),
                Value = a.Value / (b.Value * UnitStore.VectorDifferent(b.UnitList, a.UnitList))
            };
        }

        public static UnknownUnit Divide(BaseUnit a, double b)
        {
            return new BaseUnit
            {
                UnitList = a.UnitList.Copy(),
                Value = a.Value / b,
            };
        }

        public static UnknownUnit Divide(double a, BaseUnit b)
        {
            return new BaseUnit
            {
                UnitList = b.UnitList.Copy(),
                Value = b.Value / a,
            };
        }

        public static double DivideResultsInDouble(BaseUnit a, BaseUnit b)
        {
            return a.Value / (b.Value * UnitStore.VectorDifferent(b.UnitList, a.UnitList));
        }

        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => BaseUnit.Multiply(a, b);
        public static UnknownUnit operator *(BaseUnit a, double b) => BaseUnit.Multiply(a, b);
        public static UnknownUnit operator *(double a, BaseUnit b) => BaseUnit.Multiply(b, a);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => BaseUnit.Divide(a, b);
        public static UnknownUnit operator /(BaseUnit a, double b) => BaseUnit.Divide(a, b);
        public static UnknownUnit operator /(double a, BaseUnit b) => BaseUnit.Divide(a, b);
        public static UnknownUnit operator +(BaseUnit a, BaseUnit b) => BaseUnit.Add(a, b);
        public static UnknownUnit operator -(BaseUnit a, BaseUnit b) => BaseUnit.Subtract(a, b);



        public static implicit operator UnknownUnit(BaseUnit baseUnit)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit = baseUnit;
            return local;
        }

        public override string ToString()
        {
            return $"{Value} {UnitList}";
        }



    }
}
