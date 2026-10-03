using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;
using EU = global::EngineeringUnits;
using EUUnits = global::EngineeringUnits.Units;

namespace UnitTests.Fast;

/// <summary>
/// ==, !=, &lt;, &gt;, &lt;= and &gt;= allow 1e-12 (relative), so a value reached through two units compares equal even when the
/// doubles are 1 ulp apart - as in EngineeringUnits, which compares exact fractions. Equals, GetHashCode and CompareTo stay exact.
/// </summary>
[TestClass]
public class ComparisonTests
{
    // 16.8833 bar = 1688330 Pa exactly, but 16.8833 * 100000 in doubles is 1688329.9999999998
    private static readonly Pressure FromBar = Pressure.FromBar(16.8833);
    private static readonly Pressure FromPascal = Pressure.FromPascal(1688330);

    [TestMethod]
    public void TheDoublesReallyDiffer()
    {
        Assert.AreNotEqual(FromBar.SI, FromPascal.SI);
        Assert.AreNotEqual(Length.FromFoot(1).SI, Length.FromInch(12).SI);
    }

    [TestMethod]
    public void SameValueFromTwoUnits_IsEqual()
    {
        Assert.IsTrue(FromBar == FromPascal);
        Assert.IsFalse(FromBar != FromPascal);
        Assert.IsTrue(Length.FromFoot(1) == Length.FromInch(12));

        // Like EngineeringUnits
        Assert.IsTrue(EU.Pressure.FromBar(16.8833) == EU.Pressure.FromPascal(1688330));
    }

    [TestMethod]
    public void EqualValues_AreNeitherLessNorGreater()
    {
        Assert.IsFalse(FromBar < FromPascal);
        Assert.IsFalse(FromBar > FromPascal);
        Assert.IsFalse(FromPascal < FromBar);
        Assert.IsFalse(FromPascal > FromBar);
        Assert.IsTrue(FromBar <= FromPascal);
        Assert.IsTrue(FromBar >= FromPascal);
        Assert.IsTrue(FromPascal <= FromBar);
        Assert.IsTrue(FromPascal >= FromBar);
    }

    [TestMethod]
    public void RealDifferences_AreStillSeen()
    {
        var bigger = Pressure.FromPascal(1688330.01);
        Assert.IsTrue(FromPascal != bigger);
        Assert.IsTrue(FromPascal < bigger);
        Assert.IsTrue(bigger > FromPascal);
        Assert.IsFalse(FromPascal >= bigger);
        Assert.IsFalse(Length.FromFoot(1) == Length.FromInch(12.001));
    }

    [TestMethod]
    public void CloseToZero_IsStillExact()
    {
        Assert.IsTrue(Pressure.FromPascal(1e-300) != Pressure.Zero);
        Assert.IsTrue(Pressure.FromPascal(1e-300) > Pressure.Zero);
        Assert.IsTrue(Pressure.FromPascal(-0d) == Pressure.Zero);
    }

    [TestMethod]
    public void NaNAndInfinity()
    {
        var nan = Pressure.FromPascal(double.NaN);
        var inf = Pressure.FromPascal(double.PositiveInfinity);
        var max = Pressure.FromPascal(double.MaxValue);

        Assert.IsFalse(nan == nan);
        Assert.IsTrue(nan != nan);
        Assert.IsFalse(nan < FromPascal || nan > FromPascal || nan <= FromPascal || nan >= FromPascal);

        Assert.IsTrue(inf == inf);
        Assert.IsTrue(inf != max);
        Assert.IsTrue(inf > max);
        Assert.IsFalse(inf.IsCloseTo(FromPascal, 1));
        Assert.IsTrue(Pressure.FromPascal(double.NegativeInfinity) != inf);
    }

