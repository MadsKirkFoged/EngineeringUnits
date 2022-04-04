using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class InformationTest
    {



        [TestMethod]
        public void InformationAutoTest()
        {
            var A1 = new UnitsNet.Information(1, UnitsNet.Units.InformationUnit.Byte);
            var A2 = new EngineeringUnits.Information(1, InformationUnit.Byte);

            int WorkingCompares = 0;


            foreach (var EU in UnitTypebase.ListOf<InformationUnit>())
            {


                double Error = 1E-4;
                double RelError = 1E-3;

                var UNList = UnitsNet.Information.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.InformationUnit.CaloriePerSecondSquareCentimeter) RelError = 0.06687685105569595;
                    

                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")


                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(26, WorkingCompares);

        }
    }
}