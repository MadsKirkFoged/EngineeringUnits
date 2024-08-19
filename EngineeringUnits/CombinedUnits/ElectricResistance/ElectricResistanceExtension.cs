using System;

namespace EngineeringUnits
{
    public static class ElectricResistanceUnitExtension
    {

        public static ElectricResistance? IfNullSetToZero(this ElectricResistance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricResistance.Zero;
        }

    }
}                   