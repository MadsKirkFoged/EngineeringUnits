using System;

namespace EngineeringUnits
{
    public static class PermittivityUnitExtension
    {

        public static Permittivity? IfNullSetToZero(this Permittivity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Permittivity.Zero;
        }

    }
}                   