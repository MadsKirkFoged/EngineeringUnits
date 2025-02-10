using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass()]
public class BaseUnitAlias
{
    [TestMethod()]
    public void SwitchBetweenAlias()
    {
        //Arrange
        var test = SpecificHeatCapacity.FromBtuPerPoundRankine(0.51387988198709567);

        // Act
        SpecificEntropy test2 = test!;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }

    [TestMethod()]
    public void SwitchBetweenAlias2()
    {
        //Arrange
        SpecificEntropy test = SpecificHeatCapacity.FromBtuPerPoundRankine(0.51387988198709567)!;

        // Act
        SpecificHeatCapacity test2 = test!;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }

    [TestMethod()]
    public void SwitchBetweenAlias3()
    {
        //Arrange
        var test = SpecificEntropy.FromBtuPerPoundRankine(0.51387988198709567);

        // Act
        SpecificHeatCapacity test2 = test!;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }
}