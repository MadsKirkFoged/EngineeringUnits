using System;

namespace EngineeringUnits
{
    public static class ElectricResistivityUnitExtension
    {

        public static ElectricResistivity? IfNullSetToZero(this ElectricResistivity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricResistivity.Zero;
        }

    }
}                   