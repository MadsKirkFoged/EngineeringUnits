using System;

namespace EngineeringUnits
{
    public static class MolarMassUnitExtension
    {

        public static MolarMass? IfNullSetToZero(this MolarMass? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MolarMass.Zero;
        }

    }
}                   