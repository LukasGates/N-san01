using System;

namespace nasan04
{
    public class Hardware
    {
        private string namn;


        private int pris;


        public Hardware(string n)
        {
            namn = n;
            pris = 0;
        }

        public string GetNamn()
        {
            return namn;
        }
        public int GetPris()
        {
            return pris;
        }

        public int SetPris(int p)
        {
            pris = p;

            return pris;
        }
    }
}
