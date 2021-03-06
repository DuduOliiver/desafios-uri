using System;
using System.Collections.Generic;


class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        int.TryParse(line[0], out int n1);
        int.TryParse(line[1], out int n2);
        int.TryParse(line[2], out int n3);

        List<int> lista = new List<int>();
        lista.Add(n1);
        lista.Add(n2);
        lista.Add(n3);
        lista.Sort();
        foreach (int item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        for (int i = 0; i <= line.Length - 1; i++)
        {
            Console.WriteLine(line[i]);
        }
    }
}
