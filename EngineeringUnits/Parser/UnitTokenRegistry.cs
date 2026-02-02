using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Parsing
{
    public static class UnitTokenRegistry<TUnit> where TUnit : UnitTypebase
    {
        private static readonly ConcurrentDictionary<string, TUnit> TokenToUnit = new(StringComparer.OrdinalIgnoreCase);

        static UnitTokenRegistry()
        {
            Build();
        }

        public static bool TryResolve(string token, out TUnit unit)
        {
            unit = default!;
            if (string.IsNullOrWhiteSpace(token))
                return false;

            var normalized = NormalizeToken(token);
            return TokenToUnit.TryGetValue(normalized, out unit);
        }

        private static void Build()
        {
            foreach (FieldInfo field in typeof(TUnit).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (!typeof(TUnit).IsAssignableFrom(field.FieldType))
                    continue;

                var unit = (TUnit?)field.GetValue(null);
                if (unit is null)
                    continue;

                // Always map: field name ("Meter")
                AddToken(field.Name, unit);

                // Map: canonical display token (UnitTypebase.ToString())
                // This is the important change.
                var canonical = unit.ToString();
                if (!string.IsNullOrWhiteSpace(canonical))
                    AddToken(canonical, unit);

                // Map: synonyms from attributes
                foreach (var attrObj in field.GetCustomAttributes(typeof(SynonymsAttribute), false))
                {
                    var syn = (SynonymsAttribute)attrObj;
                    foreach (var t in syn.Tokens)
                        AddToken(t, unit);
                }
            }
        }

        private static void AddToken(string rawToken, TUnit unit)
        {
            if (string.IsNullOrWhiteSpace(rawToken))
                return;

            var token = NormalizeToken(rawToken);

            if (TokenToUnit.TryGetValue(token, out var existing) && (existing != unit))
            {
                var candidates = new List<string>
                {
                    existing.ToString(),
                    unit.ToString()
                };

                throw new AmbiguousUnitTokenException(token, candidates);
            }

            //TokenToUnit[token] = unit;
            TokenToUnit.TryAdd(token, unit);

            // Optional: support "nautical mile" -> "nauticalmile"
            var noSpaces = token.Replace(" ", "");
            if (!string.Equals(noSpaces, token, StringComparison.Ordinal))
            {
                if (TokenToUnit.TryGetValue(noSpaces, out existing) && (existing != unit))
                {
                    var candidates = new List<string>
                    {
                        existing.ToString(),
                        unit.ToString()
                    };
                    throw new AmbiguousUnitTokenException(noSpaces, candidates);
                }

                TokenToUnit.TryAdd(noSpaces, unit);

                //TokenToUnit[noSpaces] = unit;
            }
        }

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