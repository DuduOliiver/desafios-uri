using System;

namespace ex1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num);
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

/*
MÉTODO 2:
            int.TryParse(Console.ReadLine(), out int x);
            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
*/
