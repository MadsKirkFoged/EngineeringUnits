using System;

namespace EngineeringUnits
{
    public static class ElectricConductivityUnitExtension
    {

        public static ElectricConductivity? IfNullSetToZero(this ElectricConductivity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricConductivity.Zero;
        }

    }
}                   