using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.HaveToFail
{
    [TestClass]
    public class UnitsAreWrong
    {
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void AreaCantBeVolume()
        {
            var length = Length.FromYard(1);
            var length2 = Length.FromMeter(5);

            Area area2 = length * length2 * length2;

        }


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void EnergyCantBeDensity()
        {
            var mass = Mass.FromGram(150);
            var volume = Volume.FromLiter(3);

           Energy energy = mass / volume;

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare01()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

           var equal = length == mass;
          
        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare02()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            
            var notEqual = length != mass;
           

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare03()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

           
            var greater = length > mass;
            

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare04()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

          
            var greaterOrEqual = length >= mass;
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare05()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

         
            var smaller = length < mass;

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare06()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            var smallerOrEqual = length <= mass;

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare07()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);
            
           length.CompareTo(mass);
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare08()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            length.Equals(mass);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToCompare01()
        {
            var speed = Length.FromCentimeter(7)/Duration.FromMinute(32);
            var density =Mass.FromCentigram(15)/Volume.FromCubicFoot(7);
            
            speed.Equals(density);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToCompare02()
        {
            var list1 = new List<UnknownUnit>
            {
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(2),
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(1),
                Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(3),
                Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(5),
                Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(4)

            };
            var density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);


            object test = (object)list1.First();

            density.CompareTo(test);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToCompare03()
        {
            var speed = Length.FromCentimeter(7) / Duration.FromMinute(32);
            var density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);

            speed.CompareTo(density);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToCompare04()
        {
            var speed = Length.FromCentimeter(7) / Duration.FromMinute(32);
            var density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);
            object test = density;
            speed.Equals(test);

        }
       


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void CheckWrongUnit01()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            length.UnitCheck(mass.Unit);

        }


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void CheckWrongUnit02()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            length.UnitCheck(mass);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void CheckWrongUnit03()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);
            Length.UnitCheck(mass.Unit,length.Unit);


        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitsToAdd()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            var add = length + mass;
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitsToSubtract()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            var subtract = length - mass;
        }


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitCast01()
        {
           
        var A4 = new Length(10, LengthUnit.Kilometer);
        var A5 = new Duration(1, DurationUnit.Minute);
        var A6 = new Duration(1, DurationUnit.Hour);


        Acceleration Result2 = A4 / (A5 * A6);
        var res = A4 * (A5 * A6);
        
            var x = (double)res;


        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitCast02()
        {

            var A4 = new Length(10, LengthUnit.Kilometer);
            var A5 = new Duration(1, DurationUnit.Minute);
            var A6 = new Duration(1, DurationUnit.Hour);

            Acceleration Result2 = A4 / (A5 * A6);
            var res = A4 * (A5 * A6);
           
            var x = (decimal)res;


        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitAddUits()
        {

            var A1 = new Duration(1, DurationUnit.Minute);
            var A2 = new Length(1, LengthUnit.Chain);

            Duration Result = A1+ A2;



        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void WrongListToCompare()
        {
            var list1 = new List<UnknownUnit>
            {

            };
            UnknownUnit Min = UnitMath.Min(list1);
            UnknownUnit Average = UnitMath.Average(list1);
            UnknownUnit Sum = UnitMath.Sum(list1);
            UnknownUnit Max = UnitMath.Max(list1);

            

        }



    }
}
