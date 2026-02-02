using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Parsing
{
    //public sealed class AmbiguousUnitTokenException : Exception
    //{
    //    public string Token { get; }
    //    public IReadOnlyList<string> Candidates { get; }

    //    public AmbiguousUnitTokenException(string token, IReadOnlyList<string> candidates)
    //        : base($"Ambiguous unit token '{token}'. Candidates: {string.Join(", ", candidates)}")
    //    {
    //        Token = token;
    //        Candidates = candidates;
    //    }
    //}

    public static class AnyUnitTokenRegistry
    {
        private sealed class Maps
        {
            public readonly Dictionary<string, UnitTypebase> TokenToUnit = new(StringComparer.OrdinalIgnoreCase);
            public readonly Dictionary<string, List<UnitTypebase>> Ambiguous = new(StringComparer.OrdinalIgnoreCase);
        }

        private static readonly Lazy<Maps> _maps = new(BuildMaps, isThreadSafe: true);

        public static bool TryResolve(string token, out UnitTypebase unit)
        {
            unit = default!;
            if (string.IsNullOrWhiteSpace(token))
                return false;

            var normalized = NormalizeToken(token);
            var maps = _maps.Value;

            if (maps.Ambiguous.TryGetValue(normalized, out var candidates) && candidates.Count > 0)
            {
                var names = candidates.Select(u => u.ToString())
                                      .Distinct(StringComparer.OrdinalIgnoreCase)
                                      .ToList();
                throw new AmbiguousUnitTokenException(normalized, names);
            }

            return maps.TokenToUnit.TryGetValue(normalized, out unit);
        }

        private static Maps BuildMaps()
        {
            var maps = new Maps();

            // Scan only the EngineeringUnits assembly and only EngineeringUnits.Units namespace
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

                    // 1) Field name (e.g. "Meter", "KilowattHour")
                    AddToken(maps, field.Name, unit);

                    // 2) Canonical token (ToString => symbol if present)
                    var canonical = unit.ToString();
                    if (!string.IsNullOrWhiteSpace(canonical))
                        AddToken(maps, canonical, unit);

                    // 3) Optional: SynonymsAttribute support (if present)
                    foreach (var attr in field.GetCustomAttributes(false))
                    {
                        if (attr.GetType().Name == "SynonymsAttribute")
                        {
                            var tokensProp = attr.GetType().GetProperty("Tokens");
                            if (tokensProp?.GetValue(attr) is string[] tokens)
                            {
                                foreach (var syn in tokens)
                                    AddToken(maps, syn, unit);
                            }
                        }
                    }
                }
            }

            return maps;
        }

        private static void AddToken(Maps maps, string rawToken, UnitTypebase unit)
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

        private static void AddTokenInternal(Maps maps, string token, UnitTypebase unit)
        {
            // already ambiguous -> add if new
            if (maps.Ambiguous.TryGetValue(token, out var list))
            {
                if (!list.Any(u => ReferenceEquals(u, unit) || UnitsEquivalent(u, unit)))
                    list.Add(unit);
                return;
            }

            // existing mapping?
            if (maps.TokenToUnit.TryGetValue(token, out var existing))
            {
                // If equivalent (aliases like SI vs Meter), keep non-ambiguous
                if (ReferenceEquals(existing, unit) || UnitsEquivalent(existing, unit))
                    return;

                maps.TokenToUnit.Remove(token);
                maps.Ambiguous[token] = new List<UnitTypebase> { existing, unit };
                return;
            }

            maps.TokenToUnit[token] = unit;
        }

        private static bool UnitsEquivalent(UnitTypebase a, UnitTypebase b) => a.Unit == b.Unit;

        public static string NormalizeToken(string token)
        {
            token = (token ?? "").Trim();
            if (token.Length == 0)
                return token;

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