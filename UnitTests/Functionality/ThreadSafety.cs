using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ThreadSafety
    {
        [TestMethod]// (Skip = "race condition demonstration")]
        public void ParallelAccess2()
        {
            var unit1 = LengthUnit.Meter;
            var unit2 = DurationUnit.Millisecond;

            

            List<Task> tasks = new();
            for (int i = 1; i < 400; ++i)
            {
                tasks.Add(Task.Run(dividedUnit));
            }

            Task.WaitAll(tasks.ToArray());




            //Local function
            UnitSystem dividedUnit()
            {
                var unit3 = unit1.Unit / unit2.Unit;
                return unit3;
            }
        }


    }
}
