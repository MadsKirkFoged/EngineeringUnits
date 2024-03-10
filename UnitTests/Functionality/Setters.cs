using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

[TestClass]
public class Setters
{

    [TestMethod]
    public void SettingANull()
    {
        double? value = null;

        var length = Length.FromMeter(value);

        Assert.IsNull(length);
    }
}
