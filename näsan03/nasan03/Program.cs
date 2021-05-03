using System;

namespace nasan03
{
    class Program
    {
        static void Main(string[] args)
        {
            //punkt 1
            Hello32();
            static void Hello32()
            {
                int x = 0;
                while (x < 32)
                {
                    Console.WriteLine("Hello, World");
                    x++;
                }

            }

            //Punkt 2
            Gånger(6);
            static void Gånger(int siffra)
            {
                int multiplikation = siffra * siffra;
                Console.WriteLine(multiplikation);

            }

            //Punkt 3
            Console.WriteLine(Multi(1f, 2f));
            static float Multi(float y, float z)
            {
                float multip = y * z;
                return multip;
            }


            //Punkt 4
            RightTriangleArea(4f, 4f);
            static float RightTriangleArea(float y, float z)
            {
                float result = y * z / 2;
                return result;
            }
            Console.WriteLine("arean av rätvinkliga triangeln är " + RightTriangleArea(4f, 4f));


            //Punkt 5
            CirkelArea(2f, 3.14f);
            static float CirkelArea(float y, float z)
            {
                float result = (y * y) * z;
                return result;

            }
            Console.WriteLine("arean av cirkeln är " + CirkelArea(2f, 3.14f));
            

            //Punkt 6
            static int GetNumberInput()
            {
               // string GetNumberInput = Console.ReadLine();
                int result = 0;
               // bool sucess = int.TryParse(GetNumberInput, out result);

                //Kan stringen inte konverteras får de försöka igen:
                while (result == 0)
                {
                    Console.WriteLine("skriv nummer");
                    string GetNumberInput = Console.ReadLine();
                    bool sucess = int.TryParse(GetNumberInput, out result);
                }
        
                return result;
            }
            Console.WriteLine("Ditt returnerade nummer "+ GetNumberInput());
            Console.ReadLine();





        }
    }
}
