# EngineeringUnits


This is an (almost) interchangeable version of [UnitsNet](https://github.com/angularsen/UnitsNet) which mean you just have to change the *using* if you already use [UnitsNet](https://github.com/angularsen/UnitsNet)

```
//using UnitsNet;
//using UnitsNet.Units;

using EngineeringUnits;
using EngineeringUnits.Units;
```



## Comparing UnitsNet and EngineeringUnits


###### :heavy_check_mark: EngineeringUnits can handle mathematical operations (+-*/) between any unit

```
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
```
Length L2 = new Length(1, LengthUnit.Mile);
Correct result in Inch:   63360

EngineeringUnits in Inch: 63360
UnitsNet in Inch:         63359,84251968504
```

###### :triangular_flag_on_post: Unit checks has been moved from Compile time to runtime. In [UnitsNet](https://github.com/angularsen/UnitsNet) if you do mathematical operations on units that doesnt turn into the expected unit, you're get an error before you compile the program. In EngineeringUnits you still have the same check but you will get the error when you run the program.



## Should I change from UnitsNet to EngineeringUnits?


###### :heavy_check_mark: If you are working with engineering-, physics- , chemical- equations then EngineeringUnits will make your life easier
###### :triangular_flag_on_post: If you are just making converions ( Meter -> Inch) and you dont care about the extra precision then UnitsNet and EngineeringUnits are identical.


## How to install

###### :heavy_check_mark: Nuget Package: EngineeringUnits


## The future of EngineeringUnits

###### :white_check_mark: Create Unittests to compare everything in UnitsNet and EngineeringUnits
###### :green_square: Optimize code for faster execution time 
###### :green_square: Refactor parts of the code that are 'not too well written' 
###### :green_square: Create more alias for units which have the same baseunit but have different names
###### :green_square: Create class with all commonly used physical constants (speed of light, Planck constant, Boltzmann constant.. etc)
###### :green_square: Make EngineeringUnits and UnitsNet even more interchangeable
###### :green_square: Fix all user reported bug
###### :green_square: Add user requested functionality
