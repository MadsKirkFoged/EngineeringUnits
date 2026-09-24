using EngineeringUnits.Parser.Accessories;
using EngineeringUnits.Parser.UnitParser;
using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Parsing
{
    internal enum TokenTier
    {
        // Canonical display symbol (UnitTypebase.ToString()), e.g. "MPa"
        Symbol = 0,
        // [Synonyms(...)] entries, e.g. "megapascal", "psi"
        Synonym = 1,
        // Field names and names derived from them, e.g. "Megapascal", "Megapascals"
        Name = 2,
    }

    internal enum TokenResolution { NotFound, Found, Ambiguous }

    /// <summary>
    /// Token -> unit lookup shared by <see cref="UnitTokenRegistry{TUnit}"/> and <see cref="GlobalUnitTokenRegistry"/>.
    /// <para>
    /// Lookup order: exact (case-sensitive) symbol, exact synonym, exact name, then a case-insensitive
    /// fallback. Case matters for SI prefixes ("mA" vs "MA"), so the fallback is only used when every
    /// case-insensitive match converts identically, and never for single-character tokens ("s" vs "S").
    /// </para>
    /// <para>
    /// Two units only count as the same when dimension, conversion factor and offset all match.
    /// (<see cref="UnitSystem"/> equality compares dimensions only, which is not enough here.)
    /// When several different units match, units marked <see cref="SecondarySymbolAttribute"/> give way;
    /// if that does not leave exactly one, the token is ambiguous.
    /// </para>
    /// </summary>
    internal sealed class UnitTokenIndex<T> where T : UnitTypebase
    {
        private sealed class Candidate
        {
            public Candidate(T unit, bool secondary) { Unit = unit; Secondary = secondary; }

            public T Unit { get; }
            public bool Secondary { get; set; }

            /// <summary>How the token was registered for this unit (used by the case-insensitive fallback).</summary>
            public List<string> Spellings { get; } = new();
        }

        private readonly Dictionary<string, List<Candidate>>[] _exact =
        {
            new(StringComparer.Ordinal),
            new(StringComparer.Ordinal),
            new(StringComparer.Ordinal),
        };

        private readonly Dictionary<string, List<Candidate>> _folded = new(StringComparer.OrdinalIgnoreCase);

        public void Add(string rawToken, T unit, TokenTier tier, bool secondary = false)
        {
            var token = NormalizeToken(rawToken);
            if (token.Length == 0)
                return;

            AddWithVariants(token, unit, tier, secondary);

            // Also register the form lookups see after normalization ("n/m²" -> "n/m^2", "μm" -> "µm")
            var normalized = NormalizeToken(UnitExpressionNormalizer.Normalize(token));
            if (normalized.Length > 0 && !string.Equals(normalized, token, StringComparison.Ordinal))
                AddWithVariants(normalized, unit, tier, secondary);
        }

        private void AddWithVariants(string token, T unit, TokenTier tier, bool secondary)
        {
            AddInternal(token, unit, tier, secondary);

            // "nautical mile" -> "nauticalmile" (not for short results: "n m" must not become "nm")
            var noSpaces = token.Replace(" ", "");
            if (noSpaces.Length >= 4 && !string.Equals(noSpaces, token, StringComparison.Ordinal))
                AddInternal(noSpaces, unit, tier, secondary);
        }

        private void AddInternal(string token, T unit, TokenTier tier, bool secondary)
        {
            AddCandidate(_exact[(int)tier], token, unit, secondary);
            AddCandidate(_folded, token, unit, secondary);
        }

        private static void AddCandidate(Dictionary<string, List<Candidate>> map, string token, T unit, bool secondary)
        {
            if (!map.TryGetValue(token, out var list))
                map[token] = list = new List<Candidate>();

            var same = list.FirstOrDefault(c => UnitsEquivalent(c.Unit, unit));
            if (same is null)
            {
                same = new Candidate(unit, secondary);
                list.Add(same);
            }
            else if (secondary)
            {
                same.Secondary = true;
            }

            if (!same.Spellings.Contains(token))
                same.Spellings.Add(token);
        }

        /// <summary>
        /// m/M, p/P, y/Y and z/Z are SI prefixes in both cases (milli/mega, pico/peta, ...). The case-insensitive
        /// fallback never flips the case of such a leading letter: "Mm" must not silently become "mm".
        /// </summary>
        private static bool FlipsPrefixCase(string registered, string typed)
        {
            char r = registered[0], t = typed[0];
            return r != t && char.ToLowerInvariant(r) == char.ToLowerInvariant(t) && char.ToLowerInvariant(r) is 'm' or 'p' or 'y' or 'z';
        }

        public TokenResolution Resolve(string rawToken, out T unit, out IReadOnlyList<T> candidates)
        {
            unit = default!;
            candidates = Array.Empty<T>();

            var token = NormalizeToken(rawToken);
            if (token.Length == 0)
                return TokenResolution.NotFound;

            foreach (var map in _exact)
            {
                if (map.TryGetValue(token, out var list))
                    return FromList(list, out unit, out candidates);
            }

            if (token.Length >= 2 && _folded.TryGetValue(token, out var folded))
            {
                // The case of a leading prefix letter always counts: "MPA" -> MPa (not mPa), "Mm" -> nothing (not mm)
                var kept = folded.Where(c => c.Spellings.Any(s => !FlipsPrefixCase(s, token))).ToList();

                // ...except in all-lowercase input, where case clearly was not typed on purpose ("mpa", "mw")
                if (kept.Count < folded.Count && token.Any(char.IsLetter) && !token.Any(char.IsUpper))
                    kept = folded;

                if (kept.Count == 0)
                    return TokenResolution.NotFound;

                return FromList(kept, out unit, out candidates);
            }

            return TokenResolution.NotFound;
        }

        /// <summary>Resolves a token, throwing <see cref="AmbiguousUnitTokenException"/> when it is ambiguous.</summary>
        public bool TryResolve(string token, out T unit)
        {
            switch (Resolve(token, out unit, out var candidates))
            {
                case TokenResolution.Found:
                    return true;
                case TokenResolution.Ambiguous:
                    throw new AmbiguousUnitTokenException(NormalizeToken(token), DescribeCandidates(candidates));
                default:
                    return false;
            }
        }

        private static TokenResolution FromList(List<Candidate> list, out T unit, out IReadOnlyList<T> candidates)
        {
            candidates = list.Select(c => c.Unit).ToList();

            if (list.Count == 1)
            {
                unit = list[0].Unit;
                return TokenResolution.Found;
            }

            var primary = list.Where(c => !c.Secondary).ToList();
            if (primary.Count == 1)
            {
                unit = primary[0].Unit;
                return TokenResolution.Found;
            }

            unit = default!;
            return TokenResolution.Ambiguous;
        }

        /// <summary>All exact tokens that are ambiguous (for diagnostics/tests).</summary>
        public IEnumerable<(string Token, IReadOnlyList<string> Candidates)> AmbiguousTokens()
        {
            foreach (var map in _exact)
            {
                foreach (var kv in map)
                {
                    if (FromList(kv.Value, out _, out var candidates) == TokenResolution.Ambiguous)
                        yield return (kv.Key, DescribeCandidates(candidates));
                }
            }
        }

        internal static IReadOnlyList<string> DescribeCandidates(IEnumerable<T> candidates)
        {
            return candidates.Select(Describe)
                             .Distinct(StringComparer.Ordinal)
                             .ToList();
        }

        private static string Describe(T unit)
        {
            var symbol = unit.ToString();
            var quantity = unit.GetType().Name;
            if (quantity.EndsWith("Unit", StringComparison.Ordinal))
                quantity = quantity.Substring(0, quantity.Length - 4);

            return $"{symbol} ({quantity})";
        }

        // ---------------- equivalence ----------------

        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<UnitSystem, object> _signatures = new();

        private sealed class Signature
        {
            public int Dimension;
            public Fraction Factor;
            public Fraction Offset;
        }

        private static Signature GetSignature(UnitSystem unit)
        {
            return (Signature)_signatures.GetValue(unit, u => new Signature
            {
                Dimension = u.GetHashCodeForUnitTypeCompare(),
                Factor = u.SumConstant(),
                Offset = u.SumOfBConstants(),
            });
        }

        internal static bool UnitsEquivalent(UnitTypebase a, UnitTypebase b)
            => ReferenceEquals(a, b) || UnitsEquivalent(a.Unit, b.Unit);

        internal static bool UnitsEquivalent(UnitSystem a, UnitSystem b)
        {
            if (ReferenceEquals(a, b))
                return true;

            var sa = GetSignature(a);
            var sb = GetSignature(b);

            return sa.Dimension == sb.Dimension &&
                   sa.Factor == sb.Factor &&
                   sa.Offset == sb.Offset;
        }

        // ---------------- building from reflection ----------------

        /// <summary>Registers all public static unit fields of <paramref name="unitType"/>.</summary>
        public void AddUnitsFrom(Type unitType)
        {
            foreach (var field in unitType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (!unitType.IsAssignableFrom(field.FieldType))
                    continue;

                if (field.GetValue(null) is not T unit)
                    continue;

                bool secondary = field.IsDefined(typeof(SecondarySymbolAttribute), false);

                var symbol = unit.ToString();
                if (!string.IsNullOrWhiteSpace(symbol))
                    Add(symbol, unit, TokenTier.Symbol, secondary);

                foreach (var attr in field.GetCustomAttributes<SynonymsAttribute>(false))
                    foreach (var syn in attr.Tokens)
                        Add(syn, unit, TokenTier.Synonym, secondary);

                foreach (var name in DeriveNames(field.Name))
                    Add(name, unit, TokenTier.Name, secondary);
            }
        }

        /// <summary>
        /// "Meter" -> "Meter", "Meters"; "NauticalMile" -> also "Nautical Mile", "Nautical Miles".
        /// Plurals are only derived for real words (4+ letters), never for short/symbol-like field names.
        /// </summary>
        internal static IEnumerable<string> DeriveNames(string fieldName)
        {
            yield return fieldName;

            if (fieldName.Length < 4 || !fieldName.All(char.IsLetter))
                yield break;

            var spaced = SplitCamelCase(fieldName);
            if (!string.Equals(spaced, fieldName, StringComparison.Ordinal))
                yield return spaced;

            if (!fieldName.EndsWith("s", StringComparison.OrdinalIgnoreCase))
            {
                yield return fieldName + "s";
                if (!string.Equals(spaced, fieldName, StringComparison.Ordinal))
                    yield return spaced + "s";
            }
        }

        private static string SplitCamelCase(string s)
        {
            var sb = new StringBuilder(s.Length + 4);
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && char.IsUpper(s[i]) && char.IsLower(s[i - 1]))
                    sb.Append(' ');
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        /// <summary>Trims and collapses internal whitespace to single spaces.</summary>
        public static string NormalizeToken(string? token)
        {
            token = (token ?? "").Trim();
            if (token.Length == 0)
                return token;

            bool hasWs = false;
            foreach (var ch in token)
            {
                if (char.IsWhiteSpace(ch))
                { hasWs = true; break; }
            }

            if (!hasWs)
                return token;

            var sb = new StringBuilder(token.Length);
            bool lastWasSpace = false;

            foreach (var ch in token)
            {
                if (char.IsWhiteSpace(ch))
                {
                    if (!lastWasSpace)
                        sb.Append(' ');
                    lastWasSpace = true;
                }
                else
                {
                    sb.Append(ch);
                    lastWasSpace = false;
                }
            }

            return sb.ToString();
        }
    }
}
