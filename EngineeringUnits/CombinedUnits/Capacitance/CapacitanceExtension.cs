using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class CapacitanceUnitExtension
    {

        public static Capacitance IfNullSetToZero(this Capacitance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Capacitance.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Capacitance? Abs(this Capacitance? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   