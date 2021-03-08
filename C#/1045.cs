using System;

class URI
{

    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        double lado1 = double.Parse(line[0]);
        double lado2 = double.Parse(line[1]);
        double lado3 = double.Parse(line[2]);
        double A, B, C;

        if (lado1 > lado2 && lado1 > lado3)
        {
            A = lado1;
            if (lado2 > lado3)
            {
                B = lado2;
                C = lado3;
            }
            else
            {
                C = lado2;
                B = lado3;
            }
        }
        else if (lado2 > lado1 && lado2 > lado3)
        {
            A = lado2;
            if (lado1 > lado3)
            {
                B = lado1;
                C = lado3;
            }
            else
            {
                B = lado3;
                C = lado1;
            }
        }
        else
        {
            A = lado3;
            if (lado1 > lado2)
            {
                B = lado1;
                C = lado2;
            }
            else
            {
                B = lado2;
                C = lado1;
            }
        }

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if ((A * A == (B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if ((A * A > (B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if ((A * A < (B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if ((A == B) && (A == C))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if ((A == B) ^ (B == C))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
