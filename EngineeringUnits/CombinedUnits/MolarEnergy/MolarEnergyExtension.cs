using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{                   
    // This class is auto-generated, changes to the file will be overwritten!
    public static class MolarEnergyUnitExtension
    {

        public static MolarEnergy IfNullSetToZero(this MolarEnergy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MolarEnergy.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static MolarEnergy? Abs(this MolarEnergy? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   