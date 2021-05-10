using System;

namespace nasan04
{
    public class Processorer : Hardware

    {
        public Processorer(string n) : base(n)
        {
            
        }
        private int kärnor;
        public int GetKärnor()
        {
            return kärnor;
        }

        public int SetKärnor(int k)
        {
            kärnor = k;

            return kärnor;
        }
    }
}
