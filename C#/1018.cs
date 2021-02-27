using System; 

class URI {

    static void Main(string[] args) 
    { 
        int resto, valor, num;
        num = Int32.Parse(Console.ReadLine());
        Console.WriteLine(num);
        valor = num / 100;
        resto = num % 100;
        Console.WriteLine($"{valor} nota(s) de R$ 100,00");
        valor = resto / 50;
        resto %= 50;
        Console.WriteLine($"{valor} nota(s) de R$ 50,00");
        valor = resto / 20;
        resto %= 20;
        Console.WriteLine($"{valor} nota(s) de R$ 20,00");
        valor = resto / 10;
        resto %= 10;
        Console.WriteLine($"{valor} nota(s) de R$ 10,00");
        valor = resto / 5;
        resto %= 5;
        Console.WriteLine($"{valor} nota(s) de R$ 5,00");
        valor = resto / 2;
        resto %= 2;
        Console.WriteLine($"{valor} nota(s) de R$ 2,00");
        valor = resto / 1;
        resto %= 1;
        Console.WriteLine($"{valor} nota(s) de R$ 1,00");
    }
}
