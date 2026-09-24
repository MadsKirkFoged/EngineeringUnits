using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits.Parser.UnitParser
{
    public static class UnitParser
    {
        /// <summary>Parses a unit expression such as "kg·m/s²". Never throws.</summary>
        public static bool TryParse(string expression, out UnitSystem unitSystem)
            => UnitExpressionParser.TryParse(expression, out unitSystem, out _);

        /// <summary>Parses a unit expression such as "kg·m/s²". Never throws; <paramref name="error"/> explains a failure.</summary>
        public static bool TryParse(string expression, out UnitSystem unitSystem, out string? error)
            => UnitExpressionParser.TryParse(expression, out unitSystem, out error);

        public static UnitSystem Parse(string expression)
        {
            if (!TryParse(expression, out var u, out var error))
                throw new FormatException($"Could not parse UnitSystem from '{expression}'. {error}".TrimEnd());
            return u;
        }
    }

    public static class UnitParser<TUnit> where TUnit : UnitTypebase
    {
        /// <summary>Resolves a single unit token ("mm", "millimeter") of this quantity type. Never throws.</summary>
        public static bool TryParse(string token, out TUnit unit)
            => TryParse(token, out unit, out _);

        /// <summary>Resolves a single unit token ("mm", "millimeter") of this quantity type. Never throws.</summary>
        public static bool TryParse(string token, out TUnit unit, out string? error)
        {
            unit = default!;
            error = null;

            if (string.IsNullOrWhiteSpace(token))
                return false;

            switch (UnitTokenRegistry<TUnit>.Resolve(token, out unit, out var candidates))
            {
                case TokenResolution.Found:
                    return true;

                case TokenResolution.Ambiguous:
                    error = $"Ambiguous unit token '{UnitTokenRegistry<TUnit>.NormalizeToken(token)}'. " +
                            $"Candidates: {string.Join(", ", UnitTokenIndex<TUnit>.DescribeCandidates(candidates))}";
                    return false;

                default:
                    // Try again after character clean-up (μ -> µ, ² -> ^2, ℃ -> °C, ...)
                    var normalized = UnitExpressionNormalizer.Normalize(token);
                    if (!string.Equals(normalized, token.Trim(), StringComparison.Ordinal))
                        return TryParse(normalized, out unit, out error);
                    return false;
            }
        }
    }
}
