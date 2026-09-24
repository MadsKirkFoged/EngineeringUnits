using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;
using EngineeringUnits.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace EngineeringUnits.Analyzers.Tests;

/// <summary>
/// Compiles a snippet against EngineeringUnits, runs <see cref="DimensionMismatchAnalyzer"/> and compares
/// the result with the expected diagnostics marked in the source as {|EU0002:expression|}.
/// </summary>
internal static class AnalyzerVerifier
{
    private static readonly Regex Markup = new(@"\{\|(?<id>EU\d{4}):(?<code>.*?)\|\}", RegexOptions.Singleline);

    // Every assembly the test host can load, which includes EngineeringUnits and its dependencies
    private static readonly Lazy<ImmutableArray<MetadataReference>> AllReferences = new(() =>
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Where(p => p.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(p => (MetadataReference)MetadataReference.CreateFromFile(p))
            .ToImmutableArray());

    private static readonly Lazy<ImmutableArray<MetadataReference>> ReferencesWithoutEngineeringUnits = new(() =>
        AllReferences.Value
            .Where(r => !Path.GetFileName(r.Display!).StartsWith("EngineeringUnits", StringComparison.OrdinalIgnoreCase))
            .ToImmutableArray());

    /// <summary>
    /// Wraps <paramref name="body"/> in a method that has a set of ready-made quantity parameters.
    /// </summary>
    public static Task VerifyBodyAsync(string body) => VerifyAsync($$"""
        using EngineeringUnits;

        public static class Snippet
        {
            public static void Run(
                Length length, Length length2, Area area, Energy energy, Power power,
                Duration time, Mass mass, Ratio ratio, UnknownUnit unknown,
                double number, int count, double? maybeNumber)
            {
                {{body}}
            }
        }
        """);

    public static async Task VerifyAsync(string markedSource, bool referenceEngineeringUnits = true)
    {
        var (source, expected) = ParseMarkup(markedSource);

        var compilation = CSharpCompilation.Create(
            "AnalyzerTest",
            [CSharpSyntaxTree.ParseText(source)],
            referenceEngineeringUnits ? AllReferences.Value : ReferencesWithoutEngineeringUnits.Value,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));

        // Make sure the snippet itself is valid C#, otherwise a "no diagnostics" result means nothing
        var compileErrors = compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToList();
        if (compileErrors.Count > 0)
            Assert.Fail("Test source does not compile:" + Environment.NewLine + string.Join(Environment.NewLine, compileErrors));

        var analyzer = new DimensionMismatchAnalyzer();
        var actual = await compilation
            .WithAnalyzers([analyzer])
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
            $"{Environment.NewLine}Actual:{Environment.NewLine}  {string.Join(Environment.NewLine + "  ", actualText)}");
    }

    /// <summary>
    /// Returns the analyzer diagnostics for an unmarked body, for asserting on messages.
    /// </summary>
    public static async Task<ImmutableArray<Diagnostic>> GetDiagnosticsAsync(string body)
    {
        var source = $$"""
            using EngineeringUnits;

            public static class Snippet
            {
                public static void Run(Length length, Area area, Energy energy, Power power, Duration time, Cost cost)
                {
                    {{body}}
                }
            }
            """;

        var compilation = CSharpCompilation.Create(
            "AnalyzerTest",
            [CSharpSyntaxTree.ParseText(source)],
            AllReferences.Value,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        return await compilation
            .WithAnalyzers([new DimensionMismatchAnalyzer()])
            .GetAnalyzerDiagnosticsAsync();
    }

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
