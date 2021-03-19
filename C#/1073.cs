using System;

class URI
{

    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int line);

        for (int i = 1; i <= line; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }
        }
    }
}
