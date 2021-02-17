using System.Linq.Expressions;
//using Internal;  Fungerar inte idk
using System.Dynamic;
using System;

namespace näsan01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punkt 1 i övnings dokumentet
            int i = 6;

            if (i >= 3)
                Console.WriteLine("Hello, World!");
            Console.ReadLine();

            //punkt 2,3 och 5 i övnings dokumentet
            Console.WriteLine("Enter username and password:");

            string answer = Console.ReadLine();

            if (answer == "noname nopass")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
                Console.ReadLine();
                while (answer != "noname nopass")
                {
                    Console.WriteLine ("Try again");
                    answer = Console.ReadLine();
                }
                Console.WriteLine("Welcome!");
            }
            Console.ReadLine();

            //Punkt 4 i övnings dokumentet
            int x = 0;
            while ( x<32)
            {
                Console.WriteLine("Hello, World");
                x++;
            }
            Console.ReadLine();
        }
    }
}
