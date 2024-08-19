using System;

namespace EngineeringUnits
{
    public static class WarpingMomentOfInertiaUnitExtension
    {

        public static WarpingMomentOfInertia? IfNullSetToZero(this WarpingMomentOfInertia? local)
        {
            if (local is not null)
            {
                return local;
            }

            return WarpingMomentOfInertia.Zero;
        }

    }
}                   