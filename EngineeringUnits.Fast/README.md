# EngineeringUnits.Fast (experimental)

A struct-based clone of EngineeringUnits. Every quantity is a `readonly struct` holding **one `double` in SI units**. There is no unit
information at runtime at all. Unit safety comes only from the compiler and the bundled **fail-closed Roslyn analyzer**.

```C#
MassFlow m = MassFlow.FromKilogramPerSecond(2);
SpecificEntropy cp = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
Temperature tIn = Temperature.FromDegreeCelsius(10), tOut = Temperature.FromDegreeCelsius(35);

Power q = m * cp * (tOut - tIn);      // 209 kW - compiles to three vmulsd/vsubsd instructions
Power wrong = m * cp;                 // error EUF0001: This is NOT a [m²*kg/s³] as expected, your unit is a [m²*kg/s³/K]
var bad = m + cp;                     // compiler error: the types don't add up
```

The speed is the same as raw doubles, and the checking still happens at compile time. What you give up for that is listed below.

---

## Speed

BenchmarkDotNet, .NET 10, same machine, nothing else running. See `Benchmark.Fast`.

| Benchmark | raw `double` | **Fast** | EngineeringUnits |
|---|---|---|---|
| `Q = ṁ·cp·(T2−T1)` summed over 10,000 elements | 13.9 µs | **14.1 µs (1.01×), 0 B** | 467 µs (33.6×), 3.2 MB allocated |
| `((m1 * (h2 - h1)) + P2) / P3` | 0.3 ns | **0.4 ns, 0 B** | 39–46 ns, 256 B |
| 12.345 ft → inch (`FromFoot(x).Inch`) | 0.5 ns | **0.3 ns, 0 B** (1.1 ns via `From(x, unit).As(unit)`) | 289 ns, 64 B |
| 21.5 °C → °F | – | **< 0.1 ns, 0 B** | 432 ns, 64 B |

Anything under about 1 ns is below timer resolution: the JIT folds the constant factors, the same as it does for raw doubles. The loop is the
meaningful number. Its JIT output is the same as for raw doubles (122 vs 114 bytes of code): every operator is inlined and the structs
live in `xmm` registers.

---

## How it works

| Piece | What it does |
|---|---|
| `Power`, `Length`, ... (103 structs) | `readonly struct` with a single `double`. Same names, units and `FromX` / `.X` members as EngineeringUnits. |
| `UnknownUnit` | Result of mixed arithmetic (`m * h`). A double whose dimension is known only to the analyzer. |
| `EngineeringUnits.Analyzers.Fast` | Works out the dimension of every expression at compile time. Reports an **error** whenever it can't prove it. |
| `CodeGen.Fast` | Generates all structs from the EngineeringUnits assembly by reflection: dimensions, units, exact factors, symbols, constants. |

### Operators without an N² table
Structs have no base class, so there is no `BaseUnit` to host shared operators, and C# only looks for operators on the two operand
types. Each struct `T` therefore declares:

- `T ± T → T`, `T ± UnknownUnit → T`, `UnknownUnit ± T → T`
- `T * UnknownUnit → UnknownUnit` and `T / UnknownUnit → UnknownUnit` with **T on the left only**. Every other quantity converts implicitly to `UnknownUnit`, so
  `Power * Length` has exactly one candidate. That keeps it linear (~90 operators per type) and never ambiguous.
- `T * double`, `double * T`, `T / double → T` and `double / T → UnknownUnit`
- comparisons, and explicit nullable overloads (the lifted ones alone are ambiguous)
- `implicit T(UnknownUnit)` (free at runtime, checked by EUF0001) and `implicit UnknownUnit(T)`
- for aliases (same dimension, e.g. `Enthalpy`/`SpecificEnergy`): `+ - == <` between them, plus an **explicit** conversion. Dimensionless quantities (Angle, Information, Ratio, ...) get none, because they are unrelated.

As a side effect, `Length + Mass` and `Length == Mass` are compile errors from C# itself (CS0034/CS9342), before the analyzer runs.

---

## Analyzer rules

All rules are **errors**, except the EUF0009 info. EUF0001–EUF0006 do what EU0001–EU0006 do in EngineeringUnits. EUF0007–EUF0009 are new.

