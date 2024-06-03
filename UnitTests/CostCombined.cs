using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass()]
public class CostCombined
{
    [TestMethod()]
    public void AreaCost()
    {
        //Arrange
        var test = new AreaCost(10, AreaCostUnit.SI);

        // Assert
        Assert.AreEqual("10 $/m²", test.ToString());
    }

    [TestMethod()]
    public void DurationCost()
    {
        //Arrange
        var test1 = new DurationCost(10, DurationCostUnit.SI);
        var test2 = EngineeringUnits.DurationCost.FromMillionUSDollarPerYear365(10);

        // Assert
        Assert.AreEqual("10 $/s",   test1.ToString());
        Assert.AreEqual("10 M$/yr", test2.ToString());
    }

    //create test for EnergyCost
    [TestMethod()]
    public void EnergyCost()
    {
        //Arrange
        var test = new EnergyCost(10, EnergyCostUnit.USDollarPerKilowattHour);

        // Assert
        Assert.AreEqual("10 $/kWh", test.ToString());
    }

    //Create test for LengthCost
    [TestMethod()]
    public void LengthCost()
    {
        //Arrange
        var test = new LengthCost(10, LengthCostUnit.EuroPerMeter);

        // Assert
        Assert.AreEqual("10 €/m", test.ToString());
    }

    //Create test for MassCost
    [TestMethod()]
    public void MassCost()
    {
        //Arrange
        var test = new MassCost(10, MassCostUnit.EuroPerKilogram);

        // Assert
        Assert.AreEqual("10 €/kg", test.ToString());
    }

    //Create test for PowerCost
    [TestMethod()]
    public void PowerCost()
    {
        //Arrange
        var test = new PowerCost(10, PowerCostUnit.USDollarPerKilowatt);

        // Assert
        Assert.AreEqual("10 $/kW", test.ToString());
    }

    //Create test for VolumeCost
    [TestMethod()]
    public void VolumeCost()
    {
        //Arrange
        var test = new VolumeCost(10, VolumeCostUnit.EuroPerCubicMeter);

        // Assert
        Assert.AreEqual("10 €/m³", test.ToString());
    }
}
