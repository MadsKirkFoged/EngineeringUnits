using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class VolumeCostUnitExtension
    {

        public static VolumeCost IfNullSetToZero(this VolumeCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumeCost.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static VolumeCost? Abs(this VolumeCost? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   