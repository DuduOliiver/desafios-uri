using System;

class URI
{

    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int line);
        int c1 = 0, c2 = 0;

        for (int i = 1; i <= line; i++)
        {
            int.TryParse(Console.ReadLine(), out int num);
            if (num >= 10 && num <= 20)
            {
                c1++;
            }
            else
            {
                c2++;
            }
        }
        Console.WriteLine($"{c1} in");
        Console.WriteLine($"{c2} out");
    }
}
