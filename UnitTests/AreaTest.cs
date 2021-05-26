using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void AreaSimple()
        {
            Length L1 = new Length(1, LengthUnit.Meter);
            Length L2 = new Length(1, LengthUnit.Meter);

            Debug.WriteLine($"{L1}");
            Debug.WriteLine($"{L2}");

            Area A1 = L1 * L2;

            Assert.AreEqual(1, A1.As(AreaUnit.Meter2));
            Assert.AreEqual(10000, A1.As(AreaUnit.Centimeter2));
            Assert.AreEqual(1.195990046301080256481500558, A1.As(AreaUnit.Yard2));
        }


        [TestMethod]
        public void AreaMany()
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
}
