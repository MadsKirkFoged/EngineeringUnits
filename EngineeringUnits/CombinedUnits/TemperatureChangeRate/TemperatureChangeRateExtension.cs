using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class TemperatureChangeRateUnitExtension
    {

        public static TemperatureChangeRate IfNullSetToZero(this TemperatureChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return TemperatureChangeRate.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static TemperatureChangeRate? Abs(this TemperatureChangeRate? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   