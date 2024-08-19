using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class ElectricSurfaceChargeDensityUnitExtension
    {

        public static ElectricSurfaceChargeDensity IfNullSetToZero(this ElectricSurfaceChargeDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricSurfaceChargeDensity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ElectricSurfaceChargeDensity? Abs(this ElectricSurfaceChargeDensity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   