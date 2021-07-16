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
###### :heavy_check_mark: Temperature calculations are done just like any other unit (TemperatureDelta has been removed!)
###### :heavy_check_mark: Units can have alias. Ex *SpecificEnergy* and *Enthalpy* are the same thing and you can just choose the one you normally use. (No code duplication for this option!)
###### :triangular_flag_on_post: Unit checks has been moved from Compile time to runtime. In [UnitsNet](https://github.com/angularsen/UnitsNet) if you do mathematical operations on units that doesnt turn into the expected unit, you're get an error before you compile the program. In EngineeringUnits you still have the same check but you will get the error when you run the program.



## Should I change from UnitsNet to EngineeringUnits?


###### :heavy_check_mark: If you are working with engineering-, physics- , chemical- equations then EngineeringUnits will make your life easier
###### :triangular_flag_on_post: If you are just making converions ( Meter -> Inch) then UnitsNet and EngineeringUnits are identical.

