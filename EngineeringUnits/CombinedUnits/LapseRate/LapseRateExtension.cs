using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class LapseRateUnitExtension
    {

        public static LapseRate IfNullSetToZero(this LapseRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LapseRate.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static LapseRate? Abs(this LapseRate? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   