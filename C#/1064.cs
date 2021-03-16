using System;

class URI
{

    static void Main(string[] args)
    {
        double[] num = new double[6];
        int c = 0;
        double value = 0;

        for (int i = 0; i <= 5; i++)
        {
            double.TryParse(Console.ReadLine(), out num[i]);
            if (num[i] > 0)
            {
                c++;
                value = value + num[i];
            }
        }

        Console.WriteLine($"{c} valores positivos");
        Console.WriteLine((value / c).ToString("F1"));
    }
}
