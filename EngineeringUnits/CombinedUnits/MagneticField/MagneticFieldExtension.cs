using System;

namespace EngineeringUnits
{
    public static class MagneticFieldUnitExtension
    {

        public static MagneticField? IfNullSetToZero(this MagneticField? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MagneticField.Zero;
        }

    }
}                   