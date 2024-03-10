namespace EngineeringUnits.Units;

//public class testUnit : Enumeration
//{

//    public static readonly testUnit SI = new(LengthUnit.SI);
//    public static readonly testUnit CubicMeter = new(LengthUnit.Meter);
//    public static readonly testUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
//    public static readonly testUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);

//    public testUnit(LengthUnit Length, string NewSymbol = "Empty")
//    {
//        Unit = Length * Length * Length;
//        SetNewSymbol(NewSymbol);
//    }

//    public testUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty")
//    {
//        Unit = Area * Length;
//        SetNewSymbol(NewSymbol, $"{Area}-{Length}");
//    }

//    public testUnit(PreFix SI, testUnit unit)
//    {
//        Unit = unit.Unit.Copy() * PrefixSISize(SI);
//        SetNewSymbol(SI);
//    }

//    public testUnit(testUnit unit, string NewSymbol = "Empty")
//    {
//        Unit = unit.Unit.Copy();
//        SetNewSymbol(NewSymbol);
//    }

//}