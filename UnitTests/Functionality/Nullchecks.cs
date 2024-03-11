using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class Nullchecks
{

    [TestMethod]
    public void ConvertFromNull()
    {
        MassFlow massFlow = null;
        var nulltest = massFlow.ToUnknownUnit();

        MassFlow massFlow2 = nulltest;

        Assert.IsNull(nulltest);
        Assert.IsNull(massFlow2);

    }
}
