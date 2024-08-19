using System;

namespace EngineeringUnits
{
    public static class BrakeSpecificFuelConsumptionUnitExtension
    {

        public static BrakeSpecificFuelConsumption? IfNullSetToZero(this BrakeSpecificFuelConsumption? local)
        {
            if (local is not null)
            {
                return local;
            }

            return BrakeSpecificFuelConsumption.Zero;
        }

    }
}                   