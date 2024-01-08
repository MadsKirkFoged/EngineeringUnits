using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringUnits.Tests;

[TestClass()]
public class BaseUnitAlias
{
    [TestMethod()]
    public void SwitchBetweenAlias()
    {
        //Arrange
        SpecificHeatCapacity test = SpecificHeatCapacity.FromBtuPerPoundRankine(0.51387988198709567);

        // Act
        SpecificEntropy test2 = test;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }

    [TestMethod()]
    public void SwitchBetweenAlias2()
    {
        //Arrange
        SpecificEntropy test = SpecificHeatCapacity.FromBtuPerPoundRankine(0.51387988198709567);

        // Act
        SpecificHeatCapacity test2 = test;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }

    [TestMethod()]
    public void SwitchBetweenAlias3()
    {
        //Arrange
        SpecificEntropy test = SpecificEntropy.FromBtuPerPoundRankine(0.51387988198709567);

        // Act
        SpecificHeatCapacity test2 = test;

        // Assert
        Assert.AreEqual(test.SI, test2.SI);
    }
}