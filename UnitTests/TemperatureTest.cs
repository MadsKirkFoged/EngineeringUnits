using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Assert.AreEqual(-243.835, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(29.315, T1.As(TemperatureUnit.Kelvin));

        }


        [TestMethod]
        public void TemperatureCelsiusTimesDouble()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            T1 *= 10;

            Assert.AreEqual(2658.35, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(2931.5, T1.As(TemperatureUnit.Kelvin));

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


            Assert.AreEqual(20, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(-253.15, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(-423.67, T1.As(TemperatureUnit.DegreeFahrenheit),0.0000001);            
        }


        [TestMethod]
        public void TemperatureConvertsFromCelsius()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);


            Assert.AreEqual(293.15, T1.As(TemperatureUnit.Kelvin));
            Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeCelsius));
            Assert.AreEqual(68, T1.As(TemperatureUnit.DegreeFahrenheit), 0.0000001);
        }


        [TestMethod]
        public void TemperatureConvertsFromFahrenheit()
        {
            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeFahrenheit);


            Assert.AreEqual(266.48333333333335, T1.As(TemperatureUnit.Kelvin), 0.0001);
            Assert.AreEqual(-6.666667, T1.As(TemperatureUnit.DegreeCelsius), 0.00001);
            Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeFahrenheit));
        }

        //[TestMethod]
        //public void LengthIP2IP()
        //{
        //    Length L1 = new Length(1, LengthUnit.Mile);


        //    Assert.AreEqual(1, L1.As(LengthUnit.Mile));
        //    Assert.AreEqual(1760, L1.As(LengthUnit.Yard));
        //    Assert.AreEqual(5280, L1.As(LengthUnit.Foot));
        //    Assert.AreEqual(63360, L1.As(LengthUnit.Inch));
        //}

        //[TestMethod]
        //public void LengthIP2SI()
        //{
        //    Length L1 = new Length(1, LengthUnit.Mile);


        //    Assert.AreEqual(160934.4, L1.As(LengthUnit.Centimeter));
        //    Assert.AreEqual(1609344, L1.As(LengthUnit.Millimeter));
        //    Assert.AreEqual(1609.344, L1.As(LengthUnit.Meter));
        //}

        //[TestMethod]
        //public void LengthAdd()
        //{
        //    Length L1 = new Length(3.87, LengthUnit.Inch);
        //    Length L2 = new Length(2.78, LengthUnit.Meter);

        //    Length L3 = L1 + L2;

        //    Assert.AreEqual(287.8298, L3.As(LengthUnit.Centimeter), 0.0001);
        //    Assert.AreEqual(113.318819, L3.As(LengthUnit.Inch), 0.00001);

        //}

        //[TestMethod]
        //public void LengthSub()
        //{
        //    Length L1 = new Length(3.87, LengthUnit.Inch);
        //    Length L2 = new Length(2.78, LengthUnit.Meter);

        //    Length L3 = L2 - L1;

        //    Assert.AreEqual(268.17019999999997, L3.As(LengthUnit.Centimeter), 0.000000001);
        //    Assert.AreEqual(105.57881889763776, L3.As(LengthUnit.Inch), 0.000000001);

        //}

        //[TestMethod]
        //public void LengthDivide()
        //{
        //    Length L1 = new Length(3.87, LengthUnit.Inch);
        //    Length L2 = new Length(2.78, LengthUnit.Meter);

        //    Length L3 = new Length(9, LengthUnit.Meter);
        //    Length L4 = new Length(3, LengthUnit.Meter);

        //    Length L5 = new Length(80, LengthUnit.Inch);
        //    Length L6 = new Length(20, LengthUnit.Inch);

        //    Assert.AreEqual(1, (double)(L1 / L1));
        //    Assert.AreEqual(1, (double)(L2 / L2));

        //    Assert.AreEqual(0.035358992805755406, (double)(L1 / L2), 0.000000001);
        //    Assert.AreEqual(28.281348552361187, (double)(L2 / L1), 0.000000001);

        //    Assert.AreEqual(3, (double)(L3 / L4));
        //    Assert.AreEqual(4, (double)(L5 / L6));
        //}

        //[TestMethod]
        //public void LengthMultiply()
        //{
        //    Length L1 = new Length(3, LengthUnit.Inch);
        //    Length L2 = new Length(2, LengthUnit.Meter);

        //    var test13 = (L1 * 10) / L1;
        //    var test14 = (L1 * 10);

        //    var test15 = test14/ L1;


        //    //Make a crazy series
        //    Area test1 = L1 * L1;
        //    var test16 = L1 * L1;

        //    var test2 = L1 * L1 * L1;
        //    var test3 = L1 * L1 * L1 * L1;
        //    var test4 = L1 * L1 * L1 * L1 * L1;
        //    var test5 = L1 * L1 * L1 * L1 * L1 * 50;
        //    var test6 = L1 * L1 * L1 * L1 * L1 / 100;
        //    var test7 = L1 / 100;
        //    var test8 = 100 / L1;
        //    var test9 = 100 * L1;
        //    var test10 = L1 * 100;
        //    Length L3 = L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 / (L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1);
        //    Area A2 = L1 * L1;
        //    Area A3 = L2 * L2;

        //    Length test11 = (L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1) + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);
        //    var test12 = (((L1 * 10) / L1) * 10 * L1 / 10 / 10 / 10 / L1 * 10 * L1 - L1 - L1 - L1 - L1 - L1) + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);

        //    //Assert.AreEqual(1, A1.To(LengthUnits.Centimeter));
        //    //Assert.AreEqual(1, L2 / L2);


        //}

        //[TestMethod]
        //public void LengthOperators()
        //{
        //    Length L1 = new Length(5, LengthUnit.Meter);
        //    Length L2 = new Length(2, LengthUnit.Inch);

        //    Length L3 = L1;

        //    Assert.IsTrue(L1 == L3);
        //    Assert.IsTrue(L3 == L1);

        //    Assert.IsTrue( L1 >  L2);
        //    Assert.IsTrue( L1 >= L2);
        //    Assert.IsFalse(L1 <  L2);
        //    Assert.IsFalse(L1 <= L2);


        //    Assert.IsTrue(L1 * L1 == L3 * L3);
        //    Assert.IsTrue(L3 * L3 == L1 * L1);

        //    Assert.IsTrue(L1 * L1 > L2 * L2);
        //    Assert.IsTrue(L1 * L1 >= L2 * L2);
        //    Assert.IsFalse(L1 * L1 < L2 * L2);
        //    Assert.IsFalse(L1 * L1 <= L2 * L2);




        //}

    }
}
