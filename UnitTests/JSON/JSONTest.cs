using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class JSONTest
    {
        [TestMethod]
        public void AreaJSON()
        {
            Length L1 = new Length(1d, LengthUnit.Meter);
            Length L2 = new Length(1d, LengthUnit.Meter);

            Debug.WriteLine($"{L1}");
            Debug.WriteLine($"{L2}");

            Area A1 = L1 * L2;

            string jsonString1 = JsonConvert.SerializeObject(A1);
            Area JSON = JsonConvert.DeserializeObject<Area>(jsonString1);
            string jsonString2 = JsonConvert.SerializeObject(JSON);

            Assert.AreEqual(1, A1.As(AreaUnit.SquareMeter));
            Assert.AreEqual(10000, A1.As(AreaUnit.SquareCentimeter));
            Assert.AreEqual(1.195990046301080256481500558, A1.As(AreaUnit.SquareYard));

            //JSON
            Assert.AreEqual(1, JSON.As(AreaUnit.SquareMeter));
            Assert.AreEqual(10000, JSON.As(AreaUnit.SquareCentimeter));
            Assert.AreEqual(1.195990046301080256481500558, JSON.As(AreaUnit.SquareYard));


            Assert.AreEqual(jsonString1, jsonString2);



        }

        [TestMethod]
        public void AreaListJSON()
        {
            Area L1 = new Area(1, AreaUnit.SquareMeter);
            Area L2 = new Area(1, AreaUnit.SquareInch);

            List<Area> LocalList = new List<Area>();

            LocalList.Add(L1);
            LocalList.Add(L2);


            string jsonString1 = JsonConvert.SerializeObject(LocalList);
            List<Area> JSON = JsonConvert.DeserializeObject<List<Area>>(jsonString1);
            string jsonString2 = JsonConvert.SerializeObject(JSON);


            Assert.AreEqual(jsonString1, jsonString2);
        }



        [TestMethod]
        public void PowerListJSON()
        {
            Power L1 = new Power(1, PowerUnit.KilojoulePerHour);
            Power L2 = new Power(1, PowerUnit.Watt);

            List<Power> LocalList = new List<Power>();

            LocalList.Add(L1);
            LocalList.Add(L2);


            string jsonString1 = JsonConvert.SerializeObject(LocalList);
            List<Power> JSON = JsonConvert.DeserializeObject<List<Power>>(jsonString1);
            string jsonString2 = JsonConvert.SerializeObject(JSON);


            Assert.AreEqual(jsonString1, jsonString2);
        }


    }
}
