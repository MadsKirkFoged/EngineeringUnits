﻿using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Level : BaseUnit
    {

        public Level() { }
        public Level(decimal value, LevelUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Level(double value, LevelUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Level(int value, LevelUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Level(UnknownUnit value) : base(value) { }

        public Level(UnknownUnit value, LevelUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Level From(double value, LevelUnit unit) => new(value, unit);
        public double As(LevelUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Level ToUnit(LevelUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Level Zero => new(0, LevelUnit.SI);

        public static implicit operator Level(UnknownUnit Unit) => new(Unit, LevelUnit.SI);


    }
}
