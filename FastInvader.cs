namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        protected override int StepSize {get; } = 2;

        public override string ToString()
        {
            return "a fast invader";
        }

        public FastInvader(Path path) : base(path)
        {}

     }
}