using System;
using System.Collections.Generic;

namespace EngineeringUnits.Parsing
{
    public sealed class AmbiguousUnitTokenException : Exception
    {
        public string Token { get; }
        public IReadOnlyList<string> Candidates { get; }

        public AmbiguousUnitTokenException(string token, IReadOnlyList<string> candidates)
            : base($"Ambiguous unit token '{token}'. Candidates: {string.Join(", ", candidates)}")
        {
            Token = token;
            Candidates = candidates;
        }
    }
}