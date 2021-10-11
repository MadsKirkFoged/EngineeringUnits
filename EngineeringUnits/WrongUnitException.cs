using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringUnits
{
    [Serializable]
    public class WrongUnitException : Exception
    {
        public WrongUnitException()
        { }

        public WrongUnitException(string message)
            : base(message)
        { }

        public WrongUnitException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
