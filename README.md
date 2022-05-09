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
###### Unit lists

####### AmountOfSubstance:[mol], [mol], [cmol], [dmol], [kmol], [Mmol], [µmol], [mmol], [nmol], [pmol], [nlbmol], [µlbmol], [mlbmol], [lbmol], [klbmol], [dlbmol], [clbmol], 
