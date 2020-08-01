using System;

namespace ConsoleApp1
{
    class Bird : MovingObject
    {
        public Tree HomeTree { get; private set; }

        public Bird(byte x, byte y) : base(x, y)
        {}

        public void Nest(Tree tree) => HomeTree = tree;

        public override void Grow()
        {
            if (Age < 5) base.Grow();
            else Die();
        }

        public new void Move(byte x, byte y)
        {
            if (Math.Abs(Location.x - x) <= 2 && Math.Abs(Location.y - y) <= 2)
                base.Move(x, y);
        }
    }
}