using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class LengthUnitExtension
    {

        public static Length IfNullSetToZero(this Length? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Length.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Length? Abs(this Length? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   