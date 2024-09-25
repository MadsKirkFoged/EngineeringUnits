using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class ElectricCurrentGradientUnitExtension
    {

        public static ElectricCurrentGradient IfNullSetToZero(this ElectricCurrentGradient? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCurrentGradient.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ElectricCurrentGradient? Abs(this ElectricCurrentGradient? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   