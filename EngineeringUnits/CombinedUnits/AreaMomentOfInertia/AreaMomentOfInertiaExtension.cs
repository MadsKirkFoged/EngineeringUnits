using System;

namespace EngineeringUnits
{
    public static class AreaMomentOfInertiaUnitExtension
    {

        public static AreaMomentOfInertia? IfNullSetToZero(this AreaMomentOfInertia? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AreaMomentOfInertia.Zero;
        }

    }
}                   