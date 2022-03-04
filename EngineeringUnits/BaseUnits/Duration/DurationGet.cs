
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Duration
    {

 

            /// <summary>
            ///     Get Duration in Nanosecond.
            /// </summary>
            public double Nanosecond => As(DurationUnit.Nanosecond);
            /// <summary>
            ///     Get Duration in Millisecond.
            /// </summary>
            public double Millisecond => As(DurationUnit.Millisecond);
            /// <summary>
            ///     Get Duration in Microsecond.
            /// </summary>
            public double Microsecond => As(DurationUnit.Microsecond);
            /// <summary>
            ///     Get Duration in Second.
            /// </summary>
            public double Second => As(DurationUnit.Second);
            /// <summary>
            ///     Get Duration in Minute.
            /// </summary>
            public double Minute => As(DurationUnit.Minute);
            /// <summary>
            ///     Get Duration in Hour.
            /// </summary>
            public double Hour => As(DurationUnit.Hour);
            /// <summary>
            ///     Get Duration in Day.
            /// </summary>
            public double Day => As(DurationUnit.Day);
            /// <summary>
            ///     Get Duration in Week.
            /// </summary>
            public double Week => As(DurationUnit.Week);
            /// <summary>
            ///     Get Duration in Month30.
            /// </summary>
            public double Month30 => As(DurationUnit.Month30);
            /// <summary>
            ///     Get Duration in Year365.
            /// </summary>
            public double Year365 => As(DurationUnit.Year365);
            /// <summary>
            ///     Get Duration in SI.
            /// </summary>
            public double SI => As(DurationUnit.SI);
    }
}


