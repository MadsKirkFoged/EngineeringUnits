using EngineeringUnits.Units;


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

        public static Level From(double value, LevelUnit unit) => new Level(value, unit);
        public double As(LevelUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Level ToUnit(LevelUnit selectedUnit) => new Level(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Level Zero => new Level(0, LevelUnit.SI);

        public static implicit operator Level(UnknownUnit Unit) => new Level(Unit, LevelUnit.SI);


    }
}
