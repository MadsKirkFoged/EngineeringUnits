using System;

namespace EngineeringUnits
{
    public static class ElectricFieldUnitExtension
    {

        public static ElectricField? IfNullSetToZero(this ElectricField? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricField.Zero;
        }

    }
}                   