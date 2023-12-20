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
            Power f2 = f1.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f3 = new(17, PowerUnit.KilojoulePerHour);
            Power f4 = f3.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f5 = new(-17, PowerUnit.KilojoulePerHour);
            Power f6 = f5.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f7 = new(-19, PowerUnit.KilojoulePerHour);
            Power f8 = f7.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f9 = new(4, PowerUnit.Watt);
            Power f10 = f9.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));



            Assert.AreEqual(5, f2.Watt);
            Assert.AreNotEqual(6, f2.Watt);
            Assert.AreEqual(17, f4.KilojoulePerHour);
            Assert.AreEqual(-17, f6.KilojoulePerHour);
            Assert.AreEqual(-5, f8.Watt);
            Assert.AreEqual(4, f10.Watt);
        }

        [TestMethod]
        public void ClampTest()
        {
            Power f1 = new(19, PowerUnit.KilojoulePerHour);
            Power f2 = f1.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            Power f3 = new(17, PowerUnit.KilojoulePerHour);
            Power f4 = f3.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            Power f5 = new(-17, PowerUnit.KilojoulePerHour);
            Power f6 = f5.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            Power f7 = new(-19, PowerUnit.KilojoulePerHour);
            Power f8 = f7.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            Power f9 = new(4, PowerUnit.Watt);
            Power f10 = f9.Clamp(Power.FromWatt(-5), Power.FromWatt(5));



            Assert.AreEqual(5, f2.Watt);
            Assert.AreNotEqual(6, f2.Watt);
            Assert.AreEqual(17, f4.KilojoulePerHour);
            Assert.AreEqual(-17, f6.KilojoulePerHour);
            Assert.AreEqual(-5, f8.Watt);
            Assert.AreEqual(4, f10.Watt);
        }

        //clamp test for unknownunit and baseunit
        [TestMethod]
        public void ClampTestUnknownUnit()
        {
            UnknownUnit f1 = new(19d, PowerUnit.KilojoulePerHour);
            UnknownUnit f2 = f1.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            UnknownUnit f3 = new(17d, PowerUnit.KilojoulePerHour);
            UnknownUnit f4 = f3.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            UnknownUnit f5 = new(-17d, PowerUnit.KilojoulePerHour);
            UnknownUnit f6 = f5.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            UnknownUnit f7 = new(-19d, PowerUnit.KilojoulePerHour);
            UnknownUnit f8 = f7.Clamp(Power.FromWatt(-5), Power.FromWatt(5));

            UnknownUnit f9 = new(4d, PowerUnit.Watt);
            UnknownUnit f10 = f9.Clamp(Power.FromWatt(-5), Power.FromWatt(5));



            Assert.AreEqual(5, f2.As(PowerUnit.Watt));
            Assert.AreNotEqual(6, f2.As(PowerUnit.Watt));
            Assert.AreEqual(17, f4.As(PowerUnit.KilojoulePerHour));
            Assert.AreEqual(-17, f6.As(PowerUnit.KilojoulePerHour));
            Assert.AreEqual(-5, f8.As(PowerUnit.Watt));
            Assert.AreEqual(4, f10.As(PowerUnit.Watt));

        }


        //clamp test for unknownunit and length 
        [TestMethod]
        public void ClampTestUnknownUnitLength()
        {
            UnknownUnit Ulocal = new(19d, LengthUnit.Meter);
            UnknownUnit Umax = new(5d, LengthUnit.Meter);
            UnknownUnit Umin = new(-5d, LengthUnit.Meter);

            Length local = new(19d, LengthUnit.Meter);
            Length max = new(5d, LengthUnit.Meter);
            Length min = new(-5d, LengthUnit.Meter);



            UnknownUnit f2 = Ulocal.Clamp(Umin, Umax);
            UnknownUnit f3 = Ulocal.Clamp(min, Umax);
            UnknownUnit f4 = Ulocal.Clamp(Umin, max);
            UnknownUnit f5 = Ulocal.Clamp(min, max);



            UnknownUnit f6 = local.Clamp(Umin, Umax);
            UnknownUnit f7 = local.Clamp(min, Umax);
            UnknownUnit f8 = local.Clamp(Umin, max);
            UnknownUnit f9 = local.Clamp(min, max);


            Assert.AreEqual(f2, f3);
            Assert.AreEqual(f3, f4);
            Assert.AreEqual(f4, f5);
            Assert.AreEqual(f5, f6);
            Assert.AreEqual(f6, f7);
            Assert.AreEqual(f7, f8);
            Assert.AreEqual(f8, f9);
            Assert.AreEqual(f9, f2);

        }

    }
}
