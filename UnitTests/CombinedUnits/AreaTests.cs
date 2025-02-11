using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class AreaTests
{
    [TestMethod]
    public void CompareAutoTest()
    {
        var A1 = new UnitsNet.Area(65.743, UnitsNet.Units.AreaUnit.SquareFoot);
        var A2 = new EngineeringUnits.Area(65.743, AreaUnit.SquareFoot);

        var WorkingCompares = 0;

        foreach (AreaUnit EU in UnitTypebase.ListOf<AreaUnit>())
        {

            var Error = 5E-2;
            var RelError = 1E-3;

            IEnumerable<UnitsNet.Units.AreaUnit> UNList = UnitsNet.Area.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.AreaUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.AreaUnit.SquareMicrometer)
                    Error = 2629720.0009765625;
                if (UN == UnitsNet.Units.AreaUnit.SquareMillimeter)
                    Error = 2.629720000550151;

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
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(13, WorkingCompares);
    }

    [TestMethod]
    public void Simple()
    {
        Length L1 = new(1d, LengthUnit.Meter);
        Length L2 = new(1d, LengthUnit.Meter);

        Debug.WriteLine($"{L1}");
        Debug.WriteLine($"{L2}");

        Area A1 = L1 * L2;

        var jsonString = JsonConvert.SerializeObject(A1);
        Area? JSON = JsonConvert.DeserializeObject<Area>(jsonString);

        Assert.IsNotNull(JSON);
        Assert.AreEqual(1, A1.As(AreaUnit.SquareMeter));
        Assert.AreEqual(10000, A1.As(AreaUnit.SquareCentimeter));
        Assert.AreEqual(1.195990046301080256481500558, A1.As(AreaUnit.SquareYard));

        //JSON
        Assert.AreEqual(1, JSON.As(AreaUnit.SquareMeter));
        Assert.AreEqual(10000, JSON.As(AreaUnit.SquareCentimeter));
        Assert.AreEqual(1.195990046301080256481500558, JSON.As(AreaUnit.SquareYard));

    }

    [TestMethod]
    public void Many()
    {
        //Length L1 = new Length(10, LengthUnit.Meter);
        //Length L2 = new Length(10, LengthUnit.Meter);

        //Area A1 = ((L1 * L2) * (L1 * L2) * (L1 * L2)) / ((L1 * L2) * (L1 * L2));

        ////Assert.AreEqual(1000000, A1.As(LengthUnit.Centimeter));
        //Assert.AreEqual(100, A1.As(LengthUnit.Meter));
        ////Assert.AreEqual(119.599004630108, A1.As(LengthUnit.Yard), 0.000000001);
    }

    [TestMethod]
    public void AreaTimesDouble()
    {
        //Length L1 = new Length(10, LengthUnit.Meter);
        //Length L2 = new Length(10, LengthUnit.Meter);

        //Area A1 = (L1 * L2) * 2;

        ////Debug.Print($"{A1}");

        ////Assert.AreEqual(1000000, A1.As(LengthUnit.Centimeter));
        //Assert.AreEqual(200, A1.As(LengthUnit.Meter));
        ////Assert.AreEqual(119.599004630108, A1.As(LengthUnit.Yard), 0.000000001);
    }
}
