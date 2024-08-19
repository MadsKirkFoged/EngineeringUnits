using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class MagneticFluxUnitExtension
    {

        public static MagneticFlux IfNullSetToZero(this MagneticFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MagneticFlux.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static MagneticFlux? Abs(this MagneticFlux? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   