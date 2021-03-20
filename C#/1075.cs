using System;

class URI
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int line);
        for (int i = 1; i <= 10000; i++)
        {
            if (i % line == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
