using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class AreaCostUnitExtension
    {

        public static AreaCost IfNullSetToZero(this AreaCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AreaCost.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static AreaCost? Abs(this AreaCost? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   