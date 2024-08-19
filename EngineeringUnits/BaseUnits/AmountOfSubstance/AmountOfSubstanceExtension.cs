using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class AmountOfSubstanceUnitExtension
    {

        public static AmountOfSubstance IfNullSetToZero(this AmountOfSubstance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AmountOfSubstance.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static AmountOfSubstance? Abs(this AmountOfSubstance? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   