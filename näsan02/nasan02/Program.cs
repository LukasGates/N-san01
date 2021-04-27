using System;
using System.Collections.Generic;

namespace nasan02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Punkt 1: Samlar in leksaker som lagras i stringen "toynames"
            string[] toynames = { "Racerbil", "Barbie", "Båt", "Pinne", "Anka" };
            //Punkt 3: Samlar in namn som lagras i stringen "classnames"
            string[] classnames = { "Nor Nöstvold", "William Mårback", "Love winelid", "Linnea Klangby", "Sebastian Gadler" };

            //Punkt 4: en integer-array med fem olika värden som loopen nedan använder sig av när den sätter ut betyg till olika leksaker.
            int[] array = new int[] { 1, 2, 4, 5, 8 };

            //Punkt 2, 5: Loop som skriver ut ett namn tillsammans med en leksak på en egen rad tills loopen har körts 5 gånger
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(classnames[i] + " Ger " + toynames[i] + " " + array[i] + " poäng i betyg.");
            }

            //Punkt 6: Lista där städer ska lagras
            List<string> cities = new List<string>();

            //Punkt 7: loop där användaren skriver in städer som skickas till listan tills användaren skriver exit och man kommer ut ur loopen.
            string exit = "";
            while (exit != "exit")
            {
                Console.WriteLine("Skriv en stad:");
                cities.Add(Console.ReadLine());
                Console.WriteLine("Bra! Tryck enter för att skriva in en ny stad eller skriv exit för att avsluta");
                exit = Console.ReadLine();
            }

            //Punkt 8: Loop som ränkar upp alla städer användaren skrivit in tills det inte finns fler städer att skriva ut.
            Console.WriteLine("Här är listan av alla städer du skrev in:");
            for (int i = 0; i < cities.Count; i++)
            {
                System.Console.WriteLine(cities[i]);
            }
            Console.ReadLine();


        }
    }
}
