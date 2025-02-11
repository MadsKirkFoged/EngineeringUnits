using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SpeedTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Speed(65.743, UnitsNet.Units.SpeedUnit.FootPerHour);
        var A2 = new EngineeringUnits.Speed(65.743, SpeedUnit.FootPerHour);

        var WorkingCompares = 0;

        foreach (SpeedUnit EU in UnitTypebase.ListOf<SpeedUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-4;

            IEnumerable<UnitsNet.Units.SpeedUnit> UNList = UnitsNet.Speed.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.SpeedUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.SpeedUnit.SquareMicrometer) Error = 2629720.0009765625;

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
                                //.Replace("/min", "/m")
                                );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(32, WorkingCompares);

    }

    [TestMethod]
    public void Simple()
    {
        Length L1 = new(100, LengthUnit.Meter);
        Duration D1 = new(10, DurationUnit.Second);

        var jsonString = JsonConvert.SerializeObject(L1);
        Length? L1JSON = JsonConvert.DeserializeObject<Length>(jsonString);

        var jsonString2 = JsonConvert.SerializeObject(D1);
        Length? D1JSON = JsonConvert.DeserializeObject<Length>(jsonString2);

        Speed? S1 = L1JSON / D1JSON;

        var jsonString3 = JsonConvert.SerializeObject(S1);
        Speed? S1JSON = JsonConvert.DeserializeObject<Speed>(jsonString3);

        Assert.IsNotNull(S1JSON);
        Assert.AreEqual(10, (double)S1JSON.As(SpeedUnit.MeterPerSecond));
        Assert.AreEqual(36, (double)S1JSON.As(SpeedUnit.KilometerPerhour));
        Assert.AreEqual(10.936132983377078, (double)S1JSON.As(SpeedUnit.YardPerSecond));
    }

    [TestMethod]
    public void Simple2()
    {
        Length L1 = new(100, LengthUnit.Yard);
        Duration D1 = new(10, DurationUnit.Hour);

        Speed S1 = L1 / D1;

        Assert.AreEqual(0.00254, (double)S1.As(SpeedUnit.MeterPerSecond));
        Assert.AreEqual(0.009144, (double)S1.As(SpeedUnit.KilometerPerhour));
        Assert.AreEqual(0.002777777777777778, (double)S1.As(SpeedUnit.YardPerSecond));
        Assert.AreEqual(0.1, (double)S1.As(SpeedUnit.InchPerSecond));
    }

    [TestMethod]
    public void CanBeZero()
    {
        Speed speed = Speed.Zero;
        Assert.AreEqual(Speed.Zero, speed);
    }

    [TestMethod]
    public void OperatorTest()
    {
        Speed speed = Length.FromCentimeter(255)/Duration.FromMinute(30);
        Assert.AreEqual("cm/min", speed.ToString("UnitOnly"));
    }
}
