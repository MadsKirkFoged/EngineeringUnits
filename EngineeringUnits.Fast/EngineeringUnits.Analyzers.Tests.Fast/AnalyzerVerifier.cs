using EngineeringUnits.Analyzers.Fast;
using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace EngineeringUnits.Analyzers.Tests.Fast;

/// <summary>
/// Compiles a snippet against EngineeringUnits.Fast, runs <see cref="FastDimensionAnalyzer"/> and compares
/// the result with the expected diagnostics marked in the source as {|EUF0002:expression|}.
/// </summary>
internal static class AnalyzerVerifier
{
    private static readonly Regex Markup = new(@"\{\|(?<id>EUF\d{4}):(?<code>.*?)\|\}", RegexOptions.Singleline);

    // Every assembly the test host can load, which includes EngineeringUnits.Fast
    private static readonly Lazy<ImmutableArray<MetadataReference>> AllReferences = new(() =>
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Where(p => p.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(p => (MetadataReference)MetadataReference.CreateFromFile(p))
            .ToImmutableArray());

    private static readonly Lazy<ImmutableArray<MetadataReference>> ReferencesWithoutFast = new(() =>
        AllReferences.Value
            .Where(r => !Path.GetFileName(r.Display!).StartsWith("EngineeringUnits", StringComparison.OrdinalIgnoreCase))
            .ToImmutableArray());

    public const string Parameters = """
        Length length, Length length2, Area area, Volume volume, Energy energy, Power power, Duration time, Mass mass,
        MassFlow massFlow, Enthalpy enthalpy, SpecificEnergy specificEnergy, SpecificEntropy cp, Temperature t1, Temperature t2,
        Speed speed, Ratio ratio, Power? maybePower, double number, int count, bool flag
        """;

    /// <summary>Wraps <paramref name="body"/> in a method that has a set of ready-made quantity parameters.</summary>
    public static Task VerifyBodyAsync(string body) => VerifyAsync(WrapBody(body));

    public static string WrapBody(string body) => $$"""
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using EngineeringUnits.Fast;
        using EngineeringUnits.Units.Fast;

        public static class Snippet
        {
            public static void Run({{Parameters}})
            {
                {{body}}
            }
        }
        """;

    public static async Task VerifyAsync(string markedSource, bool referenceFast = true, string path = "Snippet.cs")
    {
        var (source, expected) = ParseMarkup(markedSource);
        var compilation = Compile(source, referenceFast, path);

        // Make sure the snippet itself is valid C#, otherwise a "no diagnostics" result means nothing
        var compileErrors = compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToList();
        if (compileErrors.Count > 0)
            Assert.Fail("Test source does not compile:" + Environment.NewLine + string.Join(Environment.NewLine, compileErrors));

        var actual = await compilation
            .WithAnalyzers([new FastDimensionAnalyzer()])
            .GetAnalyzerDiagnosticsAsync();

        var actualText = actual
            .OrderBy(d => d.Location.SourceSpan.Start)
            .Select(d => Describe(d.Id, source, d.Location.SourceSpan))
            .ToList();

        var expectedText = expected
            .OrderBy(e => e.Span.Start)
            .Select(e => Describe(e.Id, source, e.Span))
            .ToList();

        CollectionAssert.AreEqual(expectedText, actualText,
            $"{Environment.NewLine}Expected:{Environment.NewLine}  {string.Join(Environment.NewLine + "  ", expectedText)}" +
            $"{Environment.NewLine}Actual:{Environment.NewLine}  {string.Join(Environment.NewLine + "  ", actual.OrderBy(d => d.Location.SourceSpan.Start).Select(d => Describe(d.Id, source, d.Location.SourceSpan) + " : " + d.GetMessage()))}");
    }

    /// <summary>
    /// For things the C# compiler itself rejects (e.g. Length + Mass), before any analyzer runs.
    /// Any of <paramref name="anyOfErrorIds"/>: compiler versions word the same error differently (CS0034 vs CS9342 for ambiguity).
    /// </summary>
    public static void VerifyCompileError(string body, params string[] anyOfErrorIds)
    {
        var compilation = Compile(WrapBody(body), referenceFast: true, "Snippet.cs");
        var errors = compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToList();
        Assert.IsTrue(errors.Any(e => anyOfErrorIds.Contains(e.Id)), string.Join(", ", errors));
    }

    /// <summary>Returns the analyzer diagnostics for an unmarked body, for asserting on messages.</summary>
    public static async Task<ImmutableArray<Diagnostic>> GetDiagnosticsAsync(string body)
        => await Compile(WrapBody(body), true, "Snippet.cs")
            .WithAnalyzers([new FastDimensionAnalyzer()])
            .GetAnalyzerDiagnosticsAsync();

    private static CSharpCompilation Compile(string source, bool referenceFast, string path) => CSharpCompilation.Create(
        "AnalyzerTest",
        [CSharpSyntaxTree.ParseText(source, new CSharpParseOptions(LanguageVersion.Latest), path: path)],
        referenceFast ? AllReferences.Value : ReferencesWithoutFast.Value,
        new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));

    private static string Describe(string id, string source, TextSpan span)
        => $"{id} '{source.Substring(span.Start, span.Length)}' at {span.Start}";

    private static (string Source, List<(string Id, TextSpan Span)> Expected) ParseMarkup(string markedSource)
    {
        var expected = new List<(string, TextSpan)>();
        var clean = new StringBuilder();
        var last = 0;

        foreach (Match m in Markup.Matches(markedSource))
        {
            clean.Append(markedSource, last, m.Index - last);

            var code = m.Groups["code"].Value;
            expected.Add((m.Groups["id"].Value, new TextSpan(clean.Length, code.Length)));
            clean.Append(code);

            last = m.Index + m.Length;
        }

        clean.Append(markedSource, last, markedSource.Length - last);
        return (clean.ToString(), expected);
    }
}
