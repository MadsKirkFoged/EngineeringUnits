using EngineeringUnits.Parser.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Parsing
{
    public static class UnitTokenRegistry<TUnit> where TUnit : UnitTypebase
    {
        private sealed class Maps
        {
            public readonly Dictionary<string, TUnit> TokenToUnit = new(StringComparer.OrdinalIgnoreCase);
            public readonly Dictionary<string, List<TUnit>> Ambiguous = new(StringComparer.OrdinalIgnoreCase);
        }

        // Thread-safe and will not poison the type if something goes wrong
        private static readonly Lazy<Maps> _maps = new(BuildMaps, isThreadSafe: true);

        public static bool TryResolve(string token, out TUnit unit)
        {
            unit = default!;

            if (string.IsNullOrWhiteSpace(token))
                return false;

            var normalized = NormalizeToken(token);
            var maps = _maps.Value;

            // If ambiguous, throw here (runtime), NOT in static init.
            if (maps.Ambiguous.TryGetValue(normalized, out var candidates) && candidates.Count > 0)
            {
                var names = candidates.Select(c => c.ToString())
                                      .Distinct(StringComparer.OrdinalIgnoreCase)
                                      .ToList();
                throw new AmbiguousUnitTokenException(normalized, names);
            }

            return maps.TokenToUnit.TryGetValue(normalized, out unit);
        }

        private static Maps BuildMaps()
        {
            var maps = new Maps();

            foreach (FieldInfo field in typeof(TUnit).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (!typeof(TUnit).IsAssignableFrom(field.FieldType))
                    continue;

                var unit = (TUnit?)field.GetValue(null);
                if (unit is null)
                    continue;

                // 1) Field name (e.g. "Meter", "SI")
                AddToken(maps, field.Name, unit);

                // 2) Canonical display token (UnitTypebase.ToString())
                var canonical = unit.ToString();
                if (!string.IsNullOrWhiteSpace(canonical))
                    AddToken(maps, canonical, unit);

                // 3) Synonyms
                foreach (var attrObj in field.GetCustomAttributes(typeof(SynonymsAttribute), false))
                {
                    var syn = (SynonymsAttribute)attrObj;
                    foreach (var t in syn.Tokens)
                        AddToken(maps, t, unit);
                }
            }

            return maps;
        }

        private static void AddToken(Maps maps, string rawToken, TUnit unit)
        {
            if (string.IsNullOrWhiteSpace(rawToken))
                return;

            var token = NormalizeToken(rawToken);
            AddTokenInternal(maps, token, unit);

            // Optional: "nautical mile" -> "nauticalmile"
            var noSpaces = token.Replace(" ", "");
            if (!string.Equals(noSpaces, token, StringComparison.Ordinal))
                AddTokenInternal(maps, noSpaces, unit);
        }

        private static void AddTokenInternal(Maps maps, string token, TUnit unit)
        {
            // already ambiguous -> just add candidate if new
            if (maps.Ambiguous.TryGetValue(token, out var list))
            {
                if (!list.Any(u => ReferenceEquals(u, unit) || UnitsEquivalent(u, unit)))
                    list.Add(unit);
                return;
            }

            // existing mapping?
            if (maps.TokenToUnit.TryGetValue(token, out var existing))
            {
                // If they are equivalent (aliases like Meter vs SI), keep it as non-ambiguous.
                if (ReferenceEquals(existing, unit) || UnitsEquivalent(existing, unit))
                    return;

                // Otherwise mark ambiguous
                maps.TokenToUnit.Remove(token);
                maps.Ambiguous[token] = new List<TUnit> { existing, unit };
                return;
            }

            maps.TokenToUnit[token] = unit;
        }

        // Treat two unit instances as equivalent if their underlying UnitSystem is equal
        private static bool UnitsEquivalent(UnitTypebase a, UnitTypebase b) => a.Unit == b.Unit;

        public static string NormalizeToken(string token)
        {
            token = (token ?? "").Trim();
            if (token.Length == 0)
                return token;

            bool hasWs = false;
            for (int i = 0; i < token.Length; i++)
            {
                if (char.IsWhiteSpace(token[i]))
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

            return sb.ToString().Trim();
        }
    }
}