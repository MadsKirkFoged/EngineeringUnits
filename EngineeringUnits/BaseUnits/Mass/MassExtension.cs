using System;

namespace EngineeringUnits
{
    public static class MassUnitExtension
    {

        public static Mass? IfNullSetToZero(this Mass? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Mass.Zero;
        }

    }
}                   