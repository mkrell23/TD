namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        protected override double Accuracy { get; } = 1;
        public SniperTower(MapLocation location) : base(location)
        {}
    }
}