using System;

namespace EngineeringUnits
{
    public static class DynamicViscosityUnitExtension
    {

        public static DynamicViscosity? IfNullSetToZero(this DynamicViscosity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return DynamicViscosity.Zero;
        }

    }
}                   