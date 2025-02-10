using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Math;

[TestClass]
public class InfinityZeroDivision
{
    private static readonly Mass mass0 = Mass.FromKilogram(0);
    private static readonly Mass mass1 = Mass.FromKilogram(1);
    private static readonly Mass massPosInf = Mass.FromKilogram(double.PositiveInfinity);
    private static readonly Mass massNegInf = Mass.FromKilogram(double.NegativeInfinity);

    private static readonly Duration duration0 = Duration.FromSecond(0);
    private static readonly Duration duration1 = Duration.FromSecond(1);
    private static readonly Duration durationPosInf = Duration.FromSecond(double.PositiveInfinity);
    private static readonly Duration durationNegInf = Duration.FromSecond(double.NegativeInfinity);


    [TestMethod]
    public void ZeroDividedByNumber()
    {
        // Zero divided by number should be 0
        MassFlow mf0 =       mass0 / duration1;                        // 0.0 kg / s
        MassFlow mf0_check = MassFlow.FromSI(mass0.SI / duration1.SI); // 0.0 kg / s

        Assert.AreEqual(mf0, mf0_check);
    }

    [TestMethod]
    public void InfinifyDividedByNumber()
    {
        // Infinity divided by number should be infinity
        MassFlow mfInf_1 =       massPosInf / duration1;                        // Infinity kg / s
        MassFlow mfInf_1_check = MassFlow.FromSI(massPosInf.SI / duration1.SI); // Infinity kg / s

        MassFlow mfInf_2 =       massNegInf / duration1;                        // Infinity kg / s
        MassFlow mfInf_2_check = MassFlow.FromSI(massNegInf.SI / duration1.SI); // Infinity kg / s

        Assert.AreEqual(mfInf_1, mfInf_1_check);
        Assert.AreEqual(mfInf_2, mfInf_2_check);
    }

    [TestMethod]
    public void NumberDividedByZero()
    {
        // Number divided by 0 should be infinity
        MassFlow mfInf =       mass1 / duration0;                        // Infinity kg / s
        MassFlow mfInf_check = MassFlow.FromSI(mass1.SI / duration0.SI); // Infinity kg / s

        Assert.AreEqual(mfInf, mfInf_check);
    }

    [TestMethod]
    public void NumberDividedByInfinity()
    {
        // Number divided by infinity should be 0
        MassFlow mf0_1 =       mass1 / durationPosInf;                        // Infinity kg / s <-- TODO
        MassFlow mf0_1_check = MassFlow.FromSI(mass1.SI / durationPosInf.SI); // 0.0 kg / s

        MassFlow mf0_2 =       mass1 / durationNegInf;                        // Infinity kg / s <-- TODO
        MassFlow mf0_2_check = MassFlow.FromSI(mass1.SI / durationNegInf.SI); // 0.0 kg / s

        Assert.AreEqual(mf0_1, mf0_1_check);
        Assert.AreEqual(mf0_2, mf0_2_check);
    }

    [TestMethod]
    public void ZeroDividedByZero()
    {
        // Zero divided by 0 should be NaN (not defined)
        MassFlow mfNaN =       mass0 / duration0;                        // Infinity kg / s <-- TODO
        MassFlow mfNaN_check = MassFlow.FromSI(mass0.SI / duration0.SI); // NaN kg / s

        Assert.AreEqual(mfNaN, mfNaN_check);
    }

    [TestMethod]
    public void InfinityDividedByInfinity()
    {
        // Infinity divided by infinity should be NaN (not defined)
        MassFlow mfNaN_1 =       massPosInf / durationPosInf;                        // Infinity kg / s <-- TODO
        MassFlow mfNaN_1_check = MassFlow.FromSI(massPosInf.SI / durationPosInf.SI); // NaN kg / s

        MassFlow mfNaN_2 =       massNegInf / durationNegInf;                        // Infinity kg / s <-- TODO
        MassFlow mfNaN_2_check = MassFlow.FromSI(massPosInf.SI / durationNegInf.SI); // NaN kg / s

        MassFlow mfNaN_3 =       massNegInf / durationPosInf;                        // Infinity kg / s <-- TODO
        MassFlow mfNaN_3_check = MassFlow.FromSI(massNegInf.SI / durationPosInf.SI); // NaN kg / s

        MassFlow mfNaN_4 =       massNegInf / durationPosInf;                        // Infinity kg / s <-- TODO
        MassFlow mfNaN_4_check = MassFlow.FromSI(massPosInf.SI / durationPosInf.SI); // NaN kg / s

        Assert.AreEqual(mfNaN_1, mfNaN_1_check);
        Assert.AreEqual(mfNaN_2, mfNaN_2_check);
        Assert.AreEqual(mfNaN_3, mfNaN_3_check);
        Assert.AreEqual(mfNaN_4, mfNaN_4_check);
    }

    [TestMethod]
    public void InfinityDividedByZero()
    {
        // Infinity divided by 0 should be infinity
        MassFlow mfInf_1 =       massPosInf / duration0;                        // Infinity kg / s
        MassFlow mfInf_1_check = MassFlow.FromSI(massPosInf.SI / duration0.SI); // Infinity kg / s

        MassFlow mfInf_2 =       massNegInf / duration0;                        // Infinity kg / s
        MassFlow mfInf_2_check = MassFlow.FromSI(massNegInf.SI / duration0.SI); // Infinity kg / s

        Assert.AreEqual(mfInf_1, mfInf_1_check);
        Assert.AreEqual(mfInf_2, mfInf_2_check);
    }

    [TestMethod]
    public void ZeroDividedByInfinity()
    {
        // Zero divided by infinity should be 0
        MassFlow mf0_1 = mass0 / durationPosInf;                              // Infinity kg / s <-- TODO
        MassFlow mf0_1_check = MassFlow.FromSI(mass0.SI / durationPosInf.SI); // 0.0 kg / s

        MassFlow mf0_2 = mass0 / durationNegInf;                              // Infinity kg / s <-- TODO
        MassFlow mf0_2_check = MassFlow.FromSI(mass0.SI / durationNegInf.SI); // 0.0 kg / s

        Assert.AreEqual(mf0_1, mf0_1_check);
        Assert.AreEqual(mf0_2, mf0_2_check);
    }

}
