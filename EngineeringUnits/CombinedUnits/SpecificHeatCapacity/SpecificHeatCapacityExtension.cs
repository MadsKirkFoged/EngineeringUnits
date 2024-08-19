using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpecificHeatCapacityUnitExtension
    {

        public static SpecificHeatCapacity IfNullSetToZero(this SpecificHeatCapacity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificHeatCapacity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static SpecificHeatCapacity? Abs(this SpecificHeatCapacity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   