using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Functionality
{
    [TestClass]
    public class RoundToNearest
    {
        [TestMethod]
        public void Round()
        {

            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };

            Length L2 = MyList.RoundToNearest(Length.FromMeter(4)); //20m

            Assert.AreEqual(Length.FromMeter(5), L2);

        }


        [TestMethod]
        public void RoundDown()
        {

            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };

            Length L2 = MyList.RoundDownToNearest(Length.FromMeter(30)); //20m

            Assert.AreEqual(Length.FromMeter(20), L2);

        }
        [TestMethod]
        public void RoundUp()
        {

            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };


            Length L1 = MyList.RoundUpToNearest(Length.FromMeter(30)); //44m

            Assert.AreEqual(Length.FromMeter(44), L1);

        }


        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void RoundUpWithWrongUnit()
        {
            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };


            Length L1 = MyList.RoundUpToNearest(Mass.FromKilogram(30));


        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void RoundDownWithWrongUnit()
        {
            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };


            Length L1 = MyList.RoundDownToNearest(Mass.FromKilogram(30));


        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void RoundWithWrongUnit()
        {
            var MyList = new List<Length>
            {
                Length.FromMeter(1),
                Length.FromMeter(5),
                Length.FromMeter(20),
                Length.FromMeter(44)
            };


            Length L1 = MyList.RoundToNearest(Mass.FromKilogram(30));


        }





    }
}
