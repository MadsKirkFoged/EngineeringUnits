using System;

namespace EngineeringUnits
{
    public static class ReactiveEnergyUnitExtension
    {

        public static ReactiveEnergy? IfNullSetToZero(this ReactiveEnergy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ReactiveEnergy.Zero;
        }

    }
}                   