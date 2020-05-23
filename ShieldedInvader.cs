using System;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();

        public override string ToString()
        {
            return "a shielded invader";
        }
        public ShieldedInvader(Path path) : base(path)
        {}

        public override void DecreaseHealth(int factor, string name)
        {
            if(_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor, name);
            }
            else
            {
                Console.WriteLine( name + " shot at a shielded invader at " + this.Location + " but it sustained no damage.");
            }
        }
    }
}