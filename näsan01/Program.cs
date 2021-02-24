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
                    Console.WriteLine("Try again");
                    answer = Console.ReadLine();
                }
                Console.WriteLine("Welcome!");
            }
            Console.ReadLine();

            //Punkt 4 i övnings dokumentet
            int x = 0;
            while (x < 32)
            {
                Console.WriteLine("Hello, World");
                x++;
            }
            Console.ReadLine();


            //punkt 6 i övnings dokumentet
            int y = 0;
            while (y < 5)
            {
                Console.WriteLine("Skriv ett tal");
                string input = Console.ReadLine();
                int nummer = 5;
                int.TryParse(input, out nummer);



                if (nummer > 5)
                {
                    Console.WriteLine("högre än 5!");
                    y++;
                }
                else
                {
                    y++;
                }

            }

            /* Försökt börja på punkt 7.
            Måste fortsätta eller göra om för att den ska fungera, under nästa lektion.
            int z = 0;
            while (z == 0)
            {
                string input = Console.ReadLine();
                int nummer = 0;
                int.TryParse(input, out nummer);

              
              
                if (nummer == 0)
                {
                    
                }
                else{
                    
                }
            }
            */

            Console.ReadLine();



        }
    }
}
