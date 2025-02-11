using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTests.JSON;

[TestClass]
public class JSONTest
{
    [TestMethod]
    public void AreaJSON()
    {
        Length L1 = new(1d, LengthUnit.Meter);
        Length L2 = new(1d, LengthUnit.Meter);

        Debug.WriteLine($"{L1}");
        Debug.WriteLine($"{L2}");

        Area A1 = L1 * L2;

        var jsonString1 = JsonConvert.SerializeObject(A1);
        Area? JSON = JsonConvert.DeserializeObject<Area>(jsonString1);
        var jsonString2 = JsonConvert.SerializeObject(JSON);

        Assert.AreEqual(1, A1.As(AreaUnit.SquareMeter));
        Assert.AreEqual(10000, A1.As(AreaUnit.SquareCentimeter));
        Assert.AreEqual(1.195990046301080256481500558, A1.As(AreaUnit.SquareYard));

        //JSON
        Assert.IsNotNull(JSON);
        Assert.AreEqual(1, JSON.As(AreaUnit.SquareMeter));
        Assert.AreEqual(10000, JSON.As(AreaUnit.SquareCentimeter));
        Assert.AreEqual(1.195990046301080256481500558, JSON.As(AreaUnit.SquareYard));

        Assert.AreEqual(jsonString1, jsonString2);

    }

    [TestMethod]
    public void AreaListJSON()
    {
        Area L1 = new(1, AreaUnit.SquareMeter);
        Area L2 = new(1, AreaUnit.SquareInch);

        List<Area> LocalList = [L1, L2];

        var jsonString1 = JsonConvert.SerializeObject(LocalList);
        List<Area>? JSON = JsonConvert.DeserializeObject<List<Area>>(jsonString1);
        var jsonString2 = JsonConvert.SerializeObject(JSON);

        Assert.AreEqual(jsonString1, jsonString2);
    }

    [TestMethod]
    public void PowerListJSON()
    {
        Power L1 = new(1, PowerUnit.KilojoulePerHour);
        Power L2 = new(1, PowerUnit.Watt);

        List<Power> LocalList = [L1, L2];

        var jsonString1 = JsonConvert.SerializeObject(LocalList);
        List<Power>? JSON = JsonConvert.DeserializeObject<List<Power>>(jsonString1);
        var jsonString2 = JsonConvert.SerializeObject(JSON);

        Assert.AreEqual(jsonString1, jsonString2);
    }

    [TestMethod]
    public void PowerList2JSON()
    {
        Power f1 = new(3, PowerUnit.KilojoulePerHour);
        Power f2 = f1;

        Power f3 = f1 + f2;
        Power f4 = f2 + f1;
        Power f5 = f4 + f3;

        var jsonString1 = JsonConvert.SerializeObject(f1);
        Power? f6 = JsonConvert.DeserializeObject<Power>(jsonString1);

        List<Power?> locallist = [f1, f1, f2, f3, f4, f5, f6];

        var jsonString2 = JsonConvert.SerializeObject(locallist);
        List<Power>? locallist2 = JsonConvert.DeserializeObject<List<Power>>(jsonString2);

        var jsonString3 = JsonConvert.SerializeObject(locallist2);

        Assert.AreEqual(jsonString2, jsonString3);
    }

    [TestMethod]
    public void ToStringTemperaureAfterJson()
    {
        var ResultEvapTemperature = new Temperature(10, TemperatureUnit.DegreeCelsius);

        var jsonString1 = JsonConvert.SerializeObject(ResultEvapTemperature);
        Temperature? JSON = JsonConvert.DeserializeObject<Temperature>(jsonString1);

        Assert.AreEqual($"{ResultEvapTemperature}", $"{JSON}");
    }
}
