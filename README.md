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

Density D1 = mass / volume; // 2.5 kg/m??
Density D2 = volume / mass; // WrongUnitException: 'This is NOT a [kg/m??] as expected! Your Unit is a [m??/kg]'
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
Area A1 = L1.Pow(2);  //273.9236844096 m??    
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
string Output1 = T1.ToString(); // 10.57 ??C

//This will use 5 significant digits
string Output2 = T1.ToString("S5"); // 10.572 ??C

//Same as ToString but looks better
string Output3 = $"{T1:S5}"; // 10.572 ??C

//Same as "S4" but without the unit
string Output4 = $"{T1:V4}"; // 10.57

//Display the unit without value
string Output5 = $"{T1:UnitOnly}"; // ??C

//All the normal options can still be used
//https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

//The build-in "General"
string Output6 = $"{T1:G1}"; // 1E+01 ??C
string Output7 = $"{T1:G4}"; // 10.57 ??C
            
```
###### What units are included?
```C#
Acceleration:[m/s??], [km/s??], [m/s??], [dm/s??], [cm/s??], [??m/s??], [mm/s??], [nm/s??], [in/s??], [ft/s??], [kn/s], [kn/min], [kn/h], [g], [mg],
Angle:[??], ['], [?], [g], [rad], [crad], [drad], [??rad], [mrad], [nrad], [??], [????], [m??], [n??], [r],
AreaDensity:[kg/m??], [kg/m??],
AreaMomentOfInertia:[m4], [m4], [cm4], [dm4], [mm4], [in4], [ft4],
Area:[ac], [ha], [cm??], [dm??], [km??], [m??], [??m??], [m??], [mm??], [nm??], [in??], [ft??], [yd??], [mi??], [nmi??], [ch??],
BitRate:[], [B/s], [bit/s], [Kibit/s], [Mibit/s], [Gibit/s], [Tibit/s], [Pibit/s], [Eibit/s], [KiB/s], [MiB/s], [GiB/s], [TiB/s], [PiB/s], [EiB/s], [kB/s], [MB/s], [GB/s], [TB/s], [PB/s], [EB/s], [kbit/s], [Mbit/s], [Gbit/s], [Tbit/s], [Pbit/s], [Ebit/s],
BrakeSpecificFuelConsumption:[kg/J], [kg/J], [g/kWh], [lb/hph],
Capacitance:[F], [F], [kF], [MF], [??F], [mF], [nF], [pF],
CoefficientOfThermalExpansion:[/K], [K???], [/??F], [/??C],
Density:[kg/m??], [cg/dl], [cg/l], [cg/ml], [dg/dl], [dg/l], [dg/ml], [dg/??l], [g/cm??], [g/m??], [g/mm??], [g/dl], [g/l], [g/ml], [g/??l], [kg/cm??], [kg/m??], [kg/mm??], [kg/l], [kip/ft??], [kip/in??], [??g/m??], [??g/dl], [??g/l], [??g/ml], [??g/??l], [mg/m??], [mg/dl], [mg/l], [mg/ml], [mg/??l], [ng/dl], [ng/l], [ng/ml], [ng/??l], [pg/dl], [pg/l], [pg/ml], [pg/??l], [lb/ft??], [lb/in??], [ppg (imp.)], [ppg (U.S.)], [slug/ft??], [t/cm??], [t/m??], [t/mm??],
DynamicViscosity:[Pa??s], [Pa??s], [??Pa??s], [mPa??s], [lb/ft??s], [P], [cP], [N??s/m??], [lbf??s/ft??], [lbf??s/in??], [reyn],
ElectricChargeDensity:[C/m??], [C/m??],
ElectricCharge:[C], [C], [A-h], [kA-h], [MA-h], [mA-h],
ElectricConductivity:[S/m], [S/m], [S/in], [S/ft],
ElectricCurrentDensity:[A/m??], [A/m??], [A/in??], [A/ft??],
ElectricCurrentGradient:[A/s], [A/s], [A/??s], [A/ms], [A/ns],
ElectricField:[V/m], [V/m],
ElectricInductance:[H], [H], [??H], [mH], [nH],
ElectricPotentialChangeRate:[V/s], [V/s], [V/min], [V/??s], [V/h], [mV/s], [mV/min], [mV/??s], [mV/h], [??V/s], [??V/min], [??V/??s], [??V/h], [MV/s], [MV/min], [MV/??s], [MV/h], [kV/s], [kV/min], [kV/??s], [kV/h],
ElectricPotential:[V], [V], [kV], [MV], [GV], [??V], [mV],
MolarMass:[kg/mol], [kg/mol], [cg/mol], [dag/mol], [dg/mol], [g/mol], [hg/mol], [kip/mol], [Mlb/mol], [??g/mol], [mg/mol], [ng/mol], [lb/mol],
ElectricResistance:[O], [O], [GO], [kO], [MO], [??O], [mO],
ElectricResistivity:[O??m], [O??m], [O??cm], [kO??cm], [MO??cm], [??O??cm], [mO??cm], [nO??cm], [pO??cm], [kO??m], [MO??m], [??O??m], [mO??m], [nO??m], [pO??m],
ElectricSurfaceChargeDensity:[C/m??], [C/m??], [C/cm??], [C/in??],
Energy:[J], [mJ], [J], [kJ], [MJ], [GJ], [TJ], [BTU], [kBTU], [MBTU], [GBTU], [eV], [keV], [MeV], [GeV], [TeV], [cal], [kcal], [Mcal], [Wday], [kWday], [MWday], [GWday], [TWday], [Wh], [kWh], [MWh], [GWh], [TWh], [ft??lb], [Dth (E.C.)], [Dth (imp.)], [Dth (U.S.)], [th (E.C.)], [th (imp.)], [th (U.S.)], [erg], [hp??h],
Entropy:[J/K], [J/K], [cal/K], [J/K], [kcal/K], [kJ/K], [kJ/K], [MJ/K],
ForceChangeRate:[N/s], [N/s], [N/min], [lbf/s], [lbf/min], [klbf/s], [klbf/min], [nN/s], [mN/s], [??N/s], [cN/s], [daN/s], [dN/s], [kN/s], [daN/min], [kN/min],
ForcePerLength:[N/m], [N/m], [N/cm], [N/mm], [kgf/cm], [kgf/m], [kgf/mm], [kN/cm], [kN/m], [kN/mm], [kipf/ft], [kipf/in], [MN/cm], [MN/m], [MN/mm], [??N/cm], [??N/m], [??N/mm], [mN/cm], [mN/m], [mN/mm], [lbf/ft], [lbf/in], [lbf/yd], [tf/cm], [tf/m], [tf/mm], [nN/cm], [nN/m], [nN/mm], [cN/cm], [cN/m], [cN/mm], [daN/cm], [daN/m], [daN/mm], [dN/cm], [dN/m], [dN/mm],
Force:[N], [N], [??N], [mN], [daN], [kN], [MN], [dyn], [tf], [tf (short)], [lbf], [kgf], [ozf], [kp], [kipf], [Mlbf], [pdl],
Frequency:[Hz], [Hz], [kHz], [MHz], [GHz], [THz], [s???], [bpm], [cph], [cpm], [rad/s],
FuelEfficiency:[m/m??], [km/l], [mpg (imp.)], [mpg (U.S.)],
HeatFlux:[W/m??], [W/m??], [W/in??], [W/ft??], [BTU/h??ft??], [BTU/min??ft??], [BTU/s??ft??], [BTU/s??in??], [cal/s??cm??], [kcal/h??m??], [kcal/s??cm??], [kW/m??], [??W/m??], [mW/m??], [nW/m??], [cW/m??], [dW/m??], [lbf/(ft??s)], [lb/s??],
HeatTransferCoefficient:[W/m??K], [W/m??K], [W/m????C], [Btu/ft??hr??F],
Illuminance:[lx], [lx], [klx], [Mlx], [mlx],
Information:[], [B], [b], [Kib], [Mib], [Gib], [Tib], [Pib], [Eib], [KiB], [MiB], [GiB], [TiB], [PiB], [EiB], [kB], [MB], [GB], [TB], [PB], [EB], [kb], [Mb], [Gb], [Tb], [Pb], [Eb],
Irradiance:[W/m??], [W/m??], [W/cm??], [kW/cm??], [MW/cm??], [??W/cm??], [mW/cm??], [nW/cm??], [pW/cm??], [kW/m??], [MW/m??], [??W/m??], [mW/m??], [nW/m??], [pW/m??],
Irradiation:[J/m??], [J/m??], [J/cm??], [J/mm??], [kJ/m??], [kWh/m??], [mJ/cm??], [Wh/m??],
KinematicViscosity:[m??/s], [m??/s], [St], [cSt], [dSt], [kSt], [??St], [mSt], [nSt],
LapseRate:[K/m], [???C/km],
LinearDensity:[kg/m], [kg/m], [g/cm], [g/m], [g/mm], [kg/cm], [kg/mm], [??g/cm], [??g/m], [??g/mm], [mg/cm], [mg/m], [mg/mm], [lb/ft], [lb/in],
LinearPowerDensity:[W/m], [W/m], [W/mm], [W/in], [W/ft], [W/cm], [mW/mm], [mW/m], [mW/in], [mW/ft], [mW/cm], [MW/mm], [MW/m], [MW/in], [MW/ft], [MW/cm], [kW/mm], [kW/m], [kW/in], [kW/ft], [kW/cm], [GW/mm], [GW/m], [GW/in], [GW/ft], [GW/cm],
LuminousFlux:[Empty], [lm],
MagneticField:[T], [T], [G], [mG], [??T], [mT], [nT],
MagneticFlux:[Wb], [Wb],
Magnetization:[A/m], [A/m],
MassFlow:[cg/day], [cg/s], [dag/day], [dag/s], [dg/day], [dg/s], [g/day], [g/h], [g/s], [Mg/day], [??g/s], [??g/day], [mg/s], [mg/day], [ng/s], [ng/day], [hg/day], [hg/s], [kg/s], [kg/s], [kg/min], [kg/h], [kg/day], [lb/s], [lb/min], [lb/h], [lb/day], [Mlb/day], [Mlb/h], [Mlb/min], [Mlb/s], [short tn/h], [t/day], [t/h],
MassFlux:[kg/sm??], [kg/sm??], [g/hcm??], [g/hm??], [g/hmm??], [g/scm??], [g/sm??], [g/smm??], [kg/hcm??], [kg/hm??], [kg/hmm??], [kg/scm??], [kg/smm??],
MassMomentOfInertia:[kgm??], [kgm??], [gcm??], [gdm??], [gm??], [gmm??], [kgcm??], [kgdm??], [kgmm??], [ktcm??], [ktdm??], [ktm??], [ktmm??], [Mtcm??], [Mtdm??], [Mtm??], [Mtmm??], [mgcm??], [mgdm??], [mgm??], [mgmm??], [lbft??], [lbin??], [slugft??], [slugin??], [tcm??], [tdm??], [tm??], [tmm??],
MolarEnergy:[J/mol], [J/mol], [kJ/mol], [MJ/mol],
MolarEntropy:[J/(mol??K)], [J/(mol??K)], [kJ/(mol??K)], [MJ/(mol??K)],
Molarity:[mol/m??], [mol/m??], [mol/l], [nmol/l], [pmol/l], [cmol/l], [dmol/l], [??mol/l], [mmol/l],
Permeability:[H/m], [H/m],
Permittivity:[F/m], [F/m],
PowerDensity:[W/m??], [W/m??], [W/l], [W/in??], [W/ft??], [TW/l], [TW/m??], [TW/in??], [TW/ft??], [pW/l], [pW/m??], [pW/in??], [pW/ft??], [nW/l], [nW/m??], [nW/in??], [nW/ft??], [mW/l], [mW/m??], [mW/in??], [mW/ft??], [??W/l], [??W/m??], [??W/in??], [??W/ft??], [MW/l], [MW/m??], [MW/in??], [MW/ft??], [kW/l], [kW/m??], [kW/in??], [kW/ft??], [GW/l], [GW/m??], [GW/in??], [GW/ft??], [dW/l], [dW/m??], [dW/in??], [dW/ft??], [daW/l], [daW/m??], [daW/in??], [daW/ft??],
Power:[W], [fW], [pW], [nW], [??W], [mW], [dW], [W], [daW], [kW], [MW], [GW], [TW], [PW], [mJ/h], [J/h], [kJ/h], [MJ/h], [GJ/h], [BTU/h], [BTU/min], [BTU/s], [kBTU/h], [hp(S)], [hp(E)], [hp(H)], [hp(I)], [hp(M)], [cal/s], [kcal/h], [kcal/s], [L?],
PressureChangeRate:[Pa/s], [Pa/s], [Pa/min], [MPa/s], [MPa/min], [ksi/s], [ksi/min], [kPa/s], [kPa/min], [atm/s], [psi/min], [psi/s], [Mpsi/s], [Mpsi/min],
Pressure:[Pa], [Pa], [??Pa], [mPa], [daPa], [hPa], [kPa], [MPa], [GPa], [atm], [ft of head], [inHg], [inH2O], [m of head], [mmHg], [at], [torr], [bar], [??bar], [mbar], [cbar], [dbar], [kbar], [Mbar], [dyn/cm??], [kgf/cm??], [kgf/m??], [kgf/mm??], [kN/cm??], [kN/m??], [kN/mm??], [MN/m??], [tf/cm??], [tf/m??], [tf/mm??], [N/mm??], [N/cm??], [N/m??], [kipf/ft??], [ksi], [lb/ft??], [psi], [lbm/(in??s??)],
Ratio:[], [], [ppb], [ppm], [%], [ppt], [%], [cg/g], [cg/kg], [dag/g], [dag/kg], [dg/g], [dg/kg], [g/g], [g/kg], [hg/g], [hg/kg], [kg/g], [kg/kg], [??g/g], [??g/kg], [mg/g], [mg/kg], [ng/g], [ng/kg], [cl/l], [cl/ml], [dl/l], [dl/ml], [l/l], [l/ml], [??l/l], [??l/ml], [ml/l], [ml/ml], [nl/l], [nl/ml], [pl/l], [pl/ml],
ReactiveEnergy:[vars], [varh], [Mvarh], [kvarh],
ReactivePower:[var], [var], [Mvar], [kvar], [Gvar],
RotationalSpeed:[rad/s], [rad/s], [Hz], [kHz], [MHz], [GHz], [THz], [s???], [bpm], [cph], [cpm],
SpecificEnergy:[J/kg], [J/kg], [kJ/kg], [MJ/kg], [BTU/lb], [cal/g], [kcal/g], [Wday/kg], [kWday/kg], [MWday/kg], [GWday/kg], [TWday/kg], [Wh/kg], [kWh/kg], [MWh/kg], [GWh/kg], [Wday/t], [kWday/t], [MWday/t], [GWday/t], [TWday/t], [Wday/t (short)], [kWday/t (short)], [MWday/t (short)], [GWday/t (short)], [TWday/t (short)],
SpecificEntropy:[J/kg??K], [J/kg??K], [J/kg??K], [kJ/kg??K], [kJ/kg??K], [MJ/kg??K], [MJ/kg??K], [J/kg????R], [cal/g??K], [kcal/g??K], [BTU/lb??K], [BTU/lb????R], [BTU/lb????R],
SpecificWeight:[N/m??], [N/m??], [kgf/cm??], [kgf/m??], [kgf/mm??], [kN/cm??], [kN/m??], [kN/mm??], [kipf/ft??], [kipf/in??], [MN/m??], [N/cm??], [N/mm??], [lbf/ft??], [lbf/in??], [tf/cm??], [tf/m??], [tf/mm??],
Speed:[cm/h], [cm/min], [cm/s], [dm/min], [dm/s], [ft/h], [ft/min], [ft/s], [in/h], [in/min], [in/s], [km/h], [km/min], [km/s], [kn], [m/h], [m/min], [m/s], [??m/min], [??m/s], [mph], [mm/h], [mm/min], [mm/s], [nm/min], [nm/s], [ftUS/h], [ftUS/min], [ftUS/s], [yd/h], [yd/min], [yd/s], [km/h], [m/s], [mi/s],
TemperatureChangeRate:[??C/s], [??C/s], [??C/min], [c??C/s], [da??C/s], [d??C/s], [h??C/s], [k??C/s], [????C/s], [m??C/s], [n??C/s],
ThermalConductivity:[W/m??K], [W/m??K], [BTU/h??ft????F],
ThermalResistance:[m??K/W], [m????C/W], [m??K/kW], [cm??K/W], [cm??Hr??C/kcal], [Hrft????F/Btu],
TorquePerLength:[N??m/m], [N??m/m], [kgf??cm/m], [kgf??m/m], [kgf??mm/m], [kN??cm/m], [kN??m/m], [kN??mm/m], [kipf??ft/ft], [kipf??in/ft], [MN??cm/m], [MN??m/m], [MN??mm/m], [Mlbf??ft/ft], [Mlbf??in/ft], [N??cm/m], [N??mm/m], [lbf??ft/ft], [lbf??in/ft], [tf??cm/m], [tf??m/m], [tf??mm/m],
Torque:[N??m], [N??m], [kN??m], [MN??m], [N??mm], [kN??mm], [MN??mm], [N??cm], [MN??cm], [pdl??ft], [lbf??ft], [lbf??in], [tf??cm], [tf??m], [tf??mm], [kN??cm], [kgf??cm], [kgf??m], [kgf??mm], [kipf??ft], [Mlbf??ft], [kipf??in], [Mlbf??in],
VolumeFlow:[af/d], [af/h], [af/m], [af/s], [cl/day], [cl/min], [cl/s], [cm??/min], [dm??/min], [ft??/h], [ft??/min], [ft??/s], [m??/day], [m??/h], [m??/min], [m??/s], [m??/s], [mm??/s], [yd??/day], [yd??/h], [yd??/min], [yd??/s], [dl/day], [dl/min], [dl/s], [kl/day], [kl/min], [kl/s], [kgal (U.S.)/min], [l/day], [l/h], [l/min], [l/s], [Ml/day], [??l/day], [??l/min], [??l/s], [ml/day], [ml/min], [ml/s], [MGD], [nl/day], [nl/min], [nl/s], [bbl/day], [bbl/h], [bbl/min], [bbl/s], [gal (U. K.)/d], [gal (imp.)/h], [gal (imp.)/min], [gal (imp.)/s], [gpd], [gal (U.S.)/h], [gal (U.S.)/min], [gal (U.S.)/s], [Mgal (imp.)/s],
VolumePerLength:[m??/m], [m??/m], [yd??/ft], [yd??/ftUS], [l/km], [l/m], [l/mm], [bbl/ft],
Volume:[m??], [m??], [hm??], [km??], [km??], [??m??], [mi??], [mm??], [yd??], [in??], [hm??], [ft??], [hft??], [kft??], [Mft??], [dm??], [cm??], [l], [nl], [??l], [ml], [dl], [cl], [hl], [kl], [Ml], [pl], [ac-ft], [bf], [], [bl (imp.)], [tsp], [], [gal (imp.)], [kgal (imp.)], [Mgal (imp.)], [oz (imp.)], [pt (imp.)], [], [bl (U.S.)], [], [oz (U.S.)], [gal (U.S.)], [kgal (U.S.)], [Mgal (U.S.)], [dagal (U.S.)], [dgal (U.S.)], [hgal (U.S.)], [bbl], [], [pt (U.S.)], [qt (U.S.)], [], [],
WarpingMomentOfInertia:[m6], [mm6], [in6], [ft6], [dm6], [cm6], [m6],
SpecificThermalResistance:[mK/W], [mK/W], [mK/kW], [cmK/W],
ApparentPower:[kgm??/s??], [VA], [MVA], [kVA], [GVA],
Enthalpy:[J/kg], [J/kg], [kJ/kg], [MJ/kg], [BTU/lb], [cal/g], [kcal/g], [Wday/kg], [kWday/kg], [MWday/kg], [GWday/kg], [TWday/kg], [Wh/kg], [kWh/kg], [MWh/kg], [GWh/kg], [Wday/t], [kWday/t], [MWday/t], [GWday/t], [TWday/t], [Wday/t (short)], [kWday/t (short)], [MWday/t (short)], [GWday/t (short)], [TWday/t (short)],
SpecificHeatCapacity:[J/kg??K], [J/kg??K], [J/kg??K], [kJ/kg??K], [kJ/kg??K], [MJ/kg??K], [MJ/kg??K], [J/kg????R], [cal/g??K], [kcal/g??K], [BTU/lb??K], [BTU/lb????R], [BTU/lb????R],
AmountOfSubstance:[mol], [mol], [cmol], [dmol], [kmol], [Mmol], [??mol], [mmol], [nmol], [pmol], [nlbmol], [??lbmol], [mlbmol], [lbmol], [klbmol], [dlbmol], [clbmol],
Duration:[ns], [ms], [??s], [s], [min], [h], [day], [wk], [mo], [yr], [s],
ElectricCurrent:[A], [A], [cA], [kA], [MA], [??A], [mA], [nA], [pA],
Length:[km], [hm], [m], [m], [dm], [cm], [mm], [??m], [nm], [??in], [twip], [mil], [pt], [pica], [in], [h], [ft], [yd], [fathom], [ch], [shackle], [mi], [NM], [ftUS], [ly], [kly], [Mly], [R?], [au], [pc], [kpc], [Mpc],
LuminousIntensity:[cd], [cd],
Mass:[kg], [kg], [pg], [cg], [dag], [dg], [g], [hg], [??g], [mg], [ng], [t], [kt], [Mt], [em], [oz], [lb], [st], [slug], [cwt], [cwt], [kip], [t (short)], [long tn], [Mlb], [gr],
Temperature:[K], [K], [??C], [??F], [??R],

```
