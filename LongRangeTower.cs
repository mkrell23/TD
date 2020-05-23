namespace TreehouseDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 3;

        public override string ToString()
        {
            return "A long range tower";
        }
        public LongRangeTower(MapLocation location) : base(location)
        {}
    }
}