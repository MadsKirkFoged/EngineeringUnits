using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class LenghtTest
    {


        [TestMethod]
        public void LengthTimesDouble()
        {
            Length L1 = new(65.948443434, LengthUnit.Meter);

            L1 *= 10;

            Assert.AreEqual(65948.443434, L1.As(LengthUnit.Centimeter));
            Assert.AreEqual(659484.43434, L1.As(LengthUnit.Millimeter));
            Assert.AreEqual(659.48443434, L1.As(LengthUnit.Meter));
        }

        [TestMethod]
        public void LengthTimesDouble2()
        {
            Length L1 = new(65.948443434, LengthUnit.Yard);

            L1 *= 10;

            Assert.AreEqual(659.48443434, L1.As(LengthUnit.Yard));
            Assert.AreEqual(603.032566760496, L1.As(LengthUnit.Meter));
            Assert.AreEqual(23741.43963624, L1.As(LengthUnit.Inch));
            Assert.AreEqual(1978.45330302, L1.As(LengthUnit.Foot));
        }

        [TestMethod]
        public void LengthTimesDouble3()
        {
            Length L1 = new(65.948443434, LengthUnit.Yard);

            L1 = 10 * L1;

            Assert.AreEqual(659.48443434, L1.As(LengthUnit.Yard));
            Assert.AreEqual(603.032566760496, L1.As(LengthUnit.Meter));
            Assert.AreEqual(23741.43963624, L1.As(LengthUnit.Inch));
            Assert.AreEqual(1978.45330302, L1.As(LengthUnit.Foot));
        }

        [TestMethod]
        public void LengthDivideDouble()
        {
            Length L1 = new(65.948443434, LengthUnit.Meter);


            L1 /= 10;



            Assert.AreEqual(659.48443434, L1.As(LengthUnit.Centimeter));
            Assert.AreEqual(6594.8443434, L1.As(LengthUnit.Millimeter));
            Assert.AreEqual(6.5948443434, L1.As(LengthUnit.Meter));
        }

        [TestMethod]
        public void LengthSI2SI()
        {
            Length L1 = new(65.948443434, LengthUnit.Meter);


            Assert.AreEqual(6594.8443434, L1.As(LengthUnit.Centimeter));
            Assert.AreEqual(65948.443434, L1.As(LengthUnit.Millimeter));
            Assert.AreEqual(65.948443434, L1.As(LengthUnit.Meter));
        }


        [TestMethod]
        public void LengthSI2SI2()
        {
            Length L1 = new(659484434, LengthUnit.Kilometer);


            Assert.AreEqual(65948443400000, L1.As(LengthUnit.Centimeter));
            Assert.AreEqual(659484434000000, L1.As(LengthUnit.Millimeter));
            Assert.AreEqual(659484434000, L1.As(LengthUnit.Meter));
        }



        [TestMethod]
        public void LengthIP2IP()
        {
            Length L1 = new(1, LengthUnit.Mile);


            Assert.AreEqual(1, L1.As(LengthUnit.Mile));
            Assert.AreEqual(1760, L1.As(LengthUnit.Yard));
            Assert.AreEqual(5280, L1.As(LengthUnit.Foot));
            Assert.AreEqual(63360, L1.As(LengthUnit.Inch));
        }

        [TestMethod]
        public void LengthIP2SI()
        {
            Length L1 = new(1, LengthUnit.Mile);


            Assert.AreEqual(160934.4, L1.As(LengthUnit.Centimeter));
            Assert.AreEqual(1609344, L1.As(LengthUnit.Millimeter));
            Assert.AreEqual(1609.344, L1.As(LengthUnit.Meter));
        }

        [TestMethod]
        public void LengthAddDifferent()
        {
            Length L1 = new(3.87, LengthUnit.Inch);
            Length L2 = new(2.78, LengthUnit.Meter);

            Length L3 = L1 + L2;
            Length L4 = L2 + L1;


            Assert.AreEqual(287.8298, L3.As(LengthUnit.Centimeter), 0.0000001);
            Assert.AreEqual(113.31881889763779527559055118, L3.As(LengthUnit.Inch));
            Assert.AreEqual(287.8298, L4.As(LengthUnit.Centimeter));
            Assert.AreEqual(113.31881889763779527559055118, L4.As(LengthUnit.Inch));



        }

        [TestMethod]
        public void LengthAddToExactNumber()
        {
            Length L1 = new(1000, LengthUnit.Inch);
            Length L2 = new(10000, LengthUnit.Yard);

            Length L3 = L1 + L2;
            Length L4 = L2 + L1;
            Length L5 = L1 + L1;
            Length L6 = L2 + L2;

            Assert.AreEqual(361000, L3.As(LengthUnit.Inch));
            Assert.AreEqual(361000, L4.As(LengthUnit.Inch));
            Assert.AreEqual(2000, L5.As(LengthUnit.Inch));
            Assert.AreEqual(720000, L6.As(LengthUnit.Inch));


        }

        [TestMethod]
        public void LengthSub()
        {
            Length L1 = new(3.87, LengthUnit.Inch);
            Length L2 = new(2.78, LengthUnit.Meter);

            Length L3 = L2 - L1;

            Assert.AreEqual(268.1702, L3.As(LengthUnit.Centimeter));
            Assert.AreEqual(105.57881889763779, L3.As(LengthUnit.Inch));

        }

        [TestMethod]
        public void LengthDivide()
        {
            Length L1 = new(3.87, LengthUnit.Inch);
            Length L2 = new(2.78, LengthUnit.Meter);

            Length L3 = new(9, LengthUnit.Meter);
            Length L4 = new(3, LengthUnit.Meter);

            Length L5 = new(80, LengthUnit.Inch);
            Length L6 = new(20, LengthUnit.Inch);

            Assert.AreEqual(0.0353589928057554, (double)(L1 / L2));
            Assert.AreEqual(28.281348552361187, (double)(L2 / L1));
            
            Assert.AreEqual(1, (double)(L1 / L1));
            Assert.AreEqual(1, (double)(L2 / L2));


            Assert.AreEqual(3, (double)(L3 / L4));
            Assert.AreEqual(4, (double)(L5 / L6));
        }

        [TestMethod]
        public void LengthDivide2()
        {

            Length L1 = new(200, LengthUnit.Centimeter);
            Length L2 = new(3, LengthUnit.Foot);


            var A1 = (L1 * L1 * L1) / (L2 * L2);

            Debug.Print($"{A1}");


            //Assert.AreEqual(1, A1.));
            //Assert.AreEqual(1, (double)(L2 / L2));

            //Assert.AreEqual(0.035358992805755406, (double)(L1 / L2), 0.000000001);
            //Assert.AreEqual(28.281348552361187, (double)(L2 / L1), 0.000000001);

            //Assert.AreEqual(3, (double)(L3 / L4));
            //Assert.AreEqual(4, (double)(L5 / L6));
        }

        

        [TestMethod]
        public void LengthMultiply2()
        {
            Length L1 = new(3, LengthUnit.Inch);
            Length L2 = new(2, LengthUnit.Meter);

            var test13 = (L1 * 10) / L1;
            var test14 = (L1 * 10);

            var test15 = test14/ L1;


            //Make a crazy series
            Area test1 = L1 * L1;
            var test16 = L1 * L1;

            var test2 = L1 * L1 * L1;
            var test3 = L1 * L1 * L1 * L1;
            var test4 = L1 * L1 * L1 * L1 * L1;
            var test5 = L1 * L1 * L1 * L1 * L1 * 50;
            var test6 = L1 * L1 * L1 * L1 * L1 / 100;
            var test7 = L1 / 100;
            var test8 = 100 / L1;
            var test9 = 100 * L1;
            var test10 = L1 * 100;
            Length L3 = L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 / (L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1);
            Area A2 = L1 * L1;
            Area A3 = L2 * L2;

            Length test11 = (L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1) + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);
            //var test12 = (((L1 * 10) / L1) * 10 * L1 / 10 / 10 / 10 / L1 * 10 * L1 - L1 - L1 - L1 - L1 - L1) + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);

            //Assert.AreEqual(1, A1.To(LengthUnits.Centimeter));
            //Assert.AreEqual(1, L2 / L2);


        }

        [TestMethod]
        public void LengthOperators()
        {
            Length L1 = new(5, LengthUnit.Meter);
            Length L2 = new(2, LengthUnit.Inch);
            Length L4 = new(2, LengthUnit.Inch);

            Length L3 = L1;
           

            Assert.IsTrue(L1 == L3);
            Assert.IsTrue(L3 == L1);

            Assert.IsFalse(L1 == L2);
            Assert.IsTrue(L1 != L2);

            Assert.IsFalse(L1 != L3);
            Assert.IsFalse(L3 != L1);

            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);

            Assert.IsTrue( L1 > L2);
            Assert.IsFalse(L1 > L3);
            Assert.IsFalse(L1 < L3);


            Assert.IsTrue(L1 >= L2);
            Assert.IsTrue( L2 >= L4);

            Assert.IsFalse(L1 <  L2);
            Assert.IsFalse(L1 <= L2);

            
            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 >= L1);

            Assert.IsTrue(L2 < L1);
            Assert.IsTrue(L2 <= L1);
            Assert.IsTrue(L2 <= L4);



            Assert.IsTrue(L1 * L1 == L3 * L3);
            Assert.IsTrue(L3 * L3 == L1 * L1);

            Assert.IsTrue(L1 * L1 > L2 * L2);
            Assert.IsTrue(L1 * L1 >= L2 * L2);
            Assert.IsFalse(L1 * L1 < L2 * L2);
            Assert.IsFalse(L1 * L1 <= L2 * L2);

            Assert.IsFalse(L2 * L2 > L1 * L1);
            Assert.IsFalse(L2 * L2 >= L1 * L1);
            Assert.IsTrue(L2 * L2 < L1 * L1);
            Assert.IsTrue(L2 * L2 <= L1 * L1);
            var add = L1 + L3;
            Assert.IsTrue(L1 + L1 == add);
            var subtract = L1 - L3;
            Assert.IsTrue(subtract == L1 - L1);
            Assert.IsFalse(add < subtract);

            Assert.IsTrue(L1.Equals(L3));
            


        }

        [TestMethod]
        public void UnknownOperators()
        {
            UnknownUnit L1 = new Length(5, LengthUnit.Meter);
            UnknownUnit L2 = new Length(2, LengthUnit.Inch);
            UnknownUnit L4 = new Length(2, LengthUnit.Inch);

            UnknownUnit L3 = L1;


            Assert.IsTrue(L1 == L3);
            Assert.IsTrue(L3 == L1);

            Assert.IsFalse(L1 == L2);
            Assert.IsTrue(L1 != L2);

            Assert.IsFalse(L1 != L3);
            Assert.IsFalse(L3 != L1);

            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);

            Assert.IsTrue(L1 > L2);
            Assert.IsFalse(L1 > L3);
            Assert.IsFalse(L1 < L3);


            Assert.IsTrue(L1 >= L2);
            Assert.IsTrue(L2 >= L4);

            Assert.IsFalse(L1 < L2);
            Assert.IsFalse(L1 <= L2);


            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 >= L1);

            Assert.IsTrue(L2 < L1);
            Assert.IsTrue(L2 <= L1);
            Assert.IsTrue(L2 <= L4);



            Assert.IsTrue(L1 * L1 == L3 * L3);
            Assert.IsTrue(L3 * L3 == L1 * L1);

            Assert.IsTrue(L1 * L1 > L2 * L2);
            Assert.IsTrue(L1 * L1 >= L2 * L2);
            Assert.IsFalse(L1 * L1 < L2 * L2);
            Assert.IsFalse(L1 * L1 <= L2 * L2);

            Assert.IsFalse(L2 * L2 > L1 * L1);
            Assert.IsFalse(L2 * L2 >= L1 * L1);
            Assert.IsTrue(L2 * L2 < L1 * L1);
            Assert.IsTrue(L2 * L2 <= L1 * L1);
            var add = L1 + L3;
            Assert.IsTrue(L1 + L1 == add);
            var subtract = L1 - L3;
            Assert.IsTrue(subtract == L1 - L1);
            Assert.IsFalse(add < subtract);


        }


        [TestMethod]
        public void LengthJSON()
        {
            Length L1 = new(1, LengthUnit.Mile);


            string jsonstring = JsonConvert.SerializeObject(L1);
            Length JSON = JsonConvert.DeserializeObject<Length>(jsonstring);


            Assert.AreEqual(160934.4, JSON.As(LengthUnit.Centimeter));
            Assert.AreEqual(1609344, JSON.As(LengthUnit.Millimeter));
            Assert.AreEqual(1609.344, JSON.As(LengthUnit.Meter));

        }



    }
}
