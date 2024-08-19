using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class FuelEfficiencyUnitExtension
    {

        public static FuelEfficiency IfNullSetToZero(this FuelEfficiency? local)
        {
            if (local is not null)
            {
                return local;
            }

            return FuelEfficiency.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static FuelEfficiency? Abs(this FuelEfficiency? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   