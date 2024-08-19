using System;

namespace EngineeringUnits
{
    public static class PermeabilityUnitExtension
    {

        public static Permeability? IfNullSetToZero(this Permeability? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Permeability.Zero;
        }

    }
}                   