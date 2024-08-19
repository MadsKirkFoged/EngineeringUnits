using System;

namespace EngineeringUnits
{
    public static class ElectricInductanceUnitExtension
    {

        public static ElectricInductance? IfNullSetToZero(this ElectricInductance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricInductance.Zero;
        }

    }
}                   