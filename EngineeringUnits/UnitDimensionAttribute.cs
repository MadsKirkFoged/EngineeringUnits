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
    }
}