using System;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EngineeringUnits.ExchangeRates;
#pragma warning disable IDE0060

namespace UnitTests.BaseUnits;

[TestClass]
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
        var test = new Cost(10, CostUnit.USDollar);

        // Assert
        Assert.AreEqual("10 $", test.ToString());
    }

    [TestMethod()]
    public void CostMillionDollar()
    {
        //Arrange
        var test1 = new Cost(1, CostUnit.MillionUSDollar);
        var test2 = new Cost(1e6, CostUnit.USDollar);

        // Assert
        Assert.AreEqual(test1.USDollar, test2.USDollar);
    }

    [TestMethod()]
    public void CostEuro()
    {
        //Arrange
        var test = new Cost(10, CostUnit.Euro);

        // Assert
        Assert.AreEqual("10 €", test.ToString());
    }

    [TestMethod()]
    public void CostBritishPound()
    {
        //Arrange
        var test = new Cost(10, CostUnit.BritishPound);

        // Assert
        Assert.AreEqual("10 £", test.ToString());
    }

    [TestMethod()]
    public void CostConvertUSToEuro()
    {
        //Arrange
        var USDtoEuro = ExchangeRates.GetRate(Currency.Euro);

        //Act
        var USD = new Cost(10, CostUnit.USDollar);
        _ = USD.Euro;

        // Assert
        Assert.AreEqual(9.2108171837005379m, 10 / USDtoEuro, 0.0000001m);
    }

    [TestMethod()]
    public void CurrencyCodes_WorkAsUnitNames()
    {
        Assert.AreSame(CostUnit.USDollar, UnitTypebase.GetUnitByString<CostUnit>("USD"));
        Assert.AreSame(CostUnit.Euro, UnitTypebase.GetUnitByString<CostUnit>("EUR"));
        Assert.AreSame(CostUnit.BritishPound, UnitTypebase.GetUnitByString<CostUnit>("GBP"));
        Assert.AreSame(CostUnit.DanishKrone, UnitTypebase.GetUnitByString<CostUnit>("DKK"));
        Assert.AreSame(CostUnit.DanishKrone, UnitTypebase.GetUnitByString<CostUnit>("dkk"));
        Assert.AreSame(CostUnit.DanishKrone, UnitTypebase.GetUnitByString<CostUnit>("DanishKrone"));

        // A price stored with its unit, e.g. in a database: "DKK" next to "DanishKrone"
        Cost price = 100.0.AddUnit<CostUnit>("DKK");
        Assert.AreEqual(100, price.DanishKrone, 1e-9);

        var e = Assert.ThrowsExactly<ArgumentException>(() => UnitTypebase.GetUnitByString<CostUnit>("SEK"));
        StringAssert.Contains(e.Message, "DanishKrone");
        StringAssert.Contains(e.Message, "DKK");
    }

    [TestMethod()]
    public void CurrencyCodes_Parse()
    {
        Assert.AreEqual(10, Cost.Parse("10 EUR", CultureInfo.InvariantCulture).Euro, 1e-9);
        Assert.AreEqual(10, Cost.Parse("10 dkk", CultureInfo.InvariantCulture).DanishKrone, 1e-9);
        Assert.AreEqual(2.5, EnergyCost.Parse("2.5 DKK/kWh", CultureInfo.InvariantCulture).DKKPerKilowattHour, 1e-9);
    }

    //[TestMethod()]
    //public void UpdateAfterInit()
    //{
    //    //Arrange
    //    var USDtoEuro = ExchangeRates.GetRate(Currency.Euro);

    //    //Act
    //    var USD = new Cost(10, CostUnit.USDollar);
    //    ExchangeRates.UpdateRate(Currency.Euro, 10.000m); //This should not have any affect
    //    _ = USD.Euro;

    //    // Assert
    //    Assert.AreEqual(9.2108171837005379m, 10 / USDtoEuro, 0.0000001m);
    //}
}
