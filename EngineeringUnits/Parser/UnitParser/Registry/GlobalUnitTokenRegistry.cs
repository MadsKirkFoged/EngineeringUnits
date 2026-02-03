using EngineeringUnits.Parser.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Parsing
{
    public static class GlobalUnitTokenRegistry
    {
        private sealed class Maps
        {
            // Case-sensitive symbols: "s" != "S", "nm" != "NM"
            public readonly Dictionary<string, UnitTypebase> SymbolToUnit = new(StringComparer.Ordinal);
            public readonly Dictionary<string, List<UnitTypebase>> SymbolAmbiguous = new(StringComparer.Ordinal);

            // Case-insensitive names/synonyms: "meter" == "Meter"
            public readonly Dictionary<string, UnitTypebase> NameToUnit = new(StringComparer.OrdinalIgnoreCase);
            public readonly Dictionary<string, List<UnitTypebase>> NameAmbiguous = new(StringComparer.OrdinalIgnoreCase);
        }

        private static readonly Lazy<Maps> _maps = new(BuildMaps, isThreadSafe: true);

        public static bool TryResolve(string token, out UnitTypebase unit)
        {
            unit = default!;
            if (string.IsNullOrWhiteSpace(token))
                return false;

            var t = NormalizeToken(token);
            var maps = _maps.Value;

            // 1) Exact symbol lookup first (case-sensitive)
            if (maps.SymbolAmbiguous.TryGetValue(t, out var symCandidates) && symCandidates.Count > 0)
                ThrowAmbiguous(t, symCandidates);

            if (maps.SymbolToUnit.TryGetValue(t, out unit))
                return true;

            // 2) Fallback to name/synonym lookup (case-insensitive)
            if (maps.NameAmbiguous.TryGetValue(t, out var nameCandidates) && nameCandidates.Count > 0)
                ThrowAmbiguous(t, nameCandidates);

            return maps.NameToUnit.TryGetValue(t, out unit);
        }

        private static void ThrowAmbiguous(string token, List<UnitTypebase> candidates)
        {
            var names = candidates
                .Select(u => u.ToString())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            throw new AmbiguousUnitTokenException(token, names);
        }

        private static Maps BuildMaps()
        {
            var maps = new Maps();

            var asm = typeof(UnitTypebase).Assembly;
            var unitTypes = asm.GetTypes()
                .Where(t => t is { IsAbstract: false, IsGenericTypeDefinition: false } &&
                            typeof(UnitTypebase).IsAssignableFrom(t) &&
                            t.Namespace == "EngineeringUnits.Units")
                .ToList();

            foreach (var t in unitTypes)
            {
                foreach (var field in t.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    if (!t.IsAssignableFrom(field.FieldType))
                        continue;

                    if (field.GetValue(null) is not UnitTypebase unit)
                        continue;

                    // Field name (case-insensitive map)
                    AddName(maps, field.Name, unit);

                    // Canonical display token (symbol) goes into symbol map (case-sensitive)
                    var symbol = unit.ToString();
                    if (!string.IsNullOrWhiteSpace(symbol))
                        AddSymbol(maps, symbol, unit);

                    // Optional SynonymsAttribute (case-insensitive map)
                    foreach (var attr in field.GetCustomAttributes(false))
                    {
                        if (attr.GetType().Name == "SynonymsAttribute")
                        {
                            var tokensProp = attr.GetType().GetProperty("Tokens");
                            if (tokensProp?.GetValue(attr) is string[] tokens)
                            {
                                foreach (var syn in tokens)
                                    AddName(maps, syn, unit);
                            }
                        }
                    }
                }
            }

            return maps;
        }

        private static void AddSymbol(Maps maps, string rawToken, UnitTypebase unit)
        {
            if (string.IsNullOrWhiteSpace(rawToken))
                return;

            var token = NormalizeToken(rawToken);
            AddTokenInternal(maps.SymbolToUnit, maps.SymbolAmbiguous, token, unit);

            // optional no-space
            var noSpaces = token.Replace(" ", "");
            if (!string.Equals(noSpaces, token, StringComparison.Ordinal))
                AddTokenInternal(maps.SymbolToUnit, maps.SymbolAmbiguous, noSpaces, unit);
        }

        private static void AddName(Maps maps, string rawToken, UnitTypebase unit)
        {
            if (string.IsNullOrWhiteSpace(rawToken))
                return;

            var token = NormalizeToken(rawToken);
            AddTokenInternal(maps.NameToUnit, maps.NameAmbiguous, token, unit);

            // optional no-space
            var noSpaces = token.Replace(" ", "");
            if (!string.Equals(noSpaces, token, StringComparison.Ordinal))
                AddTokenInternal(maps.NameToUnit, maps.NameAmbiguous, noSpaces, unit);
        }

        private static void AddTokenInternal(
            Dictionary<string, UnitTypebase> map,
            Dictionary<string, List<UnitTypebase>> ambiguous,
            string token,
            UnitTypebase unit)
        {
            // already ambiguous => just add candidate if new
            if (ambiguous.TryGetValue(token, out var list))
            {
                if (!list.Any(u => ReferenceEquals(u, unit) || UnitsEquivalent(u, unit)))
                    list.Add(unit);
                return;
            }

            // existing mapping?
            if (map.TryGetValue(token, out var existing))
            {
                // allow equivalent aliases (same UnitSystem)
                if (ReferenceEquals(existing, unit) || UnitsEquivalent(existing, unit))
                    return;

                map.Remove(token);
                ambiguous[token] = new List<UnitTypebase> { existing, unit };
                return;
            }

            map[token] = unit;
        }

        private static bool UnitsEquivalent(UnitTypebase a, UnitTypebase b) => a.Unit == b.Unit;

        public static string NormalizeToken(string token)
        {
            token = (token ?? "").Trim();
            if (token.Length == 0)
                return token;

            // Collapse whitespace to single space
            bool hasWs = token.Any(char.IsWhiteSpace);
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