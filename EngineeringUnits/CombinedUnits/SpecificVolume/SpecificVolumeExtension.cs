using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpecificVolumeUnitExtension
    {

        public static SpecificVolume IfNullSetToZero(this SpecificVolume? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificVolume.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static SpecificVolume? Abs(this SpecificVolume? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   