| Rule | Meaning |
|---|---|
| EUF0001 | `Power q = m * cp;`: the dimension doesn't match the target. Also checks `q *= length`, arguments, returns and `[UnitDimension]` members. |
| EUF0002 | `length + m * h`, and **`q += x` / `q -= x`**. Compound assignment is not checked by the EngineeringUnits analyzer today. |
| EUF0003 | `power > m * cp`, `==`, and `a.Equals(b)` / `a.CompareTo(b)` with different units |
| EUF0004 | `(double)(length / time)`: only dimensionless values become numbers |
| EUF0005 | `[SameDimension]` arguments differ, e.g. `UnitMath.Max(a, b)` |
| EUF0006 | `volume.Sqrt()`: the result would have fractional units |
| **EUF0007** | **Can't verify the unit.** The analyzer couldn't follow a value, and with no runtime check that has to be an error. The message says why. |
| **EUF0008** | `dynamic` hides the unit from the analyzer |
| **EUF0009** | *Info, not an error.* An EngineeringUnits quantity is converted implicitly to Fast here (see "Moving over one project at a time"). Set `dotnet_diagnostic.EUF0009.severity = warning` in `.editorconfig` to list every place that still takes EngineeringUnits values. |
| **EUF1000** | Build error (MSBuild, not the analyzer): analyzers are switched off (`RunAnalyzers=false` / `RunAnalyzersDuringBuild=false`) in a project that uses Fast. Opt out explicitly with `EngineeringUnitsFastAllowNoAnalyzer=true`. |

The analyzer also runs on generated code (`*.g.cs`, `<auto-generated>`), unlike the EngineeringUnits analyzer, because there is nothing
behind it to catch what it skips.

### How the analyzer gets into your build

Nothing checks units if the analyzer isn't loaded, so it must reach every project that uses Fast:

| You use Fast via | Analyzer comes from |
|---|---|
| NuGet `PackageReference` (also App → Lib → package) | the package: `analyzers/dotnet/cs` + guard in `build/` and `buildTransitive/` |
| `ProjectReference` inside this folder (also App → Lib → EngineeringUnits.Fast) | `Directory.Build.targets`, which adds the analyzer and the guard to every project that references the library, directly or transitively |
| `ProjectReference` from **outside** this folder | ⚠️ nothing, because ProjectReferences don't carry analyzers. Add `<ProjectReference Include="...\EngineeringUnits.Analyzers.Fast.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />` yourself, or use the package. |

**Verified by real builds, not just in-memory tests:** `AnalyzerWiringTests` runs `dotnet build` on the projects in `WiringFixtures/`
(direct and transitive ProjectReference) and on a freshly packed `.nupkg` installed in a project outside the repo. Each builds clean
code, fails with EUF0001 on a unit mistake, and fails with EUF1000 when analyzers are switched off. This caught two real bugs: a
ProjectReference brought no analyzer at all, and the guard was packed one folder too deep. **Cost:** on 14,000 lines of equation code
(1,000 methods), the analyzer took 0.155 s in total, and the build took 5.57 s with it vs 5.52 s without. It raised no false positives on that code.

### Writing code that passes EUF0007

Keep `UnknownUnit` inside expressions and locals, and use a named quantity wherever a value is stored.

```C#
var x = m * cp;                 // OK: locals are tracked, every write must have the same unit
Power q = x * (tOut - tIn);     // OK

x = x * (tOut - tIn);           // the local now changes unit...
Power p = x;                    // EUF0007: 'x' is assigned values with different units - use one typed variable per unit
```

The analyzer follows locals (including writes from lambdas and local functions), `?:`, `switch`, `??`, boxing within a method,
`Abs/Sqrt/Pow` with a constant power, and `[SameDimension]`/`[DimensionOf]` methods. It **rejects** an `UnknownUnit` that comes from:
a field, property, parameter or method return; a lambda result; a collection or LINQ; a tuple item or deconstruction; `foreach`;
patterns; `out`/`ref`; `default`/`new UnknownUnit()`; a loop that changes the unit; `Pow(n)` with a non-constant `n`.

When an `UnknownUnit` really has to cross a boundary, give it a dimension. The analyzer checks every write and trusts every read:

```C#
[UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
private UnknownUnit _heat;                        // writes checked, reads trusted

[return: UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
static UnknownUnit Heat(MassFlow m, Enthalpy h) => m * h;   // returns checked, call sites trusted
```

`ref`/`out` of such a member and deconstruction into it are handled too (checked, or rejected).

---

## What transferred

