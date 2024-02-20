using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EngineeringUnits.BaseUnitExtensions;

namespace UnitTests.Functionality;

[TestClass]
public class IsNaN
{
    [TestMethod]
    public void IsNaNCheck()
    {
        Mass massNan1 = new Mass(double.NaN, MassUnit.SI);
        Mass massNan2 = Mass.FromCentigram(double.NaN);
        Mass massNan3 = Mass.NaN;

        Mass massNotNan1 = Mass.FromCentigram(5);

        Assert.IsTrue(massNan1.IsNaN());
        Assert.IsTrue(massNan2.IsNaN());
        Assert.IsTrue(massNan3.IsNaN());

        Assert.IsFalse(massNotNan1.IsNaN());
    }

    [TestMethod]
    public void IsNaNCheckTemperature()
    {
        Temperature tempNan1 = new Temperature(double.NaN, TemperatureUnit.SI);
        Temperature tempNan2 = Temperature.FromKelvins(double.NaN);
        Temperature tempNan3 = Temperature.NaN;

        Temperature tempNotNan1 = Temperature.FromDegreesCelsius(20);

        Assert.IsTrue(tempNan1.IsNaN());
        Assert.IsTrue(tempNan2.IsNaN());
        Assert.IsTrue(tempNan3.IsNaN());
        Assert.IsFalse(tempNotNan1.IsNaN());
    }

    [TestMethod]
    public void NaNWithOperators()
    {
        Length lengthNotNan = Length.FromMeter(2);
        Length lengthNan = Length.NaN;

        Length lengthSumShouldBeNan = lengthNotNan + lengthNan;
        Length lengthPlusShouldBeNan = +lengthNan;
        Length lengthDiffShouldBeNan1 = lengthNotNan - lengthNan;
        Length lengthDiffShouldBeNan2 = lengthNan - lengthNotNan;
        Length lengthMinusShouldBeNan = -lengthNan;
        Area areaProdShouldBeNan1 = lengthNotNan * lengthNan;
        Area areaProdShouldBeNan2 = lengthNan * lengthNotNan;
        Ratio ratioDivShouldBeNan1 = lengthNotNan / lengthNan;
        Ratio ratioDivShouldBeNan2 = lengthNan / lengthNotNan;

        Assert.IsTrue(lengthSumShouldBeNan.IsNaN());
        Assert.IsTrue(lengthPlusShouldBeNan.IsNaN());
        Assert.IsTrue(lengthDiffShouldBeNan1.IsNaN());
        Assert.IsTrue(lengthDiffShouldBeNan2.IsNaN());
        Assert.IsTrue(lengthMinusShouldBeNan.IsNaN());
        Assert.IsTrue(areaProdShouldBeNan1.IsNaN());
        Assert.IsTrue(areaProdShouldBeNan2.IsNaN());
        Assert.IsTrue(ratioDivShouldBeNan1.IsNaN());
        Assert.IsTrue(ratioDivShouldBeNan2.IsNaN());

        double valNan = double.NaN;

        Length lengthProdShouldBeNanD1 = lengthNotNan * valNan;
        Length lengthProdShouldBeNanD2 = valNan * lengthNotNan;
        Length lengthDivShouldBeNanD1 = lengthNotNan / valNan;
        Length lengthDivShouldBeNanD2 = valNan / lengthNotNan;

        Assert.IsTrue(lengthProdShouldBeNanD1.IsNaN());
        Assert.IsTrue(lengthProdShouldBeNanD2.IsNaN());
        Assert.IsTrue(lengthDivShouldBeNanD1.IsNaN());
        Assert.IsTrue(lengthDivShouldBeNanD2.IsNaN());
    }
}