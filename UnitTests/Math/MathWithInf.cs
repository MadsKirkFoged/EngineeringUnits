using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Math;
[TestClass()]
public class MathWithInf
{
    [TestMethod()]
    public void DivideByZero()
    {
        //Arrange


        // Act
        Ratio Inf = MassFlow.FromKilogramPerSecond(1) / MassFlow.Zero;

        // Assert
        Assert.AreEqual(Inf.ToString(), "Infinity");
    }

    [TestMethod()]
    public void DivideEndsInInf()
    {
        //Arrange


        // Act
        Ratio Inf = MassFlow.FromKilogramPerSecond(1000000000000000) / MassFlow.FromKilogramPerSecond(0.0000000000000000001);

        // Assert
        Assert.AreEqual(Inf.ToString(), "Infinity");
    }

    [TestMethod()]
    public void DivideEndsInMinusInf()
    {
        //Arrange


        // Act
        Ratio Inf = MassFlow.FromKilogramPerSecond(-1000000000000000) / MassFlow.FromKilogramPerSecond(0.0000000000000000001);

        // Assert
        Assert.AreEqual(Inf.ToString(), "Infinity");
    }

    [TestMethod()]
    public void SmallerThanInf()
    {
        //Arrange
        MassFlow Inf = MassFlow.FromKilogramPerSecond(double.PositiveInfinity);

        // Act
        bool result = Inf < MassFlow.FromKilogramPerSecond(100000000);


        // Assert
        Assert.AreEqual(result, false);
    }

    [TestMethod()]
    public void biggerThanInf()
    {
        //Arrange
        MassFlow Inf = MassFlow.FromKilogramPerSecond(double.PositiveInfinity);

        // Act
        bool result = Inf > MassFlow.FromKilogramPerSecond(100000000);


        // Assert
        Assert.AreEqual(result, true);
    }

    [TestMethod()]
    public void InfEqualInf()
    {
        //Arrange
        MassFlow Inf = MassFlow.FromKilogramPerSecond(double.PositiveInfinity);
        MassFlow Inf2 = MassFlow.FromKilogramPerSecond(double.PositiveInfinity);

        // Act
        bool ShouldBeFalse = Inf2 > Inf;
        bool ShouldBeFalse2 = Inf2 < Inf;

        bool ShouldBeFalse3 = Inf2 != Inf;

        bool ShouldBeTrue = Inf2 >= Inf;
        bool ShouldBeTrue2 = Inf2 <= Inf;

        bool ShouldBeTrue3 = Inf2 == Inf;


        // Assert
        Assert.AreEqual(ShouldBeFalse, false);
        Assert.AreEqual(ShouldBeFalse2, false);
        Assert.AreEqual(ShouldBeFalse3, false);

        Assert.AreEqual(ShouldBeTrue, true);
        Assert.AreEqual(ShouldBeTrue2, true);
        Assert.AreEqual(ShouldBeTrue3, true);
    }

    [TestMethod()]
    public void AbsWithInf()
    {
        //Arrange
        MassFlow Inf = MassFlow.FromKilogramPerSecond(double.PositiveInfinity);

        // Act
        var result = Inf.Abs();


        // Assert
        Assert.AreEqual(result, Inf);
    }
}
