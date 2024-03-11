using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class UnitMathWithNulls
{

    [TestMethod]
    public void MathWithNullShouldBeNull()
    {
        var f1 = Frequency.FromMegahertz(-32);
        Frequency f2 = null;

        Frequency f3 = f1 + f2;
        Frequency f4 = f1 - f2;
        Frequency f5 = f1 * f2;
        Frequency f6 = f1 / f2;

        Assert.IsNull(f3);
        Assert.IsNull(f4);
        Assert.IsNull(f5);
        Assert.IsNull(f6);

    }

    [TestMethod]
    public void MathWithNullShouldBeNull2()
    {
        var f1 = Frequency.FromMegahertz(-32).ToUnknownUnit();
        UnknownUnit f2 = null;

        UnknownUnit f3 = f1 + f2;
        UnknownUnit f4 = f1 - f2;
        UnknownUnit f5 = f1 * f2;
        UnknownUnit f6 = f1 / f2;

        Assert.IsNull(f3);
        Assert.IsNull(f4);
        Assert.IsNull(f5);
        Assert.IsNull(f6);

    }

    [TestMethod]
    public void MathWithNullShouldBeNull3()
    {
        var f1 = Frequency.FromMegahertz(-32);
        Frequency f2 = null;

        UnknownUnit f3 = f1 + f2;
        UnknownUnit f4 = f1 - f2;
        UnknownUnit f5 = f1 * f2;
        UnknownUnit f6 = f1 / f2;

        Assert.IsNull(f3);
        Assert.IsNull(f4);
        Assert.IsNull(f5);
        Assert.IsNull(f6);

    }

    [TestMethod]
    public void MathWithNullShouldBeNull4()
    {
        var f1 = MassFlow.FromKilogramPerSecond(1.5485);
        MassFlow f2 = null;

        MassFlow f3 = f1 + f2;
        MassFlow f4 = f1 - f2;
        MassFlow f5 = f1 * f2;
        MassFlow f6 = f1 / f2;

        Assert.IsNull(f3);
        Assert.IsNull(f4);
        Assert.IsNull(f5);
        Assert.IsNull(f6);

    }

    [TestMethod]
    public void MathWithNullShouldBeNull5()
    {
        var f1 = Pressure.FromBar(1.5485);
        Pressure f2 = null;

        Pressure f3 = f1 + f2;
        Pressure f4 = f1 - f2;
        Pressure f5 = f1 * f2;
        Pressure f6 = f1 / f2;

        Assert.IsNull(f3);
        Assert.IsNull(f4);
        Assert.IsNull(f5);
        Assert.IsNull(f6);

    }
}
