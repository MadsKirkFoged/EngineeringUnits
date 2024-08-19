using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class VolumeUnitExtension
    {

        public static Volume IfNullSetToZero(this Volume? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Volume.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Volume? Abs(this Volume? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   