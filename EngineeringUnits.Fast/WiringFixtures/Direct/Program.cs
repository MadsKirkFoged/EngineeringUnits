using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;

MassFlow m = MassFlow.FromKilogramPerSecond(2);
SpecificEntropy cp = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
Temperature tIn = Temperature.FromDegreeCelsius(10), tOut = Temperature.FromDegreeCelsius(35);

Power q = m * cp * (tOut - tIn);
Console.WriteLine(q.ToString(PowerUnit.Kilowatt));

#if MISTAKE
Power wrong = m * m;
#endif
