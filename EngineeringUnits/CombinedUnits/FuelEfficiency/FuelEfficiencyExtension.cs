using System;

namespace EngineeringUnits
{
    public static class FuelEfficiencyUnitExtension
    {

        public static FuelEfficiency? IfNullSetToZero(this FuelEfficiency? local)
        {
            if (local is not null)
            {
                return local;
            }

            return FuelEfficiency.Zero;
        }

    }
}                   