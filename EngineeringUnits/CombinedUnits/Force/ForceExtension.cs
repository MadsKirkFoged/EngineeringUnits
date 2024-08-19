using System;

namespace EngineeringUnits
{
    public static class ForceUnitExtension
    {

        public static Force? IfNullSetToZero(this Force? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Force.Zero;
        }

    }
}                   