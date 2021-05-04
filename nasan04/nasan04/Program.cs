using System;

namespace nasan04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punkt 1
            Book b1 = new Book("Bert", 10);
            Book b2 = new Book("Åsa",20);
            Book b3 = new Book("Kent", 30);

            

            //Punkt 2
            b1.TurnPage();
            Console.WriteLine(b1.GetCurrentPage());
            Console.ReadLine();


            Console.WriteLine("Hur många stenar vill du skapa?");
            string antalStenar = Console.ReadLine();
            int Stenar;
            int.TryParse(antalStenar, out Stenar);
        }
    }
}
