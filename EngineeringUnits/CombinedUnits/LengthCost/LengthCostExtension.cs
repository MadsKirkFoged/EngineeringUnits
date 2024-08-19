using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class LengthCostUnitExtension
    {

        public static LengthCost IfNullSetToZero(this LengthCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LengthCost.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static LengthCost? Abs(this LengthCost? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   