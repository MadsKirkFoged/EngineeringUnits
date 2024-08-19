using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class LinearDensityUnitExtension
    {

        public static LinearDensity IfNullSetToZero(this LinearDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LinearDensity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static LinearDensity? Abs(this LinearDensity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   