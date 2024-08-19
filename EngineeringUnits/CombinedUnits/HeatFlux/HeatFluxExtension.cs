using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class HeatFluxUnitExtension
    {

        public static HeatFlux IfNullSetToZero(this HeatFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return HeatFlux.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static HeatFlux? Abs(this HeatFlux? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   