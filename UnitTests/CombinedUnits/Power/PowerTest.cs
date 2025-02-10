using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PowerTest
{

    [TestMethod]
    public void PowerDisplay()
    {
        var value = 10.75458;

        Power T1 = new(value, PowerUnit.SI);
        Power T2 = new(value, PowerUnit.KilojoulePerHour);
        Power T3 = new(value, PowerUnit.Watt);
        Power T4 = new(value, PowerUnit.BritishThermalUnitPerHour);

        Assert.AreEqual("10.75 W", T1.ToString());
        Assert.AreEqual("10.75 kJ/h", T2.ToString());
        Assert.AreEqual("10.75 W", T3.ToString());
        Assert.AreEqual("10.75 BTU/h", T4.ToString());

        Assert.AreEqual("W", $"{T1:UnitOnly}");
        Assert.AreEqual("kJ/h", $"{T2:UnitOnly}");
        Assert.AreEqual("W", $"{T3:UnitOnly}");
        Assert.AreEqual("BTU/h", $"{T4:UnitOnly}");

        Assert.AreEqual("11", $"{T1:V2}");
        Assert.AreEqual("10.75", $"{T2:V4}");
        Assert.AreEqual("10.7546", $"{T3:V6}");
        Assert.AreEqual("10.75458", $"{T4:V12}");

        Assert.AreEqual("11 W", $"{T1:0.}");
        Assert.AreEqual("11 kJ/h", $"{T2:0.}");
        Assert.AreEqual("11 W", $"{T3:0.}");
        Assert.AreEqual("11 BTU/h", $"{T4:0.}");

        Assert.AreEqual("10.8 W", $"{T1:0.#}");
        Assert.AreEqual("10.8 kJ/h", $"{T2:0.#}");
        Assert.AreEqual("10.8 W", $"{T3:0.#}");
        Assert.AreEqual("10.8 BTU/h", $"{T4:0.#}");

        Assert.AreEqual("10.75 W", $"{T1:0.##}");
        Assert.AreEqual("10.75 kJ/h", $"{T2:0.##}");
        Assert.AreEqual("10.75 W", $"{T3:0.##}");
        Assert.AreEqual("10.75 BTU/h", $"{T4:0.##}");

        Assert.AreEqual("10.755 W", $"{T1:0.###}");
        Assert.AreEqual("10.755 kJ/h", $"{T2:0.###}");
        Assert.AreEqual("10.755 W", $"{T3:0.###}");
        Assert.AreEqual("10.755 BTU/h", $"{T4:0.###}");

        Assert.AreEqual("10.7546 W", $"{T1:0.####}");
        Assert.AreEqual("10.7546 kJ/h", $"{T2:0.####}");
        Assert.AreEqual("10.7546 W", $"{T3:0.####}");
        Assert.AreEqual("10.7546 BTU/h", $"{T4:0.####}");

        Assert.AreEqual("10.75458 W", $"{T1:0.#####}");
        Assert.AreEqual("10.75458 kJ/h", $"{T2:0.#####}");
        Assert.AreEqual("10.75458 W", $"{T3:0.#####}");
        Assert.AreEqual("10.75458 BTU/h", $"{T4:0.#####}");

        Assert.AreEqual("10.75458 W", $"{T1:0.######}");
        Assert.AreEqual("10.75458 kJ/h", $"{T2:0.######}");
        Assert.AreEqual("10.75458 W", $"{T3:0.######}");
        Assert.AreEqual("10.75458 BTU/h", $"{T4:0.######}");

    }

    [TestMethod]
    public void PowerDisplayUnknown()
    {
        var value = 10.75458;

        UnknownUnit T1 = new(value, PowerUnit.SI);
        UnknownUnit T2 = new(value, PowerUnit.KilojoulePerHour);
        UnknownUnit T3 = new(value, PowerUnit.Watt);
        UnknownUnit T4 = new(value, PowerUnit.BritishThermalUnitPerHour);

        Assert.AreEqual("10.75 W", T1.ToString());
        Assert.AreEqual("10.75 kJ/h", T2.ToString());
        Assert.AreEqual("10.75 W", T3.ToString());
        Assert.AreEqual("10.75 BTU/h", T4.ToString());

        Assert.AreEqual("W", $"{T1:UnitOnly}");
        Assert.AreEqual("kJ/h", $"{T2:UnitOnly}");
        Assert.AreEqual("W", $"{T3:UnitOnly}");
        Assert.AreEqual("BTU/h", $"{T4:UnitOnly}");

        Assert.AreEqual("11", $"{T1:V2}");
        Assert.AreEqual("10.75", $"{T2:V4}");
        Assert.AreEqual("10.7546", $"{T3:V6}");
        Assert.AreEqual("10.75458", $"{T4:V12}");

        Assert.AreEqual("11 W", $"{T1:0.}");
        Assert.AreEqual("11 kJ/h", $"{T2:0.}");
        Assert.AreEqual("11 W", $"{T3:0.}");
        Assert.AreEqual("11 BTU/h", $"{T4:0.}");

        Assert.AreEqual("10.8 W", $"{T1:0.#}");
        Assert.AreEqual("10.8 kJ/h", $"{T2:0.#}");
        Assert.AreEqual("10.8 W", $"{T3:0.#}");
        Assert.AreEqual("10.8 BTU/h", $"{T4:0.#}");

        Assert.AreEqual("10.75 W", $"{T1:0.##}");
        Assert.AreEqual("10.75 kJ/h", $"{T2:0.##}");
        Assert.AreEqual("10.75 W", $"{T3:0.##}");
        Assert.AreEqual("10.75 BTU/h", $"{T4:0.##}");

        Assert.AreEqual("10.755 W", $"{T1:0.###}");
        Assert.AreEqual("10.755 kJ/h", $"{T2:0.###}");
        Assert.AreEqual("10.755 W", $"{T3:0.###}");
        Assert.AreEqual("10.755 BTU/h", $"{T4:0.###}");

        Assert.AreEqual("10.7546 W", $"{T1:0.####}");
        Assert.AreEqual("10.7546 kJ/h", $"{T2:0.####}");
        Assert.AreEqual("10.7546 W", $"{T3:0.####}");
        Assert.AreEqual("10.7546 BTU/h", $"{T4:0.####}");

        Assert.AreEqual("10.75458 W", $"{T1:0.#####}");
        Assert.AreEqual("10.75458 kJ/h", $"{T2:0.#####}");
        Assert.AreEqual("10.75458 W", $"{T3:0.#####}");
        Assert.AreEqual("10.75458 BTU/h", $"{T4:0.#####}");

        Assert.AreEqual("10.75458 W", $"{T1:0.######}");
        Assert.AreEqual("10.75458 kJ/h", $"{T2:0.######}");
        Assert.AreEqual("10.75458 W", $"{T3:0.######}");
        Assert.AreEqual("10.75458 BTU/h", $"{T4:0.######}");

    }
}
