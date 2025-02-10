using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumeTests
{

    [TestMethod]
    public void FromVolume01()
    {
        double? value = null;

        var v = EngineeringUnits.Volume.From(value, null);
        Assert.IsNull(v);

    }

    [TestMethod]
    public void FromVolume02()
    {
        double? value = 100;
        var v = EngineeringUnits.Volume.From(value, VolumeUnit.CubicFoot);
        var v2 = EngineeringUnits.Volume.From(value, null);
        Assert.IsNotNull(v);
        Assert.IsNull(v2);

    }
}
