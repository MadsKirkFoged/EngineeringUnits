using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class ElectricCurrentDensityUnitExtension
    {

        public static ElectricCurrentDensity IfNullSetToZero(this ElectricCurrentDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCurrentDensity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ElectricCurrentDensity? Abs(this ElectricCurrentDensity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   