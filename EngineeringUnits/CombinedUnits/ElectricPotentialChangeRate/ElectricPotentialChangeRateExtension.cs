using System;

namespace EngineeringUnits
{
    public static class ElectricPotentialChangeRateUnitExtension
    {

        public static ElectricPotentialChangeRate? IfNullSetToZero(this ElectricPotentialChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricPotentialChangeRate.Zero;
        }

    }
}                   