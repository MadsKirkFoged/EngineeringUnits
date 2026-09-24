using System;

namespace EngineeringUnits
{
    /// <summary>
    /// Marks parameters that must all have the same unit (dimension), otherwise the method throws a <see cref="WrongUnitException"/>.<br></br>
    /// The EngineeringUnits analyzer checks this at compile time (EU0005).
    /// </summary>
    /// <remarks>
    /// All parameters with the same <see cref="Group"/> must match each other. On an instance method, the instance itself is part of the default group.<br></br>
    /// Values passed to a <see langword="params"/> array, arrays created in the call and tuples are checked element by element.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public sealed class SameDimensionAttribute : Attribute
    {
        public SameDimensionAttribute()
            : this("")
        {
        }

        public SameDimensionAttribute(string group)
        {
            Group = group;
        }

        public string Group { get; }
    }
}
