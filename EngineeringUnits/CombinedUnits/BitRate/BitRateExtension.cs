using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class BitRateUnitExtension
    {

        public static BitRate IfNullSetToZero(this BitRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return BitRate.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static BitRate? Abs(this BitRate? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   