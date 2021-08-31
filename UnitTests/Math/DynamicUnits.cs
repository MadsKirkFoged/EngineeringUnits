using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DynamicUnits
    {
        [TestMethod]
        public void TestDynamics01()
        {
            ElectricPotential voltage1 = ElectricPotential.From(3, ElectricPotentialUnit.Millivolt); // 3 millivolts
            ElectricCurrent current1 = ElectricCurrent.From(5, ElectricCurrentUnit.Milliampere); // 5 milliamps

            Power power1 = voltage1 * current1; // 15 microwatts
            var power2 = voltage1 * current1;
            dynamic power3 = voltage1 * current1;
            BaseUnit power4 = (BaseUnit) (voltage1 * current1);

            Assert.IsTrue(power1.ToString().Contains("W")); // needs to be in watts, not kg * m2 / s3
            Assert.AreEqual(power1.ToString(), power2.ToString());
            Assert.AreEqual(power1.ToString(), power3.ToString());
            Assert.AreEqual(power1.ToString(), power4.ToString());
        }

        [TestMethod]
        public void TestDynamics02()
        {
            UnknownUnit repetitions = Length.FromMeters(240) / Length.FromMeters(1); // TODO: Replace this with a Dimensionless scalar when that is supported !
            Duration minute = Duration.FromMinutes(2);

            Frequency freq1 = repetitions / minute; // 2 Hertz
            var freq2 = repetitions / minute; 
            dynamic freq3 = repetitions / minute; 
            BaseUnit freq4 = (BaseUnit)(repetitions / minute);

            Assert.IsTrue(freq1.ToString().Contains("Hz")); // needs to be in Hertz, not 1 / s
            Assert.AreEqual(freq1.ToString(), freq2.ToString());
            Assert.AreEqual(freq1.ToString(), freq3.ToString());
            Assert.AreEqual(freq1.ToString(), freq4.ToString());
        }

        [TestMethod]
        public void TestDynamics03()
        {
            SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            Power Q1 = M1 * P1 * (T2 - T1);
            var Q2 = M1 * P1 * (T2 - T1);
            dynamic Q3 = M1 * P1 * (T2 - T1);
            UnknownUnit Q4 = M1 * P1 * (T2 - T1);

            Assert.IsTrue(Q1.ToString().Contains("W")); // needs to be in watts, not kg * m2 / s3
            Assert.AreEqual(Q1.ToString(), Q2.ToString());
            Assert.AreEqual(Q1.ToString(), Q3.ToString());
            Assert.AreEqual(Q1.ToString(), Q4.ToString());
        }
    }
}
