using System;

namespace EngineeringUnits
{
    public static class PipeSizeUnitExtension
    {

        public static PipeSize? IfNullSetToZero(this PipeSize? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PipeSize.Zero;
        }

    }
}                   