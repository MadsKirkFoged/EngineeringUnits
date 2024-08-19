using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class SpecificThermalResistanceUnitExtension
    {

        public static SpecificThermalResistance IfNullSetToZero(this SpecificThermalResistance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificThermalResistance.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static SpecificThermalResistance? Abs(this SpecificThermalResistance? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   