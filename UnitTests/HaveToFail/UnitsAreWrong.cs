using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    }
}
