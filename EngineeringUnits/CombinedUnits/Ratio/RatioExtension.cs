using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class RatioUnitExtension
    {

        public static Ratio IfNullSetToZero(this Ratio? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Ratio.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Ratio? Abs(this Ratio? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   