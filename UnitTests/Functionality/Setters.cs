using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Functionality;

[TestClass]
public class Setters
{

    [TestMethod]
    public void SettingANull()
    {
        double? value = null;

        var length = Length.FromMeter(value);

        Assert.IsNull(length);
    }



}
