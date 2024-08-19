using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class PressureUnitExtension
    {

        public static Pressure IfNullSetToZero(this Pressure? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Pressure.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Pressure? Abs(this Pressure? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   