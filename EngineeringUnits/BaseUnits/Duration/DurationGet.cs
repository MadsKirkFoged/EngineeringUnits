using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Duration
    {

        /// <summary>
        ///     Get Duration in Days.
        /// </summary>
        public double Days => As(DurationUnit.Day);

        /// <summary>
        ///     Get Duration in Hours.
        /// </summary>
        public double Hours => As(DurationUnit.Hour);

        /// <summary>
        ///     Get Duration in Microseconds.
        /// </summary>
        public double Microseconds => As(DurationUnit.Microsecond);

        /// <summary>
        ///     Get Duration in Milliseconds.
        /// </summary>
        public double Milliseconds => As(DurationUnit.Millisecond);

        /// <summary>
        ///     Get Duration in Minutes.
        /// </summary>
        public double Minutes => As(DurationUnit.Minute);

        /// <summary>
        ///     Get Duration in Months30.
        /// </summary>
        public double Months30 => As(DurationUnit.Month30);

        /// <summary>
        ///     Get Duration in Nanoseconds.
        /// </summary>
        public double Nanoseconds => As(DurationUnit.Nanosecond);

        /// <summary>
        ///     Get Duration in Seconds.
        /// </summary>
        public double Seconds => As(DurationUnit.Second);

        /// <summary>
        ///     Get Duration in SI Unit (Seconds).
        /// </summary>
        public double SI => As(DurationUnit.SI);

        /// <summary>
        ///     Get Duration in Weeks.
        /// </summary>
        public double Weeks => As(DurationUnit.Week);

        /// <summary>
        ///     Get Duration in Years365.
        /// </summary>
        public double Years365 => As(DurationUnit.Year365);



    }
}
