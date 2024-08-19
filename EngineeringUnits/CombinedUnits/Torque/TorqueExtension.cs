using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class TorqueUnitExtension
    {

        public static Torque IfNullSetToZero(this Torque? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Torque.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Torque? Abs(this Torque? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   