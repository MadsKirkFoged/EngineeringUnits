using System.Runtime.CompilerServices;
using System.Text;
using CodeGen.Fast;

// Reads every quantity, unit, symbol, synonym and constant from EngineeringUnits (by reflection)
// and writes the struct versions into EngineeringUnits.Fast/Generated. Run it again whenever units change.

var root = Path.GetDirectoryName(ThisFile())!;
var solution = Path.GetFullPath(Path.Combine(root, ".."));
var libOut = Path.Combine(solution, "EngineeringUnits.Fast", "Generated");

var quantities = Model.ReadQuantities();
Model.ReadForwarders(quantities);
var constants = Model.ReadConstants(quantities);
var groups = quantities.GroupBy(q => q.Dim.Key).ToDictionary(g => g.Key, g => g.ToList());

Recreate(libOut);
Directory.CreateDirectory(Path.Combine(libOut, "Quantities"));
Directory.CreateDirectory(Path.Combine(libOut, "Units"));
Directory.CreateDirectory(Path.Combine(libOut, "Nullable"));
Directory.CreateDirectory(Path.Combine(libOut, "NumberExtensions"));

foreach (var q in quantities)
{
    // Dimensionless quantities (Angle, Information, Ratio, ...) share a "dimension" but have nothing to do with each
    // other - no alias operators for them. Go through UnknownUnit when you mean it: Angle a = (UnknownUnit)ratio;
    // EngineeringUnits converts implicitly between a few of them (Enthalpy/SpecificEnergy, Ratio/Dimensionless, ...):
    // those pairs are implicit here too, so a using swap keeps compiling. All other aliases are explicit.
    var implicitAliases = quantities.Where(a => a.Name != q.Name && Model.HasImplicitConversion(q, a)).ToList();
    var aliases = (q.Dim.Terms.Count == 0 ? [] : groups[q.Dim.Key].Where(a => a.Name != q.Name))
        .Union(implicitAliases).ToList();
    Write(Path.Combine(libOut, "Quantities", $"{q.Name}.g.cs"), Emit.Quantity(q, aliases, implicitAliases.Select(a => a.Name).ToHashSet()));
    Write(Path.Combine(libOut, "Nullable", $"{q.Name}Nullable.g.cs"), Emit.NullableFile(q, aliases));
    Write(Path.Combine(libOut, "Units", $"{q.Name}Unit.g.cs"), Emit.UnitClass(q));
    Write(Path.Combine(libOut, "NumberExtensions", $"NumberTo{q.Name}.g.cs"), Emit.NumberExtensions(q));
}

Write(Path.Combine(libOut, "Constants.g.cs"), Emit.Constants(constants));
Write(Path.Combine(libOut, "Quantities.g.cs"), Emit.Catalog(quantities));

// ToFast() / ToClassic() for every quantity, in its own package
var bridgeOut = Path.Combine(solution, "EngineeringUnits.Fast.Bridge", "Generated");
Recreate(bridgeOut);
Write(Path.Combine(bridgeOut, "FastBridge.g.cs"), Emit.Bridge(quantities));

// Human readable report of what was (not) transferred
var report = new StringBuilder();
report.AppendLine("# Generation report");
report.AppendLine();
report.AppendLine($"- Quantities: {quantities.Count}");
report.AppendLine($"- Units: {quantities.Sum(q => q.Units.Count)}");
report.AppendLine($"- Extra EngineeringUnits member names forwarded (e.g. Temperature.FromKelvins): {quantities.Sum(q => q.Forwarders.Count)}");
report.AppendLine($"- Member names left out because they are [Obsolete] in EngineeringUnits: {Model.ObsoleteSkipped.Count} (e.g. {string.Join(", ", Model.ObsoleteSkipped.Take(3))})");
report.AppendLine($"- Constants: {constants.Count} ({constants.Count(c => c.QuantityName is null)} as dimension-tagged UnknownUnit)");
report.AppendLine();
report.AppendLine("## Alias groups (same dimension, different names)");
foreach (var g in groups.Values.Where(g => g.Count > 1))
    report.AppendLine($"- {string.Join(", ", g.Select(q => q.Name))}");
report.AppendLine();
report.AppendLine("Implicit conversions, like in EngineeringUnits: " + string.Join(", ", quantities.SelectMany(q => quantities
    .Where(a => string.CompareOrdinal(q.Name, a.Name) < 0 && Model.HasImplicitConversion(q, a))
    .Select(a => $"{q.Name} <-> {a.Name}"))) + ". All other aliases convert explicitly.");
report.AppendLine();
report.AppendLine("## Skipped / not transferred");
foreach (var line in Model.Log)
    report.AppendLine($"- {line}");
Write(Path.Combine(solution, "GENERATION-REPORT.md"), report.ToString());

Console.WriteLine($"Generated {quantities.Count} quantities, {quantities.Sum(q => q.Units.Count)} units, {constants.Count} constants -> {libOut}");
foreach (var line in Model.Log.Where(l => l.StartsWith("WARNING")))
    Console.WriteLine(line);

static void Recreate(string dir)
{
    if (Directory.Exists(dir))
        Directory.Delete(dir, recursive: true);
    Directory.CreateDirectory(dir);
}

static void Write(string path, string text) => File.WriteAllText(path, text.Replace("\r\n", "\n"), new UTF8Encoding(false));

static string ThisFile([CallerFilePath] string path = "") => path;
