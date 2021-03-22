using System;

class URI
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int n);
        int x = 1;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{x} x {n} = {x * n}");
            x++;
        }
    }
}
