using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests.Functionality;

[TestClass]
public class RoundToNearest
{
    [TestMethod]
    public void Round()
    {

        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };

        Length? L2 = MyList.RoundToNearest(Length.FromMeter(4)); //20m

        Assert.AreEqual(Length.FromMeter(5), L2);

    }

    [TestMethod]
    public void RoundDown()
    {

        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };

        Length? L2 = MyList.RoundDownToNearest(Length.FromMeter(30)); //20m

        Assert.AreEqual(Length.FromMeter(20), L2);

    }
    [TestMethod]
    public void RoundUp()
    {

        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };

        Length? L1 = MyList.RoundUpToNearest(Length.FromMeter(30)); //44m

        Assert.AreEqual(Length.FromMeter(44), L1);

    }

    [TestMethod]
    public void RoundUpWithNull()
    {

        var MyList = new List<Length?>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            null,
            Length.FromMeter(44)
        };

        Length? L1 = MyList.RoundUpToNearest(Length.FromMeter(30)); //44m

        Assert.IsNull(L1);

    }

    [TestMethod]
    public void RoundUpWithNull2()
    {

        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(44)
        };

        Length? L1 = MyList.RoundUpToNearest(null); //44m

        Assert.IsNull(L1);

    }

    [TestMethod]
    public void RoundUpWithEmptyList()
    {

        List<Length> MyList = [];

        Length? L1 = MyList.RoundUpToNearest(Length.FromMeter(30)); //44m

        Assert.IsNull(L1);

    }

    [TestMethod]
    public void RoundUpHigherThanMax()
    {

        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(44)
        };

        Length? L1 = MyList.RoundUpToNearest(Length.FromMeter(50)); //44m

        Assert.AreEqual(Length.FromMeter(44), L1);

    }

    [TestMethod]
    public void RoundUpWithWrongUnit()
    {
        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };

        Assert.ThrowsExactly<WrongUnitException>(() => _ = MyList.RoundUpToNearest(Mass.FromKilogram(30)));
    }

    [TestMethod]
    public void RoundDownWithWrongUnit()
    {
        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };

        Assert.ThrowsExactly<WrongUnitException>(() => _ = MyList.RoundDownToNearest(Mass.FromKilogram(30)));
    }

    [TestMethod]
    public void RoundWithWrongUnit()
    {
        var MyList = new List<Length>
        {
            Length.FromMeter(1),
            Length.FromMeter(5),
            Length.FromMeter(20),
            Length.FromMeter(44)
        };
        Assert.ThrowsExactly<WrongUnitException>(() => _ = MyList.RoundToNearest(Mass.FromKilogram(30)));
    }
}
