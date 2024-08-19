using System;

namespace EngineeringUnits
{
    public static class AreaUnitExtension
    {

        public static Area? IfNullSetToZero(this Area? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Area.Zero;
        }

    }
}                   