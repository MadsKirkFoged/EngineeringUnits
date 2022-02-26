using EngineeringUnits;
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
            var length = Length.FromYards(1);
            var length2 = Length.FromMeters(5);

            Area area2 = length * length2 * length2;
        }
    }
}
