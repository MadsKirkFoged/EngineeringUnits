using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnits;

[TestClass]
public class AmountOfSubstanceTests
{
    [TestMethod]
    public void AmountOfSubstance01()
    {
        var a1 = AmountOfSubstance.From(10, AmountOfSubstanceUnit.Centimole);
        Assert.AreEqual(10, a1.Centimole);

        var a2 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Decimole);
        Assert.AreEqual(a1, a2);
    }

    [TestMethod]
    public void AmountOfSubstance02()
    {
        double? value = null;
        var a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
        Assert.IsNull(a);

    }

    [TestMethod]
    public void FromAmountOfSubstance()
    {
        double? value = 100;
        var a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
        var a2 = AmountOfSubstance.From(value, null);
        Assert.IsNotNull(a);
        Assert.IsNull(a2);

    }
}
