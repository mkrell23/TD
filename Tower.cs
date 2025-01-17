using System;

namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        
        private static readonly Random _random = new Random();
        
        private readonly MapLocation _location;
        
        public Tower(MapLocation location)
        {
            _location = location;
        }

        public override string ToString()
        {
            return "A tower";
        }
        
        private bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power, this.ToString());
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine( this.ToString() + " neutralized " + invader.ToString() + " at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine( this.ToString() + " shot at and missed " + invader.ToString() + " at " + invader.Location + ".");
                    }
                    break;
                }
            }
        }
    }
}