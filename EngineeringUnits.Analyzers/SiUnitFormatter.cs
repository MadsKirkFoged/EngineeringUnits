using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace EngineeringUnits.Analyzers;

internal static class SiUnitFormatter
{
    // Map BaseunitType enum *member name* -> SI base symbol
    private static readonly Dictionary<string, string> BaseNameToSiSymbol = new(StringComparer.Ordinal)
    {
        ["mass"] = "kg",
        ["length"] = "m",
        ["time"] = "s",
        ["duration"] = "s",
        ["electricCurrent"] = "A",
        ["temperature"] = "K",
        ["amountOfSubstance"] = "mol",
        ["luminousIntensity"] = "cd",
    };

    internal static Dictionary<int, string> BuildEnumValueToNameMap(Compilation compilation)
    {
        var enumSym = compilation.GetTypeByMetadataName("EngineeringUnits.BaseunitType");
        var map = new Dictionary<int, string>();
        if (enumSym is null)
            return map;

        foreach (var member in enumSym.GetMembers().OfType<IFieldSymbol>())
        {
            if (member.HasConstantValue && member.ConstantValue is int v)
                map[v] = member.Name;
        }
        return map;
    }

    internal static string FormatAsSi(Dictionary<int, int> exps, Dictionary<int, string> enumValueToName)
    {
        var num = new List<string>();
        var den = new List<string>();

        foreach (var kv in exps.OrderBy(k => k.Key))
        {
            var unitKey = kv.Key;
            var exp = kv.Value;
            if (exp == 0)
                continue;

            var unitSymbol = ResolveSiSymbol(unitKey, enumValueToName);

            if (exp > 0)
                num.Add(ApplyExponent(unitSymbol, exp));
            else
                den.Add(ApplyExponent(unitSymbol, -exp));
        }

        if (num.Count == 0 && den.Count == 0)
            return "1";

        var numerator = num.Count == 0 ? "1" : string.Join("*", num);

        if (den.Count == 0)
            return numerator;

        var denominator = string.Join("*", den);
        return $"{numerator}/{denominator}";
    }

    private static string ResolveSiSymbol(int enumValue, Dictionary<int, string> enumValueToName)
    {
        if (enumValueToName.TryGetValue(enumValue, out var name) &&
            BaseNameToSiSymbol.TryGetValue(name, out var sym))
        {
            return sym;
        }

        return $"U{enumValue}";
    }

    private static string ApplyExponent(string unitSymbol, int exp)
    {
        if (exp == 1)
            return unitSymbol;
        return unitSymbol + ToSuperscript(exp);
    }

    internal static string ToSuperscript(int value)
    {
        var s = value.ToString();
        return string.Concat(s.Select(ToSuperscriptChar));
    }

    private static char ToSuperscriptChar(char c) => c switch
    {
        '0' => '⁰',
        '1' => '¹',
        '2' => '²',
        '3' => '³',
        '4' => '⁴',
        '5' => '⁵',
        '6' => '⁶',
        '7' => '⁷',
        '8' => '⁸',
        '9' => '⁹',
        '-' => '⁻',
        _ => c
    };
}