using System;
using System.Collections.Generic;

namespace nasan04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punkt 1
            Book b1 = new Book("Bert", 10);
            Book b2 = new Book("Åsa", 20);
            Book b3 = new Book("Kent", 30);



            //Punkt 2
            b1.TurnPage();
            Console.WriteLine(b1.GetCurrentPage());
            Console.ReadLine();


            Console.WriteLine("Hur många stenar vill du skapa?");
            string antalStenar = Console.ReadLine();
            int stenar;
            int.TryParse(antalStenar, out stenar);

            Rock[] rockArray = new Rock[stenar];

            List<Rock> rockList = new List<Rock>();
            
            for (int i = 0; i < rockArray.Length; i++)
            {
                rockList.Add(rockArray[i]);
            }
            //System.Console.WriteLine(rockList.Count);

            for (int i = 0; i < rockList.Count; i++)
            {
                Console.WriteLine("Hur mycket ska stenen väga?");
                antalStenar = Console.ReadLine();
                int.TryParse(antalStenar, out stenar);
                rockList[i] = new Rock(stenar);
            }
            Console.WriteLine("Dina stenar väger följande:");
            for (int i = 0; i < rockList.Count; i++)
            {
                
                Console.WriteLine(rockList[i].GetWeight() + "kg");
            }

            Console.ReadLine();
        }
    }
}
