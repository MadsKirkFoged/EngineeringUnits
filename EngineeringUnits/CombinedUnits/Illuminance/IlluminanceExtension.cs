using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class IlluminanceUnitExtension
    {

        public static Illuminance IfNullSetToZero(this Illuminance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Illuminance.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Illuminance? Abs(this Illuminance? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   