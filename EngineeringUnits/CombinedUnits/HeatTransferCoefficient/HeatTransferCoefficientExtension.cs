using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class HeatTransferCoefficientUnitExtension
    {

        public static HeatTransferCoefficient IfNullSetToZero(this HeatTransferCoefficient? local)
        {
            if (local is not null)
            {
                return local;
            }

            return HeatTransferCoefficient.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static HeatTransferCoefficient? Abs(this HeatTransferCoefficient? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   