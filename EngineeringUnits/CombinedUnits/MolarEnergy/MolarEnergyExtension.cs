using System;

namespace EngineeringUnits
{
    public static class MolarEnergyUnitExtension
    {

        public static MolarEnergy? IfNullSetToZero(this MolarEnergy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MolarEnergy.Zero;
        }

    }
}                   