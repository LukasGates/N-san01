using System;

namespace nasan04
{
    public class Grafikkort : Hardware
    {
        public Grafikkort(string n) : base(n)
        {
            
        }
        private int boost;
        public int GetBoost()
        {
            return boost;
        }

        public int SetBoost(int b)
        {
            boost = b;

            return boost;
        }
    }
}
