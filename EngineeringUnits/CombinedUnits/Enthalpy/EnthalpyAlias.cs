
using EngineeringUnits.Units;


namespace EngineeringUnits
{   //This class is auto-generated, changes to the file will be overwritten!
    public partial class Enthalpy : BaseUnit
    {
        public static implicit operator Enthalpy(SpecificEnergy Unit) => new(Unit);
        public static implicit operator SpecificEnergy(Enthalpy Unit) => new(Unit);
    }
}



 
