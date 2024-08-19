using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpecificWeightUnitExtension
    {

        public static SpecificWeight IfNullSetToZero(this SpecificWeight? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificWeight.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static SpecificWeight? Abs(this SpecificWeight? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   