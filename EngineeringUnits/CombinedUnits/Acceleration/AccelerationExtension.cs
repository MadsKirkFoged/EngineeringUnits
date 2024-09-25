using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class AccelerationUnitExtension
    {

        public static Acceleration IfNullSetToZero(this Acceleration? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Acceleration.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Acceleration? Abs(this Acceleration? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   