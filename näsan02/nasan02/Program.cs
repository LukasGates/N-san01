using System;
using System.Collections.Generic;

namespace nasan02
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Punkt 1
            string[] toynames = { "Racerbil", "Barbie", "Båt", "Pinne", "Anka" };
            //Punkt 3
            string[] classnames = { "Nor Nöstvold", "William Mårback", "Love winelid", "Linnea Klangby", "Sebastian Gadler" };

            //Punkt 4
            int[] array = new int[] {1, 2, 4, 5, 8};
            
            //Punkt 2, 5
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(classnames[i] + " Ger " + toynames[i] + " " + array[i] + " poäng i betyg.");
            }

            //Punkt 6
            List<string> cities = new List<string>();
            

            
            
            


            Console.ReadLine();

        }
    }
}
