using System;
using System.Collections.Generic;

namespace EngineeringUnits.Parsing
{
    /// <summary>
    /// Resolves tokens ("mm", "millimeter", "Millimeters") to units of a single quantity type.
    /// See <see cref="UnitTokenIndex{T}"/> for the matching rules.
    /// </summary>
    public static class UnitTokenRegistry<TUnit> where TUnit : UnitTypebase
    {
        // Thread-safe and will not poison the type if something goes wrong
        private static readonly Lazy<UnitTokenIndex<TUnit>> _index = new(BuildIndex, isThreadSafe: true);

        /// <summary>
        /// Resolves <paramref name="token"/>. Returns false when unknown.
        /// Throws <see cref="Parser.Accessories.AmbiguousUnitTokenException"/> when the token matches several different units.
        /// </summary>
        public static bool TryResolve(string token, out TUnit unit)
            => _index.Value.TryResolve(token, out unit);

        internal static TokenResolution Resolve(string token, out TUnit unit, out IReadOnlyList<TUnit> candidates)
            => _index.Value.Resolve(token, out unit, out candidates);

        internal static IEnumerable<(string Token, IReadOnlyList<string> Candidates)> AmbiguousTokens()
            => _index.Value.AmbiguousTokens();

        private static UnitTokenIndex<TUnit> BuildIndex()
        {
            var index = new UnitTokenIndex<TUnit>();
            index.AddUnitsFrom(typeof(TUnit));
            return index;
        }

        public static string NormalizeToken(string token) => UnitTokenIndex<TUnit>.NormalizeToken(token);
    }
}
