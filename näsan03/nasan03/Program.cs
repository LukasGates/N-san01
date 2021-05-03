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
            Console.WriteLine("Ditt returnerade nummer " + GetNumberInput());
            
            //Punkt 7
            static int GetChoice(string string1, string string2, string string3)
            {
                int result = 0;
                Console.WriteLine("String1: " + string1 + " | " + "String2: " + string2 + " | " + "String3: " + string3);
                Console.WriteLine("Välj string 1, 2 eller 3 genom att skriva vilket nummer");

                string playerInput = Console.ReadLine().Trim();
                bool sucess = int.TryParse(playerInput, out result);

                while (result > 3 || result < 1)
                {
                    System.Console.WriteLine("ERROR");

                    playerInput = Console.ReadLine().Trim();
                    sucess = int.TryParse(playerInput, out result);
                }

                return result;
            }
            Console.WriteLine("Du valde " + GetChoice("1", "2", "3"));
            Console.ReadLine();





        }
    }
}