| Feature | Status |
|---|---|
| 103 quantities, 1,352 units | ✅ All non-obsolete quantities, also the ones without `[UnitDimension]` in EngineeringUnits (`Level`, `Dimensionless`, `ApparentEnergy`: their dimension is read from their SI unit). Units are generated from the original's exact fractions, and every unit is tested against the original's exact path to within 1e-12. |
| `FromX(double)`, `.X`, `new T(v, unit)`, `From`, `As(unit)` | ✅ |
| The original's other current member names (`FromKelvins`, ...) | ✅ forwarded. The generator calls each original member and finds the unit it gives **by value**. |
| `1.5.Kilowatt` number extensions | ✅ (C# 14 extension properties, `double` and `int`) |
| Unit-safe `+ - * /`, comparisons | ✅ checked at compile time |
| Temperature offsets (°C, °F) | ✅ same results as EngineeringUnits (21 °C + 10 °C = 304.15 °C in both) |
| Aliases (Enthalpy/SpecificEnergy, Torque/Energy, ...) | ✅ 12 alias groups: `+ - ==` between them. The 3 pairs EngineeringUnits converts **implicitly** (Enthalpy ↔ SpecificEnergy, SpecificEntropy ↔ SpecificHeatCapacity, Dimensionless ↔ Ratio) are implicit here too (read from the original by reflection). All others (Torque/Energy, ...) need an explicit cast. Angle/Information/Ratio/... stay apart (go through `UnknownUnit` if you mean it). |
| `Abs`, `Clamp`, `Min`, `Max`, `Sum`, `Average`, `Pow`, `Sqrt` | ✅ `Pow`/`Sqrt` keep the unit checked. `Clamp` behaves like the original: swapped limits return the value, and a null limit means no limit. |
| `IsZero`, `IsNotZero`, `IsAboveZero`, `IsBelowZero`, `HasValue`, `HasNoValue`, `IfNullSetToZero`, `LowerLimitAt`, `UpperLimitAt`, `RoundTo`, `CeilingTo`, `FloorTo` | ✅ same names; results tested against EngineeringUnits |
| `RoundToNearest`, `RoundUpToNearest`, `RoundDownToNearest` (standard sizes) | ✅ tested against EngineeringUnits. Also on `T?` lists and values, with the original's rules: null when the value is null, the list is empty or it holds a null. |
| `value.AddUnit<PowerUnit>("Kilowatt")`, `UnitTypebase.GetUnitByString<T>(name)`, `ListOf<T>()` | ✅ a lookup by unit **name** (not the text parser), for `double`, `double?`, `int`, `int?`. All 1,300+ unit names give the same value as EngineeringUnits (tested). Unknown names throw the original's message. The analyzer knows the result is a `PowerUnit` value. |
| `PipeSize.DNValve`, the DN → outside diameter and pipe schedule tables | ✅ copied from EngineeringUnits. The schedule is a parameter (`GetWallThickness(PipeScheduleEnum.SCH_40)`), because a `PipeSize` here can't carry the settable `PipeSchedule` property. |
| `Duration` ↔ `TimeSpan`, `DateTime ± Duration`, `AmountOfSubstance.FromMass`/`NumberOfParticles`, `(double)ratio` / `(Ratio)0.5` | ✅ the original's hand-written extras |
| `ConvertToSI()`, `ToString(CultureInfo)`, `ToString("V4")` on quantities, `UnknownUnit` and their nullable forms | ✅ (`ConvertToSI()` returns the same value, as it is always SI) |
| `UnitMath.LinearInterpolation`, `Mean` (median), `(a, b).Min()` / `Max` / `Sum` / `Average` / `Mean` for 2–6 values | ✅ tested against EngineeringUnits. Generic, so the result is a named quantity again. |
| `AngleMath` `Sin`/`Cos`/`Tan`/`Sinh`/`Cosh`/`Tanh`, `Area.FromCircleDiameter`/`Radius` | ✅ same signatures, including `double?` |
| `1 - ratio` (number ± dimensionless quantity) | ✅ checked: `1 - length / time` is EUF0002 |
| Nullable quantities: `Temperature? t; t.Kelvin`, `t.As(unit)`, `t.Abs()`, `t.IsZero()`, `t.Pow(2)` | ✅ like EngineeringUnits' nullable class: reading a value from null throws, and helpers pass null through. They also work in files **without** `using EngineeringUnits.Fast;` (`db.Input.Pressure!.Bar` on a property from another project): in EngineeringUnits they are instance members, so these extension members live in the global namespace, which is always in scope. |
| `FromX(double?)`, `From(double?, unit)`, `FromSI(double?)` | ✅ null in, null out |
| `Temperature.FromSI(x)` inside a class with a `Temperature? Temperature` property | ✅ (hidden compatibility members, see "The using swap") |
| Unit of an alias: `cp.As(SpecificHeatCapacityUnit.JoulePerKilogramDegreeCelsius)` on a `SpecificEntropy` | ✅ |
| `x.ToUnit(unit)` for display (`$"...{p.ToUnit(PressureUnit.Bar)}..."`) | ✅ same text as EngineeringUnits, including the `S2`/`V4` formats. It returns a display wrapper that converts back to the quantity. |
| `x.AsSI` | ✅ on named quantities (a `double`, not a `decimal`). An `UnknownUnit` has none (a compile error), because it would hand out an unchecked number. |
| `UnitTypebase` as "any unit" | ✅ same name as in EngineeringUnits (Fast's unit base class) |
| A value plus a unit chosen at runtime (e.g. a report line that stores both) | ✅ `unknown.ToUnit(someUnit)` prints in that unit. Put `[SameDimension]` on the constructor's value and unit parameters and the analyzer checks every `new X(value, unit)` at compile time. Unit classes carry `[UnitDimension]` for this. |
| Newtonsoft.Json | ✅ with no registration and no extra package: a TypeConverter writes `"298.15 K"` and reads it back. Wrong data throws. Without it, Newtonsoft silently read every value back as **zero** (25 °C became −273.15 °C). |
| `ToString()` / `"S4"`, `"V4"`, `"A"`, .NET formats | ✅ port of the original formatter; default output matches the original for all 103 quantities |
| `ToString(unit)` | ✅ prints the unit you asked for (see differences) |
| Physical constants | ✅ all 52. Constants without a named quantity are dimension-tagged `UnknownUnit` (e.g. `GravitationalConstant`). |
| JSON (System.Text.Json) | ✅ `{"Value":1500,"Unit":"W"}`. It also reads other units of the quantity by exact symbol and **rejects a wrong unit on read**. A symbol that two units share (`hm³`) is rejected as ambiguous. |
| Nullable (`Power?`) | ✅ arithmetic and comparisons work, including `== null` |
| Generic math | ✅ `IAdditionOperators`, `IComparisonOperators`, `IMultiplyOperators<T,double,T>`, ... plus `IQuantity<T>.FromSI` |
| USD cost units ($, M$) | ✅ |
| Target framework | net10.0 only, no package dependencies. The analyzer is netstandard2.0 because Roslyn only loads analyzers built for it. |

## What did NOT transfer, or behaves differently

| Item | Why |
|---|---|
| **No safety without the analyzer** | If the analyzer doesn't run, nothing is checked and wrong units run silently. That happens with `RunAnalyzers=false`, a `#pragma`/`.editorconfig` suppression, compilers older than Roslyn 4.8 (VS 17.8 / .NET 8 SDK), F#/VB callers, reflection, and `Unsafe.As`. EngineeringUnits would throw in all of these. |
| Parsing: `Parse`/`TryParse`, `UnknownUnit.Parse`, `Eval`, `"1.5 kW"` in JSON | ❌ Removed. Create values with `FromX(double)` or `From(value, unit)`. `UnknownUnit.Parse`/`Eval` could not be done anyway: there is no runtime dimension to put the result in. |
| Interop with EngineeringUnits (`ToFast()` / `ToEngineeringUnits()`) | ❌ Removed. Convert at the boundary with `Fast.Power.FromSI(p.As(PowerUnit.SI))`. |
| netstandard2.0 / net8.0, C# below 14 | ❌ net10.0 only, and consumers need C# 14 (the net10.0 default). Remove any `<LangVersion>` pin. |
| Values that remember their unit | Storage is always SI. `x.ToUnit(PressureUnit.Bar)` returns a display wrapper (`QuantityInUnit<T>`): `$"{p.ToUnit(PressureUnit.Bar)}"` prints `"2 bar"` exactly like EngineeringUnits (tested), and it converts back to the quantity. It compares by value, so `Max`/`Min`/`OrderBy` over `ToUnit(...)` work as before. Math on it is a compile error, so convert first. |
| `UnknownUnit.ToString()` | Prints `6 [?]`. The unit isn't known at runtime. |
| Exact decimal / Fraction math | ❌ double only. About 10% of foot round trips (`FromFoot(x).Foot`) are 1 ulp off; EngineeringUnits gives exact results. |
| `==` across units | `==`, `!=`, `<`, `>`, `<=`, `>=` treat values within 1e-12 (relative) as equal, so `1 ft == 12 in` is **true** as in EngineeringUnits, although the doubles differ (0.3048 vs 0.30479999999999996). Close to 0 it stays exact (`1e-300 != 0`), and NaN is never equal. `Equals`, `GetHashCode` and `CompareTo` stay **exact**: a tolerance can't be hashed (`Dictionary`, `HashSet`, `Distinct`) and isn't transitive (sorting). Use `a.IsCloseTo(b, tolerance)` for a looser comparison. |
| Currency units €, £, kr (8 units) | ❌ Their factor is an exchange rate. A generated constant would be frozen at code-generation time. |
| `null` values | A struct is never null: `default` is 0, and `Power?` is `Nullable<Power>`. `Power p = someNullablePower;` needs `.Value`; C# does not allow a conversion from `T?` to `T`. `x!` does not unwrap a struct; use `x!.Value` or `x.Value`. |
| `UnknownUnit?` → quantity | Math on nullable quantities gives `UnknownUnit?`. `Speed v = nullableFlow / area;` needs `(...)!.Value`. An implicit conversion was tried and rejected: the literal `null` converts to `UnknownUnit?`, so `Power p = null;` would have compiled and thrown at runtime (the analyzer caught it). |
| `Temperature.FromX(...)` in a **static** method of a class with a `Temperature?` property | ❌ C# picks the instance property, and no library change can alter that. Write `EngineeringUnits.Fast.Temperature.FromX(...)`. |
| `BaseUnit` / `UnknownUnit` as "any quantity" parameters | ❌ No inheritance. Use generics: `void F<T>(T? value) where T : struct, IQuantity<T>`. |
| `UVector` | ❌ Not ported |
| Members marked `[Obsolete]` in EngineeringUnits (2,038 old names such as `Acceleration.FromCentimetersPerSecondSquared`) | ❌ Not carried over. Use the current name (`FromCentimeterPerSecondSquared`); the C# compiler says which member is missing. |
| `decimal` / `Fraction` constructors | ❌ `double` (and `double?`) only |
| `x is not null`, `x?.Kelvin`, `T x = null` on a **non-nullable** quantity | ❌ compile errors (CS0037, CS0023): a struct is never null. Remove the check, or make the type `T?`. |
| `.HasValue()` on a `T?` | ❌ `T?` already has a `HasValue` **property** (only checks for null), and C# picks it over any extension. Write `!x.HasNoValue()`, which is exactly the original `HasValue()` (not null, NaN or infinity). |
| A class implementing an interface with a `Length? Height { get; }` as `public Length Height => ...` | ❌ CS0738. For classes `Length` and `Length?` are the same type; for structs they are not. Declare the implementation `Length?`. |
| Fully qualified names: `EngineeringUnits.Volume.FromX(...)` | ❌ the using swap doesn't touch them. Write `EngineeringUnits.Fast.Volume` (or rely on the using). |
| `typeof(BaseUnit)` in reflection | ❌ there is no base class; test for `IQuantity` instead |
| `UnknownUnit.SI` | Internal on purpose. It would let `Power.FromSI(x.SI)` strip the unit. Use `(double)(x / Power.FromWatt(1))`, which is checked. |

## The using swap

Every Fast namespace, project and folder is its EngineeringUnits counterpart with `.Fast` added, so the swap is always "add `.Fast`":

| EngineeringUnits | EngineeringUnits.Fast |
|---|---|
| `using EngineeringUnits;` | `using EngineeringUnits.Fast;` |
| `using EngineeringUnits.Units;` | `using EngineeringUnits.Units.Fast;` |
| `using EngineeringUnits.NumberExtensions.NumberToPower;` | `using EngineeringUnits.NumberExtensions.NumberToPower.Fast;` |
| `PackageReference EngineeringUnits` | `PackageReference EngineeringUnits.Fast` (brings the analyzer) |
| `ProjectReference ...\EngineeringUnits\EngineeringUnits.csproj` | `ProjectReference ...\EngineeringUnits.Fast\EngineeringUnits.Fast\EngineeringUnits.Fast.csproj` (plus the analyzer, see above) |
| `<TargetFramework(s)>`, `<LangVersion>` | net10.0, and C# 14 or later |

**Tested on SharpFluids** (github.com/MadsKirkFoged/SharpFluids, about 10,000 lines, 83 tests):

| Step | Errors |
|---|---|
| Before these compatibility changes (only the usings swapped, plus the namespace and `UnknownUnit` patched by hand) | 94 |
| After: usings swapped, `LangVersion` pin removed | 13 in the library + 26 in the tests |
| After 35 small edits (listed below) | **0, and all 83 SharpFluids tests pass**, including its Newtonsoft JSON round trips |

The analyzer found no unit mistakes in SharpFluids. The 35 edits were of three kinds, all caused by `Temperature?` now being `Nullable<Temperature>`:

1. **`T? → T` (31 of them):** `Density d = fluid.Density;` becomes `fluid.Density!.Value`, and `Speed v = nullableFlow / area;` becomes `(nullableFlow / area)!.Value`. The same goes for tuples: `(i, Enthalpy!)` becomes `(i, Enthalpy!.Value)`.
2. **A static method in a class with same-named properties (3):** `Temperature.FromKelvins(...)` becomes `EngineeringUnits.Fast.Temperature.FromKelvins(...)`.
3. **An `UnknownUnit` "any quantity" helper that takes `null` (1 method):** rewritten as a generic method.

In instance code, `Temperature.FromSI(x)` inside a class with `public Temperature? Temperature { get; set; }` works without changes. C# resolves `Temperature` to the property there, so Fast gives `Temperature?` hidden (`[EditorBrowsable(Never)]`) copies of the static factories. They ignore the value and call `Temperature.FromSI(x)`, which is what the code meant.

Other things to know when porting:

- `UnknownUnit` fields, parameters, returns and lists → a named quantity, or `[UnitDimension]` on the `UnknownUnit`.
- A local that changes unit (`x = x * t`) → one variable per unit.
- `Torque t = energy;` → `(Torque)energy`. Only the 3 alias pairs that EngineeringUnits converts implicitly are implicit here.
- `Parse`, `UnknownUnit.Parse`/`Eval`, currencies other than USD, `decimal` inputs → keep EngineeringUnits for those, and convert at the boundary with `ToFast()`/`ToClassic()` (below).
- JSON saved by EngineeringUnits has a different shape. Old files need a one-off conversion.

**In larger applications** with many nullable quantities, most edits are `T? → T`. These edits are not mechanical: `Temperature t = row.Temperature;` quietly passed a null along in EngineeringUnits, while `.Value` throws right there. Each one is a choice between `.Value` (throw), making the target `T?`, or handling the null.

Packages built on EngineeringUnits keep using its types. Both libraries can be referenced side by side (different namespaces), but their types don't mix: convert at the boundary (below), or move that package to Fast too.

### Moving over one project at a time: conversions in EngineeringUnits

On net10.0, EngineeringUnits converts between its quantities and Fast's (all 103), so converted and unconverted code can call each
other while the rest of the code base still uses EngineeringUnits. Nothing extra to reference: EngineeringUnits' net10.0 build depends
on EngineeringUnits.Fast.

```C#
Temperature? t = refrigerant.Temperature;              // implicit: an EngineeringUnits Temperature from a package that hasn't moved
Temperature? dT = t2 - refrigerant.T_freeze;           // mixed + - < == ...: Fast's operators are used, the result is Fast
UpdateFast(refrigerant.Pressure);                      // into a Fast parameter of type Pressure?
Power q = Heat(massFlow.ToFast(), cp.ToFast(), dT.Value); // ToFast(): explicit, throws on null
EU.Power p = q.ToClassic();                            // and back: always explicit
```

**EngineeringUnits → Fast is implicit**

- **Into `T?`, so null stays null.** `Temperature t = refrigerant.Temperature;` (non-nullable) doesn't compile: that is the place to
  decide what a null means. `ToFast()` (throws on null) or `.Value` make that choice explicit.
- **One direction only.** Fast → EngineeringUnits stays `ToClassic()`. With both directions implicit, `classic - fast` would be
  ambiguous; now it always means Fast's operator.
- **Not for `*` and `/` between different quantities.** Fast multiplies a `MassFlow` by a `SpecificEntropy` through `UnknownUnit`, and
  C# applies only one user-defined conversion. `m * classicCp` needs `classicCp.ToFast()` (or `(SpecificEntropy?)classicCp`).
  For the same reason an EngineeringUnits `Enthalpy` doesn't become a Fast `SpecificEnergy?` in one step.
- **Not for extension methods.** C# doesn't convert the receiver of an extension method, so `classic.ToUnit(TemperatureUnit.Kelvin)` with
  a Fast unit needs `ToFast()` first.
- **Every use is reported as EUF0009 (info).** Raise it to a warning to list what is left.

**`ToFast()` and `ToClassic()`**

- **Fast → EngineeringUnits → Fast gives back the same bits.** `ToFast()` rounds the exact SI value once to the nearest double. A value
  in another unit (feet, °C, €) is converted to SI along EngineeringUnits' exact path, not `As()` (see finding 1 below). `ToClassic()`
  gives the shortest decimal that rounds back to the same double: `0.1` arrives as `0.1m`, and Fast's `0.1 + 0.2` as
  `0.30000000000000004m`, not `0.3m`. So the round trip keeps the bits, NaN and ±∞ included. Except for digits beyond decimal's 28
  decimal places (only values below 1e-12 can have them): they are rounded off (`1e-30` becomes 0), as for any value given to EngineeringUnits.
- **A computed double crosses with all its digits.** EngineeringUnits' own double constructors keep 15 significant digits
  (`Length.FromMeter(0.1 + 0.2)` is `0.3m`), `ToClassic()` keeps all of them. So a computed Fast value is not `==` to the
  EngineeringUnits value built from the same double: `Length.FromMeter(0.1 + 0.2).ToClassic() != EU.Length.FromMeter(0.1 + 0.2)`.
  Typed values (up to 15 significant digits) arrive the same both ways.
- **Fast has no display unit.** `ToClassic()` gives the SI unit, so `3 ft` comes back as `0.9144 m`. Use `.ToUnit(...)` on the result if it's printed.
- **Named quantities only.** An `UnknownUnit` has no runtime dimension in Fast, so it can't cross. Cast it to a quantity first.
- **No using needed.** The methods live in the global namespace, like the `{T}NullableExtensions`.

**When the move is done, remove EngineeringUnits**: the compiler then lists every `ToFast()`, `ToClassic()` and implicit conversion
that is left.

Why in EngineeringUnits: a conversion operator must be declared in one of its two types, and C# 14 doesn't allow them in `extension`
blocks. Fast stays free of EngineeringUnits. EngineeringUnits' net10.0 dependency on Fast brings its analyzer but not its build files:
the EUF1000 guard doesn't reach projects that only use EngineeringUnits. A project that uses Fast should reference EngineeringUnits.Fast
itself, which brings the guard.

The `EngineeringUnits.Fast.Bridge` package (2.2.151) had `ToFast()`/`ToClassic()` before they moved here. It is retired: replace it with
a reference to EngineeringUnits.Fast. Referencing both it and a newer EngineeringUnits makes the calls ambiguous.

## Findings about EngineeringUnits along the way

Building and testing this turned up these in the original library:

1. **`As()` loses digits on very small values.** It goes through `decimal` (28 decimal places): 1 µg/day gives `1.15740741E-20`
   instead of `1.1574074074074073E-20`. The exact path (`GetValueAs`) is fine. Fast's cross-validation tests use the exact path.
2. **Duplicate symbols.** `Volume.HectocubicMeter` (100 m³) and `Volume.CubicHectometer` (10⁶ m³) are both `hm³`, and
   `KilocubicMeter`/`CubicKilometer` are both `km³`. `ToString()` can't tell them apart, and the parser reads `hm³` as (hm)³. (Fast's JSON reader rejects these symbols as ambiguous.)
3. **`ExchangeRates.UpdateRate` has no effect once `CostUnit` has been used.** The rates are read into `static readonly` fields,
   so 100 USD stays 92.1 EUR after `UpdateRate(Euro, 2)`. The README example only works if it runs first.
4. **The analyzer doesn't check `+=` / `-=`.** `q += m * cp` is only caught at runtime (EUF0002 covers it here).
5. **`ToString(unit)` sometimes prints an equivalent unit's symbol:** `1 g/mm` prints as `1 kg/m` and `1 kt·mm²` as `1 m²·kg`
   (5 units in total).
6. `BitRate`, `Information` and `PipeSize` have an all-zero `[UnitDimension]`, the same as `Ratio`, so the analyzer treats bit/s as
   dimensionless. That may be intended; worth a check.
7. **`ElectricConductance` is a copy of `Volume`**: its units are `CubicMeter`, `HectocubicMeter`, `KilocubicMeter` and its SI unit is m³,
   instead of siemens. Not transferred to Fast, because the analyzer would learn a wrong dimension.
8. **`ElectricAdmittance` is a stub**: all its constructors are commented out. Not transferred.
9. **`Level`, `Dimensionless` and `ApparentEnergy` have no `[UnitDimension]`**, so the EngineeringUnits analyzer can't check them.
   Fast reads their dimension from their SI unit.
10. **`PowerUnit.MechanicalHorsepower` is 745.69 W** instead of 745.69987158227 W (550 ft·lbf/s).

---

## Layout

```
EngineeringUnits.sln                     (repo root) the original projects and, in the solution folder EngineeringUnits.Fast, these:
EngineeringUnits.Fast/
  EngineeringUnits.Fast/                 the library (Core/ hand-written, Generated/ from CodeGen.Fast)      <- EngineeringUnits
  EngineeringUnits.Analyzers.Fast/       fail-closed analyzer (EUF0001-EUF0009), shipped inside the package  <- EngineeringUnits.Analyzers
  EngineeringUnits.Analyzers.Tests.Fast/ rule tests + a port of UnitTests/HaveToFail/UnitsAreWrong.cs     <- EngineeringUnits.Analyzers.Tests
  UnitTests.Fast/                        every unit cross-checked against EngineeringUnits + behaviour tests <- UnitTests
  CodeGen.Fast/                          regenerates Generated/ from the EngineeringUnits assembly         <- CodeGen
  Benchmark.Fast/                        Fast vs double vs EngineeringUnits                                  <- Benchmark
  Sandbox.Fast/                          scratch console app                                                 <- Sandbox
  WiringFixtures/                        real projects AnalyzerWiringTests builds to prove the analyzer is wired in
  Directory.Build.targets                gives every project here that uses Fast the analyzer + EUF1000 guard
  GENERATION-REPORT.md                   what the generator transferred and skipped
```

Regenerate after changing units in EngineeringUnits:

```bash
dotnet run --project CodeGen.Fast
```

## Tests

**Start here if you want to read them:**

| File | What it shows |
|---|---|
| `EngineeringUnits.Analyzers.Tests.Fast/EverydayMistakesTests.cs` | 26 everyday scenarios (heater, pump, pipe, car, battery, solar, bills...). Each puts the correct line next to the mistake a person would make, and the analyzer must flag exactly the mistake. Also `WhatTheAnalyzerCannotCatch`: mistakes where the units add up (absolute temperature instead of a difference, torque vs energy). |
| `UnitTests.Fast/EverydayCalculationsTests.cs` | The same scenarios with answers you can check on a calculator (2 kW for 3 h = 6 kWh, 0.1 kg/s × 4.18 kJ/kgK × 25 K = 10.45 kW, ...) |
| `EngineeringUnits.Analyzers.Tests.Fast/RandomFormulaTests.cs` | 1,000 random formulas (5 fixed seeds). They are built from the real relationships between the 100 quantities, and about half are broken the way people break them. The generator computes the right answer itself, and the analyzer must agree on every line. The test output prints a sample. A planted analyzer bug was caught every time: a silent mismatch failed 21 of 30 tests, `/` treated as `*` failed 19, and unchecked `+=` failed 6. |

One test is `[Ignore]`d on purpose: `MechanicalHorsepower_Is550FootPoundForcePerSecond`. EngineeringUnits defines 1 hp(I) as 745.69 W
instead of 745.69987158227 W, and Fast inherits that until the original is fixed.

- **UnitTests.Fast: 926 tests** (1 skipped on purpose) (8 of them are `[TestCategory("Integration")]` wiring tests that run `dotnet build`, about a minute). For all 100 quantities, it checks every unit's factor, offset, symbol and dimension against
  EngineeringUnits. It also checks that the inlined `FromX`/`.X` members are bit-identical to the unit objects, and that `ToString` matches the original. On top of that:
  the forwarded member names, JSON, constants, arithmetic compared
  with EngineeringUnits, temperature offsets, nullable operators, aliases, generic math, and documented precision limits.
  The test code itself compiles with the Fast analyzer on.
- **EngineeringUnits.Analyzers.Tests.Fast: 108 tests.** Every rule and every fail-closed path, the `[UnitDimension]` escape hatch, and
  the holes found by red-teaming it (ref/out, deconstruction, `UnknownUnit.SI`, `Equals`/`CompareTo`, property setters). It includes a port of
  `HaveToFail/UnitsAreWrong.cs`: **every case EngineeringUnits catches at runtime is caught at compile time here**, by the analyzer or by
  the C# compiler.
