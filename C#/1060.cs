using System;

class URI
{

    static void Main(string[] args)
    {

        double[] number = new double[6];
        int positivos = 0;

        for (int i = 0; i <= 5; i++)
        {
            double.TryParse(Console.ReadLine(), out number[i]);
            if (number[i] > 0)
            {
                positivos++;
            }
        }
        Console.WriteLine($"{positivos} valores positivos");

    }
}
