using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PowerTests
{

    [TestMethod]
    public void Compare()
    {
        EngineeringUnits.Power L2 = new(1, PowerUnit.Watt);
        UnitsNet.Power L1 = new(1, UnitsNet.Units.PowerUnit.Watt);

        Assert.AreEqual(0, L2.As(PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 0);
        Assert.AreEqual(0, L2.As(PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
        Assert.AreEqual(0, L2.As(PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 1.5E-05);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Watt),
                                                L1.As(UnitsNet.Units.PowerUnit.Watt)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Kilowatt),
                                    L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.BritishThermalUnitPerHour),
                        L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0.00042);

    }

    [TestMethod]
    public void Compare2()
    {
        EngineeringUnits.Power L2 = new(1, PowerUnit.BritishThermalUnitPerHour);
        UnitsNet.Power L1 = new(1, UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour);

        Assert.AreEqual(0, L2.As(PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 1.3E-06);
        Assert.AreEqual(0, L2.As(PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 1.3E-09);
        Assert.AreEqual(0, L2.As(PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 0);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Watt),
                                                L1.As(UnitsNet.Units.PowerUnit.Watt)), 0.00042);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Kilowatt),
                                    L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0.00042);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.BritishThermalUnitPerHour),
                        L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0);

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Power(65.743m, UnitsNet.Units.PowerUnit.KilobritishThermalUnitPerHour);
        var A2 = new EngineeringUnits.Power(65.743, PowerUnit.KilobritishThermalUnitPerHour);

        var WorkingCompares = 0;

        foreach (PowerUnit EU in UnitTypebase.ListOf<PowerUnit>())
        {

            double Error = 80352555552768;
            var RelError = 5E-4;

            IEnumerable<UnitsNet.Units.PowerUnit> UNList = UnitsNet.Power.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.PowerUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.PowerUnit.Femtowatt)
                    Error = 80352555552768;
                if (UN == UnitsNet.Units.PowerUnit.Picowatt)
                    Error = 80352555556;
                if (UN == UnitsNet.Units.PowerUnit.Nanowatt)
                    Error = 80352555.5546875;
                if (UN == UnitsNet.Units.PowerUnit.Microwatt)
                    Error = 80352.55555725098;
                if (UN == UnitsNet.Units.PowerUnit.Milliwatt)
                    Error = 80.35255555808544;
                if (UN == UnitsNet.Units.PowerUnit.Deciwatt)
                    Error = 0.8035255555587355;
                if (UN == UnitsNet.Units.PowerUnit.Watt)
                    Error = 0.08035255555660115;
                if (UN == UnitsNet.Units.PowerUnit.MillijoulePerHour)
                    Error = 289269.19999694824;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("Btu", "BTU")
                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(25, WorkingCompares);
    }


    [TestMethod]
    public void Display()
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
    public void DisplayUnknown()
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



    [TestMethod]
    public void One_TR_Equals_12000_BtuPerHour()
    {
        // 1 TR = 12000 Btu/h
        var tr = new Power(1, PowerUnit.TonOfRefrigeration);

        var btuPerHour = tr.As(PowerUnit.BritishThermalUnitPerHour);

        Assert.AreEqual(12000.0, btuPerHour, 1e-9);
    }

    [TestMethod]
    public void TwelveThousand_BtuPerHour_Equals_One_TR()
    {
        var p = new Power(12000, PowerUnit.BritishThermalUnitPerHour);

        var tr = p.As(PowerUnit.TonOfRefrigeration);

        Assert.AreEqual(1.0, tr, 1e-9);
    }

    [TestMethod]
    public void TR_Has_Symbol_TR()
    {
        Assert.AreEqual("TR", PowerUnit.TonOfRefrigeration.ToString());
    }




}
