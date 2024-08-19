using System;

namespace EngineeringUnits
{
    public static class EnthalpyUnitExtension
    {

        public static Enthalpy? IfNullSetToZero(this Enthalpy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Enthalpy.Zero;
        }

    }
}                   