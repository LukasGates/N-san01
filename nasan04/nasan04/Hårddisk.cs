using System;

namespace nasan04
{
    public class Hårddisk : Hardware
    {
        public Hårddisk(string n) : base(n)
        {
            
        }
        private int lagring;
        public int GetLagring()
        {
            return lagring;
        }

        public int SetLagring(int l)
        {
            lagring = l;

            return lagring;
        }
    }
}
