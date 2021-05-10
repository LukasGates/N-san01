using System;

namespace nasan04
{
    public class Worker
    {

        protected string name;


        protected int age;

        protected int wage;

        public Worker(string n)
        {
            name = n;
            age = 0;
            wage = 0;
        }
        public void SetWage(int importInt)
        {
            wage = importInt;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetWage()
        {
            return wage;
        }



    }
}
