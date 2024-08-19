using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class MolarityUnitExtension
    {

        public static Molarity IfNullSetToZero(this Molarity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Molarity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Molarity? Abs(this Molarity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   