using EngineeringUnits;
using System;
using System.Diagnostics;

namespace testing
{
    internal class Program
    {
        [Obsolete]
        private static void Main(string[] args)
        {
            var test = Power.FromWatts(100);

            Debug.Print(test.ToString());

        }
    }
}
