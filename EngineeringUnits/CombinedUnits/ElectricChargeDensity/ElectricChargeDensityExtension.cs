using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class ElectricChargeDensityUnitExtension
    {

        public static ElectricChargeDensity IfNullSetToZero(this ElectricChargeDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricChargeDensity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ElectricChargeDensity? Abs(this ElectricChargeDensity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   