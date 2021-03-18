using System;

class URI
{

    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int X);
        int.TryParse(Console.ReadLine(), out int Y);
        int s = 0;

        for (int i = ((X < Y) ? X : Y) + 1; i < ((X < Y) ? Y : X); i++)
        {
            if (i % 2 != 0)
            {
                s += i;
            }
        }
        Console.WriteLine(s);
    }

}
