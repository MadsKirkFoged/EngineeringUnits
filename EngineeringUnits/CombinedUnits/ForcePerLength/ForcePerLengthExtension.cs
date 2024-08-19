using System;

namespace EngineeringUnits
{
    public static class ForcePerLengthUnitExtension
    {

        public static ForcePerLength? IfNullSetToZero(this ForcePerLength? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ForcePerLength.Zero;
        }

    }
}                   