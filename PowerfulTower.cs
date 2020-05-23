namespace TreehouseDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 2;

        public override string ToString()
        {
            return "A powerful tower";
        }
        public PowerfulTower(MapLocation location) : base(location)
        {}
    }
}