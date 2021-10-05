using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InRangeOf
    {
        [TestMethod]
        public void InRangeOf1()
        {
            Power f1 = new(19, PowerUnit.KilojoulePerHour);
            Power f2 = f1.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));

            Power f3 = new(17, PowerUnit.KilojoulePerHour);
            Power f4 = f3.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));

            Power f5 = new(-17, PowerUnit.KilojoulePerHour);
            Power f6 = f5.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));

            Power f7 = new(-19, PowerUnit.KilojoulePerHour);
            Power f8 = f7.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));



            Assert.AreEqual(5, f2.Watts);
            Assert.AreEqual(17, f4.KilojoulesPerHour);
            Assert.AreEqual(-17, f6.KilojoulesPerHour);
            Assert.AreEqual(-5, f8.Watts);
        }

      
    }
}
