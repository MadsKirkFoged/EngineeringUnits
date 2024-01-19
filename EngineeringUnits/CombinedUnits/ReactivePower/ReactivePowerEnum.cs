using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ReactivePowerUnit : UnitTypebase
    {

        public static readonly ReactivePowerUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI, "var");
        public static readonly ReactivePowerUnit VoltampereReactive = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "var");
        public static readonly ReactivePowerUnit MegavoltampereReactive = new(ElectricPotentialUnit.Megavolt, ElectricCurrentUnit.Ampere, "Mvar");
        public static readonly ReactivePowerUnit KilovoltampereReactive = new(ElectricPotentialUnit.Kilovolt, ElectricCurrentUnit.Ampere, "kvar");
        public static readonly ReactivePowerUnit GigavoltampereReactive = new(ElectricPotentialUnit.Gigavolt, ElectricCurrentUnit.Ampere, "Gvar");



        public ReactivePowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrent, string NewSymbol)
        {
            Unit = new UnitSystem(electricPotential * electricCurrent, NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}