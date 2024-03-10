namespace EngineeringUnits;

//public partial class test : BaseUnit
//{

//    public test()
//    {
//        Unit = testUnit.SI.Unit.Copy();
//    }

//    public test(decimal value, testUnit selectedUnit) : base(value, selectedUnit.Unit) { }
//    public test(double value, testUnit selectedUnit) : base(value, selectedUnit.Unit) { }
//    public test(int value, testUnit selectedUnit) : base(value, selectedUnit.Unit) { }

//    public static test From(double value, testUnit unit) => new test(value, unit);
//    public double As(testUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
//    public test ToUnit(testUnit selectedUnit) => new test(ToTheOutSide(selectedUnit.Unit), selectedUnit);
//    public static test Zero => new test(0, testUnit.SI);

//    public static implicit operator test(UnknownUnit Unit)
//    {
//        test local = new test(0, testUnit.SI);

//        local.Transform(Unit);
//        return local;
//    }

//}
