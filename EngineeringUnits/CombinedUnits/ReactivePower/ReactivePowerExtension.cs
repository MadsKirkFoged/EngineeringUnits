using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class ReactivePowerUnitExtension
    {

        public static ReactivePower IfNullSetToZero(this ReactivePower? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ReactivePower.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static ReactivePower? Abs(this ReactivePower? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   