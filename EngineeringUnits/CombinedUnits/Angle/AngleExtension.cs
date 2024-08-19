using System;

namespace EngineeringUnits
{
    public static class AngleUnitExtension
    {

        public static Angle? IfNullSetToZero(this Angle? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Angle.Zero;
        }

    }
}                   