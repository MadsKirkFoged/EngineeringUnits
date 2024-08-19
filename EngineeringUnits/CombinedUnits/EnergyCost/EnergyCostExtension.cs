using System;

namespace EngineeringUnits
{
    public static class EnergyCostUnitExtension
    {

        public static EnergyCost? IfNullSetToZero(this EnergyCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return EnergyCost.Zero;
        }

    }
}                   