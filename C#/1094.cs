using System;

class URI
{
    private static void Main()
    {

        int cobaias = 0;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;
        int.TryParse(Console.ReadLine(), out int line);

        for (int i = 1; i <= line; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int.TryParse(entrada[0], out int quantidade);
            char.TryParse(entrada[1], out char tipo);
            if (tipo == 'C')
            {
                coelhos += quantidade;
            }
            else if (tipo == 'R')
            {
                ratos += quantidade;
            }
            else if (tipo == 'S')
            {
                sapos += quantidade;
            }
            cobaias += quantidade;
        }
        Console.WriteLine($"Total: {cobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {(coelhos / (double)cobaias * 100).ToString("F2")} %");
        Console.WriteLine($"Percentual de ratos: {(ratos / (double)cobaias * 100).ToString("F2")} %");
        Console.WriteLine($"Percentual de sapos: {(sapos / (double)cobaias * 100).ToString("F2")} %");
    }
}
