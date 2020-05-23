using System;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public override string ToString()
        {
            return "an invader";
        }

        protected virtual int StepSize { get ; } = 1;
        
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        
        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        
        public virtual int Health { get; protected set; } = 2;
        
        public bool IsNeutralized => Health <= 0;
        
        public bool IsActive => !(IsNeutralized || HasScored);
        
        public Invader(Path path)
        {
            _path = path;
        }
        
        public virtual void Move() => _pathStep += StepSize;
        
        public virtual void DecreaseHealth(int factor, string name)
        {
            Health -= factor;
            Console.WriteLine( name + " shot at and hit " + ToString() + " at " + this.Location + "!");
        }
    }
}