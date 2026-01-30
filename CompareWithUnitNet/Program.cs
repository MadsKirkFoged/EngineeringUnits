// See https://aka.ms/new-console-template for more information





EngineeringUnits.Length L1 = new EngineeringUnits.Length(1, EngineeringUnits.Units.LengthUnit.Meter);
UnitsNet.Length L2 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Meter);


var L11 = L1.ToUnit(EngineeringUnits.Units.LengthUnit.Foot)
            .ToUnit(EngineeringUnits.Units.LengthUnit.Meter);

var L22 = L2.ToUnit(UnitsNet.Units.LengthUnit.Foot)
            .ToUnit(UnitsNet.Units.LengthUnit.Meter);

Console.WriteLine(L11 == L1);
Console.WriteLine(L22 == L2);


var test1 = L1.ToString();
var test2 = L2.ToString();

Console.WriteLine("Hello, World!");


