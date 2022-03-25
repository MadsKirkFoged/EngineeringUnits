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
    public class VolumeConcentrationTest
    {



        [TestMethod]
        public void VolumeConcentrationAutoTest()
        {
            var A1 = new UnitsNet.VolumeConcentration(1, UnitsNet.Units.VolumeConcentrationUnit.LitersPerLiter);
            var A2 = new EngineeringUnits.Ratio(1, RatioUnit.LitersPerLiter);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<RatioUnit>())
            {


                double Error = 3E-3;
                double RelError = 1E-5;

                var UNList = UnitsNet.VolumeConcentration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.VolumeConcentrationUnit.PicowattPerCubicFoot) Error = 0.0625;


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

                                //.Replace("L/L", "l/l")
                                .Replace("L", "l")
                                );


                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(20, WorkingCompares);

        }
    }
}