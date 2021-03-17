using System;

class URI
{

    static void Main(string[] args)
    {
        double[] num = new double[6];
        int c1 = 0;
        int c2 = 0;
        int c3 = 0;
        int c4 = 0;


        for (int i = 0; i <= 4; i++)
        {
            double.TryParse(Console.ReadLine(), out num[i]);
            if (num[i] % 2 == 0)
            {
                c1++;
            }

            if (num[i] % 2 != 0)
            {
                c2++;
            }

            if (num[i] > 0)
            {
                c3++;
            }

            if (num[i] < 0)
            {
                c4++;
            }
        }
        Console.WriteLine($"{c1} valor(es) par(es)");
        Console.WriteLine($"{c2} valor(es) impar(es)");
        Console.WriteLine($"{c3} valor(es) positivo(s)");
        Console.WriteLine($"{c4} valor(es) negativo(s)");
    }

}