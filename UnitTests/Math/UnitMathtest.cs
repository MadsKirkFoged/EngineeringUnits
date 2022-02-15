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
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
                MassFlow.FromKilogramsPerSecond(8),
                MassFlow.FromKilogramsPerSecond(9),
                MassFlow.FromKilogramsPerSecond(10),
            };


            MassFlow Average = UnitMath.Average(list1);
            MassFlow Sum = UnitMath.Sum(list1);
            MassFlow Max = UnitMath.Max(list1);
            MassFlow Min = UnitMath.Min(list1);

            


            MassFlow Average2 = UnitMath.Average(
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
                MassFlow.FromKilogramsPerSecond(8),
                MassFlow.FromKilogramsPerSecond(9),
                MassFlow.FromKilogramsPerSecond(10)
                );

            MassFlow Sum2 = UnitMath.Sum(
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
                MassFlow.FromKilogramsPerSecond(8),
                MassFlow.FromKilogramsPerSecond(9),
                MassFlow.FromKilogramsPerSecond(10)
                );

            MassFlow Max2 = UnitMath.Max(
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
                MassFlow.FromKilogramsPerSecond(8),
                MassFlow.FromKilogramsPerSecond(9),
                MassFlow.FromKilogramsPerSecond(10)
                );

        MassFlow Min2 = UnitMath.Min(
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
                MassFlow.FromKilogramsPerSecond(8),
                MassFlow.FromKilogramsPerSecond(9),
                MassFlow.FromKilogramsPerSecond(10)
                );


            MassFlow Average3 = list1.Average();
            MassFlow Sum3 = list1.Sum();
            MassFlow Max3 = list1.Max();
            MassFlow Min3 = list1.Min();


            Assert.AreEqual(Average.KilogramsPerSecond, 5.5, 0);
            Assert.AreEqual(Sum.KilogramsPerSecond, 55, 0);
            Assert.AreEqual(Max.KilogramsPerSecond, 10, 0);
            Assert.AreEqual(Min.KilogramsPerSecond, 1, 0);

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



    }
}
