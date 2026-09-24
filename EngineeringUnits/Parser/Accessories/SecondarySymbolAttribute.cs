using System;

namespace EngineeringUnits.Parsing
{
    /// <summary>
    /// Marks a unit whose symbol is shared with a more common unit, e.g. <c>RotationalSpeedUnit.Hertz</c> ("Hz" = 2π rad/s)
    /// versus <c>FrequencyUnit.Hertz</c> ("Hz" = 1/s). When a token matches both, parsers pick the other unit
    /// instead of reporting the token as ambiguous. Parsing the quantity itself (<c>RotationalSpeed.Parse("5 Hz")</c>)
    /// is unaffected.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class SecondarySymbolAttribute : Attribute
    {
    }
}
