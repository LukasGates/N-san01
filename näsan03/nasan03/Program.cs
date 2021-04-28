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
            static float Multi( float y, float z)
            {
                float multip = y * z;
                return multip;
            }


            Console.ReadLine();
        }
    }
}
