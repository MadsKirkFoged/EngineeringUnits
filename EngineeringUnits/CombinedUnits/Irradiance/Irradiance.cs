using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Irradiance : BaseUnit
    {

        public Irradiance()
        {
            Unit = IrradianceUnit.SI.Unit.Copy();
        }

        public Irradiance(decimal value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(double value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(int value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Irradiance From(double value, IrradianceUnit unit) => new Irradiance(value, unit);
        public double As(IrradianceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Irradiance ToUnit(IrradianceUnit selectedUnit) => new Irradiance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Irradiance Zero => new Irradiance(0, IrradianceUnit.SI);

        public static implicit operator Irradiance(UnknownUnit Unit)
        {
            Irradiance local = new Irradiance(0, IrradianceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
