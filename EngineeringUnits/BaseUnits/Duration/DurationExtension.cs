using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class DurationUnitExtension
    {

        public static Duration IfNullSetToZero(this Duration? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Duration.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Duration? Abs(this Duration? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   