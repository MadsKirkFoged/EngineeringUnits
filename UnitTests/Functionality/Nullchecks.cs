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
    public class nullchecks
    {



        [TestMethod]
        public void ConvertFromNull()
        {
            MassFlow massFlow = null;
            UnknownUnit nulltest = massFlow;

            MassFlow massFlow2 = nulltest;


            Assert.IsNull(nulltest);
            Assert.IsNull(massFlow2);

        }
    }
}
