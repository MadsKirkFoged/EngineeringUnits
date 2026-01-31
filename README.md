[![NuGet](https://img.shields.io/nuget/v/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![NuGet](https://img.shields.io/nuget/dt/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![License](https://img.shields.io/github/license/MadsKirkFoged/SharpFluids)](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/LICENSE)

# EngineeringUnits


This is an (almost) interchangeable version of [UnitsNet](https://github.com/angularsen/UnitsNet) which mean you just have to change the *using* if you already use [UnitsNet](https://github.com/angularsen/UnitsNet)

```C#
//using UnitsNet;
//using UnitsNet.Units;

using EngineeringUnits;
using EngineeringUnits.Units;
```



## Comparing UnitsNet and EngineeringUnits


###### :heavy_check_mark: EngineeringUnits can handle mathematical operations (+-*/) between any unit

```C#
SpecificEntropy P1 = 1.JoulePerKilogramKelvin;
MassFlow M1 = 1.KilogramPerSecond;
Temperature T2 = 10.DegreeCelsius;
Temperature T1 = 5.DegreeCelsius;

//Do any kind of equation
Power Q1 = M1 * P1 * (T2 - T1); // 5 W
```

###### :heavy_check_mark: Units can have alias. Ex *SpecificEnergy* and *Enthalpy* are the same thing and you can just choose the one you normally use.
###### :heavy_check_mark: Perfect precise when converting:
```C#
Length OneMeter = 1.Meter;
Length InFoot = OneMeter.ToUnit(LengthUnit.Foot);
Length OneMeterRoundTrip = InFoot.ToUnit(LengthUnit.Meter);

bool check = OneMeter == OneMeterRoundTrip; //true
```

###### :heavy_check_mark: Units are checked at Compile time



## Should I change from UnitsNet to EngineeringUnits?


###### :heavy_check_mark: If you are working with engineering-, physics- , chemical- equations then EngineeringUnits will make your life easier
###### :triangular_flag_on_post: If you are just making converions ( Meter -> Inch) and you dont care about the extra precision then UnitsNet and EngineeringUnits are identical.


## How to install

###### :heavy_check_mark: Nuget Package: EngineeringUnits

## Code examples

###### Get told if you mess up a calculation
```C#
Mass mass = 10.Kilogram;
Volume volume = 4.CubicMeter;

Density D1 = mass / volume; // 2.5 kg/m³
Density D2 = volume / mass; // Red line at compile time: 'This is NOT a [kg/m³] as expected! Your Unit is a [m³/kg]'
```

###### Creating a new Unit
```C#
//Different ways of creating a new unit
Length length1 = Length.FromYard(1);
Length length2 = new Length(1, LengthUnit.Yard);

// add using EngineeringUnits.NumberExtensions.NumberToLength;
Length length3 = 1.Yard;
```

###### Exporting a Unit
```C#
// The general idea is to only a the edge of your code to export unit out of the unit safety
Speed DrivingSpeed = Speed.FromKilometerPerHour(60);

double DrivingSpeedAsDouble = DrivingSpeed.As(SpeedUnit.MilePerHour); //37.282271534240039

string DefaultDisplay = DrivingSpeed.ToString(); // 60 km/h
string DefaultDisplay2 = DrivingSpeed.ToUnit(SpeedUnit.MilePerHour).ToString(); // 37.28 mph
```

###### Absolute value
```C#
MassFlow M1 = MassFlow.FromKilogramPerSecond(-10); //-10 kg/s
MassFlow M2 = M1.Abs(); //10 kg/s                   
```

###### min/max/Average/Mean/Sum value
```C#
//Following functions work in this way:
//min() max() Average() Mean() Sum()

Length L1 = Length.FromMeter(5);
Length L2 = Length.FromMeter(15);

//Recommended way
Length LMin = (L1, L2).Min(); //5m

//Obsolete way
Length LMin2 = UnitMath.Min(L1, L2); //5m

//Alternative way using a list
List<Length> List = [L1, L2];
Length LMin3 = List.Min(); //5m

//Obsolete way using a list
List<Length> List2 = new List<Length>() { L1, L2 };
Length LMin4 = List2.Min(); //5m
               
```

###### Powers and Square Roots
```C#
Length L1 = new Length(54.3, LengthUnit.Foot); //54.3 ft
Area A1 = L1.Pow(2);  //2948 ft²    
Length L2 = A1.Sqrt(); //54.3 ft               
```


Find the closed in a list
```C#
var MyList = new List<Length>
{
   Length.FromMeter(1),
   Length.FromMeter(5),
   Length.FromMeter(20),
   Length.FromMeter(44)
};

Length L1 = MyList.RoundUpToNearest(Length.FromMeter(30)); //44m
Length L2 = MyList.RoundDownToNearest(Length.FromMeter(30)); //20m
Length L3 = MyList.RoundToNearest(Length.FromMeter(4)); //5m
```

###### Clamp(min,max)
```C#
//The value is restricted (Clamp) to be inside the limits.

Power min = Power.FromWatt(-5);
Power max = Power.FromWatt(5);

Power f1 = Power.FromWatt(19);
Power f2 = f1.Clamp(min, max); //5 W

Power f3 = Power.FromWatt(-19);
Power f4 = f3.Clamp(min, max); //-5 W

Power f5 = Power.FromWatt(4);
Power f6 = f5.Clamp(min, max); //4 W

Power f7 = Power.FromWatt(-10).LowerLimitAt(min);//-5 W
Power f8 = Power.FromWatt(10).UpperLimitAt(max); //5 W

//Same as using Clamp(min, max)
Power f9 = Power.FromWatt(4).LowerLimitAt(min)
                            .UpperLimitAt(max); //4 W
```


###### Checks
```C#
var length1 = Length.FromYard(1);
var length2 = Length.FromMeter(5);

if ((length1 - length2).IsAboveZero())
if ((length1 - length2).IsBelowZero())
if ((length1 - length2).IsZero())
if ((length1 - length2).IsNotZero())
if (length1 >= length2)
if (length1 <= length2)
if (length1 == length2)
if (length1 < length2)
if (length1 > length2)

```

###### Chaining functions
```C#
//Create a list of Lenghts
List<Length> listOfLengths = [Length.FromYard(-1),
                              Length.FromYard(-2),
                              Length.FromYard(3),
                              Length.FromYard(4)];

// Chaining many functions together
Area NewUnit = listOfLengths                          // [-1,-2,3,4]
               .Select(x => x.Abs())                  // [1,2,3,4]
               .Where(x => x > Length.FromMeter(1))   // [2,3,4]
               .Average()                             // [4.5]
               .Pow(2)                                // [20.25] yr2 (turn into area!)
               .UpperLimitAt(Area.FromSquareMeter(8)) // Set the upper limit of the area to 8 m^2
               .ToUnit(AreaUnit.SquareMeter);         // Turn the area into a specific unit-type
                                                      // result: 7.525 m²

                           
```

###### How fast is EngineeringUnits?

For the average user the calculation speed of EngineeringUnits is not the bottleneck of their system.
It can calculate 10 mio equations in about ~1sec (Dependent of the size of the equation and the resources of the system..)

What if I want it to be even faster?
Declaring units as SI, gives a slight speed boost because some check can be skipped when all units are in SI
```C#
Power P2 = Power.FromSI(10);
Length L2 = Length.FromSI(2);
Temperature T2 = Temperature.FromSI(4);

ThermalConductivity TC = P2 / (L2 * T2);
```

What if I want maximum speed?

If 10mio in ~1sec is too slow for you then converting to double, do your calculations, and turn in back into Units is the way for you.
This way you only have a small part of your code where you bypass the safety features.

```C#
Power P2 = Power.FromSI(10);
Length L2 = Length.FromSI(2);
Temperature T2 = Temperature.FromSI(4);

// Unit --> double
double PowerAsSI = P2.SI;
double LengthAsSI = L2.SI;
double TemperatureAsSI = T2.SI;
double ThermalConductivityAsSI = 0;

//Solver or function where calculation speed is critical!
for (int i = 0; i < 1000000000; i++)
{
     //Doing very heavy calculation
     ThermalConductivityAsSI = PowerAsSI / (LengthAsSI * TemperatureAsSI);
}

// double --> Unit
ThermalConductivity Result = ThermalConductivity.FromSI(ThermalConductivityAsSI);
```


###### What are my options for outputting to a string?
```C#
Temperature T1 = new Temperature(10.572455, TemperatureUnit.DegreeCelsius);

//This will as standard use 4 significant digits
string Output1 = T1.ToString(); // 10.57 °C

//This will use 5 significant digits
string Output2 = T1.ToString("S5"); // 10.572 °C

//Same as ToString but looks better
string Output3 = $"{T1:S5}"; // 10.572 °C

//Same as "S4" but without the unit
string Output4 = $"{T1:V4}"; // 10.57

//Display the unit without value
string Output5 = $"{T1:UnitOnly}"; // °C

//All the normal options can still be used
//https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

//The build-in "General"
string Output6 = $"{T1:G1}"; // 1E+01 °C
string Output7 = $"{T1:G4}"; // 10.57 °C            
```
###### Working with currency 
```C#
// Update the currency (euro to usd) 1.19        
ExchangeRates.UpdateRate(Currency.Euro, 1.19m);

Cost Price = Cost.FromMillionUSDollar(10);
Length Road = Length.FromKilometer(10);

LengthCost PricePerLenght = Price / Road; // 1000 $/m
LengthCost EUROs = PricePerLenght.ToUnit(LengthCostUnit.EuroPerMeter); // 840.3 €/m
```

###### Working with physical constants
Inside Constants. is a large collection of physical constants ready to use.

```C#
//Working with physical constants
 Energy E = Mass.FromKilogram(1) * Constants.SpeedOfLight.Pow(2); // 8.988e+16 J
 ```

###### Transfer Units in APIs or store in database

Recommended way to Transfer Units between systems is to serialize/Deserialize the units
```C#
//Create new unit
Length L11 = new(1d, LengthUnit.Meter);

//Serialize it into JSON 
string L1AsJSON = JsonConvert.SerializeObject(L11);

//Deserialize from JSON
Length BackFromJSON = JsonConvert.DeserializeObject<Length>(L1AsJSON);
```

Recommended way to store single units in database
[See all the names further down the page]

```C#
//Got from database (Stored in two different cells)
double? value = 10;
string unit = "Meter";

//Put it back together
Length temp = value.AddUnit<LengthUnit>(unit);
```
###### Add you own units?
There is a guide in the [Wiki section](https://github.com/MadsKirkFoged/EngineeringUnits/wiki/Costume-units)


###### Want to contribute to making EngineeringUnits better?
We need more code examples of real users using EngineeringUnits.
Create an 'Issue' and showcase how you are using it!
This could both improve your code and help other people learn!
 

 ###### Constants that are current included
 ```C#
 Mechanics / Gravitation
GravitationalConstant — Gravitational constant G — m³·kg⁻¹·s⁻²
StandardGravity — Standard gravity g₀ — m·s⁻²
SpeedOfLight — Speed of light in vacuum c — m·s⁻¹

Quantum / Fundamental
PlanckConstant — Planck constant h — J·s
ReducedPlanckConstant — Reduced Planck constant ħ — J·s

Electromagnetism
VacuumElectricPermittivity — Vacuum permittivity ε₀ — F·m⁻¹
VacuumMagneticPermeability — Vacuum permeability μ₀ — H·m⁻¹
ImpedanceOfFreeSpace — Free-space impedance Z₀ — Ω
CoulombConstant — Coulomb constant kₑ = 1/(4π ε₀) — N·m²·C⁻²

Electricity / Quantum electrical standards
ElementaryCharge — Elementary charge e — C
ConductanceQuantum — Conductance quantum G₀ = 2e²/h — S
InverseConductanceQuantum — Inverse conductance quantum G₀⁻¹ = h/(2e²) — Ω
JosephsonConstant — Josephson constant Kⱼ = 2e/h — Hz·V⁻¹
VonKlitzingConstant — von Klitzing constant Rₖ = h/e² — Ω
MagneticFluxQuantum — Magnetic flux quantum Φ₀ = h/(2e) — Wb

Thermodynamics / Statistical mechanics
BoltzmannConstant — Boltzmann constant k — J·K⁻¹
IdealGasConstant — Molar gas constant R — J·mol⁻¹·K⁻¹
StefanBoltzmannConstant — Stefan–Boltzmann constant σ — W·m⁻²·K⁻⁴
FirstRadiationConstant — First radiation constant c₁ = 2πhc² — W·m²
FirstRadiationConstantForSpectralRadiance — First radiation constant for spectral radiance c₁L = 2hc² — W·m² 
SecondRadiationConstant — Second radiation constant c₂ = hc/k — m·K
WienWavelengthDisplacementLawConstant — Wien displacement constant b = λₘₐₓ·T — m·K
WienFrequencyDisplacementLawConstant — Wien frequency displacement constant b′ = νₘₐₓ/T — Hz·K⁻¹
WienEntropyDisplacementLawConstant — Wien entropy displacement constant — m·K

Chemistry / Amount-of-substance / Molar constants
AvogadroConstant — Avogadro constant N_A — mol⁻¹
FaradayConstant — Faraday constant F = N_A·e — C·mol⁻¹
AtomicMassConstant — Atomic mass constant u — kg
MolarMassConstant — Molar mass constant M_u — kg·mol⁻¹
MolarMassOfCarbon12 — Molar mass of carbon-12 M(¹²C) — kg·mol⁻¹
MolarPlanckConstant — Molar Planck constant N_A·h — J·s·mol⁻¹ 

Atomic / Particle / Radiation physics
ElectronMass — Electron mass mₑ — kg
ProtonMass — Proton mass mₚ — kg
NeutronMass — Neutron mass mₙ — kg
BohrRadius — Bohr radius a₀ — m
ClassicalElectronRadius — Classical electron radius rₑ — m
ThomsonCrossSection — Thomson cross section σ_T — m²
HartreeEnergy — Hartree energy E_h — J
RydbergConstant — Rydberg constant R∞ — m⁻¹
QuantumOfCirculation — Quantum of circulation κ — m²·s⁻¹
FermiCouplingConstant — Fermi coupling constant G_F — J⁻² 

Magnetons (magnetic dipole moments)
BohrMagneton — Bohr magneton μ_B — J·T⁻¹
NuclearMagneton — Nuclear magneton μ_N — J·T⁻¹

Dimensionless / Ratios
FineStructureConstant — Fine-structure constant α — dimensionless
InverseFineStructureConstant — α⁻¹ — dimensionless
ElectronGFactor — Electron g-factor gₑ — dimensionless
WToZMassRatio — W-to-Z mass ratio m_W/m_Z — dimensionless
WeakMixingAngle — Weak mixing angle (on-shell) sin²θ_W — dimensionless

Metrology / Definitions / Reference values
StandardAtmosphere — Standard atmosphere atm — Pa
StandardStatePressure — Standard-state pressure p° — Pa
ElectronVoltInJoules — Electron volt expressed in joules — J
LuminousEfficacy540THz — Luminous efficacy at 540 THz Kcd — lm·W⁻¹
Cesium133HyperfineTransitionFrequency — Caesium-133 hyperfine transition frequency ΔνCs — Hz
```

###### What units are included?
```C#
Acceleration:[m/s²], [km/s²], [m/s²], [dm/s²], [cm/s²], [µm/s²], [mm/s²], [nm/s²], [in/s²], [ft/s²], [kn/s], [kn/min], [kn/h], [g], [mg],
AreaDensity:[kg/m²], [kg/m²],
AreaMomentOfInertia:[m4], [m4], [cm4], [dm4], [mm4], [in4], [ft4],
Area:[ac], [ha], [cm²], [dm²], [km²], [m²], [µm²], [m²], [mm²], [nm²], [in²], [ft²], [yd²], [mi²], [nmi²], [ch²],
AreaCost:[$/m²], [$/m²], [M$/m²], [?/m²],
BitRate:[], [B/s], [bit/s], [Kibit/s], [Mibit/s], [Gibit/s], [Tibit/s], [Pibit/s], [Eibit/s], [KiB/s], [MiB/s], [GiB/s], [TiB/s], [PiB/s], [EiB/s], [kB/s], [MB/s], [GB/s], [TB/s], [PB/s], [EB/s], [kbit/s], [Mbit/s], [Gbit/s], [Tbit/s], [Pbit/s], [Ebit/s],
BrakeSpecificFuelConsumption:[kg/J], [kg/J], [g/kWh], [lb/hph],
Capacitance:[F], [F], [kF], [MF], [µF], [mF], [nF], [pF],
CoefficientOfThermalExpansion:[/K], [K?¹], [/°F], [/°C],
Density:[kg/m³], [cg/dl], [cg/l], [cg/ml], [dg/dl], [dg/l], [dg/ml], [dg/µl], [g/cm³], [g/m³], [g/mm³], [g/dl], [g/l], [g/ml], [g/µl], [kg/cm³], [kg/m³], [kg/mm³], [kg/l], [kip/ft³], [kip/in³], [µg/m³], [µg/dl], [µg/l], [µg/ml], [µg/µl], [mg/m³], [mg/dl], [mg/l], [mg/ml], [mg/µl], [ng/dl], [ng/l], [ng/ml], [ng/µl], [pg/dl], [pg/l], [pg/ml], [pg/µl], [lb/ft³], [lb/in³], [ppg (imp.)], [ppg (U.S.)], [slug/ft³], [t/cm³], [t/m³], [t/mm³],
DynamicViscosity:[Pa·s], [Pa·s], [µPa·s], [mPa·s], [lb/ft·s], [P], [cP], [N·s/m²], [lbf·s/ft²], [lbf·s/in²], [reyn],
ElectricChargeDensity:[C/m³], [C/m³],
ElectricCharge:[C], [C], [A-h], [kA-h], [MA-h], [mA-h],
ElectricConductivity:[S/m], [S/m], [S/in], [S/ft],
ElectricCurrentDensity:[A/m²], [A/m²], [A/in²], [A/ft²],
ElectricCurrentGradient:[A/s], [A/s], [A/µs], [A/ms], [A/ns],
ElectricField:[V/m], [V/m],
ElectricInductance:[H], [H], [µH], [mH], [nH],
ElectricPotentialChangeRate:[V/s], [V/s], [V/min], [V/µs], [V/h], [mV/s], [mV/min], [mV/µs], [mV/h], [µV/s], [µV/min], [µV/µs], [µV/h], [MV/s], [MV/min], [MV/µs], [MV/h], [kV/s], [kV/min], [kV/µs], [kV/h],
ElectricPotential:[V], [V], [kV], [MV], [GV], [µV], [mV],
MolarMass:[kg/mol], [kg/mol], [cg/mol], [dag/mol], [dg/mol], [g/mol], [hg/mol], [kip/mol], [Mlb/mol], [µg/mol], [mg/mol], [ng/mol], [lb/mol],
ElectricResistance:[O], [O], [GO], [kO], [MO], [µO], [mO],
ElectricResistivity:[O·m], [O·m], [O·cm], [kO·cm], [MO·cm], [µO·cm], [mO·cm], [nO·cm], [pO·cm], [kO·m], [MO·m], [µO·m], [mO·m], [nO·m], [pO·m],
ElectricSurfaceChargeDensity:[C/m²], [C/m²], [C/cm²], [C/in²],
Energy:[J], [mJ], [J], [kJ], [MJ], [GJ], [TJ], [BTU], [kBTU], [MBTU], [GBTU], [eV], [keV], [MeV], [GeV], [TeV], [cal], [kcal], [Mcal], [Wday], [kWday], [MWday], [GWday], [TWday], [Wh], [kWh], [MWh], [GWh], [TWh], [ft·lb], [Dth (E.C.)], [Dth (imp.)], [Dth (U.S.)], [th (E.C.)], [th (imp.)], [th (U.S.)], [erg], [hp·h],
EnergyCost:[$/J], [$/J], [$/kJ], [$/MJ], [$/GJ], [$/kWh], [$/MWh], [M$/J], [M$/kJ], [M$/MJ], [M$/GJ], [M$/kWh], [M$/MWh],
Entropy:[J/K], [J/K], [cal/K], [J/K], [kcal/K], [kJ/K], [kJ/K], [MJ/K],
ForceChangeRate:[N/s], [N/s], [N/min], [lbf/s], [lbf/min], [klbf/s], [klbf/min], [nN/s], [mN/s], [µN/s], [cN/s], [daN/s], [dN/s], [kN/s], [daN/min], [kN/min],
ForcePerLength:[N/m], [N/m], [N/cm], [N/mm], [kgf/cm], [kgf/m], [kgf/mm], [kN/cm], [kN/m], [kN/mm], [kipf/ft], [kipf/in], [MN/cm], [MN/m], [MN/mm], [µN/cm], [µN/m], [µN/mm], [mN/cm], [mN/m], [mN/mm], [lbf/ft], [lbf/in], [lbf/yd], [tf/cm], [tf/m], [tf/mm], [nN/cm], [nN/m], [nN/mm], [cN/cm], [cN/m], [cN/mm], [daN/cm], [daN/m], [daN/mm], [dN/cm], [dN/m], [dN/mm],
Force:[N], [N], [µN], [mN], [daN], [kN], [MN], [dyn], [tf], [tf (short)], [lbf], [kgf], [ozf], [kp], [kipf], [Mlbf], [pdl],
Frequency:[Hz], [Hz], [kHz], [MHz], [GHz], [THz], [s?¹], [bpm], [RPM], [RPM], [cph], [cpm], [rad/s],
FuelEfficiency:[m/m³], [km/l], [mpg (imp.)], [mpg (U.S.)],
HeatFlux:[W/m²], [W/m²], [W/in²], [W/ft²], [BTU/h·ft²], [BTU/min·ft²], [BTU/s·ft²], [BTU/s·in²], [cal/s·cm²], [kcal/h·m²], [kcal/s·cm²], [kW/m²], [µW/m²], [mW/m²], [nW/m²], [cW/m²], [dW/m²], [lbf/(ft·s)], [lb/s³],
HeatTransferCoefficient:[W/m²K], [W/m²K], [W/m²°C], [Btu/ft²hr°F],
Illuminance:[lx], [lx], [klx], [Mlx], [mlx],
Information:[], [B], [b], [Kib], [Mib], [Gib], [Tib], [Pib], [Eib], [KiB], [MiB], [GiB], [TiB], [PiB], [EiB], [kB], [MB], [GB], [TB], [PB], [EB], [kb], [Mb], [Gb], [Tb], [Pb], [Eb],
Irradiance:[W/m²], [W/m²], [W/cm²], [kW/cm²], [MW/cm²], [µW/cm²], [mW/cm²], [nW/cm²], [pW/cm²], [kW/m²], [MW/m²], [µW/m²], [mW/m²], [nW/m²], [pW/m²],
Irradiation:[J/m²], [J/m²], [J/cm²], [J/mm²], [kJ/m²], [kWh/m²], [mJ/cm²], [Wh/m²],
KinematicViscosity:[m²/s], [m²/s], [St], [cSt], [dSt], [kSt], [µSt], [mSt], [nSt],
LapseRate:[K/m], [?°C/km],
LengthCost:[$/m], [$/m], [?/m],
LinearDensity:[kg/m], [kg/m], [g/cm], [g/m], [g/mm], [kg/cm], [kg/mm], [µg/cm], [µg/m], [µg/mm], [mg/cm], [mg/m], [mg/mm], [lb/ft], [lb/in],
LinearPowerDensity:[W/m], [W/m], [W/mm], [W/in], [W/ft], [W/cm], [mW/mm], [mW/m], [mW/in], [mW/ft], [mW/cm], [MW/mm], [MW/m], [MW/in], [MW/ft], [MW/cm], [kW/mm], [kW/m], [kW/in], [kW/ft], [kW/cm], [GW/mm], [GW/m], [GW/in], [GW/ft], [GW/cm],
LuminousFlux:[Empty], [lm],
MagneticField:[T], [T], [G], [mG], [µT], [mT], [nT],
MagneticFlux:[Wb], [Wb],
Magnetization:[A/m], [A/m],
MassCost:[$/kg], [?/kg], [$/kg], [$/t], [M$/t],
MassFlow:[cg/day], [cg/s], [dag/day], [dag/s], [dg/day], [dg/s], [g/day], [g/h], [g/s], [Mg/day], [µg/s], [µg/day], [mg/s], [mg/day], [ng/s], [ng/day], [hg/day], [hg/s], [kg/s], [kg/s], [kg/min], [kg/h], [kg/day], [lb/s], [lb/min], [lb/h], [lb/day], [Mlb/day], [Mlb/h], [Mlb/min], [Mlb/s], [short tn/h], [t/day], [t/h],
MassFlux:[kg/sm²], [kg/sm²], [g/hcm²], [g/hm²], [g/hmm²], [g/scm²], [g/sm²], [g/smm²], [kg/hcm²], [kg/hm²], [kg/hmm²], [kg/scm²], [kg/smm²],
MassMomentOfInertia:[kgm²], [kgm²], [gcm²], [gdm²], [gm²], [gmm²], [kgcm²], [kgdm²], [kgmm²], [ktcm²], [ktdm²], [ktm²], [ktmm²], [Mtcm²], [Mtdm²], [Mtm²], [Mtmm²], [mgcm²], [mgdm²], [mgm²], [mgmm²], [lbft²], [lbin²], [slugft²], [slugin²], [tcm²], [tdm²], [tm²], [tmm²],
MolarEnergy:[J/mol], [J/mol], [kJ/mol], [MJ/mol],
MolarEntropy:[J/(mol·K)], [J/(mol·K)], [kJ/(mol·K)], [MJ/(mol·K)],
Molarity:[mol/m³], [mol/m³], [mol/l], [nmol/l], [pmol/l], [cmol/l], [dmol/l], [µmol/l], [mmol/l],
Permeability:[H/m], [H/m],
Permittivity:[F/m], [F/m],
PowerDensity:[W/m³], [W/m³], [W/l], [W/in³], [W/ft³], [TW/l], [TW/m³], [TW/in³], [TW/ft³], [pW/l], [pW/m³], [pW/in³], [pW/ft³], [nW/l], [nW/m³], [nW/in³], [nW/ft³], [mW/l], [mW/m³], [mW/in³], [mW/ft³], [µW/l], [µW/m³], [µW/in³], [µW/ft³], [MW/l], [MW/m³], [MW/in³], [MW/ft³], [kW/l], [kW/m³], [kW/in³], [kW/ft³], [GW/l], [GW/m³], [GW/in³], [GW/ft³], [dW/l], [dW/m³], [dW/in³], [dW/ft³], [daW/l], [daW/m³], [daW/in³], [daW/ft³],
Power:[W], [fW], [pW], [nW], [µW], [mW], [dW], [W], [daW], [kW], [MW], [GW], [TW], [PW], [mJ/h], [J/h], [kJ/h], [MJ/h], [GJ/h], [BTU/h], [BTU/min], [BTU/s], [kBTU/h], [hp(S)], [hp(E)], [hp(H)], [hp(I)], [hp(M)], [cal/s], [kcal/h], [kcal/s], [L?],
PowerCost:[$/W], [$/kW], [$/W],
Pressure:[Pa], [Pa], [µPa], [mPa], [daPa], [hPa], [kPa], [MPa], [GPa], [atm], [ft of head], [inHg], [inH2O], [m of head], [mmHg], [at], [torr], [bar], [µbar], [mbar], [cbar], [dbar], [kbar], [Mbar], [dyn/cm²], [kgf/cm²], [kgf/m²], [kgf/mm²], [kN/cm²], [kN/m²], [kN/mm²], [MN/m²], [tf/cm²], [tf/m²], [tf/mm²], [N/mm²], [N/cm²], [N/m²], [kipf/ft²], [ksi], [lb/ft²], [psi], [lbm/(in·s²)], [bara], [barg],
PressureChangeRate:[Pa/s], [Pa/s], [Pa/min], [MPa/s], [MPa/min], [ksi/s], [ksi/min], [kPa/s], [kPa/min], [atm/s], [psi/min], [psi/s], [Mpsi/s], [Mpsi/min],
Ratio:[-], [-], [ppb], [ppm], [%], [ppt], [%], [cg/g], [cg/kg], [dag/g], [dag/kg], [dg/g], [dg/kg], [g/g], [g/kg], [hg/g], [hg/kg], [kg/g], [kg/kg], [µg/g], [µg/kg], [mg/g], [mg/kg], [ng/g], [ng/kg], [cl/l], [cl/ml], [dl/l], [dl/ml], [l/l], [l/ml], [µl/l], [µl/ml], [ml/l], [ml/ml], [nl/l], [nl/ml], [pl/l], [pl/ml],
ReactiveEnergy:[vars], [varh], [Mvarh], [kvarh],
ReactivePower:[var], [var], [Mvar], [kvar], [Gvar],
RotationalSpeed:[rad/s], [rad/s], [Hz], [kHz], [MHz], [GHz], [THz], [s?¹], [bpm], [cph], [cpm],
SpecificEnergy:[J/kg], [J/kg], [kJ/kg], [MJ/kg], [BTU/lb], [cal/g], [kcal/g], [Wday/kg], [kWday/kg], [MWday/kg], [GWday/kg], [TWday/kg], [Wh/kg], [kWh/kg], [MWh/kg], [GWh/kg], [Wday/t], [kWday/t], [MWday/t], [GWday/t], [TWday/t], [Wday/t (short)], [kWday/t (short)], [MWday/t (short)], [GWday/t (short)], [TWday/t (short)],
SpecificEntropy:[J/kg·K], [J/kg·K], [J/kg·K], [kJ/kg·K], [kJ/kg·K], [MJ/kg·K], [MJ/kg·K], [J/kg·°R], [cal/g·K], [kcal/g·K], [BTU/lb·K], [BTU/lb·°R], [BTU/lb·°R],
SpecificWeight:[N/m³], [N/m³], [kgf/cm³], [kgf/m³], [kgf/mm³], [kN/cm³], [kN/m³], [kN/mm³], [kipf/ft³], [kipf/in³], [MN/m³], [N/cm³], [N/mm³], [lbf/ft³], [lbf/in³], [tf/cm³], [tf/m³], [tf/mm³],
Speed:[cm/h], [cm/min], [cm/s], [dm/min], [dm/s], [ft/h], [ft/min], [ft/s], [in/h], [in/min], [in/s], [km/h], [km/min], [km/s], [kn], [m/h], [m/min], [m/s], [µm/min], [µm/s], [mph], [mm/h], [mm/min], [mm/s], [nm/min], [nm/s], [ftUS/h], [ftUS/min], [ftUS/s], [yd/h], [yd/min], [yd/s], [km/h], [m/s], [mi/s],
TemperatureChangeRate:[°C/s], [°C/s], [°C/min], [c°C/s], [da°C/s], [d°C/s], [h°C/s], [k°C/s], [µ°C/s], [m°C/s], [n°C/s],
ThermalConductivity:[W/m·K], [W/m·K], [BTU/h·ft·°F],
ThermalResistance:[m²K/W], [m²°C/W], [m²K/kW], [cm²K/W], [cm²Hr°C/kcal], [Hrft²°F/Btu],
TorquePerLength:[N·m/m], [N·m/m], [kgf·cm/m], [kgf·m/m], [kgf·mm/m], [kN·cm/m], [kN·m/m], [kN·mm/m], [kipf·ft/ft], [kipf·in/ft], [MN·cm/m], [MN·m/m], [MN·mm/m], [Mlbf·ft/ft], [Mlbf·in/ft], [N·cm/m], [N·mm/m], [lbf·ft/ft], [lbf·in/ft], [tf·cm/m], [tf·m/m], [tf·mm/m],
Torque:[N·m], [N·m], [kN·m], [MN·m], [N·mm], [kN·mm], [MN·mm], [N·cm], [MN·cm], [pdl·ft], [lbf·ft], [lbf·in], [tf·cm], [tf·m], [tf·mm], [kN·cm], [kgf·cm], [kgf·m], [kgf·mm], [kipf·ft], [Mlbf·ft], [kipf·in], [Mlbf·in],
VolumeFlow:[af/d], [af/h], [af/m], [af/s], [cl/day], [cl/min], [cl/s], [cm³/min], [dm³/min], [ft³/h], [ft³/min], [ft³/s], [m³/day], [m³/h], [m³/min], [m³/s], [m³/s], [mm³/s], [yd³/day], [yd³/h], [yd³/min], [yd³/s], [dl/day], [dl/min], [dl/s], [kl/day], [kl/min], [kl/s], [kgal (U.S.)/min], [l/day], [l/h], [l/min], [l/s], [Ml/day], [µl/day], [µl/min], [µl/s], [ml/day], [ml/min], [ml/s], [MGD], [nl/day], [nl/min], [nl/s], [bbl/day], [bbl/h], [bbl/min], [bbl/s], [gal (U. K.)/d], [gal (imp.)/h], [gal (imp.)/min], [gal (imp.)/s], [gpd], [gal (U.S.)/h], [gal (U.S.)/min], [gal (U.S.)/s], [Mgal (imp.)/s],
VolumePerLength:[m³/m], [m³/m], [yd³/ft], [yd³/ftUS], [l/km], [l/m], [l/mm], [bbl/ft],
Volume:[m³], [m³], [hm³], [km³], [km³], [µm³], [mi³], [mm³], [yd³], [in³], [hm³], [ft³], [hft³], [kft³], [Mft³], [dm³], [cm³], [l], [nl], [µl], [ml], [dl], [cl], [hl], [kl], [Ml], [pl], [ac-ft], [bf], [], [bl (imp.)], [tsp], [], [gal (imp.)], [kgal (imp.)], [Mgal (imp.)], [oz (imp.)], [pt (imp.)], [], [bl (U.S.)], [], [oz (U.S.)], [gal (U.S.)], [kgal (U.S.)], [Mgal (U.S.)], [dagal (U.S.)], [dgal (U.S.)], [hgal (U.S.)], [bbl], [], [pt (U.S.)], [qt (U.S.)], [], [],
VolumeCost:[$/m³], [$/m³], [?/m³],
WarpingMomentOfInertia:[m6], [mm6], [in6], [ft6], [dm6], [cm6], [m6],
SpecificThermalResistance:[mK/W], [mK/W], [mK/kW], [cmK/W],
ApparentPower:[kgm²/s³], [VA], [MVA], [kVA], [GVA],
Enthalpy:[J/kg], [J/kg], [kJ/kg], [MJ/kg], [BTU/lb], [cal/g], [kcal/g], [Wday/kg], [kWday/kg], [MWday/kg], [GWday/kg], [TWday/kg], [Wh/kg], [kWh/kg], [MWh/kg], [GWh/kg], [Wday/t], [kWday/t], [MWday/t], [GWday/t], [TWday/t], [Wday/t (short)], [kWday/t (short)], [MWday/t (short)], [GWday/t (short)], [TWday/t (short)],
SpecificHeatCapacity:[J/kg·K], [J/kg·K], [J/kg·K], [kJ/kg·K], [kJ/kg·K], [MJ/kg·K], [MJ/kg·K], [J/kg·°R], [cal/g·K], [kcal/g·K], [BTU/lb·K], [BTU/lb·°R], [BTU/lb·°R],
Angle:[°], ['], ["], [g], [rad], [crad], [drad], [µrad], [mrad], [nrad], [°], [µ°], [m°], [n°], [r],
MolarFlow:[mol/s], [mol/s],
SpecificVolume:[m³/kg], [m³/kg],
VolumetricHeatTransferCoefficient:[W/m³K], [W/m³K],
Jerk:[m/s³], [km/s³], [m/s³], [dm/s³], [cm/s³], [µm/s³], [mm/s³], [nm/s³],
AmountOfSubstance:[mol], [mol], [cmol], [dmol], [kmol], [Mmol], [µmol], [mmol], [nmol], [pmol], [nlbmol], [µlbmol], [mlbmol], [lbmol], [klbmol], [dlbmol], [clbmol],
Duration:[ns], [ms], [µs], [s], [min], [h], [day], [wk], [mo], [yr], [s],
ElectricCurrent:[A], [A], [cA], [kA], [MA], [µA], [mA], [nA], [pA],
Length:[km], [hm], [m], [m], [dm], [cm], [mm], [µm], [nm], [µin], [twip], [mil], [pt], [pica], [in], [h], [ft], [yd], [fathom], [ch], [shackle], [mi], [NM], [ftUS], [ly], [kly], [Mly], [R?], [au], [pc], [kpc], [Mpc],
LuminousIntensity:[cd], [cd],
Mass:[kg], [kg], [pg], [cg], [dag], [dg], [g], [hg], [µg], [mg], [ng], [t], [kt], [Mt], [em], [oz], [lb], [st], [slug], [cwt], [cwt], [kip], [t (short)], [long tn], [Mlb], [gr],
Temperature:[K], [K], [°C], [°F], [°R],
Cost:[$], [$], [M$], [?], [£],

```

###### What are the names of the units?
```C#
Acceleration:[SI], [KilometerPerSecondSquared], [MeterPerSecondSquared], [DecimeterPerSecondSquared], [CentimeterPerSecondSquared], [MicrometerPerSecondSquared], [MillimeterPerSecondSquared], [NanometerPerSecondSquared], [InchPerSecondSquared], [FootPerSecondSquared], [KnotPerSecond], [KnotPerMinute], [KnotPerHour], [StandardGravity], [MillistandardGravity],
AmountOfSubstance:[SI], [Mole], [Centimole], [Decimole], [Kilomole], [Megamole], [Micromole], [Millimole], [Nanomole], [Picomole], [NanopoundMole], [MicropoundMole], [MillipoundMole], [PoundMole], [KilopoundMole], [DecipoundMole], [CentipoundMole],
Angle:[SI], [Arcminute], [Arcsecond], [Gradian], [Radian], [Centiradian], [Deciradian], [Microradian], [Milliradian], [Nanoradian], [Degree], [Microdegree], [Millidegree], [Nanodegree], [Revolution],
ApparentPower:[SI], [Voltampere], [Megavoltampere], [Kilovoltampere], [Gigavoltampere],
Area:[Acre], [Hectare], [SquareCentimeter], [SquareDecimeter], [SquareKilometer], [SquareMeter], [SquareMicrometer], [SI], [SquareMillimeter], [SquareNanometer], [SquareInch], [SquareFoot], [SquareYard], [SquareMile], [SquareNauticalMile], [SquareChain],
AreaCost:[SI], [USDollarPerSquareMeter], [MillionUSDollarPerSquareMeter], [EuroPerSquareMeter],
AreaDensity:[SI], [KilogramPerSquareMeter],
AreaMomentOfInertia:[SI], [MeterToTheFourth], [CentimeterToTheFourth], [DecimeterToTheFourth], [MillimeterToTheFourth], [InchToTheFourth], [FootToTheFourth],
BitRate:[SI], [BytePerSecond], [BitPerSecond], [KibibitPerSecond], [MebibitPerSecond], [GibibitPerSecond], [TebibitPerSecond], [PebibitPerSecond], [ExbibitPerSecond], [KibibytePerSecond], [MebibytePerSecond], [GibibytePerSecond], [TebibytePerSecond], [PebibytePerSecond], [ExbibytePerSecond], [KilobytePerSecond], [MegabytePerSecond], [GigabytePerSecond], [TerabytePerSecond], [PetabytePerSecond], [ExabytePerSecond], [KilobitPerSecond], [MegabitPerSecond], [GigabitPerSecond], [TerabitPerSecond], [PetabitPerSecond], [ExabitPerSecond],
BrakeSpecificFuelConsumption:[SI], [KilogramPerJoule], [GramPerKiloWattHour], [PoundPerMechanicalHorsepowerHour],
Capacitance:[SI], [Farad], [Kilofarad], [Megafarad], [Microfarad], [Millifarad], [Nanofarad], [Picofarad],
CoefficientOfThermalExpansion:[SI], [InverseKelvin], [InverseDegreeFahrenheit], [InverseDegreeCelsius],
Cost:[SI], [USDollar], [MillionUSDollar], [Euro], [BritishPound],
Density:[SI], [CentigramPerDeciliter], [CentigramPerLiter], [CentigramPerMilliliter], [DecigramPerDeciliter], [DecigramPerLiter], [DecigramPerMilliliter], [DecigramPerMicroliter], [GramPerCubicCentimeter], [GramPerCubicMeter], [GramPerCubicMillimeter], [GramPerDeciliter], [GramPerLiter], [GramPerMilliliter], [GramPerMicroliter], [KilogramPerCubicCentimeter], [KilogramPerCubicMeter], [KilogramPerCubicMillimeter], [KilogramPerLiter], [KilopoundPerCubicFoot], [KilopoundPerCubicInch], [MicrogramPerCubicMeter], [MicrogramPerDeciliter], [MicrogramPerLiter], [MicrogramPerMilliliter], [MicrogramPerMicroliter], [MilligramPerCubicMeter], [MilligramPerDeciliter], [MilligramPerLiter], [MilligramPerMilliliter], [MilligramPerMicroliter], [NanogramPerDeciliter], [NanogramPerLiter], [NanogramPerMilliliter], [NanogramPerMicroliter], [PicogramPerDeciliter], [PicogramPerLiter], [PicogramPerMilliliter], [PicogramPerMicroliter], [PoundPerCubicFoot], [PoundPerCubicInch], [PoundPerImperialGallon], [PoundPerUSGallon], [SlugPerCubicFoot], [TonnePerCubicCentimeter], [TonnePerCubicMeter], [TonnePerCubicMillimeter],
Duration:[Nanosecond], [Millisecond], [Microsecond], [Second], [Minute], [Hour], [Day], [Week], [Month30], [Year365], [SI],
DynamicViscosity:[SI], [PascalSecond], [MicropascalSecond], [MillipascalSecond], [PoundPerFootSecond], [Poise], [Centipoise], [NewtonSecondPerMeterSquared], [PoundForceSecondPerSquareFoot], [PoundForceSecondPerSquareInch], [Reyn],
ElectricCharge:[SI], [Coulomb], [AmpereHour], [KiloampereHour], [MegaampereHour], [MilliampereHour],
ElectricChargeDensity:[SI], [CoulombPerCubicMeter],
ElectricConductivity:[SI], [SiemensPerMeter], [SiemensPerInch], [SiemensPerFoot],
ElectricCurrent:[SI], [Ampere], [Centiampere], [Kiloampere], [Megaampere], [Microampere], [Milliampere], [Nanoampere], [Picoampere],
ElectricCurrentDensity:[SI], [AmperePerSquareMeter], [AmperePerSquareInch], [AmperePerSquareFoot],
ElectricCurrentGradient:[SI], [AmperePerSecond], [AmperePerMicrosecond], [AmperePerMillisecond], [AmperePerNanosecond],
ElectricField:[SI], [VoltPerMeter],
ElectricInductance:[SI], [Henry], [Microhenry], [Millihenry], [Nanohenry],
ElectricPotential:[SI], [Volt], [Kilovolt], [Megavolt], [Gigavolt], [Microvolt], [Millivolt],
ElectricPotentialChangeRate:[SI], [VoltPerSecond], [VoltPerMinute], [VoltPerMicrosecond], [VoltPerHour], [MillivoltPerSecond], [MillivoltPerMinute], [MillivoltPerMicrosecond], [MillivoltPerHour], [MicrovoltPerSecond], [MicrovoltPerMinute], [MicrovoltPerMicrosecond], [MicrovoltPerHour], [MegavoltPerSecond], [MegavoltPerMinute], [MegavoltPerMicrosecond], [MegavoltPerHour], [KilovoltPerSecond], [KilovoltPerMinute], [KilovoltPerMicrosecond], [KilovoltPerHour],
ElectricResistance:[SI], [Ohm], [Gigaohm], [Kiloohm], [Megaohm], [Microohm], [Milliohm],
ElectricResistivity:[SI], [OhmMeter], [OhmCentimeter], [KiloohmCentimeter], [MegaohmCentimeter], [MicroohmCentimeter], [MilliohmCentimeter], [NanoohmCentimeter], [PicoohmCentimeter], [KiloohmMeter], [MegaohmMeter], [MicroohmMeter], [MilliohmMeter], [NanoohmMeter], [PicoohmMeter],
ElectricSurfaceChargeDensity:[SI], [CoulombPerSquareMeter], [CoulombPerSquareCentimeter], [CoulombPerSquareInch],
Energy:[SI], [Millijoule], [Joule], [Kilojoule], [Megajoule], [Gigajoule], [Terajoule], [BritishThermalUnit], [KilobritishThermalUnit], [MegabritishThermalUnit], [GigabritishThermalUnit], [ElectronVolt], [KiloelectronVolt], [MegaelectronVolt], [GigaelectronVolt], [TeraelectronVolt], [Calorie], [Kilocalorie], [Megacalorie], [WattDay], [KilowattDay], [MegawattDay], [GigawattDay], [TerawattDay], [WattHour], [KilowattHour], [MegawattHour], [GigawattHour], [TerawattHour], [FootPound], [DecathermEc], [DecathermImperial], [DecathermUs], [ThermEc], [ThermImperial], [ThermUs], [Erg], [HorsepowerHour],
EnergyCost:[SI], [USDollarPerJoule], [USDollarPerKilojoule], [USDollarPerMegajoule], [USDollarPerGigajoule], [USDollarPerKilowattHour], [USDollarPerMegawattHour], [MillionUSDollarPerJoule], [MillionUSDollarPerKilojoule], [MillionUSDollarPerMegajoule], [MillionUSDollarPerGigajoule], [MillionUSDollarPerKilowattHour], [MillionUSDollarPerMegawattHour],
Enthalpy:[SI], [JoulePerKilogram], [KilojoulePerKilogram], [MegajoulePerKilogram], [BtuPerPound], [CaloriePerGram], [KilocaloriePerGram], [WattDayPerKilogram], [KilowattDayPerKilogram], [MegawattDayPerKilogram], [GigawattDayPerKilogram], [TerawattDayPerKilogram], [WattHourPerKilogram], [KilowattHourPerKilogram], [MegawattHourPerKilogram], [GigawattHourPerKilogram], [WattDayPerTonne], [KilowattDayPerTonne], [MegawattDayPerTonne], [GigawattDayPerTonne], [TerawattDayPerTonne], [WattDayPerShortTon], [KilowattDayPerShortTon], [MegawattDayPerShortTon], [GigawattDayPerShortTon], [TerawattDayPerShortTon],
Entropy:[SI], [JoulePerKelvin], [CaloriePerKelvin], [JoulePerDegreeCelsius], [KilocaloriePerKelvin], [KilojoulePerDegreeCelsius], [KilojoulePerKelvin], [MegajoulePerKelvin],
Force:[SI], [Newton], [Micronewton], [Millinewton], [Decanewton], [Kilonewton], [Meganewton], [Dyn], [TonneForce], [ShortTonForce], [PoundForce], [KilogramForce], [OunceForce], [KiloPond], [KilopoundForce], [MegapoundForce], [Poundal],
ForceChangeRate:[SI], [NewtonPerSecond], [NewtonPerMinute], [PoundForcePerSecond], [PoundForcePerMinute], [KilopoundForcePerSecond], [KilopoundForcePerMinute], [NanonewtonPerSecond], [MillinewtonPerSecond], [MicronewtonPerSecond], [CentinewtonPerSecond], [DecanewtonPerSecond], [DecinewtonPerSecond], [KilonewtonPerSecond], [DecanewtonPerMinute], [KilonewtonPerMinute],
ForcePerLength:[SI], [NewtonPerMeter], [NewtonPerCentimeter], [NewtonPerMillimeter], [KilogramForcePerCentimeter], [KilogramForcePerMeter], [KilogramForcePerMillimeter], [KilonewtonPerCentimeter], [KilonewtonPerMeter], [KilonewtonPerMillimeter], [KilopoundForcePerFoot], [KilopoundForcePerInch], [MeganewtonPerCentimeter], [MeganewtonPerMeter], [MeganewtonPerMillimeter], [MicronewtonPerCentimeter], [MicronewtonPerMeter], [MicronewtonPerMillimeter], [MillinewtonPerCentimeter], [MillinewtonPerMeter], [MillinewtonPerMillimeter], [PoundForcePerFoot], [PoundForcePerInch], [PoundForcePerYard], [TonneForcePerCentimeter], [TonneForcePerMeter], [TonneForcePerMillimeter], [NanonewtonPerCentimeter], [NanonewtonPerMeter], [NanonewtonPerMillimeter], [CentinewtonPerCentimeter], [CentinewtonPerMeter], [CentinewtonPerMillimeter], [DecanewtonPerCentimeter], [DecanewtonPerMeter], [DecanewtonPerMillimeter], [DecinewtonPerCentimeter], [DecinewtonPerMeter], [DecinewtonPerMillimeter],
Frequency:[SI], [Hertz], [Kilohertz], [Megahertz], [Gigahertz], [Terahertz], [PerSecond], [BeatPerMinute], [RevolutionsPerMinute], [RPM], [CyclePerHour], [CyclePerMinute], [RadianPerSecond],
FuelEfficiency:[SI], [KilometerPerLiter], [MilePerUkGallon], [MilePerUsGallon],
HeatFlux:[SI], [WattPerSquareMeter], [WattPerSquareInch], [WattPerSquareFoot], [BtuPerHourSquareFoot], [BtuPerMinuteSquareFoot], [BtuPerSecondSquareFoot], [BtuPerSecondSquareInch], [CaloriePerSecondSquareCentimeter], [KilocaloriePerHourSquareMeter], [KilocaloriePerSecondSquareCentimeter], [KilowattPerSquareMeter], [MicrowattPerSquareMeter], [MilliwattPerSquareMeter], [NanowattPerSquareMeter], [CentiwattPerSquareMeter], [DeciwattPerSquareMeter], [PoundForcePerFootSecond], [PoundPerSecondCubed],
HeatTransferCoefficient:[SI], [WattPerSquareMeterKelvin], [WattPerSquareMeterCelsius], [BtuPerSquareFootDegreeFahrenheit],
Illuminance:[SI], [Lux], [Kilolux], [Megalux], [Millilux],
Information:[SI], [Byte], [Bit], [Kibibit], [Mebibit], [Gibibit], [Tebibit], [Pebibit], [Exbibit], [Kibibyte], [Mebibyte], [Gibibyte], [Tebibyte], [Pebibyte], [Exbibyte], [Kilobyte], [Megabyte], [Gigabyte], [Terabyte], [Petabyte], [Exabyte], [Kilobit], [Megabit], [Gigabit], [Terabit], [Petabit], [Exabit],
Irradiance:[SI], [WattPerSquareMeter], [WattPerSquareCentimeter], [KilowattPerSquareCentimeter], [MegawattPerSquareCentimeter], [MicrowattPerSquareCentimeter], [MilliwattPerSquareCentimeter], [NanowattPerSquareCentimeter], [PicowattPerSquareCentimeter], [KilowattPerSquareMeter], [MegawattPerSquareMeter], [MicrowattPerSquareMeter], [MilliwattPerSquareMeter], [NanowattPerSquareMeter], [PicowattPerSquareMeter],
Irradiation:[SI], [JoulePerSquareMeter], [JoulePerSquareCentimeter], [JoulePerSquareMillimeter], [KilojoulePerSquareMeter], [KilowattHourPerSquareMeter], [MillijoulePerSquareCentimeter], [WattHourPerSquareMeter],
Jerk:[SI], [KilometerPerSecondCubed], [MeterPerSecondCubed], [DecimeterPerSecondCubed], [CentimeterPerSecondCubed], [MicrometerPerSecondCubed], [MillimeterPerSecondCubed], [NanometerPerSecondCubed],
KinematicViscosity:[SI], [SquareMeterPerSecond], [Stokes], [Centistokes], [Decistokes], [Kilostokes], [Microstokes], [Millistokes], [Nanostokes],
LapseRate:[SI], [DegreeCelsiusPerKilometer],
Length:[Kilometer], [Hectometer], [Meter], [SI], [Decimeter], [Centimeter], [Millimeter], [Micrometer], [Nanometer], [Microinch], [Twip], [Mil], [DtpPoint], [DtpPica], [Inch], [Hand], [Foot], [Yard], [Fathom], [Chain], [Shackle], [Mile], [NauticalMile], [UsSurveyFoot], [LightYear], [KilolightYear], [MegalightYear], [SolarRadius], [AstronomicalUnit], [Parsec], [Kiloparsec], [Megaparsec],
LengthCost:[SI], [DollarPerMeter], [EuroPerMeter],
LinearDensity:[SI], [KilogramPerMeter], [GramPerCentimeter], [GramPerMeter], [GramPerMillimeter], [KilogramPerCentimeter], [KilogramPerMillimeter], [MicrogramPerCentimeter], [MicrogramPerMeter], [MicrogramPerMillimeter], [MilligramPerCentimeter], [MilligramPerMeter], [MilligramPerMillimeter], [PoundPerFoot], [PoundPerInch],
LinearPowerDensity:[SI], [WattPerMeter], [WattPerMillimeter], [WattPerInch], [WattPerFoot], [WattPerCentimeter], [MilliwattPerMillimeter], [MilliwattPerMeter], [MilliwattPerInch], [MilliwattPerFoot], [MilliwattPerCentimeter], [MegawattPerMillimeter], [MegawattPerMeter], [MegawattPerInch], [MegawattPerFoot], [MegawattPerCentimeter], [KilowattPerMillimeter], [KilowattPerMeter], [KilowattPerInch], [KilowattPerFoot], [KilowattPerCentimeter], [GigawattPerMillimeter], [GigawattPerMeter], [GigawattPerInch], [GigawattPerFoot], [GigawattPerCentimeter],
LuminousFlux:[SI], [Lumen],
LuminousIntensity:[SI], [Candela],
MagneticField:[SI], [Tesla], [Gauss], [Milligauss], [Microtesla], [Millitesla], [Nanotesla],
MagneticFlux:[SI], [Weber],
Magnetization:[SI], [AmperePerMeter],
Mass:[SI], [Kilogram], [Picogram], [Centigram], [Decagram], [Decigram], [Gram], [Hectogram], [Microgram], [Milligram], [Nanogram], [Tonne], [Kilotonne], [Megatonne], [EarthMass], [Ounce], [Pound], [Stone], [Slug], [ShortHundredweight], [LongHundredweight], [Kilopound], [ShortTon], [LongTon], [Megapound], [Grain],
MassCost:[SI], [EuroPerKilogram], [USDollarPerKilogram], [USDollarPerTonne], [MillionUSDollarPerTonne],
MassFlow:[CentigramPerDay], [CentigramPerSecond], [DecagramPerDay], [DecagramPerSecond], [DecigramPerDay], [DecigramPerSecond], [GramPerDay], [GramPerHour], [GramPerSecond], [MegagramPerDay], [MicrogramPerSecond], [MicrogramPerDay], [MilligramPerSecond], [MilligramPerDay], [NanogramPerSecond], [NanogramPerDay], [HectogramPerDay], [HectogramPerSecond], [SI], [KilogramPerSecond], [KilogramPerMinute], [KilogramPerHour], [KilogramPerDay], [PoundPerSecond], [PoundPerMinute], [PoundPerHour], [PoundPerDay], [MegapoundPerDay], [MegapoundPerHour], [MegapoundPerMinute], [MegapoundPerSecond], [ShortTonPerHour], [TonnePerDay], [TonnePerHour],
MassFlux:[SI], [KilogramPerSecondPerSquareMeter], [GramPerHourPerSquareCentimeter], [GramPerHourPerSquareMeter], [GramPerHourPerSquareMillimeter], [GramPerSecondPerSquareCentimeter], [GramPerSecondPerSquareMeter], [GramPerSecondPerSquareMillimeter], [KilogramPerHourPerSquareCentimeter], [KilogramPerHourPerSquareMeter], [KilogramPerHourPerSquareMillimeter], [KilogramPerSecondPerSquareCentimeter], [KilogramPerSecondPerSquareMillimeter],
MassMomentOfInertia:[SI], [KilogramSquareMeter], [GramSquareCentimeter], [GramSquareDecimeter], [GramSquareMeter], [GramSquareMillimeter], [KilogramSquareCentimeter], [KilogramSquareDecimeter], [KilogramSquareMillimeter], [KilotonneSquareCentimeter], [KilotonneSquareDecimeter], [KilotonneSquareMeter], [KilotonneSquareMilimeter], [MegatonneSquareCentimeter], [MegatonneSquareDecimeter], [MegatonneSquareMeter], [MegatonneSquareMilimeter], [MilligramSquareCentimeter], [MilligramSquareDecimeter], [MilligramSquareMeter], [MilligramSquareMillimeter], [PoundSquareFoot], [PoundSquareInch], [SlugSquareFoot], [SlugSquareInch], [TonneSquareCentimeter], [TonneSquareDecimeter], [TonneSquareMeter], [TonneSquareMilimeter],
MolarEnergy:[SI], [JoulePerMole], [KilojoulePerMole], [MegajoulePerMole],
MolarEntropy:[SI], [JoulePerMoleKelvin], [KilojoulePerMoleKelvin], [MegajoulePerMoleKelvin],
MolarFlow:[SI], [MolePerSecond],
Molarity:[SI], [MolesPerCubicMeter], [MolesPerLiter], [NanomolesPerLiter], [PicomolesPerLiter], [CentimolesPerLiter], [DecimolesPerLiter], [MicromolesPerLiter], [MillimolesPerLiter],
MolarMass:[SI], [KilogramPerMole], [CentigramPerMole], [DecagramPerMole], [DecigramPerMole], [GramPerMole], [HectogramPerMole], [KilopoundPerMole], [MegapoundPerMole], [MicrogramPerMole], [MilligramPerMole], [NanogramPerMole], [PoundPerMole],
Permeability:[SI], [HenryPerMeter],
Permittivity:[SI], [FaradPerMeter],
Power:[SI], [Femtowatt], [Picowatt], [Nanowatt], [Microwatt], [Milliwatt], [Deciwatt], [Watt], [Decawatt], [Kilowatt], [Megawatt], [Gigawatt], [Terawatt], [Petawatt], [MillijoulePerHour], [JoulePerHour], [KilojoulePerHour], [MegajoulePerHour], [GigajoulePerHour], [BritishThermalUnitPerHour], [BritishThermalUnitPerMinute], [BritishThermalUnitPerSecond], [KilobritishThermalUnitPerHour], [BoilerHorsepower], [ElectricalHorsepower], [HydraulicHorsepower], [MechanicalHorsepower], [MetricHorsepower], [CaloriePerSecond], [KilocaloriePerHour], [KilocaloriePerSecond], [SolarLuminosity],
PowerCost:[SI], [USDollarPerKilowatt], [USDollarPerWatt],
PowerDensity:[SI], [WattPerCubicMeter], [WattPerLiter], [WattPerCubicInch], [WattPerCubicFoot], [TerawattPerLiter], [TerawattPerCubicMeter], [TerawattPerCubicInch], [TerawattPerCubicFoot], [PicowattPerLiter], [PicowattPerCubicMeter], [PicowattPerCubicInch], [PicowattPerCubicFoot], [NanowattPerLiter], [NanowattPerCubicMeter], [NanowattPerCubicInch], [NanowattPerCubicFoot], [MilliwattPerLiter], [MilliwattPerCubicMeter], [MilliwattPerCubicInch], [MilliwattPerCubicFoot], [MicrowattPerLiter], [MicrowattPerCubicMeter], [MicrowattPerCubicInch], [MicrowattPerCubicFoot], [MegawattPerLiter], [MegawattPerCubicMeter], [MegawattPerCubicInch], [MegawattPerCubicFoot], [KilowattPerLiter], [KilowattPerCubicMeter], [KilowattPerCubicInch], [KilowattPerCubicFoot], [GigawattPerLiter], [GigawattPerCubicMeter], [GigawattPerCubicInch], [GigawattPerCubicFoot], [DeciwattPerLiter], [DeciwattPerCubicMeter], [DeciwattPerCubicInch], [DeciwattPerCubicFoot], [DecawattPerLiter], [DecawattPerCubicMeter], [DecawattPerCubicInch], [DecawattPerCubicFoot],
Pressure:[SI], [Pascal], [Micropascal], [Millipascal], [Decapascal], [Hectopascal], [Kilopascal], [Megapascal], [Gigapascal], [Atmosphere], [FootOfHead], [InchOfMercury], [InchOfWaterColumn], [MeterOfHead], [MillimeterOfMercury], [TechnicalAtmosphere], [Torr], [Bar], [Microbar], [Millibar], [Centibar], [Decibar], [Kilobar], [Megabar], [DynePerSquareCentimeter], [KilogramForcePerSquareCentimeter], [KilogramForcePerSquareMeter], [KilogramForcePerSquareMillimeter], [KilonewtonPerSquareCentimeter], [KilonewtonPerSquareMeter], [KilonewtonPerSquareMillimeter], [MeganewtonPerSquareMeter], [TonneForcePerSquareCentimeter], [TonneForcePerSquareMeter], [TonneForcePerSquareMillimeter], [NewtonPerSquareMillimeter], [NewtonPerSquareCentimeter], [NewtonPerSquareMeter], [KilopoundForcePerSquareFoot], [KilopoundForcePerSquareInch], [PoundForcePerSquareFoot], [PoundForcePerSquareInch], [PoundPerInchSecondSquared], [BarA], [BarG],
PressureChangeRate:[SI], [PascalPerSecond], [PascalPerMinute], [MegapascalPerSecond], [MegapascalPerMinute], [KilopoundForcePerSquareInchPerSecond], [KilopoundForcePerSquareInchPerMinute], [KilopascalPerSecond], [KilopascalPerMinute], [AtmospherePerSecond], [PoundForcePerSquareInchPerMinute], [PoundForcePerSquareInchPerSecond], [MegapoundForcePerSquareInchPerSecond], [MegapoundForcePerSquareInchPerMinute],
Ratio:[SI], [DecimalFraction], [PartPerBillion], [PartPerMillion], [PartPerThousand], [PartPerTrillion], [Percent], [CentigramPerGram], [CentigramPerKilogram], [DecagramPerGram], [DecagramPerKilogram], [DecigramPerGram], [DecigramPerKilogram], [GramPerGram], [GramPerKilogram], [HectogramPerGram], [HectogramPerKilogram], [KilogramPerGram], [KilogramPerKilogram], [MicrogramPerGram], [MicrogramPerKilogram], [MilligramPerGram], [MilligramPerKilogram], [NanogramPerGram], [NanogramPerKilogram], [CentilitersPerLiter], [CentilitersPerMililiter], [DecilitersPerLiter], [DecilitersPerMililiter], [LitersPerLiter], [LitersPerMililiter], [MicrolitersPerLiter], [MicrolitersPerMililiter], [MillilitersPerLiter], [MillilitersPerMililiter], [NanolitersPerLiter], [NanolitersPerMililiter], [PicolitersPerLiter], [PicolitersPerMililiter],
ReactiveEnergy:[SI], [VoltampereReactiveHour], [MegavoltampereReactiveHour], [KilovoltampereReactiveHour],
ReactivePower:[SI], [VoltampereReactive], [MegavoltampereReactive], [KilovoltampereReactive], [GigavoltampereReactive],
RotationalSpeed:[SI], [RadianPerSecond], [Hertz], [Kilohertz], [Megahertz], [Gigahertz], [Terahertz], [PerSecond], [BeatPerMinute], [CyclePerHour], [CyclePerMinute],
SpecificEnergy:[SI], [JoulePerKilogram], [KilojoulePerKilogram], [MegajoulePerKilogram], [BtuPerPound], [CaloriePerGram], [KilocaloriePerGram], [WattDayPerKilogram], [KilowattDayPerKilogram], [MegawattDayPerKilogram], [GigawattDayPerKilogram], [TerawattDayPerKilogram], [WattHourPerKilogram], [KilowattHourPerKilogram], [MegawattHourPerKilogram], [GigawattHourPerKilogram], [WattDayPerTonne], [KilowattDayPerTonne], [MegawattDayPerTonne], [GigawattDayPerTonne], [TerawattDayPerTonne], [WattDayPerShortTon], [KilowattDayPerShortTon], [MegawattDayPerShortTon], [GigawattDayPerShortTon], [TerawattDayPerShortTon],
SpecificEntropy:[SI], [JoulePerKilogramKelvin], [JoulePerKilogramDegreeCelsius], [KilojoulePerKilogramDegreeCelsius], [KilojoulePerKilogramKelvin], [MegajoulePerKilogramDegreeCelsius], [MegajoulePerKilogramKelvin], [JoulePerKilogramRankine], [CaloriePerGramKelvin], [KilocaloriePerGramKelvin], [BtuPerPoundKelvin], [BtuPerPoundRankine], [BtuPerPoundFahrenheit],
SpecificHeatCapacity:[SI], [JoulePerKilogramKelvin], [JoulePerKilogramDegreeCelsius], [KilojoulePerKilogramDegreeCelsius], [KilojoulePerKilogramKelvin], [MegajoulePerKilogramDegreeCelsius], [MegajoulePerKilogramKelvin], [JoulePerKilogramRankine], [CaloriePerGramKelvin], [KilocaloriePerGramKelvin], [BtuPerPoundKelvin], [BtuPerPoundRankine], [BtuPerPoundFahrenheit],
SpecificThermalResistance:[SI], [MeterDegreeCelsiusPerWatt], [MeterKelvinPerKilowatt], [CentimeterKelvinPerWatt],
SpecificVolume:[SI], [CubicMeterPerKilogram],
SpecificWeight:[SI], [NewtonPerCubicMeter], [KilogramForcePerCubicCentimeter], [KilogramForcePerCubicMeter], [KilogramForcePerCubicMillimeter], [KilonewtonPerCubicCentimeter], [KilonewtonPerCubicMeter], [KilonewtonPerCubicMillimeter], [KilopoundForcePerCubicFoot], [KilopoundForcePerCubicInch], [MeganewtonPerCubicMeter], [NewtonPerCubicCentimeter], [NewtonPerCubicMillimeter], [PoundForcePerCubicFoot], [PoundForcePerCubicInch], [TonneForcePerCubicCentimeter], [TonneForcePerCubicMeter], [TonneForcePerCubicMillimeter],
Speed:[CentimeterPerHour], [CentimeterPerMinute], [CentimeterPerSecond], [DecimeterPerMinute], [DecimeterPerSecond], [FootPerHour], [FootPerMinute], [FootPerSecond], [InchPerHour], [InchPerMinute], [InchPerSecond], [KilometerPerHour], [KilometerPerMinute], [KilometerPerSecond], [Knot], [MeterPerHour], [MeterPerMinute], [MeterPerSecond], [MicrometerPerMinute], [MicrometerPerSecond], [MilePerHour], [MillimeterPerHour], [MillimeterPerMinute], [MillimeterPerSecond], [NanometerPerMinute], [NanometerPerSecond], [UsSurveyFootPerHour], [UsSurveyFootPerMinute], [UsSurveyFootPerSecond], [YardPerHour], [YardPerMinute], [YardPerSecond], [KilometerPerhour], [SI], [MilePerSecond],
Temperature:[Kelvin], [SI], [DegreeCelsius], [DegreeFahrenheit], [DegreeRankine],
TemperatureChangeRate:[SI], [DegreeCelsiusPerSecond], [DegreeCelsiusPerMinute], [CentidegreeCelsiusPerSecond], [DecadegreeCelsiusPerSecond], [DecidegreeCelsiusPerSecond], [HectodegreeCelsiusPerSecond], [KilodegreeCelsiusPerSecond], [MicrodegreeCelsiusPerSecond], [MillidegreeCelsiusPerSecond], [NanodegreeCelsiusPerSecond],
ThermalConductivity:[SI], [WattPerMeterKelvin], [BtuPerHourFootFahrenheit],
ThermalResistance:[SI], [SquareMeterDegreeCelsiusPerWatt], [SquareMeterKelvinPerKilowatt], [SquareCentimeterKelvinPerWatt], [SquareCentimeterHourDegreeCelsiusPerKilocalorie], [HourSquareFeetDegreeFahrenheitPerBtu],
Torque:[SI], [NewtonMeter], [KilonewtonMeter], [MeganewtonMeter], [NewtonMillimeter], [KilonewtonMillimeter], [MeganewtonMillimeter], [NewtonCentimeter], [MeganewtonCentimeter], [PoundalFoot], [PoundForceFoot], [PoundForceInch], [TonneForceCentimeter], [TonneForceMeter], [TonneForceMillimeter], [KilonewtonCentimeter], [KilogramForceCentimeter], [KilogramForceMeter], [KilogramForceMillimeter], [KilopoundForceFoot], [MegapoundForceFoot], [KilopoundForceInch], [MegapoundForceInch],
TorquePerLength:[SI], [NewtonMeterPerMeter], [KilogramForceCentimeterPerMeter], [KilogramForceMeterPerMeter], [KilogramForceMillimeterPerMeter], [KilonewtonCentimeterPerMeter], [KilonewtonMeterPerMeter], [KilonewtonMillimeterPerMeter], [KilopoundForceFootPerFoot], [KilopoundForceInchPerFoot], [MeganewtonCentimeterPerMeter], [MeganewtonMeterPerMeter], [MeganewtonMillimeterPerMeter], [MegapoundForceFootPerFoot], [MegapoundForceInchPerFoot], [NewtonCentimeterPerMeter], [NewtonMillimeterPerMeter], [PoundForceFootPerFoot], [PoundForceInchPerFoot], [TonneForceCentimeterPerMeter], [TonneForceMeterPerMeter], [TonneForceMillimeterPerMeter],
Volume:[SI], [CubicMeter], [HectocubicMeter], [KilocubicMeter], [CubicKilometer], [CubicMicrometer], [CubicMile], [CubicMillimeter], [CubicYard], [CubicInch], [CubicHectometer], [CubicFoot], [HectocubicFoot], [KilocubicFoot], [MegacubicFoot], [CubicDecimeter], [CubicCentimeter], [Liter], [Nanoliter], [Microliter], [Milliliter], [Deciliter], [Centiliter], [Hectoliter], [Kiloliter], [Megaliter], [Picoliter], [AcreFoot], [BoardFoot], [AuTablespoon], [ImperialBeerBarrel], [MetricTeaspoon], [MetricCup], [ImperialGallon], [KiloimperialGallon], [MegaimperialGallon], [ImperialOunce], [ImperialPint], [UsCustomaryCup], [UsBeerBarrel], [UkTablespoon], [UsOunce], [UsGallon], [KilousGallon], [MegausGallon], [DecausGallon], [DeciusGallon], [HectousGallon], [OilBarrel], [UsLegalCup], [UsPint], [UsQuart], [UsTablespoon], [UsTeaspoon],
VolumeCost:[SI], [USDollarPerCubicMeter], [EuroPerCubicMeter],
VolumeFlow:[AcreFootPerDay], [AcreFootPerHour], [AcreFootPerMinute], [AcreFootPerSecond], [CentiliterPerDay], [CentiliterPerMinute], [CentiliterPerSecond], [CubicCentimeterPerMinute], [CubicDecimeterPerMinute], [CubicFootPerHour], [CubicFootPerMinute], [CubicFootPerSecond], [CubicMeterPerDay], [CubicMeterPerHour], [CubicMeterPerMinute], [CubicMeterPerSecond], [SI], [CubicMillimeterPerSecond], [CubicYardPerDay], [CubicYardPerHour], [CubicYardPerMinute], [CubicYardPerSecond], [DeciliterPerDay], [DeciliterPerMinute], [DeciliterPerSecond], [KiloliterPerDay], [KiloliterPerMinute], [KiloliterPerSecond], [KilousGallonPerMinute], [LiterPerDay], [LiterPerHour], [LiterPerMinute], [LiterPerSecond], [MegaliterPerDay], [MicroliterPerDay], [MicroliterPerMinute], [MicroliterPerSecond], [MilliliterPerDay], [MilliliterPerMinute], [MilliliterPerSecond], [MillionUsGallonsPerDay], [NanoliterPerDay], [NanoliterPerMinute], [NanoliterPerSecond], [OilBarrelPerDay], [OilBarrelPerHour], [OilBarrelPerMinute], [OilBarrelPerSecond], [UkGallonPerDay], [UkGallonPerHour], [UkGallonPerMinute], [UkGallonPerSecond], [UsGallonPerDay], [UsGallonPerHour], [UsGallonPerMinute], [UsGallonPerSecond], [MegaukGallonPerSecond],
VolumePerLength:[SI], [CubicMeterPerMeter], [CubicYardPerFoot], [CubicYardPerUsSurveyFoot], [LiterPerKilometer], [LiterPerMeter], [LiterPerMillimeter], [OilBarrelPerFoot],
VolumetricHeatTransferCoefficient:[SI], [WattPerCubicMeterKelvin],
WarpingMomentOfInertia:[MeterToTheSixth], [MillimeterToTheSixth], [InchToTheSixth], [FootToTheSixth], [DecimeterToTheSixth], [CentimeterToTheSixth], [SI],


```
