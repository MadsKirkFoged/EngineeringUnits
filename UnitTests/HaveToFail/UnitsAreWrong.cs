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
        public void WrongBaseUnitsEqualOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

           var equal = length == mass;
          
        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongBaseUnitsNotEqualOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            
            var notEqual = length != mass;
           

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongBaseUnitsGreaterOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

           
            var greater = length > mass;
            

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongBaseUnitGreaterOrEqualOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

          
            var greaterOrEqual = length >= mass;
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongBaseUnitSmallerOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

         
            var smaller = length < mass;

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongBaseUnitSmallerOrEqualOperator()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            var smallerOrEqual = length <= mass;

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);
            
           length.CompareTo(mass);
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitEquals()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            length.Equals(mass);

        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnitToCompare02()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);
            object test = mass;
            length.CompareTo(test);

        }
       
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitEquals01()
        {
            var speed = Length.FromCentimeter(7)/Duration.FromMinute(32);
            var density =Mass.FromCentigram(15)/Volume.FromCubicFoot(7);
            
            speed.Equals(density);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToCompare01()
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
        public void WrongUnknownUnitToCompare02()
        {
            var speed = Length.FromCentimeter(7) / Duration.FromMinute(32);
            var density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);

            speed.CompareTo(density);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void WrongUnknownUnitToEquals02()
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

            //length.UnitCheck(mass);
            GuardAgainst.DifferentUnits(length, mass);

        }


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void CheckWrongUnit02()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            GuardAgainst.DifferentUnits(length, mass);

        }
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void CheckWrongUnit03()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            GuardAgainst.DifferentUnits(length, mass);


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
        public void WrongUnitsToSubtract01()
        {
            var length = Length.FromCentimeter(3);
            var mass = Mass.FromKilogram(3);

            var subtract = length - mass;
        }

        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void WrongUnitsToSubtract02()
        //{
        //    var length = Length.FromCentimeter(3);
        //    var mass = Mass.FromKilogram(3);

        //    UnitSystem.Subtract(length.Unit, mass.Unit);
        //}

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
        public void WrongUnitAddUits01()
        {

            var A1 = new Duration(1, DurationUnit.Minute);
            var A2 = new Length(1, LengthUnit.Chain);

            Duration Result = A1+ A2;



        }
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void WrongUnitAddUits02()
        //{

        //    var A1 = new Duration(1, DurationUnit.Minute);
        //    var A2 = new Length(1, LengthUnit.Chain);

        //    UnitSystem Result = UnitSystem.Add(A1.Unit, A2.Unit);




        //}


        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        //public void WrongListToCompare()
        //{
        //    var list1 = new List<UnknownUnit>
        //    {

        //    };
        //    UnknownUnit Min = UnitMath.Min(list1);
        //    UnknownUnit Average = UnitMath.Average(list1);
        //    UnknownUnit Sum = UnitMath.Sum(list1);
        //    UnknownUnit Max = UnitMath.Max(list1);

            

        //}
        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void EnergyCantBePower()
        {
            var mass = Mass.FromCentigram(1);
            var length = Length.FromMeter(5);
            var duration = Duration.FromHour(5);


            Power local = (mass * length.Pow(2)) / duration.Pow(2);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void ToUnitWithWrongUnit()
        {
            var mass = Mass.FromCentigram(1);

            var local = mass.ToUnit(MassFlowUnit.KilogramPerSecond);


        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void GetUnitByWrongString()
        //{
        //    LengthUnit unitasstring = Enumeration.GetUnitByString<LengthUnit>("Kilobeter");

        //}

        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void SpeedShouldBeZero()
        //{
        //    Speed speed = 5;
        //}

        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void DurationShouldBeZero()
        //{
        //    Duration duration = 5;
        //}
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void LengthShouldBeZero()
        //{
        //    Length length = 5;
        //}
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void AmountShouldBeZero()
        //{
        //    AmountOfSubstance amount = 3;
        //}
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void LuminousIntensityShouldBeZero()
        //{
        //    LuminousIntensity luminousIntensity = 3;
        //}

        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void AccelerationShouldBeZero()
        //{
        //    Acceleration a = 5;
        //}
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void AngleShouldBeZero()
        //{
          
        //    EngineeringUnits.Angle angle = 5;
        //}

        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void MassShouldBeZero()
        //{

        //    Mass mass = 5;
        //}
        //[TestMethod]
        //[ExpectedException(typeof(WrongUnitException))]
        //public void VolumeShouldBeZero()
        //{

        //    Volume volume = 5;
        //}


    }
}
