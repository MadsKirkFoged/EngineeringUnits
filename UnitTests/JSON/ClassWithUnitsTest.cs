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


            var test = new ClassWithUnits
            {
                massflow = MassFlow.FromKilogramPerSecond(10)
            };

            //Debug.WriteLine($"{test.massflow}");
            //Debug.WriteLine($"List count: {test.massflow.Unit.ListOfUnits.Count}");


            var jsonString1 = JsonConvert.SerializeObject(test);
            ClassWithUnits JSON = JsonConvert.DeserializeObject<ClassWithUnits>(jsonString1);
            //var jsonString2 = JsonConvert.SerializeObject(JSON);

            UnitSystem unitSystem1 = test.massflow;
            UnitSystem unitSystem = JSON.massflow;


            foreach (var item in unitSystem.ListOfUnits)
            {
                Debug.Print($"{item.GetType()}");
            }

            foreach (var item in unitSystem.ListOfUnits)
            {
                Debug.Print($"{item.GetType()}");
            }

            Debug.WriteLine($"{JSON.massflow}");
            Debug.WriteLine($"List count: {unitSystem.ListOfUnits.Count}");


            Assert.AreEqual(unitSystem.ListOfUnits.Count, unitSystem1.ListOfUnits.Count);

        }   


    }
}
