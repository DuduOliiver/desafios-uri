using System;

class URI
{

    static void Main(string[] args)
    {
        double valor, total;
        valor = double.Parse(Console.ReadLine());
        if (valor >= 0 && valor <= 2000)
            Console.WriteLine("Isento");
        else if (valor >= 2000.01 && valor <= 3000)
        {
            valor -= 2000;
            total = valor * .08;
            Console.WriteLine("R$ {0}", total.ToString("0.00"));
        }
        else if (valor >= 3000.01 && valor <= 4500)
        {
            valor -= 3000;
            total = valor * .18 + 80;
            Console.WriteLine("R$ {0}", total.ToString("0.00"));
        }
        else
        {
            valor -= 4500;
            total = valor * .28 + 350;
            Console.WriteLine("R$ {0}", total.ToString("0.00"));
        }
    }
}
