using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class ElectricPotentialChangeRateUnitExtension
    {

        public static ElectricPotentialChangeRate IfNullSetToZero(this ElectricPotentialChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricPotentialChangeRate.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ElectricPotentialChangeRate? Abs(this ElectricPotentialChangeRate? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   