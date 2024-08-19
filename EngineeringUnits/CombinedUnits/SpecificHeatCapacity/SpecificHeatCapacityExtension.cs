using System;

namespace EngineeringUnits
{
    public static class SpecificHeatCapacityUnitExtension
    {

        public static SpecificHeatCapacity? IfNullSetToZero(this SpecificHeatCapacity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificHeatCapacity.Zero;
        }

    }
}                   