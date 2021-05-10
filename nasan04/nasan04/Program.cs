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

            Worker worker = new Worker("Bob");
            WhiteCollar whiteCollar = new WhiteCollar("Jeff");
            BlueCollar blueCollar = new BlueCollar("Sara");

            Console.WriteLine("namn: " + worker.GetName());
            Console.WriteLine("ålder: " + worker.GetAge());
            Console.WriteLine("lön: " + worker.GetWage());

            Console.WriteLine("namn: " + whiteCollar.GetName());
            Console.WriteLine("ålder: " + whiteCollar.GetAge());
            Console.WriteLine("lön: " + whiteCollar.GetWage());

            Console.WriteLine("namn: " + blueCollar.GetName());
            Console.WriteLine("ålder: " + blueCollar.GetAge());
            Console.WriteLine("lön: " + blueCollar.GetWage());



            int result;

            List<Hardware> hårdvaror = new List<Hardware>();

            Hårddisk hårddisk = new Hårddisk("Seagate");
            Processorer processorer = new Processorer("AMD");
            Grafikkort grafikkort = new Grafikkort("Nvidia");

            while (true)
            {
                System.Console.WriteLine("Hårdvara att skapa?");
                System.Console.WriteLine("1: Hårdisk");
                System.Console.WriteLine("2: Processor");
                System.Console.WriteLine("3: Grafikkort");

                int.TryParse(Console.ReadLine(), out result);

                if (result == 1)
                {
                    System.Console.WriteLine("Hur mycket lagring?");

                    int.TryParse(Console.ReadLine(), out result);
                    hårddisk.SetLagring(result);
                    hårddisk.SetPris(500);

                    hårdvaror.Add(hårddisk);
                }

                else if (result == 2)
                {
                    System.Console.WriteLine("Hur många kärnor?");

                    int.TryParse(Console.ReadLine(), out result);
                    processorer.SetKärnor(result);
                    processorer.SetPris(1500);

                    hårdvaror.Add(processorer);
                }

                else if (result == 3)
                {
                    System.Console.WriteLine("Hur mycket boost?");

                    int.TryParse(Console.ReadLine(), out result);
                    grafikkort.SetBoost(result);
                    grafikkort.SetPris(250000000);

                    hårdvaror.Add(grafikkort);
                }

                Console.Clear();

                System.Console.WriteLine("Du har valt:");
                System.Console.WriteLine();

                for (int i = 0; i < hårdvaror.Count; i++)
                {
                    System.Console.WriteLine("Märke: " + hårdvaror[i].GetNamn());
                    System.Console.WriteLine("Pris: " + hårdvaror[i].GetPris());
                    System.Console.WriteLine();
                }
            }


            Console.ReadLine();
        }
    }
}
