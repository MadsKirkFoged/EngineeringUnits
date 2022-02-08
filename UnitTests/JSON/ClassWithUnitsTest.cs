using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using UnitTests.JSON;

namespace UnitTests
{
    [TestClass]
    public class ClassWithUnitsTest
    {
        [TestMethod]
        public void AreaJSON()
        {


            ClassWithUnits test = new ClassWithUnits();

            test.massflow = MassFlow.FromKilogramsPerSecond(10);            

            Debug.WriteLine($"{test.massflow}");
            Debug.WriteLine($"List count: {test.massflow.Unit.ListOfUnits.Count}");


            string jsonString1 = JsonConvert.SerializeObject(test);
            ClassWithUnits JSON = JsonConvert.DeserializeObject<ClassWithUnits>(jsonString1);
            string jsonString2 = JsonConvert.SerializeObject(JSON);


            foreach (var item in test.massflow.Unit.ListOfUnits)
            {
                Debug.Print($"{item.GetType()}");
            }

            foreach (var item in JSON.massflow.Unit.ListOfUnits)
            {
                Debug.Print($"{item.GetType()}");
            }

            Debug.WriteLine($"{JSON.massflow}");
            Debug.WriteLine($"List count: {JSON.massflow.Unit.ListOfUnits.Count}");


            Assert.AreEqual(JSON.massflow.Unit.ListOfUnits.Count, test.massflow.Unit.ListOfUnits.Count);
            //Assert.AreEqual(10000, A1.As(AreaUnit.SquareCentimeter));
            //Assert.AreEqual(1.195990046301080256481500558, A1.As(AreaUnit.SquareYard));

            ////JSON
            //Assert.AreEqual(1, JSON.As(AreaUnit.SquareMeter));
            //Assert.AreEqual(10000, JSON.As(AreaUnit.SquareCentimeter));
            //Assert.AreEqual(1.195990046301080256481500558, JSON.As(AreaUnit.SquareYard));


            //Assert.AreEqual(jsonString1, jsonString2);



        }   


    }
}
