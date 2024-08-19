using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class InformationUnitExtension
    {

        public static Information IfNullSetToZero(this Information? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Information.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Information? Abs(this Information? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   