namespace TreehouseDefense
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public override string ToString()
        {
            return "a strong invader";
        }
        public StrongInvader(Path path) : base(path)
        {}
    }
}