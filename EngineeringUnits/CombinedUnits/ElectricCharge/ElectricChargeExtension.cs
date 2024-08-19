using System;

namespace EngineeringUnits
{
    public static class ElectricChargeUnitExtension
    {

        public static ElectricCharge? IfNullSetToZero(this ElectricCharge? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCharge.Zero;
        }

    }
}                   