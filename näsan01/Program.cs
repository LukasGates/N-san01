﻿using System.Linq.Expressions;
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
            //lägger in siffran 6
            int i = 6;
            //Om 6 är större eller lika med 3 så skrivs hello world
            if (i >= 3)
                Console.WriteLine("Hello, World!");
            Console.ReadLine();

            //punkt 2,3 och 5 i övnings dokumentet
            //if-sats som skriver ut "Welcome!" om användarnamnet som anges är lika med "noname" och lösenordet är "nopass".
            Console.WriteLine("Enter username and password:");

            string answer = Console.ReadLine();

            if (answer == "noname nopass")
            {
                Console.WriteLine("Welcome!");
            }
            //Om lösenordet och eller användarnamnet inte stämmer skrivs detta ut:
            else
            {
                Console.WriteLine("Wrong username or password");
                Console.ReadLine();
                while (answer != "noname nopass")
                {
                    //(loopen fortsätter så länge användaren inte har skrivit in rätt namn och lösenord)
                    Console.WriteLine("Try again");
                    answer = Console.ReadLine();
                }
                Console.WriteLine("Welcome!");
            }
            Console.ReadLine();

            //Punkt 4 i övnings dokumentet
            //en while loop som skriver ut "Hello, World" 32 gånger
            int x = 0;
            while (x < 32)
            {
                Console.WriteLine("Hello, World");
                x++;
            }
            Console.ReadLine();


            //punkt 6 i övnings dokumentet
            //en loop som körs 5 gånger och där varje gång loopen körs ska användaren skriva in ett tal.
            int y = 0;
            while (y < 5)
            {
                Console.WriteLine("Skriv ett tal");
                string input = Console.ReadLine();
                int nummer = 5;
                int.TryParse(input, out nummer);


                // Om det angivna talet är högre än 5 så skriv ut “högre än 5!”
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

            //Punkt 7
            //Behöver hjälp, har svårt med denna
            Console.WriteLine("skriv något"); 
            string tal = Console.ReadLine();
            int resultat;
            bool lyckad = int.TryParse(tal, out resultat);

            

            Console.ReadLine();



        }
    }
}
