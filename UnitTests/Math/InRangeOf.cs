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

            Power f9 = new(4, PowerUnit.Watt);
            Power f10 = f9.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));



            Assert.AreEqual(5, f2.Watt);
            Assert.AreNotEqual(6, f2.Watt);
            Assert.AreEqual(17, f4.KilojoulePerHour);
            Assert.AreEqual(-17, f6.KilojoulePerHour);
            Assert.AreEqual(-5, f8.Watt);
            Assert.AreEqual(4, f10.Watt);
        }

      
    }
}
