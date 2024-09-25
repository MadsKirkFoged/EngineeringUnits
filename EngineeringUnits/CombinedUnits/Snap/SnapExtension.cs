using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    public static class SnapUnitExtension
    {

        public static Snap IfNullSetToZero(this Snap? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Snap.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Snap? Abs(this Snap? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   