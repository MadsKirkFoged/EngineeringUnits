using System;

namespace EngineeringUnits
{
    /// <summary>
    /// Tells the EngineeringUnits analyzer which unit (dimension) a method returns, based on one of its parameters.<br></br>
    /// This lets the analyzer keep checking units through calls like <c>a.Abs()</c>, <c>a.Pow(2)</c> or <c>a.Sqrt()</c>.
    /// </summary>
    /// <example>
    /// <code>
    /// [return: DimensionOf(nameof(a))]                                   // same unit as a
    /// [return: DimensionOf(nameof(a), PowerParameter = nameof(toPower))] // a^toPower
    /// [return: DimensionOf(nameof(a), Root = 2)]                         // square root of a
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
    public sealed class DimensionOfAttribute : Attribute
    {
        public DimensionOfAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        /// <summary>The parameter whose unit the result is based on. For arrays and tuples, the unit of their elements.</summary>
        public string ParameterName { get; }

        /// <summary>Name of an <see langword="int"/> parameter that the unit is raised to the power of.</summary>
        public string? PowerParameter { get; set; }

        /// <summary>The result is this root of the unit, e.g. 2 for a square root. The method throws if the unit can't be split evenly.</summary>
        public int Root { get; set; } = 1;
    }
}
