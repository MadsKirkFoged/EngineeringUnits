using System;

namespace EngineeringUnits
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public sealed class UnitDimensionAttribute : Attribute
    {
        // Flat pairs: (BaseunitType, exponent) repeated
        public BaseunitType[] Types { get; }
        public int[] Exponents { get; }

        public UnitDimensionAttribute(BaseunitType t1, int e1)
        {
            Types = new[] { t1 };
            Exponents = new[] { e1 };
        }

        public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2)
        {
            Types = new[] { t1, t2 };
            Exponents = new[] { e1, e2 };
        }

        public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4, BaseunitType t5, int e5, BaseunitType t6, int e6, BaseunitType t7, int e7, BaseunitType t8, int e8)
        {
            Types = new[] { t1, t2, t3, t4, t5, t6, t7 ,t8 };
            Exponents = new[] { e1, e2, e3, e4, e5, e6, e7, e8 };
        }
    }
}