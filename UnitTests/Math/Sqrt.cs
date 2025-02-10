using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Math;

[TestClass]
public class Sqrt
{
    [TestMethod]
    public void Sqrt1()
    {
        Speed M6 = (Area.FromAcre(10) / Duration.FromSecond(1).Pow(2)).Sqrt();

        Assert.AreEqual(201.168, M6.SI);
    }

    [TestMethod]
    public void Sqrt2()
    {
        var A1 = Area.FromSquareFoot(19);

        Length L1 = A1.Sqrt();

        Assert.AreEqual(1.3285923979911973, L1.SI);
    }

    [TestMethod]
    public void SqrtOfNegative()
    {
        var A1 = Area.FromSquareFoot(-19);

        Length L1 = A1.Sqrt();

        Assert.IsNull(L1);
    }

    [TestMethod]
    public void SqrtOfZero()
    {
        var A1 = Area.FromSquareFoot(0);

        Length L1 = A1.Sqrt();

        Assert.AreEqual(0, L1.SI);
    }
}
