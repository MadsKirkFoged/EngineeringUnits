using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;


[TestClass()]
public class ToStringTests
{

    [TestMethod()]
    public void InfTostring()
    {
        //Arrange
        MassFlow Inf = MassFlow.FromKilogramPerSecond(10) / Ratio.Zero;

        // Act
        string test = Inf.ToString();
        string test2 = Inf.ToString("S5");
        string test3 = $"{Inf:S5}"; 
        string test4 = $"{Inf:UnitOnly}"; 
        string test5 = $"{Inf:G1}"; 


        // Assert
        Assert.AreEqual("Infinity kg/s", test);
        Assert.AreEqual("Infinity kg/s", test2);
        Assert.AreEqual("Infinity kg/s", test3);
        Assert.AreEqual("kg/s", test4);
        Assert.AreEqual("Infinity kg/s", test5);

    }

    [TestMethod()]
    public void NaATostring()
    {
        //Arrange
        MassFlow NaN = MassFlow.NaN;

        // Act
        string test = NaN.ToString();
        string test2 = NaN.ToString("S5");
        string test3 = $"{NaN:S5}";
        string test4 = $"{NaN:UnitOnly}";
        string test5 = $"{NaN:G1}";


        // Assert
        Assert.AreEqual("NaN kg/s", test);
        Assert.AreEqual("NaN kg/s", test2);
        Assert.AreEqual("NaN kg/s", test3);
        Assert.AreEqual("kg/s", test4);
        Assert.AreEqual("NaN kg/s", test5);

    }


}
