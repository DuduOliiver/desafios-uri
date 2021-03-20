using System;

class URI
{

    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int line);
        for (int i = 1; i <= line; i++)
        {
            int.TryParse(Console.ReadLine(), out int num);
            if (num == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (num % 2 != 0)
            {
                if (num < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
            }
        }
    }
}
