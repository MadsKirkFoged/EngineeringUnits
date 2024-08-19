using System;

namespace EngineeringUnits
{
    public static class MassMomentOfInertiaUnitExtension
    {

        public static MassMomentOfInertia? IfNullSetToZero(this MassMomentOfInertia? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MassMomentOfInertia.Zero;
        }

    }
}                   