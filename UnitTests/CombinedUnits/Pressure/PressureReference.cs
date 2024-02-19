using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineeringUnits;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class PressureReferenceTest
    {

        [TestMethod]
        public void Pressure()
        {
            //Creating new with undefined
            Pressure P1 = new Pressure(10, PressureUnit.Bar);
            Assert.AreEqual(P1.ToString(), "10 bar");
            Assert.AreEqual($"{P1}", "10 bar");

            //Creating new with undefined and setting to Absolute
            Pressure P2 = P1.ToUnit(PressureUnit.BarA);
            Assert.AreEqual(P2.ToString(), "10 bara");
            Assert.AreEqual($"{P2}", "10 bara");

            //Converting from undefined to Gauge
            Pressure P3 = P1.ToUnit(PressureUnit.BarG);
            Assert.AreEqual(P3.ToString(), "8.987 barg");
            Assert.AreEqual($"{P3}", "8.987 barg");

            //Creating new with Gauge
            Pressure P4 = new Pressure(10m, PressureUnit.BarG);
            Assert.AreEqual(P4.ToString(), "10 barg");
            Assert.AreEqual($"{P4}", "10 barg");

            //Creating new with Absolute
            Pressure P5 = new Pressure(10m, PressureUnit.BarA);
            Assert.AreEqual(P5.ToString(), "10 bara");
            Assert.AreEqual($"{P5}", "10 bara");

            //Converting from Gauge to Gauge
            Pressure P6 = P4.ToUnit(PressureUnit.BarG);
            Assert.AreEqual(P6.ToString(), "10 barg");
            Assert.AreEqual($"{P6}", "10 barg");

            //Converting from Absolute to Gauge
            Pressure P7 = P5.ToUnit(PressureUnit.BarG);
            Assert.AreEqual(P7.ToString(), "8.987 barg");
            Assert.AreEqual($"{P7}", "8.987 barg");

            //Converting from Gauge to Absolute
            Pressure P8 = P4.ToUnit(PressureUnit.BarA);
            Assert.AreEqual(P8.ToString(), "11.01 bara");
            Assert.AreEqual($"{P8}", "11.01 bara");

            //Converting from Absolute to Absolute
            Pressure P9 = P5.ToUnit(PressureUnit.BarA);
            Assert.AreEqual(P9.ToString(), "10 bara");
            Assert.AreEqual($"{P9}", "10 bara");
        }


        [TestMethod]
        public void AbsoluteToAbsolute()
        {
            //Arrange
            Pressure A = new Pressure(10, PressureUnit.BarA);

            //Act
            var G = A.ToUnit(PressureUnit.BarG);


            //Assert
            Assert.AreEqual(A, G);
        }

        [TestMethod]
        public void GaugeAddGauge()
        {
            //Arrange
            Pressure A = new Pressure(10, PressureUnit.BarG);
            Pressure B = new Pressure(5, PressureUnit.BarG);

            //Act
            Pressure C = A + B;
            double K3 = A.As(PressureUnit.SI) - B.As(PressureUnit.SI);

            //Assert
            Assert.AreEqual(C.ToString(), "17.03 bar");
            Assert.AreEqual(C.As(PressureUnit.Bar), 17.0265);
            Assert.AreEqual(C.As(PressureUnit.BarA), 17.0265);
            Assert.AreEqual(K3, 500000);
        }

    }
}
