using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpecificEnergyUnitExtension
    {

        public static SpecificEnergy IfNullSetToZero(this SpecificEnergy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificEnergy.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static SpecificEnergy? Abs(this SpecificEnergy? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   