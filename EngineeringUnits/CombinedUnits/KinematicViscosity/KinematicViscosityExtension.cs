using System;

namespace EngineeringUnits
{
    public static class KinematicViscosityUnitExtension
    {

        public static KinematicViscosity? IfNullSetToZero(this KinematicViscosity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return KinematicViscosity.Zero;
        }

    }
}                   