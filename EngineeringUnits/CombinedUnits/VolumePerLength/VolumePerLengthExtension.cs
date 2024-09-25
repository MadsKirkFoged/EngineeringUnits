using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class VolumePerLengthUnitExtension
    {

        public static VolumePerLength IfNullSetToZero(this VolumePerLength? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumePerLength.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static VolumePerLength? Abs(this VolumePerLength? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   