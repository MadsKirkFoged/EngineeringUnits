using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EngineeringUnits.ExchangeRates;

namespace UnitTests;

[TestClass()]
public class CostTests
{
    [ClassInitialize]
    public static void UpdateRates(TestContext context)
    {
        ExchangeRates.UpdateRate(Currency.USDollar, 1);
        ExchangeRates.UpdateRate(Currency.Euro, 1.08568m);
        ExchangeRates.UpdateRate(Currency.BritishPound, 1.2665902m);
    }



    [TestMethod()]
    public void CostDollar()
    {
        //Arrange
        Cost test = new Cost(10, CostUnit.USDollar);


        // Assert
        Assert.AreEqual("10 $", test.ToString());
    }

    [TestMethod()]
    public void CostEuro()
    {
        //Arrange
        Cost test = new Cost(10, CostUnit.Euro);


        // Assert
        Assert.AreEqual("10 €", test.ToString());
    }

    [TestMethod()]
    public void CostBritishPound()
    {
        //Arrange
        Cost test = new Cost(10, CostUnit.BritishPound);


        // Assert
        Assert.AreEqual("10 £", test.ToString());
    }

    [TestMethod()]
    public void CostConvertUSToEuro()
    {
        //Arrange
        decimal USDtoEuro = ExchangeRates.GetRate(Currency.Euro);

        //Act
        Cost USD = new Cost(10, CostUnit.USDollar);
        var Euro = USD.Euro;

        // Assert
        Assert.AreEqual(9.2108171837005379m, 10 / USDtoEuro, 0.0000001m);
    }
   

    [TestMethod()]
    public void UpdateAfterInit()
    {
        //Arrange
        decimal USDtoEuro = ExchangeRates.GetRate(Currency.Euro);
        

        //Act
        Cost USD = new Cost(10, CostUnit.USDollar);
        ExchangeRates.UpdateRate(Currency.Euro, 10.000m); //This should not have any affect

        var Euro = USD.Euro;

        // Assert
        Assert.AreEqual(9.2108171837005379m, 10 / USDtoEuro, 0.0000001m);
    }
}
