using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ToStringTest
    {


        [TestMethod]
        public void DisplaySignificantDigits()
        {
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(-1));
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(0));
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(1));
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(2));
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(3));
            Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(4));
            Assert.AreEqual("100.01", 100.005m.DisplaySignificantDigits(5));
            Assert.AreEqual("100.005", 100.005m.DisplaySignificantDigits(6));
            Assert.AreEqual("100.005", 100.005m.DisplaySignificantDigits(7));

            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(-1));
            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(0));
            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(1));
            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(2));
            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(3));
            Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(4));
            Assert.AreEqual("-100.01", (-100.005m).DisplaySignificantDigits(5));
            Assert.AreEqual("-100.005", (-100.005m).DisplaySignificantDigits(6));
            Assert.AreEqual("-100.005", (-100.005m).DisplaySignificantDigits(7));

            Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(0));
            Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(1));
            Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(2));
            Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(3));
            Assert.AreEqual("0.004", 0.004m.DisplaySignificantDigits(4));
            Assert.AreEqual("0.004", 0.004m.DisplaySignificantDigits(5));


            Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(0));
            Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(1));
            Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(2));
            Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(3));
            Assert.AreEqual("0.005", 0.0045m.DisplaySignificantDigits(4));
            Assert.AreEqual("0.0045", 0.0045m.DisplaySignificantDigits(5));


            Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(0));
            Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(1));
            Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(2));
            Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(3));
            Assert.AreEqual("-0.005", (-0.0045m).DisplaySignificantDigits(4));
            Assert.AreEqual("-0.0045", (-0.0045m).DisplaySignificantDigits(5));


            Assert.AreEqual("-879746", (-879746.13216645m).DisplaySignificantDigits(0));
            Assert.AreEqual("-789794.1111546987", (-789794.1111546987m).DisplaySignificantDigits(20));
            Assert.AreEqual("-789794.111154699", (-789794.1111546987m).DisplaySignificantDigits(15));
            Assert.AreEqual("-789794.1112", (-789794.1111546987m).DisplaySignificantDigits(10));
            Assert.AreEqual("-789794.1", (-789794.1111546987m).DisplaySignificantDigits(7));
            Assert.AreEqual("-789794.2", (-789794.1911546987m).DisplaySignificantDigits(7));


        }



    }
}
