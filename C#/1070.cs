using System;

class URI
{

    static void Main(string[] args)
    {

        int.TryParse(Console.ReadLine(), out int X);
        X--;

        for (int i = 0; i <= 5; i++)
        {
            if (X % 2 == 0)
            {
                Console.WriteLine(X += 1);
            }
            else
            {
                Console.WriteLine(X += 2);
            }
        }
    }
}
