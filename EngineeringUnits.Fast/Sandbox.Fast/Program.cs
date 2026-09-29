using EngineeringUnits.Fast;


Console.WriteLine("Hello, World!");


// Power q = m1 * p1 * (t2 - t1) from the EngineeringUnits README
SpecificEntropy p1 = SpecificEntropy.FromJoulePerKilogramKelvin(1);
MassFlow m1 = MassFlow.FromKilogramPerSecond(1);
Temperature t2 = Temperature.FromDegreeCelsius(10);
Temperature t1 = Temperature.FromDegreeCelsius(5);

Power q = m1 * p1 * (t2 - t1);
