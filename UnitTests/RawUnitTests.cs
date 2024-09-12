using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class RawUnitTests
{
    //Create test for creating a RawUnit
    [TestMethod]
    public void CreateRawUnit()
    {
        RawUnit unit = new()
        {
            Symbol = "m",
            A = 1,
            B = 0,
            Count = 1,
            UnitType = BaseunitType.length

        };

        Assert.IsTrue(unit.IsSI);
    }

    // Create test for creating a RawUnit and calling CloneAndReverseCount
    [TestMethod]
    public void CreateRawUnitAndReverseCount()
    {
        RawUnit unit = new()
        {
            Symbol = "m",
            A = 1,
            B = 0,
            Count = 1,
            UnitType = BaseunitType.length

        };

        RawUnit unit2 = unit.CloneAndReverseCount();

        Assert.AreEqual(-1, unit2.Count);
        Assert.AreEqual(1, unit2.A);
        Assert.AreEqual(0, unit2.B);
        Assert.AreEqual("m", unit2.Symbol);
        Assert.AreEqual(BaseunitType.length, unit2.UnitType);
    }

    //Create test for creating a RawUnit and calling GetHashCode()
    [TestMethod]
    public void CreateRawUnitAndCallGetHashCode()
    {
        RawUnit unit = new()
        {
            Symbol = "m",
            A = 1,
            B = 0,
            Count = 1,
            UnitType = BaseunitType.length

        };

        Assert.AreEqual(-1939243696, unit.GetHashCode());
        Assert.AreEqual(1939243694, unit.CloneAndReverseCount().GetHashCode());
        Assert.AreEqual(1939243694, unit.CloneWithNewCount(-1).GetHashCode());
        Assert.AreEqual(-1989576551, unit.CloneWithNewCount(2).GetHashCode());
    }
}