    [TestMethod]
    public void UnknownUnit_ComparesTheSameWay()
    {
        UnknownUnit fromBar = 16.8833.AddUnit<PressureUnit>("Bar");
        UnknownUnit fromPascal = 1688330.0.AddUnit<PressureUnit>("Pascal");

        Assert.IsTrue(fromBar == fromPascal);
        Assert.IsFalse(fromBar < fromPascal || fromBar > fromPascal);
        Assert.IsTrue(FromPascal == fromBar);
        Assert.IsTrue(fromBar == FromPascal);
        Assert.IsTrue(FromPascal <= fromBar && fromBar >= FromPascal);
    }

    [TestMethod]
    public void Alias_ComparesTheSameWay()
    {
        Energy energy = Energy.FromJoule(1688330);
        Torque torque = Torque.FromSI(FromBar.SI);   // the 1-ulp-off number, as a Torque
        Assert.AreNotEqual(energy.SI, torque.SI);
        Assert.IsTrue(energy == torque);
        Assert.IsFalse(energy < torque || energy > torque);
    }

    [TestMethod]
    public void Nullable()
    {
        Pressure? none = null;
        Pressure? fromBar = FromBar;

        Assert.IsTrue(fromBar == FromPascal);
        Assert.IsTrue(FromPascal == fromBar);
        Assert.IsTrue(fromBar == (Pressure?)FromPascal);
        Assert.IsFalse(fromBar != (Pressure?)FromPascal);
        Assert.IsTrue(fromBar <= FromPascal && FromPascal >= fromBar);
        Assert.IsFalse(fromBar < FromPascal || FromPascal > fromBar);

        Assert.IsTrue(none == (Pressure?)null);
        Assert.IsTrue(none != FromPascal);
        Assert.IsTrue(FromPascal != none);
        Assert.IsFalse(none < FromPascal || none > FromPascal || none <= FromPascal || none >= FromPascal);
    }

    /// <summary>
    /// A database row filter: a classic value through ToFast() against a requirement read with Fast's AddUnit. The two take
    /// different routes to SI (exact fraction vs double) and end 1 ulp apart; no row may be removed.
    /// </summary>
    [TestMethod]
    public void RequirementFilter_KeepsRowsWithTheSameValue()
    {
        var rows = new List<EU.Pressure?>
        {
            (EU.Pressure)EU.Extensions.AddUnit<EUUnits.PressureUnit>(16.8833, "Bar"),
            (EU.Pressure)EU.Extensions.AddUnit<EUUnits.PressureUnit>(16.8833, "Bar"),
        };
        UnknownUnit? requirement = ((double?)16.8833).AddUnit<PressureUnit>("Bar");

        Assert.AreNotEqual(rows[0]!.ToFast().SI, ((Pressure)requirement!.Value).SI);

        int removed = rows.RemoveAll(x => x?.ToFast() != (Pressure?)requirement);
        Assert.AreEqual(0, removed);

        removed = rows.RemoveAll(x => x?.ToFast() > (Pressure?)requirement);
        Assert.AreEqual(0, removed);
    }

    /// <summary>A tolerance can't be hashed and isn't transitive, so these stay exact.</summary>
    [TestMethod]
    public void EqualsHashCodeAndCompareTo_StayExact()
    {
        Assert.IsFalse(FromBar.Equals(FromPascal));
        Assert.IsFalse(((object)FromBar).Equals(FromPascal));
        Assert.AreNotEqual(0, FromBar.CompareTo(FromPascal));
        Assert.AreEqual(2, new HashSet<Pressure> { FromBar, FromPascal }.Count);

        Assert.IsTrue(FromBar.Equals(Pressure.FromBar(16.8833)));
        Assert.AreEqual(FromBar.GetHashCode(), Pressure.FromBar(16.8833).GetHashCode());
    }

    [TestMethod]
    public void IsCloseTo_TakesItsOwnTolerance()
    {
        Assert.IsTrue(FromBar.IsCloseTo(FromPascal));
        Assert.IsFalse(Pressure.FromPascal(100).IsCloseTo(Pressure.FromPascal(101)));
        Assert.IsTrue(Pressure.FromPascal(100).IsCloseTo(Pressure.FromPascal(101), 0.01));
    }
}
