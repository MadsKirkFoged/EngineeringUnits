using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class TemperatureTest
    {


        [TestMethod]
        public void TemperatureCelsiusDivideDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            T1 /= 10;

            Assert.AreEqual(-243.835m, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(29.315m, T1.As(TemperatureUnit.Kelvin));

        }


        [TestMethod]
        public void TemperatureCelsiusTimesDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            T1 *= 10;

            Assert.AreEqual(2658.35m, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(2931.5m, T1.As(TemperatureUnit.Kelvin));

        }


        [TestMethod]
        public void TemperatureKelvinTimesDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.Kelvin);


            T1 *= 10;

            Assert.AreEqual(200, T1.As(TemperatureUnit.Kelvin));

        }




        [TestMethod]
        public void TemperatureConvertsFromKelvin()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.Kelvin);


            Assert.AreEqual(20m, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(-253.15m, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(-423.67d, (double)T1.As(TemperatureUnit.DegreeFahrenheit),0.00000001);            
        }


        [TestMethod]
        public void TemperatureConvertsFromCelsius()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);

            Debug.Print($"{T1}");

            Assert.AreEqual(293.15m, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(20m, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(68d, (double)T1.As(TemperatureUnit.DegreeFahrenheit), 0.000001);
        }


        [TestMethod]
        public void TemperatureConvertsFromFahrenheit()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeFahrenheit);


            Assert.AreEqual(266.48333333333335d, (double)T1.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(-6.666667d, (double)T1.As(TemperatureUnit.DegreeCelsius),0.00001);
            Assert.AreEqual(20m, T1.As(TemperatureUnit.DegreeFahrenheit));
        }


        [TestMethod]
        public void TemperatureAdd()
        {

            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(293.15, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(68, TemperatureUnit.DegreeFahrenheit);



            //Debug.WriteLine($"{T1}");
            Temperature T4 = T1 + T1;
            Temperature T5 = T2 + T2;
            Temperature T6 = T3 + T3;


            Assert.AreEqual(586.3d, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(313.15d, (double)T5.As(TemperatureUnit.DegreeCelsius), 0.00001);
            Assert.AreEqual(595.67d, (double)T6.As(TemperatureUnit.DegreeFahrenheit));
        }

        [TestMethod]
        public void TemperatureAdd2()
        {

            Temperature T1 = new Temperature(0, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(0, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(0, TemperatureUnit.DegreeFahrenheit);



            //Debug.WriteLine($"{T1}");
            Temperature T4 = T1 + T1;
            Temperature T5 = T2 + T2;
            Temperature T6 = T3 + T3;


            Assert.AreEqual(546.3d, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
            Assert.AreEqual(0d, (double)T5.As(TemperatureUnit.Kelvin), 0.00001);
            Assert.AreEqual(510.7444444444448d, (double)T6.As(TemperatureUnit.Kelvin));
        }

        [TestMethod]
        public void TemperatureMultiply()
        {

            Temperature T1 = new Temperature(0, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(0, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(0, TemperatureUnit.DegreeFahrenheit);


            var T4 = T1 * T1;
            var T5 = T2 * T2;
            var T6 = T3 * T3;


            Assert.AreEqual("74337,7725 °C²", T4.ToString());
            Assert.AreEqual("0 k²", T5.ToString());
            //Assert.AreEqual("116927,27938888899 °F²", T6.ToString());
        }

    }
}
