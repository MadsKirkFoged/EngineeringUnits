using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class MassFluxUnitExtension
    {

        public static MassFlux IfNullSetToZero(this MassFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MassFlux.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static MassFlux? Abs(this MassFlux? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   