using System;

namespace EngineeringUnits
{
    public static class EnergyUnitExtension
    {

        public static Energy? IfNullSetToZero(this Energy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Energy.Zero;
        }

    }
}                   