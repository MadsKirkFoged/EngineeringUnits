using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class IrradianceUnitExtension
    {

        public static Irradiance IfNullSetToZero(this Irradiance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Irradiance.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Irradiance? Abs(this Irradiance? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   