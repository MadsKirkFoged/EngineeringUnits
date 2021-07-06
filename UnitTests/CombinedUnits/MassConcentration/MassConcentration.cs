using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class MassConcentrationTest
    {



        [TestMethod]
        public void MassConcentrationAutoTest()
        {
            var A1 = new UnitsNet.MassConcentration(1, UnitsNet.Units.MassConcentrationUnit.DecigramPerMilliliter);
            var A2 = new EngineeringUnits.MassConcentration(1, EngineeringUnits.DensityUnit.DecigramPerMilliliter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<DensityUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-3;

                var UNList = UnitsNet.MassConcentration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.MassConcentrationUnit.NanowattPerSquareMeter) Error = 0.0001220703125;


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
                    if (UN != UnitsNet.Units.MassConcentrationUnit.MicrogramPerCubicMeter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.MicrogramPerDeciliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.MicrogramPerLiter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.MicrogramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.MicrogramPerMilliliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.CentigramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.CentigramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.DecigramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.GramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.MilligramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.NanogramPerMicroliter &&
                        UN != UnitsNet.Units.MassConcentrationUnit.PicogramPerMicroliter 
                        )
                    {
                        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                        A1.ToUnit(UN).ToString("a")

                                        .Replace("L","l")   
                                        //.Replace("klb", "kb")
                                        );
                    }

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(46, WorkingCompares);

        }
    }
}