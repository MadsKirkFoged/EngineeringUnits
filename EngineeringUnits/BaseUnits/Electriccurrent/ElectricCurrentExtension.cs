using System;

namespace EngineeringUnits
{
    public static class ElectricCurrentUnitExtension
    {

        public static ElectricCurrent? IfNullSetToZero(this ElectricCurrent? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCurrent.Zero;
        }

    }
}                   