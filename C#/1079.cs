using System;

class URI
{
    static void Main(string[] args)
    {

        int.TryParse(Console.ReadLine(), out int N);
        for (int i = 1; i <= N; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            double.TryParse(line[0], out double n1);
            double.TryParse(line[1], out double n2);
            double.TryParse(line[2], out double n3);
            Console.WriteLine($"{((n1 * 2 + n2 * 3 + n3 * 5) / 10).ToString("F1")}");
        }
    }
}
