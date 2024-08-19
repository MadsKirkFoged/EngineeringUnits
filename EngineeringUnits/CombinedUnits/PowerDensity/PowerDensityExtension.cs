using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class PowerDensityUnitExtension
    {

        public static PowerDensity IfNullSetToZero(this PowerDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PowerDensity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static PowerDensity? Abs(this PowerDensity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   