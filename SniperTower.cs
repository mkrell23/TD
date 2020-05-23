namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        protected override double Accuracy { get; } = 1;

        public override string ToString()
        {
            return "A sniper tower";
        }
        public SniperTower(MapLocation location) : base(location)
        {}
    }
}