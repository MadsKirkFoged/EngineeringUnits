using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class ThreadSafety
{
    [TestMethod]// (Skip = "race condition demonstration")]
    public void ParallelAccess2()
    {
        LengthUnit unit1 = LengthUnit.Meter;
        DurationUnit unit2 = DurationUnit.Millisecond;



        List<Task> tasks = [];
        for (var i = 1; i < 400; ++i)
        {
            tasks.Add(Task.Run(dividedUnit));
        }

        Task.WaitAll([.. tasks]);

        //Local function
        UnitSystem dividedUnit()
        {
            UnitSystem unit3 = unit1.Unit / unit2.Unit;
            return unit3;
        }
    }
}
