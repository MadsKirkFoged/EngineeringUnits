# Analyzer wiring fixtures

Real projects that `AnalyzerWiringTests` builds with `dotnet build` to prove the analyzer runs where users use the library.
They are not in the solution. Each compiles clean, and has a unit mistake behind `#if MISTAKE`.

- `Direct`: ProjectReference to EngineeringUnits.Fast
- `Transitive`: ProjectReference to `Library`, which references EngineeringUnits.Fast
