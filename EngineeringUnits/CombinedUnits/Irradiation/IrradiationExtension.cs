using System;

namespace EngineeringUnits
{
    public static class IrradiationUnitExtension
    {

        public static Irradiation? IfNullSetToZero(this Irradiation? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Irradiation.Zero;
        }

    }
}                   