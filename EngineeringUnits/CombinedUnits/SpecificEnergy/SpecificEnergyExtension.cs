using System;

namespace EngineeringUnits
{
    public static class SpecificEnergyUnitExtension
    {

        public static SpecificEnergy? IfNullSetToZero(this SpecificEnergy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificEnergy.Zero;
        }

    }
}                   