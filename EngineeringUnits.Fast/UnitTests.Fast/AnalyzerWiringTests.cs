using EngineeringUnits.Fast;
using System.Diagnostics;
using System.Text;

namespace UnitTests.Fast;

/// <summary>
/// The analyzer tests prove the RULES work. These prove the analyzer actually RUNS where people use the library - by building
/// real projects with dotnet build. Fast has no runtime unit checks, so a project that silently builds without the analyzer
/// has no unit safety at all. (That happened: a plain ProjectReference to EngineeringUnits.Fast used to bring no analyzer.)
/// </summary>
[TestClass]
[TestCategory("Integration")]
public class AnalyzerWiringTests
{
    private static readonly string FastDir = FindFastDir();
    private static readonly string Fixtures = Path.Combine(FastDir, "WiringFixtures");

    [TestMethod]
    [DataRow("Direct")]
    [DataRow("Transitive")]
    public void ProjectReference_CleanCodeBuilds(string fixture)
    {
        var result = Build(Path.Combine(Fixtures, fixture));
        Assert.AreEqual(0, result.ExitCode, result.Output);
    }

    [TestMethod]
    [DataRow("Direct", "Program.cs(12,")]
    [DataRow("Transitive", "Program.cs(8,")]
    public void ProjectReference_UnitMistakeFailsTheBuild(string fixture, string location)
    {
        var result = Build(Path.Combine(Fixtures, fixture), env: ("FAST_FIXTURE_MISTAKE", "true"));

        Assert.AreNotEqual(0, result.ExitCode, "A unit mistake compiled - the analyzer did not run:\n" + result.Output);
        StringAssert.Contains(result.Output, location);
        StringAssert.Contains(result.Output, "error EUF0001");
    }

    [TestMethod]
    [DataRow("-p:RunAnalyzers=false")]
    [DataRow("-p:RunAnalyzersDuringBuild=false")]
    public void ProjectReference_AnalyzersSwitchedOff_FailsTheBuild(string property)
    {
        var result = Build(Path.Combine(Fixtures, "Direct"), property);

        Assert.AreNotEqual(0, result.ExitCode, result.Output);
        StringAssert.Contains(result.Output, "error EUF1000");
    }

    [TestMethod]
    public void ProjectReference_OptOutIsExplicit()
    {
        var result = Build(Path.Combine(Fixtures, "Direct"), "-p:RunAnalyzers=false", "-p:EngineeringUnitsFastAllowNoAnalyzer=true");
        Assert.AreEqual(0, result.ExitCode, result.Output);
    }

    /// <summary>What a NuGet user gets: pack the library, install it in a project outside this repo, build.</summary>
    [TestMethod]
    public void Package_UnitMistakeFailsTheBuild_AndAnalyzersCantBeSwitchedOff()
    {
        var work = Directory.CreateTempSubdirectory("eufast-wiring-");
        try
        {
            var feed = Directory.CreateDirectory(Path.Combine(work.FullName, "feed")).FullName;
            var version = "0.0.0-wiring" + DateTime.UtcNow.Ticks;

            var pack = Run(Path.Combine(FastDir, "EngineeringUnits.Fast"), "pack", "-nologo", "-v", "q", "-o", feed, $"-p:PackageVersion={version}");
            Assert.AreEqual(0, pack.ExitCode, pack.Output);

            var consumer = Directory.CreateDirectory(Path.Combine(work.FullName, "consumer")).FullName;
            File.WriteAllText(Path.Combine(consumer, "nuget.config"), $"""
                <?xml version="1.0" encoding="utf-8"?>
                <configuration>
                  <packageSources>
                    <clear />
                    <add key="feed" value="{feed}" />
                  </packageSources>
                </configuration>
                """);
            File.WriteAllText(Path.Combine(consumer, "Consumer.csproj"), $"""
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net10.0</TargetFramework>
                    <Nullable>enable</Nullable>
                    <RestorePackagesPath>{Path.Combine(work.FullName, "packages")}</RestorePackagesPath>
                    <DefineConstants Condition="'$(FAST_FIXTURE_MISTAKE)' == 'true'">$(DefineConstants);MISTAKE</DefineConstants>
                  </PropertyGroup>
                  <ItemGroup>
                    <PackageReference Include="EngineeringUnits.Fast" Version="{version}" />
                  </ItemGroup>
                </Project>
                """);
            File.WriteAllText(Path.Combine(consumer, "Calc.cs"), """
                using EngineeringUnits.Fast;

                public static class Calc
                {
                    public static Power Heat(MassFlow m, Enthalpy h) => m * h;
                #if MISTAKE
                    public static Power Wrong(MassFlow m) => m * m;
                #endif
                }
                """);

            var clean = Build(consumer);
            Assert.AreEqual(0, clean.ExitCode, clean.Output);

            var mistake = Build(consumer, env: ("FAST_FIXTURE_MISTAKE", "true"));
            Assert.AreNotEqual(0, mistake.ExitCode, "A unit mistake compiled from the package - the analyzer did not run:\n" + mistake.Output);
            StringAssert.Contains(mistake.Output, "error EUF0001");

            var off = Build(consumer, "-p:RunAnalyzers=false");
            Assert.AreNotEqual(0, off.ExitCode, off.Output);
            StringAssert.Contains(off.Output, "error EUF1000");
        }
        finally
        {
            try { work.Delete(recursive: true); } catch (IOException) { } catch (UnauthorizedAccessException) { }
        }
    }

    // --no-incremental: an up-to-date check must never hide a missing analyzer
    private static (int ExitCode, string Output) Build(string projectDir, params string[] extra)
        => Build(projectDir, null, extra);

    private static (int ExitCode, string Output) Build(string projectDir, (string Name, string Value)? env, params string[] extra)
        => Run(projectDir, ["build", "-nologo", "-v", "q", "--no-incremental", "-nodeReuse:false", .. extra], env);

    private static (int ExitCode, string Output) Run(string workingDir, params string[] args) => Run(workingDir, args, null);

    private static (int ExitCode, string Output) Run(string workingDir, string[] args, (string Name, string Value)? env)
    {
        var psi = new ProcessStartInfo("dotnet")
        {
            WorkingDirectory = workingDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        };
        foreach (var a in args)
            psi.ArgumentList.Add(a);

        // Don't inherit the test run's MSBuild state
        psi.Environment.Remove("MSBuildExtensionsPath");
        psi.Environment.Remove("MSBUILD_EXE_PATH");
        psi.Environment.Remove("MSBuildSDKsPath");
        if (env is { } e)
            psi.Environment[e.Name] = e.Value;

        using var p = Process.Start(psi)!;
        var output = new StringBuilder();
        p.OutputDataReceived += (_, d) => { if (d.Data is not null) lock (output) output.AppendLine(d.Data); };
        p.ErrorDataReceived += (_, d) => { if (d.Data is not null) lock (output) output.AppendLine(d.Data); };
        p.BeginOutputReadLine();
        p.BeginErrorReadLine();

        if (!p.WaitForExit(TimeSpan.FromMinutes(5)))
        {
            p.Kill(entireProcessTree: true);
            Assert.Fail($"dotnet {string.Join(' ', args)} timed out");
        }
        p.WaitForExit();
        return (p.ExitCode, output.ToString());
    }

    // The EngineeringUnits.Fast folder: the one that holds WiringFixtures/
    private static string FindFastDir()
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
        {
            if (Directory.Exists(Path.Combine(dir.FullName, "WiringFixtures")))
                return dir.FullName;
        }
        throw new InvalidOperationException("WiringFixtures not found above " + AppContext.BaseDirectory);
    }
}
