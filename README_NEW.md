[![NuGet](https://img.shields.io/nuget/v/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![License](https://img.shields.io/github/license/MadsKirkFoged/EngineeringUnits)](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/LICENSE)

# EngineeringUnits

**EngineeringUnits** is a units-of-measure library for .NET designed for **engineering, physics, and chemistry calculations**.
It is an (almost) drop-in alternative to **UnitsNet**, with a key difference:

> ✅ You can do arithmetic between *any* units and keep the result unit-safe.

---

## Why EngineeringUnits?

- ✅ **Unit-safe math**: multiply/divide/add/subtract quantities and keep the resulting unit correct.
- ✅ **Runtime unit validation**: invalid casts/assignments throw early.
- ✅ **Aliases**: multiple names can represent the same dimension (e.g., *SpecificEnergy* vs *Enthalpy*).
- ✅ **Precise conversions**: stable round-trip conversions.
- ✅ **Batteries included**: helpers (Min/Max/Average, Clamp…), currency support, and physical constants.

---

## Install

```bash
dotnet add package EngineeringUnits
```

---

## Quick start

If you already use UnitsNet, switching is usually just changing the `using`:

```csharp
// UnitsNet:
// using UnitsNet;
// using UnitsNet.Units;

using EngineeringUnits;
using EngineeringUnits.Units;
```

---

## Unit-safe engineering math

```csharp
SpecificEntropy p1 = 1.JoulePerKilogramKelvin;
MassFlow m1 = 1.KilogramPerSecond;
Temperature t2 = 10.DegreeCelsius;
Temperature t1 = 5.DegreeCelsius;

Power q = m1 * p1 * (t2 - t1);   // 5 W
```

---

## Conversion (round-trip safe)

```csharp
Length oneMeter = 1.Meter;

Length inFoot = oneMeter.ToUnit(LengthUnit.Foot);
Length backToMeter = inFoot.ToUnit(LengthUnit.Meter);

bool roundTripOk = oneMeter == backToMeter; // true
```

---

## Catch unit mistakes early

```csharp
Mass mass = 10.Kilogram;
Volume volume = 4.CubicMeter;

Density d1 = mass / volume;   // 2.5 kg/m³

// This will fail when you try to treat m³/kg as Density:
Density d2 = volume / mass;   // WrongUnitException (unit mismatch)
```

---

## Creating quantities

```csharp
// Factory
Length length1 = Length.FromYard(1);

// Constructor
Length length2 = new Length(1, LengthUnit.Yard);

// Number extensions (if you added the extension namespace)
Length length3 = 1.Yard;
```

---

## Exporting values (edge of your system)

A good pattern is: **keep units inside your domain**, export primitive values at boundaries only.

```csharp
Speed drivingSpeed = Speed.FromKilometerPerHour(60);

double mph = drivingSpeed.As(SpeedUnit.MilePerHour); // 37.28227...

string display1 = drivingSpeed.ToString();                               // "60 km/h"
string display2 = drivingSpeed.ToUnit(SpeedUnit.MilePerHour).ToString(); // "37.28 mph"
```

> Tip: Use `.AsSI` when you want the SI base value as `decimal`.

---

## Useful helpers

### Absolute value

```csharp
MassFlow m1 = MassFlow.FromKilogramPerSecond(-10); // -10 kg/s
MassFlow m2 = m1.Abs();                            //  10 kg/s
```

### Min / Max / Average / Sum

```csharp
Length l1 = Length.FromMeter(5);
Length l2 = Length.FromMeter(15);

Length min = (l1, l2).Min();
Length avg = (l1, l2).Average();

var list = new List<Length> { l1, l2 };
Length max = list.Max();
```

### Pow / Sqrt

```csharp
Length l1 = new Length(54.3, LengthUnit.Foot);
Area a1 = l1.Pow(2);
Length l2 = a1.Sqrt();
```

### Clamp / Limits

```csharp
Power min = Power.FromWatt(-5);
Power max = Power.FromWatt(5);

Power p = Power.FromWatt(19).Clamp(min, max);   // 5 W
Power q = Power.FromWatt(-19).Clamp(min, max);  // -5 W
```

---

## Serialization (APIs / storage)

### Recommended for APIs: serialize the quantity (value + unit)

```csharp
Length l = new(1d, LengthUnit.Meter);

string json = JsonConvert.SerializeObject(l);
Length back = JsonConvert.DeserializeObject<Length>(json);
```

### Recommended for DB: store `value` + `unitName`

```csharp
double? value = 10;
string unit = "Meter";

Length length = value.AddUnit<LengthUnit>(unit);
```

---

## Currency support

```csharp
// Update the currency rate (e.g., EUR -> USD) 1.19
ExchangeRates.UpdateRate(Currency.Euro, 1.19m);

Cost price = Cost.FromMillionUSDollar(10);
Length road = Length.FromKilometer(10);

LengthCost pricePerLength = price / road; // 1000 $/m
LengthCost euros = pricePerLength.ToUnit(LengthCostUnit.EuroPerMeter); // 840.3 €/m
```

---

## Physical constants

EngineeringUnits includes a growing list of physical constants under `Constants`.

```csharp
Energy e = Mass.FromKilogram(1) * Constants.SpeedOfLight.Pow(2); // ~8.99e16 J
```

<details>
<summary><b>List of constants currently included</b></summary>

```text
Mechanics / Gravitation
- GravitationalConstant
- StandardGravity
- SpeedOfLight

Quantum / Fundamental
- PlanckConstant
- ReducedPlanckConstant

Electromagnetism
- VacuumElectricPermittivity
- VacuumMagneticPermeability
- ImpedanceOfFreeSpace
- CoulombConstant

Electricity / Quantum electrical standards
- ElementaryCharge
- ConductanceQuantum
- InverseConductanceQuantum
- JosephsonConstant
- VonKlitzingConstant
- MagneticFluxQuantum

Thermodynamics / Statistical mechanics
- BoltzmannConstant
- IdealGasConstant
- StefanBoltzmannConstant
- FirstRadiationConstant
- FirstRadiationConstantForSpectralRadiance
- SecondRadiationConstant
- WienWavelengthDisplacementLawConstant
- WienFrequencyDisplacementLawConstant
- WienEntropyDisplacementLawConstant

Chemistry / Molar constants
- AvogadroConstant
- FaradayConstant
- AtomicMassConstant
- MolarMassConstant
- MolarMassOfCarbon12
- MolarPlanckConstant

Atomic / Particle / Radiation physics
- ElectronMass
- ProtonMass
- NeutronMass
- BohrRadius
- ClassicalElectronRadius
- ThomsonCrossSection
- HartreeEnergy
- RydbergConstant
- QuantumOfCirculation
- FermiCouplingConstant

Magnetons
- BohrMagneton
- NuclearMagneton

Dimensionless / Ratios
- FineStructureConstant
- InverseFineStructureConstant
- ElectronGFactor
- WToZMassRatio
- WeakMixingAngle

Metrology / Reference values
- StandardAtmosphere
- StandardStatePressure
- ElectronVoltInJoules
- LuminousEfficacy540THz
- Cesium133HyperfineTransitionFrequency
```

</details>

---

## Performance

For most users, EngineeringUnits performance is more than sufficient.
If you need maximum speed in a hot loop, you can:
1) work in SI units, and/or
2) temporarily convert to primitive values, compute, then convert back.

```csharp
Power p = Power.FromSI(10);
Length l = Length.FromSI(2);
Temperature t = Temperature.FromSI(4);

double pSI = (double)p.AsSI;
double lSI = (double)l.AsSI;
double tSI = (double)t.AsSI;

double resultSI = 0;

for (int i = 0; i < 1_000_000_000; i++)
{
    resultSI = pSI / (lSI * tSI);
}

ThermalConductivity result = ThermalConductivity.FromSI(resultSI);
```

---

## Documentation / Custom units

- Add your own units: see the wiki
  https://github.com/MadsKirkFoged/EngineeringUnits/wiki/Costume-units

---

## Contributing

Contributions are welcome!
The most helpful contributions are:
- real-world example snippets (engineering, physics, chemistry)
- bug reports with minimal repro
- unit additions + tests

Open an issue and show how you use EngineeringUnits:
https://github.com/MadsKirkFoged/EngineeringUnits/issues

---

## License

MIT — see [LICENSE](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/LICENSE)
