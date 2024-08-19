using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class EnthalpyUnitExtension
    {

        public static Enthalpy IfNullSetToZero(this Enthalpy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Enthalpy.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Enthalpy? Abs(this Enthalpy? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   