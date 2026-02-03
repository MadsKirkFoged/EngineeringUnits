using System;

namespace EngineeringUnits.Parsing
{
    public static class UnitParser
    {
        public static bool TryParse(string expression, out UnitSystem unitSystem)
            => UnitExpressionParser.TryParse(expression, out unitSystem);

        public static UnitSystem Parse(string expression)
        {
            if (!TryParse(expression, out var u))
                throw new FormatException($"Could not parse UnitSystem from '{expression}'.");
            return u;
        }

        // Optional helper: resolve a single token to ANY UnitTypebase (for debugging/UI).
        public static bool TryParseToken(string token, out UnitTypebase unit)
            => AnyUnitTokenRegistry.TryResolve(token, out unit);
    }


}