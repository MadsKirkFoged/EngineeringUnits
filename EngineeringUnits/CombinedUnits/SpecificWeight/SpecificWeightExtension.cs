using System;

namespace EngineeringUnits
{
    public static class SpecificWeightUnitExtension
    {

        public static SpecificWeight? IfNullSetToZero(this SpecificWeight? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificWeight.Zero;
        }

    }
}                   