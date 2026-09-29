using EngineeringUnits.Fast;

Power q = Pump.Heat(MassFlow.FromKilogramPerSecond(2), Enthalpy.FromKilojoulePerKilogram(3));
Console.WriteLine(q);

#if MISTAKE
MassFlow m = MassFlow.FromKilogramPerSecond(1);
Power wrong = m * m;
#endif
