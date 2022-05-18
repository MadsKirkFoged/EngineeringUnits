[![NuGet](https://img.shields.io/nuget/v/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![NuGet](https://img.shields.io/nuget/dt/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
![Platform](https://img.shields.io/badge/Platform-64%2F32bit-brightgreen)
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
SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

//UnitsNet cant do this..
Power Q1 = M1 * P1 * (T2 - T1);
```

###### :heavy_check_mark: Temperature calculations are done just like any other unit (TemperatureDelta has been removed!)
###### :heavy_check_mark: Units can have alias. Ex *SpecificEnergy* and *Enthalpy* are the same thing and you can just choose the one you normally use. (No code duplication for this option!)
###### :heavy_check_mark: More precise convertions:
```C#
Length L2 = new Length(1, LengthUnit.Mile);

//Correct result in Inch:   63360
//EngineeringUnits in Inch: 63360
//UnitsNet in Inch:         63359.84251968504
```

###### :triangular_flag_on_post: Unit checks has been moved from Compile time to runtime. In [UnitsNet](https://github.com/angularsen/UnitsNet) if you do mathematical operations on units that doesnt turn into the expected unit, you're get an error before you compile the program. In EngineeringUnits you still have the same check but you will get the error when you run the program.



## Should I change from UnitsNet to EngineeringUnits?


###### :heavy_check_mark: If you are working with engineering-, physics- , chemical- equations then EngineeringUnits will make your life easier
###### :triangular_flag_on_post: If you are just making converions ( Meter -> Inch) and you dont care about the extra precision then UnitsNet and EngineeringUnits are identical.


## How to install

###### :heavy_check_mark: Nuget Package: EngineeringUnits

## Code examples

###### Get told if you mess up a calculation
```C#
Mass mass = new Mass(10, MassUnit.Kilogram);
Volume volume = new Volume(0, VolumeUnit.CubicMeter);

Density D1 = mass / volume; // 2.5 kg/m³
Density D2 = volume / mass; // WrongUnitException: 'This is NOT a [kg/m³] as expected! Your Unit is a [m³/kg]'
```

###### Creating a new Unit
```C#
//Two Different ways of creating a new unit
Length length = Length.FromYards(1);
Length length2 = new Length(1, LengthUnit.Yard); 
```

###### Exporting a Unit
```C#
Length length = Length.FromYards(1);

//Display the unis as it was created
Debug.Print($"{length}"); //1 yd

//Returns as an other unit
Debug.Print($"{length.ToUnit(LengthUnit.Meter)}"); //0.9144 m

//Returns as a double
Debug.Print($"{length.As(LengthUnit.Meter)}"); //0.9144
```

###### Absolute value
```C#
MassFlow M1 = new MassFlow(10, MassFlowUnit.HectogramPerSecond); //-10 kg/s
MassFlow M2 = M1.Abs(); //10 kg/s                   
```

###### Powers and Square Roots
```C#
Length L1 = new Length(54.3, LengthUnit.Foot); //16.55064 m
Area A1 = L1.Pow(2);  //273.9236844096 m²    
Length L2 = A1.Sqrt(); //16.55064 m               
```

###### Get the min/max/Average/Sum
```C#
Mass M1 = new Mass(43, MassUnit.Kilogram);
Mass M2 = new Mass(2, MassUnit.Megapound);
Mass M3 = new Mass(77644, MassUnit.Milligram);
Mass M4 = new Mass(345, MassUnit.Pound);

Mass MinMass = UnitMath.Min(M1, M2, M3, M4);    //7.764e+04 mg
Mass MaxMass = UnitMath.Max(M1, M2, M3, M4);    //2 Mlb
Mass MaxAvg = UnitMath.Average(M1, M2, M3, M4); //2.268e+05 kg
Mass MaxSum = UnitMath.Sum(M1, M2, M3, M4);     //9.074e+05 kg

```

```C#
Length length = Length.FromYards(1);
Length length2 = Length.FromMeters(5);

var list = new List<Length>();

list.Add(length);
list.Add(length2);

Length lenghtAvg = list.Average();
```

###### Force quantity In Range Of(min,max)
```C#
Power f1 = new(19, PowerUnit.KilojoulePerHour);
Power f2 = f1.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //5 W

Power f7 = new(-19, PowerUnit.KilojoulePerHour);
Power f8 = f7.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //-5 W

Power f9 = new(4, PowerUnit.Watt);
Power f10 = f9.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //4 W

```

###### Checks
```C#
var length = Length.FromYards(1);
var length2 = Length.FromMeters(5);

if ((length - length2).IsAboveZero())
if ((length - length2).IsBelowZero())
if ((length - length2).IsZero())
if ((length - length2).IsNotZero())

```

###### Combine methods in one line
```C#
//Create a list of Lenghts
var listOfLenghts = new List<Length>() 
                      {Length.FromYards(1), 
                      Length.FromYards(2) };


Area NewUnit = listOfLenghts //Take the list 
               .Average()    //--> calculate the average of the list
               .Pow(2)       //--> Calculate the 2. power of the lenght, making it into a Area
               .ToUnit(AreaUnit.SquareMeter); //Turn the area into a specific unit-type
                           
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
//dummy data
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
###### What units are included?
```C#
AmountOfSubstance:[mol], [mol], [cmol], [dmol], [kmol], [Mmol], [µmol], [mmol], [nmol], [pmol], [nlbmol], [µlbmol], [mlbmol], [lbmol], [klbmol], [dlbmol], [clbmol] *
Duration:[ns], [ms], [µs], [s], [min], [h], [day], [wk], [mo], [yr], [s]
ElectricCurrent:[A], [A], [cA], [kA], [MA], [µA], [mA], [nA], [pA] 
Length:[km], [hm], [m], [m], [dm], [cm], [mm], [µm], [nm], [µin], [twip], [mil], [pt], [pica], [in], [h], [ft], [yd], [fathom], [ch], [shackle], [mi], [NM], [ftUS], [ly], [kly], [Mly], [R⊙], [au], [pc], [kpc], [Mpc]
LuminousIntensity:[cd], [cd] 
Mass:[kg], [kg], [pg], [cg], [dag], [dg], [g], [hg], [µg], [mg], [ng], [t], [kt], [Mt], [em], [oz], [lb], [st], [slug], [cwt], [cwt], [kip], [t (short)], [long tn], [Mlb], [gr]
Acceleration:[m/s²], [km/s²], [m/s²], [dm/s²], [cm/s²], [µm/s²], [mm/s²], [nm/s²], [in/s²], [ft/s²], [kn/s], [kn/min], [kn/h], [g], [mg]
Angle:[°], ['], [″], [g], [rad], [crad], [drad], [µrad], [mrad], [nrad], [°], [µ°], [m°], [n°], [r]
ApparentPower:[kgm²/s³], [VA], [MVA], [kVA], [GVA] 
AreaDensity:[kg/m²], [kg/m²] 
AreaMomentOfInertia:[m⁴], [m⁴], [cm⁴], [dm⁴], [mm⁴], [in⁴], [ft⁴]
Area:[ac], [ha], [cm²], [dm²], [km²], [m²], [µm²], [m²], [mm²], [nm²], [in²], [ft²], [yd²], [mi²], [nmi²], [ch²] 
BitRate:[], [B/s], [bit/s], [Kibit/s], [Mibit/s], [Gibit/s], [Tibit/s], [Pibit/s], [Eibit/s], [KiB/s], [MiB/s], [GiB/s], [TiB/s], [PiB/s], [EiB/s], [kB/s], [MB/s], [GB/s], [TB/s], [PB/s], [EB/s], [kbit/s], [Mbit/s], [Gbit/s], [Tbit/s], [Pbit/s], [Ebit/s] 
BrakeSpecificFuelConsumption:[kg/J], [kg/J], [g/kWh], [lb/hph] 
Capacitance:[F], [F], [kF], [MF], [µF], [mF], [nF], [pF]
CoefficientOfThermalExpansion:[/K], [K⁻¹], [/°F], [/°C] 
Density:[kg/m³], [cg/dl], [cg/l], [cg/ml], [dg/dl], [dg/l], [dg/ml], [dg/µl], [g/cm³], [g/m³], [g/mm³], [g/dl], [g/l], [g/ml], [g/µl], [kg/cm³], [kg/m³], [kg/mm³], [kg/l], [kip/ft³], [kip/in³], [µg/m³], [µg/dl], [µg/l], [µg/ml], [µg/µl], [mg/m³], [mg/dl], [mg/l], [mg/ml], [mg/µl], [ng/dl], [ng/l], [ng/ml], [ng/µl], [pg/dl], [pg/l], [pg/ml], [pg/µl], [lb/ft³], [lb/in³], [ppg (imp.)], [ppg (U.S.)], [slug/ft³], [t/cm³], [t/m³], [t/mm³] 
DynamicViscosity:[Pa·s], [Pa·s], [µPa·s], [mPa·s], [lb/ft·s], [P], [cP], [N·s/m²], [lbf·s/ft²], [lbf·s/in²], [reyn]
ElectricChargeDensity:[C/m³], [C/m³] 
ElectricCharge:[C], [C], [A-h], [kA-h], [MA-h], [mA-h] 
ElectricConductivity:[S/m], [S/m], [S/in], [S/ft]
ElectricCurrentDensity:[A/m²], [A/m²], [A/in²], [A/ft²] 
ElectricCurrentGradient:[A/s], [A/s], [A/µs], [A/ms], [A/ns]
ElectricField:[V/m], [V/m]
ElectricInductance:[H], [H], [µH], [mH], [nH]
ElectricPotentialChangeRate:[V/s], [V/s], [V/min], [V/µs], [V/h], [mV/s], [mV/min], [mV/µs], [mV/h], [µV/s], [µV/min], [µV/µs], [µV/h], [MV/s], [MV/min], [MV/µs], [MV/h], [kV/s], [kV/min], [kV/µs], [kV/h]
ElectricPotential:[V], [V], [kV], [MV], [GV], [µV], [mV]
MolarMass:[kg/mol], [kg/mol], [cg/mol], [dag/mol], [dg/mol], [g/mol], [hg/mol], [kip/mol], [Mlb/mol], [µg/mol], [mg/mol], [ng/mol], [lb/mol]
ElectricResistance:[Ω], [Ω], [GΩ], [kΩ], [MΩ], [µΩ], [mΩ]
ElectricResistivity:[Ω·m], [Ω·m], [Ω·cm], [kΩ·cm], [MΩ·cm], [µΩ·cm], [mΩ·cm], [nΩ·cm], [pΩ·cm], [kΩ·m], [MΩ·m], [µΩ·m], [mΩ·m], [nΩ·m], [pΩ·m]
ElectricSurfaceChargeDensity:[C/m²], [C/m²], [C/cm²], [C/in²]
Energy:[J], [mJ], [J], [kJ], [MJ], [GJ], [TJ], [BTU], [kBTU], [MBTU], [GBTU], [eV], [keV], [MeV], [GeV], [TeV], [cal], [kcal], [Mcal], [Wday], [kWday], [MWday], [GWday], [TWday], [Wh], [kWh], [MWh], [GWh], [TWh], [ft·lb], [Dth (E.C.)], [Dth (imp.)], [Dth (U.S.)], [th (E.C.)], [th (imp.)], [th (U.S.)], [erg], [hp·h], 
Entropy:[J/K], [J/K], [cal/K], [J/K], [kcal/K], [kJ/K], [kJ/K], [MJ/K]
ForceChangeRate:[N/s], [N/s], [N/min], [lbf/s], [lbf/min], [klbf/s], [klbf/min], [nN/s], [mN/s], [µN/s], [cN/s], [daN/s], [dN/s], [kN/s], [daN/min], [kN/min] 
ForcePerLength:[N/m], [N/m], [N/cm], [N/mm], [kgf/cm], [kgf/m], [kgf/mm], [kN/cm], [kN/m], [kN/mm], [kipf/ft], [kipf/in], [MN/cm], [MN/m], [MN/mm], [µN/cm], [µN/m], [µN/mm], [mN/cm], [mN/m], [mN/mm], [lbf/ft], [lbf/in], [lbf/yd], [tf/cm], [tf/m], [tf/mm], [nN/cm], [nN/m], [nN/mm], [cN/cm], [cN/m], [cN/mm], [daN/cm], [daN/m], [daN/mm], [dN/cm], [dN/m], [dN/mm] 
Force:[N], [N], [µN], [mN], [daN], [kN], [MN], [dyn], [tf], [tf (short)], [lbf], [kgf], [ozf], [kp], [kipf], [Mlbf], [pdl]
Frequency:[Hz], [Hz], [kHz], [MHz], [GHz], [THz], [s⁻¹], [bpm], [cph], [cpm], [rad/s] 
FuelEfficiency:[m/m³], [km/l], [mpg (imp.)], [mpg (U.S.)]
HeatFlux:[W/m²], [W/m²], [W/in²], [W/ft²], [BTU/h·ft²], [BTU/min·ft²], [BTU/s·ft²], [BTU/s·in²], [cal/s·cm²], [kcal/h·m²], [kcal/s·cm²], [kW/m²], [µW/m²], [mW/m²], [nW/m²], [cW/m²], [dW/m²], [lbf/(ft·s)], [lb/s³]
HeatTransferCoefficient:[W/m²K], [W/m²K], [W/m²°C], [Btu/ft²hr°F]
Illuminance:[lx], [lx], [klx], [Mlx], [mlx]
Information:[], [B], [b], [Kib], [Mib], [Gib], [Tib], [Pib], [Eib], [KiB], [MiB], [GiB], [TiB], [PiB], [EiB], [kB], [MB], [GB], [TB], [PB], [EB], [kb], [Mb], [Gb], [Tb], [Pb], [Eb]
Irradiance:[W/m²], [W/m²], [W/cm²], [kW/cm²], [MW/cm²], [µW/cm²], [mW/cm²], [nW/cm²], [pW/cm²], [kW/m²], [MW/m²], [µW/m²], [mW/m²], [nW/m²], [pW/m²]
Irradiation:[J/m²], [J/m²], [J/cm²], [J/mm²], [kJ/m²], [kWh/m²], [mJ/cm²], [Wh/m²]
KinematicViscosity:[m²/s], [m²/s], [St], [cSt], [dSt], [kSt], [µSt], [mSt], [nSt]
LapseRate:[K/m], [∆°C/km]
LinearDensity:[kg/m], [kg/m], [g/cm], [g/m], [g/mm], [kg/cm], [kg/mm], [µg/cm], [µg/m], [µg/mm], [mg/cm], [mg/m], [mg/mm], [lb/ft], [lb/in]
LinearPowerDensity:[W/m], [W/m], [W/mm], [W/in], [W/ft], [W/cm], [mW/mm], [mW/m], [mW/in], [mW/ft], [mW/cm], [MW/mm], [MW/m], [MW/in], [MW/ft], [MW/cm], [kW/mm], [kW/m], [kW/in], [kW/ft], [kW/cm], [GW/mm], [GW/m], [GW/in], [GW/ft], [GW/cm]
LuminousFlux:[Empty], [lm]
MagneticField:[T], [T], [G], [mG], [µT], [mT], [nT]
MagneticFlux:[Wb], [Wb]
Magnetization:[A/m], [A/m]
MassFlow:[cg/day], [cg/s], [dag/day], [dag/s], [dg/day], [dg/s], [g/day], [g/h], [g/s], [Mg/day], [µg/s], [µg/day], [mg/s], [mg/day], [ng/s], [ng/day], [hg/day], [hg/s], [kg/s], [kg/s], [kg/min], [kg/h], [kg/day], [lb/s], [lb/min], [lb/h], [lb/day], [Mlb/day], [Mlb/h], [Mlb/min], [Mlb/s], [short tn/h], [t/day], [t/h]
MassFlux:[kg/sm²], [kg/sm²], [g/hcm²], [g/hm²], [g/hmm²], [g/scm²], [g/sm²], [g/smm²], [kg/hcm²], [kg/hm²], [kg/hmm²], [kg/scm²], [kg/smm²]
MassMomentOfInertia:[kgm²], [kgm²], [gcm²], [gdm²], [gm²], [gmm²], [kgcm²], [kgdm²], [kgmm²], [ktcm²], [ktdm²], [ktm²], [ktmm²], [Mtcm²], [Mtdm²], [Mtm²], [Mtmm²], [mgcm²], [mgdm²], [mgm²], [mgmm²], [lbft²], [lbin²], [slugft²], [slugin²], [tcm²], [tdm²], [tm²], [tmm²]
MolarEnergy:[J/mol], [J/mol], [kJ/mol], [MJ/mol]
MolarEntropy:[J/(mol*K)], [J/(mol*K)], [kJ/(mol*K)], [MJ/(mol*K)]
Molarity:[mol/m³], [mol/m³], [mol/l], [nmol/l], [pmol/l], [cmol/l], [dmol/l], [µmol/l], [mmol/l]
Permeability:[H/m], [H/m]
Permittivity:[F/m], [F/m]
PowerDensity:[W/m³], [W/m³], [W/l], [W/in³], [W/ft³], [TW/l], [TW/m³], [TW/in³], [TW/ft³], [pW/l], [pW/m³], [pW/in³], [pW/ft³], [nW/l], [nW/m³], [nW/in³], [nW/ft³], [mW/l], [mW/m³], [mW/in³], [mW/ft³], [µW/l], [µW/m³], [µW/in³], [µW/ft³], [MW/l], [MW/m³], [MW/in³], [MW/ft³], [kW/l], [kW/m³], [kW/in³], [kW/ft³], [GW/l], [GW/m³], [GW/in³], [GW/ft³], [dW/l], [dW/m³], [dW/in³], [dW/ft³], [daW/l], [daW/m³], [daW/in³], [daW/ft³]
Power:[W], [fW], [pW], [nW], [µW], [mW], [dW], [W], [daW], [kW], [MW], [GW], [TW], [PW], [mJ/h], [J/h], [kJ/h], [MJ/h], [GJ/h], [BTU/h], [BTU/min], [BTU/s], [kBTU/h], [hp(S)], [hp(E)], [hp(H)], [hp(I)], [hp(M)], [cal/s], [kcal/h], [kcal/s], [L⊙]
PressureChangeRate:[Pa/s], [Pa/s], [Pa/min], [MPa/s], [MPa/min], [ksi/s], [ksi/min], [kPa/s], [kPa/min], [atm/s], [psi/min], [psi/s], [Mpsi/s], [Mpsi/min]
Pressure:[Pa], [Pa], [µPa], [mPa], [daPa], [hPa], [kPa], [MPa], [GPa], [atm], [ft of head], [inHg], [inH2O], [m of head], [mmHg], [at], [torr], [bar], [µbar], [mbar], [cbar], [dbar], [kbar], [Mbar], [dyn/cm²], [kgf/cm²], [kgf/m²], [kgf/mm²], [kN/cm²], [kN/m²], [kN/mm²], [MN/m²], [tf/cm²], [tf/m²], [tf/mm²], [N/mm²], [N/cm²], [N/m²], [kipf/ft²], [ksi], [lb/ft²], [psi], [lbm/(in·s²)]
Ratio:[], [], [ppb], [ppm], [‰], [ppt], [%], [cg/g], [cg/kg], [dag/g], [dag/kg], [dg/g], [dg/kg], [g/g], [g/kg], [hg/g], [hg/kg], [kg/g], [kg/kg], [µg/g], [µg/kg], [mg/g], [mg/kg], [ng/g], [ng/kg], [cl/l], [cl/ml], [dl/l], [dl/ml], [l/l], [l/ml], [µl/l], [µl/ml], [ml/l], [ml/ml], [nl/l], [nl/ml], [pl/l], [pl/ml]
ReactiveEnergy:[vars], [varh], [Mvarh], [kvarh]
ReactivePower:[var], [var], [Mvar], [kvar], [Gvar]
RotationalSpeed:[rad/s], [rad/s], [Hz], [kHz], [MHz], [GHz], [THz], [s⁻¹], [bpm], [cph], [cpm]
SpecificEnergy:[J/kg], [J/kg], [kJ/kg], [MJ/kg], [BTU/lb], [cal/g], [kcal/g], [Wday/kg], [kWday/kg], [MWday/kg], [GWday/kg], [TWday/kg], [Wh/kg], [kWh/kg], [MWh/kg], [GWh/kg], [Wday/t], [kWday/t], [MWday/t], [GWday/t], [TWday/t], [Wday/t (short)], [kWday/t (short)], [MWday/t (short)], [GWday/t (short)], [TWday/t (short)]
SpecificEntropy:[J/kg*K], [J/kg*K], [J/kg*K], [kJ/kg*K], [kJ/kg*K], [MJ/kg*K], [MJ/kg*K], [J/kg*°R], [cal/g*K], [kcal/g*K], [BTU/lb*K], [BTU/lb*°R], [BTU/lb*°R]
SpecificWeight:[N/m³], [N/m³], [kgf/cm³], [kgf/m³], [kgf/mm³], [kN/cm³], [kN/m³], [kN/mm³], [kipf/ft³], [kipf/in³], [MN/m³], [N/cm³], [N/mm³], [lbf/ft³], [lbf/in³], [tf/cm³], [tf/m³], [tf/mm³]
Speed:[cm/h], [cm/min], [cm/s], [dm/min], [dm/s], [ft/h], [ft/min], [ft/s], [in/h], [in/min], [in/s], [km/h], [km/min], [km/s], [kn], [m/h], [m/min], [m/s], [µm/min], [µm/s], [mph], [mm/h], [mm/min], [mm/s], [nm/min], [nm/s], [ftUS/h], [ftUS/min], [ftUS/s], [yd/h], [yd/min], [yd/s], [km/h], [m/s], [mi/s]
TemperatureChangeRate:[°C/s], [°C/s], [°C/min], [c°C/s], [da°C/s], [d°C/s], [h°C/s], [k°C/s], [µ°C/s], [m°C/s], [n°C/s]
ThermalConductivity:[W/m·K], [W/m·K], [BTU/h·ft·°F]
ThermalResistance:[m²K/W], [m²°C/W], [m²K/kW], [cm²K/W], [cm²Hr°C/kcal], [Hrft²°F/Btu]
TorquePerLength:[N·m/m], [N·m/m], [kgf·cm/m], [kgf·m/m], [kgf·mm/m], [kN·cm/m], [kN·m/m], [kN·mm/m], [kipf·ft/ft], [kipf·in/ft], [MN·cm/m], [MN·m/m], [MN·mm/m], [Mlbf·ft/ft], [Mlbf·in/ft], [N·cm/m], [N·mm/m], [lbf·ft/ft], [lbf·in/ft], [tf·cm/m], [tf·m/m], [tf·mm/m]
Torque:[N·m], [N·m], [kN·m], [MN·m], [N·mm], [kN·mm], [MN·mm], [N·cm], [MN·cm], [pdl·ft], [lbf·ft], [lbf·in], [tf·cm], [tf·m], [tf·mm], [kN·cm], [kgf·cm], [kgf·m], [kgf·mm], [kipf·ft], [Mlbf·ft], [kipf·in], [Mlbf·in]
VolumeFlow:[af/d], [af/h], [af/m], [af/s], [cl/day], [cl/min], [cl/s], [cm³/min], [dm³/min], [ft³/h], [ft³/min], [ft³/s], [m³/day], [m³/h], [m³/min], [m³/s], [m³/s], [mm³/s], [yd³/day], [yd³/h], [yd³/min], [yd³/s], [dl/day], [dl/min], [dl/s], [kl/day], [kl/min], [kl/s], [kgal (U.S.)/min], [l/day], [l/h], [l/min], [l/s], [Ml/day], [µl/day], [µl/min], [µl/s], [ml/day], [ml/min], [ml/s], [MGD], [nl/day], [nl/min], [nl/s], [bbl/day], [bbl/h], [bbl/min], [bbl/s], [gal (U. K.)/d], [gal (imp.)/h], [gal (imp.)/min], [gal (imp.)/s], [gpd], [gal (U.S.)/h], [gal (U.S.)/min], [gal (U.S.)/s], [Mgal (imp.)/s]
VolumePerLength:[m³/m], [m³/m], [yd³/ft], [yd³/ftUS], [l/km], [l/m], [l/mm], [bbl/ft]
Volume:[m³], [m³], [hm³], [km³], [km³], [µm³], [mi³], [mm³], [yd³], [in³], [hm³], [ft³], [hft³], [kft³], [Mft³], [dm³], [cm³], [l], [nl], [µl], [ml], [dl], [cl], [hl], [kl], [Ml], [pl], [ac-ft], [bf], [], [bl (imp.)], [tsp], [], [gal (imp.)], [kgal (imp.)], [Mgal (imp.)], [oz (imp.)], [pt (imp.)], [], [bl (U.S.)], [], [oz (U.S.)], [gal (U.S.)], [kgal (U.S.)], [Mgal (U.S.)], [dagal (U.S.)], [dgal (U.S.)], [hgal (U.S.)], [bbl], [], [pt (U.S.)], [qt (U.S.)], [], []
WarpingMomentOfInertia:[m⁶], [mm⁶], [in⁶], [ft⁶], [dm⁶], [cm⁶], [m⁶]
SpecificThermalResistance:[mK/W], [mK/W], [mK/kW], [cmK/W] 
```
