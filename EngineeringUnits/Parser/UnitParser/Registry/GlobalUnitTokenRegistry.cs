using System;
using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits.Parsing
{
    /// <summary>
    /// Resolves tokens to units across all quantity types (used by the unit expression parser).
    /// See <see cref="UnitTokenIndex{T}"/> for the matching rules.
    /// </summary>
    public static class GlobalUnitTokenRegistry
    {
        private static readonly Lazy<UnitTokenIndex<UnitTypebase>> _index = new(BuildIndex, isThreadSafe: true);

        /// <summary>
        /// Resolves <paramref name="token"/>. Returns false when unknown.
        /// Throws <see cref="Parser.Accessories.AmbiguousUnitTokenException"/> when the token matches several different units.
        /// </summary>
        public static bool TryResolve(string token, out UnitTypebase unit)
            => _index.Value.TryResolve(token, out unit);

        internal static TokenResolution Resolve(string token, out UnitTypebase unit, out IReadOnlyList<UnitTypebase> candidates)
            => _index.Value.Resolve(token, out unit, out candidates);

        internal static IReadOnlyList<string> DescribeCandidates(IEnumerable<UnitTypebase> candidates)
            => UnitTokenIndex<UnitTypebase>.DescribeCandidates(candidates);

        internal static IEnumerable<(string Token, IReadOnlyList<string> Candidates)> AmbiguousTokens()
            => _index.Value.AmbiguousTokens();

        private static UnitTokenIndex<UnitTypebase> BuildIndex()
        {
            var index = new UnitTokenIndex<UnitTypebase>();

            var unitTypes = typeof(UnitTypebase).Assembly.GetTypes()
                .Where(t => t is { IsAbstract: false, IsGenericTypeDefinition: false } &&
                            typeof(UnitTypebase).IsAssignableFrom(t) &&
                            t.Namespace == "EngineeringUnits.Units")
                .OrderBy(t => t.FullName, StringComparer.Ordinal); // deterministic candidate order

            foreach (var t in unitTypes)
                index.AddUnitsFrom(t);

            return index;
        }

        public static string NormalizeToken(string token) => UnitTokenIndex<UnitTypebase>.NormalizeToken(token);
    }
}
