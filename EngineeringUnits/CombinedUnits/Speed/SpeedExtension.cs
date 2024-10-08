using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpeedUnitExtension
    {

        public static Speed IfNullSetToZero(this Speed? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Speed.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Speed? Abs(this Speed? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   