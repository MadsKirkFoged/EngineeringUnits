using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;


[TestClass()]
public class CostCombined
{
    [TestMethod()]
    public void AreaCost()
    {
        //Arrange
        AreaCost test = new AreaCost(10, AreaCostUnit.SI);


        // Assert
        Assert.AreEqual("10 $/m²", test.ToString());
    }

    //create test for EnergyCost
    [TestMethod()]
    public void EnergyCost()
    {
        //Arrange
        EnergyCost test = new EnergyCost(10, EnergyCostUnit.DollarPerKilowattHour);

        // Assert
        Assert.AreEqual("10 $/kWh", test.ToString());
    }

    //Create test for LengthCost
    [TestMethod()]
    public void LengthCost()
    {
        //Arrange
        LengthCost test = new LengthCost(10, LengthCostUnit.EuroPerMeter);

        // Assert
        Assert.AreEqual("10 €/m", test.ToString());
    }

    //Create test for MassCost
    [TestMethod()]
    public void MassCost()
    {
        //Arrange
        MassCost test = new MassCost(10, MassCostUnit.EuroPerKilogram);

        // Assert
        Assert.AreEqual("10 €/kg", test.ToString());
    }

    //Create test for PowerCost
    [TestMethod()]
    public void PowerCost()
    {
        //Arrange
        PowerCost test = new PowerCost(10, PowerCostUnit.USDollarPerKilowatt);

        // Assert
        Assert.AreEqual("10 $/kW", test.ToString());
    }

    //Create test for VolumeCost
    [TestMethod()]
    public void VolumeCost()
    {
        //Arrange
        VolumeCost test = new VolumeCost(10, VolumeCostUnit.EuroPerCubicMeter);

        // Assert
        Assert.AreEqual("10 €/m³", test.ToString());
    }

}
