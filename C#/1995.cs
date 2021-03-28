using System;

namespace uri1095 // Sequencia IJ 1
{
    internal static class Program
    {
        private static void Main()
        {
            for (int i = 1, j = 60; j >= 0; i += 3)
            {
                Console.WriteLine($"I={i} J={j}");
                j -= 5;
            }
        }
    }
}


//MÉTODO 2:
using System;

class URI
{

    static void Main(string[] args)
    {

        int I = 1, J = 60;
        while (J > 0)
        {
            Console.WriteLine($"I={I} J={J}");

            if (I < 60)
            {
                I = I + 3;
            }
            if (J > 0)
            {
                J = J - 5;
            }
        }

        Console.WriteLine($"I={I} J={J}");

    }

}
