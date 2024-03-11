using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class MassConcentrationTest
{

    [TestMethod]
    public void MassConcentrationAutoTest()
    {
        var A1 = new UnitsNet.MassConcentration(1, UnitsNet.Units.MassConcentrationUnit.DecigramPerMilliliter);
        var A2 = new EngineeringUnits.MassConcentration(1, DensityUnit.DecigramPerMilliliter);

        var WorkingCompares = 0;

        foreach (DensityUnit EU in UnitTypebase.ListOf<DensityUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-3;

            IEnumerable<UnitsNet.Units.MassConcentrationUnit> UNList = UnitsNet.MassConcentration.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MassConcentrationUnit UN = UNList.Single();

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
                if (UN is not UnitsNet.Units.MassConcentrationUnit.MicrogramPerCubicMeter and
                    not UnitsNet.Units.MassConcentrationUnit.MicrogramPerDeciliter and
                    not UnitsNet.Units.MassConcentrationUnit.MicrogramPerLiter and
                    not UnitsNet.Units.MassConcentrationUnit.MicrogramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.MicrogramPerMilliliter and
                    not UnitsNet.Units.MassConcentrationUnit.CentigramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.CentigramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.DecigramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.GramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.MilligramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.NanogramPerMicroliter and
                    not UnitsNet.Units.MassConcentrationUnit.PicogramPerMicroliter
                    )
                {
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")

                                    .Replace("L", "l")
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