using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNetEq
    {


        [TestMethod]
        public void Powerequation()
        {

            //Q = m * Cp * dT

            //obs - UnitsNet cant do this eq..


            EngineeringUnits.SpecificEntropy P1 = new EngineeringUnits.SpecificEntropy(1, EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin);
            EngineeringUnits.MassFlow M1 = new EngineeringUnits.MassFlow(1, EngineeringUnits.MassFlowUnit.KilogramPerSecond);
            EngineeringUnits.Temperature T2 = new EngineeringUnits.Temperature(10, EngineeringUnits.TemperatureUnit.DegreeCelsius);
            EngineeringUnits.Temperature T1 = new EngineeringUnits.Temperature(5, EngineeringUnits.TemperatureUnit.DegreeCelsius);

            EngineeringUnits.Power Q1 = M1 * P1 * (T2 - T1);




            UnitsNet.SpecificEntropy p1 = new UnitsNet.SpecificEntropy(1, UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin);
            UnitsNet.MassFlow m1 = new UnitsNet.MassFlow(1, UnitsNet.Units.MassFlowUnit.KilogramPerSecond);
            UnitsNet.Temperature t2 = new UnitsNet.Temperature(10, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
            UnitsNet.Temperature t1 = new UnitsNet.Temperature(5, UnitsNet.Units.TemperatureUnit.DegreeCelsius);

            UnitsNet.Power q1 = UnitsNet.Power.FromWatts( p1.JoulesPerKilogramKelvin * m1.KilogramsPerSecond * (t2.Kelvins - t1.Kelvins));




            Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour) - q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 7.2E-05);
            Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Kilowatt) - q1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
            Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Watt) - q1.As(UnitsNet.Units.PowerUnit.Watt), 0);


        }

        [TestMethod]
        public void Powerequation2()
        {

            //Q = m * Cp * dT

            //obs - UnitsNet cant do this eq..


            EngineeringUnits.SpecificEntropy P1 = new EngineeringUnits.SpecificEntropy(35345, EngineeringUnits.SpecificEntropyUnit.BtuPerPoundRankine);
            EngineeringUnits.MassFlow M1 = new EngineeringUnits.MassFlow(4356, EngineeringUnits.MassFlowUnit.PoundPerMinute);
            EngineeringUnits.Temperature T2 = new EngineeringUnits.Temperature(342, EngineeringUnits.TemperatureUnit.DegreeRankine);
            EngineeringUnits.Temperature T1 = new EngineeringUnits.Temperature(43, EngineeringUnits.TemperatureUnit.DegreeRankine);

            EngineeringUnits.Power Q1 = M1 * P1 * (T2 - T1);



            UnitsNet.SpecificEntropy p1 = new UnitsNet.SpecificEntropy(35345, UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit);
            UnitsNet.MassFlow m1 = new UnitsNet.MassFlow(4356, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
            UnitsNet.Temperature t2 = new UnitsNet.Temperature(342, UnitsNet.Units.TemperatureUnit.DegreeRankine);
            UnitsNet.Temperature t1 = new UnitsNet.Temperature(43, UnitsNet.Units.TemperatureUnit.DegreeRankine);

            UnitsNet.Power q1 = UnitsNet.Power.FromWatts(p1.JoulesPerKilogramKelvin * m1.KilogramsPerSecond * (t2.Kelvins - t1.Kelvins));



            //BtuPerPoundFahrenheit-- > JoulePerKilogramKelvin
            //UnitsNet: 4186,8
            //EngineeringUnits: 4186,816458133984
            //UnitsNet dont not use a high precision for this conversion which gives a off result

            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent( P1.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin), 
                                                    p1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)),  0.0004);

            Assert.AreEqual(0, HelperClass.Percent( P1.As(EngineeringUnits.SpecificEntropyUnit.BtuPerPoundRankine),
                                                    p1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit)), 0);

            Assert.AreEqual(0, HelperClass.Percent(M1.As(EngineeringUnits.MassFlowUnit.KilogramPerSecond),
                                                    m1.As(UnitsNet.Units.MassFlowUnit.KilogramPerSecond)), 0.0003);






            //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour) - q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 0);
            //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Kilowatt) - q1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
            //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Watt) - q1.As(UnitsNet.Units.PowerUnit.Watt), 0);

            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent( Q1.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour), 
                                                    q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0.0003);

            Assert.AreEqual(0, HelperClass.Percent( Q1.As(EngineeringUnits.PowerUnit.Kilowatt), 
                                                    q1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0.00013);

            Assert.AreEqual(0, HelperClass.Percent( Q1.As(EngineeringUnits.PowerUnit.Watt),  
                                                    q1.As(UnitsNet.Units.PowerUnit.Watt)), 0.00013);




            string jsonString1 = JsonConvert.SerializeObject(Q1);
            EngineeringUnits.Power JSON = JsonConvert.DeserializeObject<EngineeringUnits.Power>(jsonString1);
            string jsonString2 = JsonConvert.SerializeObject(JSON);


            Assert.AreEqual(jsonString1, jsonString2);


        }


    }
}
