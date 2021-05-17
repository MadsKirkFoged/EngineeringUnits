using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class LenghtTest
    {
        [TestMethod]
        public void LengthSI2SI()
        {
            Length L1 = new Length(65.948443434, LengthUnits.Meter);


            Assert.AreEqual(6594.8443434, L1.To(LengthUnits.Centimeter));
            Assert.AreEqual(65948.443434, L1.To(LengthUnits.Milimeter));
            Assert.AreEqual(65.948443434, L1.To(LengthUnits.Meter));
        }

        [TestMethod]
        public void LengthIP2IP()
        {
            Length L1 = new Length(1, LengthUnits.mile);


            Assert.AreEqual(1, L1.To(LengthUnits.mile));
            Assert.AreEqual(1760, L1.To(LengthUnits.Yard));
            Assert.AreEqual(5280, L1.To(LengthUnits.Foot));
            Assert.AreEqual(63360, L1.To(LengthUnits.Inch));
        }

        [TestMethod]
        public void LengthIP2SI()
        {
            Length L1 = new Length(1, LengthUnits.mile);


            Assert.AreEqual(160934.4, L1.To(LengthUnits.Centimeter));
            Assert.AreEqual(1609344, L1.To(LengthUnits.Milimeter));
            Assert.AreEqual(1609.344, L1.To(LengthUnits.Meter));
        }

        [TestMethod]
        public void LengthAdd()
        {
            Length L1 = new Length(3.87, LengthUnits.Inch);
            Length L2 = new Length(2.78, LengthUnits.Meter);

            Length L3 = L1 + L2;

            Assert.AreEqual(287.82979999999986, L3.To(LengthUnits.Centimeter));
            Assert.AreEqual(113.31881889763777, L3.To(LengthUnits.Inch));

        }

        [TestMethod]
        public void LengthSub()
        {
            Length L1 = new Length(3.87, LengthUnits.Inch);
            Length L2 = new Length(2.78, LengthUnits.Meter);

            Length L3 = L2 - L1;

            Assert.AreEqual(268.17019999999997, L3.To(LengthUnits.Centimeter));
            Assert.AreEqual(105.57881889763776, L3.To(LengthUnits.Inch));

        }

        [TestMethod]
        public void LengthDivide()
        {
            Length L1 = new Length(3.87, LengthUnits.Inch);
            Length L2 = new Length(2.78, LengthUnits.Meter);

            Length L3 = new Length(9, LengthUnits.Meter);
            Length L4 = new Length(3, LengthUnits.Meter);

            Length L5 = new Length(80, LengthUnits.Inch);
            Length L6 = new Length(20, LengthUnits.Inch);

            Assert.AreEqual(1, L1 / L1);
            Assert.AreEqual(1, L2 / L2);

            Assert.AreEqual(0.035358992805755406, L1 / L2);
            Assert.AreEqual(28.281348552361187, L2 / L1);

            Assert.AreEqual(3, L3 / L4);
            Assert.AreEqual(4, L5 / L6);
        }


        public void LengthMultiply()
        {
            Length L1 = new Length(3, LengthUnits.Inch);
            Length L2 = new Length(2, LengthUnits.Meter);

            Area A1 = L1 * L2;
            Area A2 = L1 * L1;
            Area A3 = L2 * L2;


            //Assert.AreEqual(1, A1.To(LengthUnits.Centimeter));
            //Assert.AreEqual(1, L2 / L2);


        }

    }
}
