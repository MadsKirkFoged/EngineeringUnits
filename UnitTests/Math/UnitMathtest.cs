using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests
{
    [TestClass]
    public class UnitMathTest
    {


        [TestMethod]
        public void Sum()
        {

            var list1 = new List<MassFlow>
            {
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(10),
                MassFlow.FromKilogramPerSecond(9),
            };

            
            MassFlow Average = UnitMath.Average(list1);
            MassFlow Sum = UnitMath.Sum(list1);
            MassFlow Max = UnitMath.Max(list1);
            MassFlow Min = UnitMath.Min(list1);

          
            MassFlow Average2 = UnitMath.Average(
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(9),
                MassFlow.FromKilogramPerSecond(10)
                );

            MassFlow Sum2 = UnitMath.Sum(
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(9),
                MassFlow.FromKilogramPerSecond(10)
                );

            MassFlow Max2 = UnitMath.Max(
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(9),
                MassFlow.FromKilogramPerSecond(10)
                );

        MassFlow Min2 = UnitMath.Min(
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(9),
                MassFlow.FromKilogramPerSecond(10)
                );


            MassFlow Average3 = list1.Average();
            MassFlow Sum3 = list1.Sum();
            MassFlow Max3 = list1.Max();
            MassFlow Min3 = list1.Min();


            Assert.AreEqual(Average.KilogramPerSecond, 5.5, 0);
            Assert.AreEqual(Sum.KilogramPerSecond, 55, 0);
            Assert.AreEqual(Max.KilogramPerSecond, 10, 0);
            Assert.AreEqual(Min.KilogramPerSecond, 1, 0);

            Assert.AreEqual(Average, Average2);
            Assert.AreEqual(Sum, Sum2);
            Assert.AreEqual(Max, Max2);
            Assert.AreEqual(Min, Min2);

            Assert.AreEqual(Average, Average3);
            Assert.AreEqual(Sum, Sum3);
            Assert.AreEqual(Max, Max3);
            Assert.AreEqual(Min, Min3);

        }

        //Create test




        [TestMethod]
        public void Pow()
        {
            Length twoMeters = Length.From(2, LengthUnit.Meter);

            var powMinus3 = twoMeters.Pow(-3);
            var powMinus2 = twoMeters.Pow(-2);
            var powMinus1 = twoMeters.Pow(-1);
            var pow0 = twoMeters.Pow(0);
            var pow1 = twoMeters.Pow(1);
            var pow2 = twoMeters.Pow(2);
            var pow3 = twoMeters.Pow(3);

            Assert.AreEqual(Math.Pow(2, -3), (double)powMinus3.SI);
            Assert.AreEqual(Math.Pow(2, -2), (double)powMinus2.SI);
            Assert.AreEqual(Math.Pow(2, -1), (double)powMinus1.SI);
            Assert.AreEqual(Math.Pow(2, 0), (double)pow0.SI);
            Assert.AreEqual(Math.Pow(2, 1), (double)pow1.SI);
            Assert.AreEqual(Math.Pow(2, 2), (double)pow2.SI);
            Assert.AreEqual(Math.Pow(2, 3), (double)pow3.SI);
        }

        [TestMethod]
        public void Sum02()
        {
            
            var list1 = new List<UnknownUnit>
            {
                Length.FromKilometer(1)/Duration.FromHour(2),
                Length.FromKilometer(1)/Duration.FromHour(1),
                Length.FromKilometer(1)/Duration.FromHour(3),
                Length.FromKilometer(1)/Duration.FromHour(5),
                 Length.FromKilometer(1)/Duration.FromHour(4)
               
            };
         

            UnknownUnit Average = UnitMath.Average(list1);
            UnknownUnit Sum = UnitMath.Sum(list1);
            UnknownUnit Max = UnitMath.Max(list1);
            UnknownUnit Min = UnitMath.Min(list1);

                UnknownUnit Average2 = UnitMath.Average(
               Length.FromKilometer(1) / Duration.FromHour(1),
                Length.FromKilometer(1) / Duration.FromHour(2),
                Length.FromKilometer(1) / Duration.FromHour(3),
                Length.FromKilometer(1) / Duration.FromHour(4),
                Length.FromKilometer(1) / Duration.FromHour(5)
                );

            UnknownUnit Sum2 = UnitMath.Sum(
               Length.FromKilometer(1) / Duration.FromHour(1),
                Length.FromKilometer(1) / Duration.FromHour(2),
                Length.FromKilometer(1) / Duration.FromHour(3),
                Length.FromKilometer(1) / Duration.FromHour(4),
                Length.FromKilometer(1) / Duration.FromHour(5)
                );

            UnknownUnit Max2 = UnitMath.Max(
                Length.FromKilometer(1) / Duration.FromHour(1),
                Length.FromKilometer(1) / Duration.FromHour(2),
                Length.FromKilometer(1) / Duration.FromHour(3),
                Length.FromKilometer(1) / Duration.FromHour(4),
                Length.FromKilometer(1) / Duration.FromHour(5)
                );

            UnknownUnit Min2 = UnitMath.Min(
                Length.FromKilometer(1) / Duration.FromHour(1),
                Length.FromKilometer(1) / Duration.FromHour(2),
                Length.FromKilometer(1) / Duration.FromHour(3),
                Length.FromKilometer(1) / Duration.FromHour(4),
                Length.FromKilometer(1) / Duration.FromHour(5)
                    );


            UnknownUnit Average3 = list1.Average();
            UnknownUnit Sum3 = list1.Sum();
            UnknownUnit Max3 = list1.Max();
            UnknownUnit Min3 = list1.Min();

            Assert.AreEqual(Average.As(SpeedUnit.KilometerPerhour), 0.4566666666666667);
            Assert.AreEqual(Sum.As(SpeedUnit.KilometerPerhour), 2.283333333333333);
            Assert.AreEqual(Max.As(SpeedUnit.KilometerPerhour), 1);
            Assert.AreEqual(Min.As(SpeedUnit.KilometerPerhour), 0.2);


            
            Assert.AreEqual(Average, Average2);
            Assert.AreEqual(Sum, Sum2);
            Assert.AreEqual(Max, Max2);
            Assert.AreEqual(Min, Min2);

            Assert.AreEqual(Average, Average3);
            Assert.AreEqual(Sum, Sum3);
            Assert.AreEqual(Max, Max3);
            Assert.AreEqual(Min, Min3);
            
           


        }


        [TestMethod]
        public void UnknownUnitMathTest()
        {

            var list1 = new List<UnknownUnit>
            {
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(4)

            };

            

            UnknownUnit Average = UnitMath.Average(list1);
            UnknownUnit Sum = UnitMath.Sum(list1);
            UnknownUnit Max = UnitMath.Max(list1);
            UnknownUnit Min = UnitMath.Min(list1);

            UnknownUnit Average2 = UnitMath.Average(
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
            );

            UnknownUnit Sum2 = UnitMath.Sum(
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
                );

            UnknownUnit Max2 = UnitMath.Max(
                 Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
                );

            UnknownUnit Min2 = UnitMath.Min(
                 Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
                    );


            UnknownUnit Average3 = list1.Average();
            UnknownUnit Sum3 = list1.Sum();
            UnknownUnit Max3 = list1.Max();
            UnknownUnit Min3 = list1.Min();

            Assert.AreEqual(Average, Average2);
            Assert.AreEqual(Sum, Sum2);
            Assert.AreEqual(Max, Max2);
            Assert.AreEqual(Min, Min2);

            Assert.AreEqual(Average, Average3);
            Assert.AreEqual(Sum, Sum3);
            Assert.AreEqual(Max, Max3);
            Assert.AreEqual(Min, Min3);

            Assert.IsTrue(Average.Equals(Average3));
            Max.CompareTo(Max3);
            Max.Equals(Max3);

           


        }



        [TestMethod]
        public void UnknownUnitMathTest02()
        {
            var speed = new List<UnknownUnit> 
            {
                Length.FromMeter(12)/Duration.FromMinute(5),
                Length.FromMeter(5)/Duration.FromMinute(3),
                Length.FromMeter(22)/Duration.FromMinute(13),
                Length.FromMeter(2)/Duration.FromMinute(3),
                Length.FromMeter(100)/Duration.FromMinute(3)

            };
            var speed2 = new List<UnknownUnit>
            {
                Length.FromMeter(2)/Duration.FromMinute(3),
                Length.FromMeter(1)/Duration.FromMinute(3),
                Length.FromMeter(22)/Duration.FromMinute(13),
                Length.FromMeter(2)/Duration.FromMinute(3),
                Length.FromMeter(100)/Duration.FromMinute(3)

            };
            var minlist = new List<UnknownUnit>();
            minlist.Add(UnitMath.Min(speed));
            minlist.Add(UnitMath.Min(speed2));


            var res = UnitMath.Min(minlist);
            var max = UnitMath.Max(minlist);
            Assert.AreEqual(res, minlist.ElementAt(1));
            Assert.AreEqual(max, UnitMath.Min(speed));





        }
        [TestMethod]
        public void TestUnknownUnitEqualNullObject()
        {
            object obj = null;
            var test = Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2);
            test.Equals(obj);
            Assert.IsFalse(test.Equals(obj));

        }



        }
}
