using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class PipeSizeUnitExtension
    {

        public static PipeSize IfNullSetToZero(this PipeSize? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PipeSize.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static PipeSize? Abs(this PipeSize? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   