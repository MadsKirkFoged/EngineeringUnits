using System;

namespace EngineeringUnits
{
    public static class ElectricPotentialUnitExtension
    {

        public static ElectricPotential? IfNullSetToZero(this ElectricPotential? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricPotential.Zero;
        }

    }
}                   