using System;

namespace EngineeringUnits.Parsing
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public sealed class SynonymsAttribute : Attribute
    {
        public string[] Tokens { get; }

        public SynonymsAttribute(params string[] tokens)
        {
            Tokens = tokens ?? Array.Empty<string>();
        }
    }
}